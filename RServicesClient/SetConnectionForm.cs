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
    public partial class SetConnectionForm : Form
    {
        public SetConnectionForm()
        {
            InitializeComponent();
        }

        public String ConnectionString => setConnectionControl1.ConnectionString;

        private void applyButton_Click(Object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
