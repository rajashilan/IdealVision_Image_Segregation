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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            //openFileDialog.Filter = "Image Files(jpg/png/gif/bmp)|.jpg;.jpeg;.png; *.gif;.bmp;";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string UploadFolder = Path.Combine(@"Upload\");

                foreach (string fileName in openFileDialog.FileNames)
                {

                    try
                    {
                        File.Copy(fileName, UploadFolder + Path.GetFileName(fileName));
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Reported error: " + ex.Message);
                    }
                }

                Form4 fm = new Form4();
                fm.Show();
                this.Hide();
            }

        }
    }
}
