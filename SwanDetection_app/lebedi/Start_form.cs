using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace lebedi
{
    public partial class Start_form : Form
    {
        public Start_form()
        {
            BackColor = Color.FromArgb(229, 255, 248);

            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;

            openFileDialog1.Filter = "Images (*.PNG;*.JPG)|*.PNG;*.JPG";
            DialogResult result = openFileDialog1.ShowDialog();

            List<string> files = new List<string>();

            if (result == DialogResult.OK)
            {

                foreach (String file in openFileDialog1.FileNames)
                {

                    string filename = openFileDialog1.FileName;
                    files.Add(file);
                }
                Form frm = new result(files);
                frm.Show();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Start_form_Load(object sender, EventArgs e)
        {

        }
    }
}
