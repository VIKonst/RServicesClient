using System;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RServicesClient
{
    public partial class SetConnectionForm : Form
    {

        private CancellationTokenSource _cancellation;

        public SetConnectionForm()
        {
            InitializeComponent();
            FormClosing += OnFormClosing;
        }


        private void OnFormClosing(Object sender, FormClosingEventArgs e)
        {
            if (_cancellation?.IsCancellationRequested == false)
                e.Cancel = true;
        }

        private void CrearteNewCancellation()
        {
            _cancellation = new CancellationTokenSource();
        }


        public SqlConnectionStringBuilder ConnectionString => setConnectionControl1.ConnectionString;

        private void applyButton_Click(Object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void _testConnectionButton_Click(Object sender, EventArgs e)
        {
            ExecOperationWithDB(token => setConnectionControl1.TestConnection(token));           
        }

        private void loadDBsBtn_Click(Object sender, EventArgs e)
        {
            ExecOperationWithDB(token => setConnectionControl1.LoadDataBases(token));
        }

        private volatile Boolean _isBusy = false; 

        private async void ExecOperationWithDB(Func<CancellationToken ,Task> action)
        {
            if (_isBusy) return;

            _isBusy = true;
            loadDBsBtn.Enabled = false;
            _cancelBtn.Enabled = true;
            _testConnectionButton.Enabled = false;
            setConnectionControl1.Enabled = false;
            applyButton.Enabled = false;

            try
            {
                CrearteNewCancellation();
                await action(_cancellation.Token);
            }
            catch (Exception exception)
            {
                if (!_cancellation.IsCancellationRequested)
                    MessageBox.Show(exception.Message);
            }
            finally
            {
                loadDBsBtn.Enabled = true;
                _cancelBtn.Enabled = false;
                _testConnectionButton.Enabled = true;
                setConnectionControl1.Enabled = true;
                applyButton.Enabled = true;
                _isBusy = false;

                _cancellation = null;
            }        

        }

        private void _cancelBtn_Click(Object sender, EventArgs e)
        {
            _cancellation?.Cancel();
        }
    }
}
