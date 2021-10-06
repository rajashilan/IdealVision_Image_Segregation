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

            //set initial directory for the 'select folder'
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

            //format current date and time
            string currentDateTime = DateTime.Now.ToString("dd-MM-yyyy_HHmmss");

            //create new folder named as current date and time
            string UploadFolder = Path.Combine(@"Upload\", currentDateTime);
            Directory.CreateDirectory(UploadFolder);

            //create pass folder under newly created folder
            string passFolder = Path.Combine(UploadFolder, "Pass");
            Directory.CreateDirectory(passFolder);

            //create fail folder under newly created folder
            string failFolder = Path.Combine(UploadFolder, "Fail");
            Directory.CreateDirectory(failFolder);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //get last modified folder
                DirectoryInfo latestFolder = new DirectoryInfo(@"Upload\").GetDirectories().OrderByDescending(d => d.LastWriteTimeUtc).First();

                foreach (string fileName in openFileDialog.FileNames)
                {
                    try
                    {
                        File.Copy(fileName, Path.Combine(latestFolder.ToString(), Path.GetFileName(fileName)));
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
