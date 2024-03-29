﻿using System;
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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        public String Value { get; set; }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            string path = @"Upload\";
            if (Directory.GetDirectories(path).Length == 0) {
                MessageBox.Show("No session folders found. Unable to resume.");
            } else {
                Form2 fm = new Form2();
                fm.Show();
                this.Hide();
            }
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog FDB = new FolderBrowserDialog();
            FDB.SelectedPath = Path.GetFullPath(@"Upload\");
            if (FDB.ShowDialog() == DialogResult.OK)
            {
                string currentpath = Path.Combine(FDB.SelectedPath + @"\Fail\");
                Form5 fm = new Form5(currentpath);
                fm.Show();
            }

            
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {

                DialogResult dialogResult = MessageBox.Show("Please be careful if u have any session undone yet. \n" +
                "By clicking 'Yes', you will unable to resume the last session.\n\n" +
                "Are you sure you want to continue?", "Creating New Session", MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.Yes)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();

                    //set initial directory for the 'select folder'
                    openFileDialog.InitialDirectory = @"C:\";
                    openFileDialog.Multiselect = true;
                    openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";



                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
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
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
