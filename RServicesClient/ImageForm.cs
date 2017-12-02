using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RServicesClient
{
    public partial class ImageForm : Form
    {
        public ImageForm(Byte[] imgBytes)
        {
            InitializeComponent();

            using (MemoryStream stream = new MemoryStream(imgBytes) )
            {
                pictureBox1.Image = Image.FromStream(stream);
                
            }
           
        }

        private void ImageForm_Load(Object sender, EventArgs e)
        {
            
        }
    }
}
