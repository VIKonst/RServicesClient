using DataAnalyzer;
using DataAnalyzer.FileSaving;
using RServicesClient.ApplicationSettings;
using RServicesClient.Core.Scripts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RServicesClient
{
    public partial class MainForm : Form
    {

        private Stopwatch _stopwatch;
        private SetConnectionForm _setConnectionForm;

        private CancellationTokenSource _cancellation;

        private String _connectionString;

        enum ExecutionMode
        {
            DataTable,
            Image
        }

        class ExecutionModeItem
        {
            public String DisplayValue { get; set; }
            public ExecutionMode Value { get; set; }
        }

        public MainForm()
        {
            _setConnectionForm = new SetConnectionForm();
            InitializeComponent();
        }

        private async Task ExecuteScript()
        {
            execute_MenuItem.Enabled = false;
            _cancellation = new CancellationTokenSource();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    await connection.OpenAsync(_cancellation.Token);

                    ExternalScriptExecuter scriptExecuter = new ExternalScriptExecuter(connection, ScriptLanguage.R)
                    {
                        Script = _scriptTextBox.Text,
                        Input = _inputScriptTextBox.Text,
                        TimeOut = AppSettings.Instance.TimeOut
                    };

                    StartStopwatch();
                    Form resultForm;
                    ExecutionMode executionMode = (ExecutionMode)comboBox1.SelectedValue;

                    if (executionMode == ExecutionMode.Image)
                    {
                        IList<Byte[]> result = await scriptExecuter.ExecuteBinaryDataAsync(_cancellation.Token);
                        resultForm = new ImageForm(result[0]);
                    }
                    else
                    {
                        IDataReader reader = await scriptExecuter.ExecuteDataReaderAsync(_cancellation.Token);

                        DataTable sqlDataTable = new DataTable();
                        sqlDataTable.Load(reader);

                        resultForm = new DataForm(sqlDataTable);                       
                    }
                    
                    ResetStopwatch();

                    resultForm.Show();
                }
            }
            catch (TaskCanceledException)
            {
                ResetStopwatch();
                MessageBox.Show("Execution was cancelleed");
            }
            catch (Exception ex)
            {
                ResetStopwatch();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                execute_MenuItem.Enabled = true;
            }

        }     


        private void StartStopwatch()
        {
            _stopwatch = Stopwatch.StartNew();

            _execTimeLabel.Text = $"Executing..";
        }

        private void ResetStopwatch()
        {
            if (_stopwatch != null)
            {
                _stopwatch.Stop();
                _execTimeLabel.Text = $"{_stopwatch.ElapsedMilliseconds} ms";
                _stopwatch = null;
            }         
        }

        private void MainForm_Load(Object sender, EventArgs e)
        {
            comboBox1.DataSource = new ExecutionModeItem[] {
                new ExecutionModeItem
                {
                    DisplayValue = "As table",
                    Value = ExecutionMode.DataTable
                },
                new ExecutionModeItem
                {

                    DisplayValue = "As image",
                    Value = ExecutionMode.Image
                }
            };

            comboBox1.DisplayMember = "DisplayValue";
            comboBox1.ValueMember = "Value";
        
        }

        private async void execute_MenuItem_Click(Object sender, EventArgs e)
        {
             await ExecuteScript();
        }

        private void settingsToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void setConnectionToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            ShowSetConnectionForm();
        }

        private void ShowSetConnectionForm()
        {
            if (_setConnectionForm.ShowDialog() == DialogResult.OK)
            {
                String newString = _setConnectionForm.ConnectionString.ToString();
                if (newString == _connectionString) return;

                _connectionString = newString;
                _dbStructureForm = new DBStructureForm(_connectionString);
                _currentScriptLabel.Text = "Script is not from DB";
                _serverStatusLabel1.Text = _setConnectionForm.ConnectionString.DataSource;
                _dbNameStatusLabel.Text = _setConnectionForm.ConnectionString.InitialCatalog;
            }
        }

        private void MainForm_Shown(Object sender, EventArgs e)
        {
            ShowSetConnectionForm();
        }

        private void cancelToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            _cancellation.Cancel();
        }

        private void newWindowToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            string s = Process.GetCurrentProcess().ProcessName;
            Process.Start(s);
        }

        FileLoader _fileLoader = new FileLoader();

        private void rScriptToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            _fileLoader.SaveRScript(_scriptTextBox.Text);
        }

        private void sQLScriptToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            _fileLoader.SaveSqlScript(_inputScriptTextBox.Text);
        }

        private void rServicesFileToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            _fileLoader.SaveRServicesFile(_scriptTextBox.Text, _inputScriptTextBox.Text);
        }

        private void openSQLScriptToolStripMenuItem1_Click(Object sender, EventArgs e)
        {
           String text = _fileLoader.OpenSqlScript();

           if(text != null)
           {
                _inputScriptTextBox.Text = text;
           }
        }

        private void openRScriptToolStripMenuItem1_Click(Object sender, EventArgs e)
        {

            String text = _fileLoader.OpenRScript();

            if (text != null)
            {
                _scriptTextBox.Text = text;
            }
        }

        private void openRServicesFileToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            (String rScript, String sql) = _fileLoader.OpenRServicesFile();

            if (rScript != null && sql != null)
            {
                _inputScriptTextBox.Text = sql;
                _scriptTextBox.Text = rScript;
            }
        }

        DBStructureForm _dbStructureForm = new DBStructureForm(String.Empty);

        private void scriptsDBStorageToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            if(_dbStructureForm.CurrentScript != null)
            {
                _dbStructureForm.CurrentScript.SqlInput = _inputScriptTextBox.Text;
                _dbStructureForm.CurrentScript.Script = _scriptTextBox.Text;
            }

            
            if(_dbStructureForm.ShowDialog() == DialogResult.Yes)
            {
                _inputScriptTextBox.Text = _dbStructureForm.CurrentScript.SqlInput;
                _scriptTextBox.Text = _dbStructureForm.CurrentScript.Script;
                _currentScriptLabel.Text = $"Current script is from DB: { _dbStructureForm.CurrentScript.Name}";
            }

        }
    }
}
