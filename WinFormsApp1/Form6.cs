using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace WinFormsApp1
{
    public partial class Form6 : Form
    {

        public Form6(string value, string img)
        {
            InitializeComponent();
            this.Value = value;
            this.Image = img;
        }

        public String Value { get; set; }
        public String Image { get; set; }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBoxFailCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //refer to form 5, the defact list should auto appear when the form loaded
            listBoxFailCategories.Items.Clear();
            string[] dirs = Directory.GetDirectories(Value);

            foreach (string dir in dirs)
            {
                listBoxFailCategories.Items.Add(Path.GetFileName(dir));
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            foreach(string item in listBoxFailCategories.SelectedItems)
            {
                string defectFolder = Path.Combine(Value, item);
                File.Copy(Image, Path.Combine(defectFolder, Path.GetFileName(Image)), true);
                this.Close();
            }
            File.Delete(Image);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            listBoxFailCategories.Items.Clear();
            string[] dirs = Directory.GetDirectories(Value);

            foreach (string dir in dirs)
            {
                listBoxFailCategories.Items.Add(Path.GetFileName(dir));
            }
        }
    }
}
