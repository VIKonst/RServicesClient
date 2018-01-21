using DataAnalyzer.SqlServer;
using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RServicesClient.Controls
{
    public partial class SetConnectionControl : UserControl
    {


        public SetConnectionControl()
        {

            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {

        }

        public SqlConnectionStringBuilder ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder connectionStr = new SqlConnectionStringBuilder();
                connectionStr.IntegratedSecurity = chbIntegratedSecuritySource.Checked;
                connectionStr.DataSource = cbServer.Text;
                connectionStr.InitialCatalog = String.IsNullOrWhiteSpace(cbDbSource.Text) ? "master" : cbDbSource.Text;

                if (!connectionStr.IntegratedSecurity)
                {
                    connectionStr.UserID = tbUser.Text;
                    connectionStr.Password = tbPass.Text;
                }
                return connectionStr;
            }
        }

        public String Server
        {
            get
            {
                return cbServer.Text;
            }
        }

        public String User
        {
            get
            {
                return tbUser.Text;
            }
        }

        public Boolean IsNeedSavePasswor
        {
            get
            {
                return chbSavePass.Checked;
            }
        }

        public Boolean IsWindowsAuthentificatiion
        {
            get
            {
                return chbIntegratedSecuritySource.Checked;
            }
        }

        [Localizable(true)]
        [SettingsBindable(true)]
        [Bindable(true)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override String Text
        {
            get
            {
                return titleLabel.Text;
            }

            set
            {
                titleLabel.Text = value;
            }
        }


        public async Task TestConnection(CancellationToken cancellationToken)
        {
            try
            {
                DataBaseHelper dataBaseHelper = new DataBaseHelper();
                await dataBaseHelper.TestConnectionAsync(this.ConnectionString.ToString(), cancellationToken);

                MessageBox.Show("Success");

            }
            catch(TaskCanceledException)
            {
                throw;//Ignore if task cancelled
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserControl1_Load(Object sender, EventArgs e)
        {

        }

        private void cbDbSource_DropDown(Object sender, EventArgs e)
        {
        }

        private void chbIntegratedSecuritySource_CheckedChanged(Object sender, EventArgs e)
        {
            Boolean isNeedUser = !chbIntegratedSecuritySource.Checked;
            tbPass.Enabled = tbUser.Enabled = isNeedUser;
        }

        private void cbDbSource_Click(Object sender, EventArgs e)
        {

        }




        public async Task LoadDataBases(CancellationToken token)
        {
            try
            {
                token.ThrowIfCancellationRequested();
                DataBaseHelper dataBaseHelper = new DataBaseHelper();
                cbDbSource.DataSource = await dataBaseHelper.GteDbNamesAsync(this.ConnectionString.ToString(), token);
            }
            catch (Exception exception)
            {
                if (!token.IsCancellationRequested)
                    MessageBox.Show(exception.Message);
            }
        }
    }
}
