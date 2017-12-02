
using RServicesClient.ApplicationSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RServicesClient
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            _timeOutTextBox.Text = AppSettings.Instance.TimeOut.ToString();
        }

        private void label1_Click(Object sender, EventArgs e)
        {

        }

        private void _saveBtn_Click(Object sender, EventArgs e)
        {
            if(!Int32.TryParse(_timeOutTextBox.Text, out Int32 timeOut))
            {
                MessageBox.Show("Incorrect value");
                return;
            }

            AppSettings.Instance.TimeOut = timeOut;

            AppSettings.Instance.SaveChanges();
        }
    }
}
