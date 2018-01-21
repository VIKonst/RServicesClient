using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnalyzer
{
    public partial class InputNameDialog : Form
    {

        public String InputName { get; private set; }


        public InputNameDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            InputName = textBox1.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
