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

        public Form6()
        {
            InitializeComponent();
        }

        public String Value { 
            get; 
            set; 
        }

        public String Image { 
            get; 
            set; 
        }

        public String DefectCategory { get; set; }

        public String FullPathName { get; set; }

        public bool added = false;

        public string sendDefectCategory()
        {
            return DefectCategory;
        }

        public string sendPathName()
        {
            return FullPathName; //HANDLE IF MORE THAN 1 DEFECT CATEGORY
        }

        public bool hasValue()
        {
            return added;
        }


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
            Form9 fm = new Form9();
            fm.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (listBoxFailCategories.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any defect category");
            }
            else
            {
                var tempDefectCategory = "";

                foreach (string item in listBoxFailCategories.SelectedItems)
                {
                    string defectFolder = Path.Combine(Value, item);
                    File.Copy(Image, Path.Combine(defectFolder, Path.GetFileName(Image)), true);

                    added = true;

                    tempDefectCategory = tempDefectCategory + item.ToString() + ",";

                    FullPathName = Path.Combine(defectFolder, Path.GetFileName(Image));

                }
                DefectCategory = tempDefectCategory;
                File.Delete(Image);
                this.Close();
            }
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
