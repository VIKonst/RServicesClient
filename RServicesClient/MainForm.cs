using RServicesClient.ApplicationSettings;
using RServicesClient.Core.Scripts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RServicesClient
{
    public partial class MainForm : Form
    {

        private Stopwatch _stopwatch;

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
            InitializeComponent();
        }

        private async Task ExecuteScript()
        {
            execute_MenuItem.Enabled = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString.Text))
                {
                    await connection.OpenAsync();

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
                        IList<Byte[]> result = await scriptExecuter.ExecuteBinaryDataAsync();
                        resultForm = new ImageForm(result[0]);
                    }
                    else
                    {
                        IDataReader reader = await scriptExecuter.ExecuteDataReaderAsync();

                        DataTable sqlDataTable = new DataTable();
                        sqlDataTable.Load(reader);

                        resultForm = new DataForm(sqlDataTable);                       
                    }
                    
                    ResetStopwatch();

                    resultForm.ShowDialog();
                }
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
            SetConnectionForm form = new SetConnectionForm();

            if(form.ShowDialog() == DialogResult.OK)
            {
                _connectionString.Text = form.ConnectionString;
            }
        }
    }
}
