using System.Data;
using System.Windows.Forms;

namespace RServicesClient
{
    public partial class DataForm : Form
    {
        public DataForm(DataTable dataTable)
        {
            InitializeComponent();
            dataGridView1.DataSource = dataTable;
        }
    }
}
