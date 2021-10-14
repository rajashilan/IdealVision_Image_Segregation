using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5(string value)
        {
            InitializeComponent();
            this.Value = value;
        }

        public String Value { get; set; }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Defect category auto loaded when the form loaded
            labelcurrentpath.Text = Value;
            listBoxFailCategories.Items.Clear();
            string[] dirs = Directory.GetDirectories(labelcurrentpath.Text);

            foreach (string dir in dirs)
            {
                listBoxFailCategories.Items.Add(Path.GetFileName(dir));
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //create defect category
            string path = Path.Combine(labelcurrentpath.Text + TBoxDefect.Text);
            if (Directory.Exists(path))
            {
                MessageBox.Show("Defect Categories Exist");
            }
            else if (TBoxDefect.Text == ""|| TBoxDefect.Text == "Key in new defect categories")
            {
                MessageBox.Show("Please fill in the defect category name");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Defect Categories Created");


                //refresh the listbox
                listBoxFailCategories.Items.Clear();
                string[] dirs = Directory.GetDirectories(labelcurrentpath.Text);

                foreach (string dir in dirs)
                {
                    listBoxFailCategories.Items.Add(Path.GetFileName(dir));
                }

                TBoxDefect.Text = "";
            }
        }

        private void listBoxFailCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected defect category name will copy to textbox
            int index = listBoxFailCategories.SelectedIndex;
            if (index != -1)
            {
                textBoxOldName.Text = listBoxFailCategories.SelectedItem.ToString();
            }
        }

        private void TBoxDefect_Enter(object sender, EventArgs e)
        {
            if (TBoxDefect.Text == "Key in new defect categories")
            {
                TBoxDefect.Text = "";
            }
        }

        private void TBoxDefect_Leave(object sender, EventArgs e)
        {
            if (TBoxDefect.Text == "")
            {
                TBoxDefect.Text = "Key in new defect categories";
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            //rename defect category with different error condition
            string path = labelcurrentpath.Text;

            if (listBoxFailCategories.SelectedIndex != -1)
            {
                if (textBoxNewName.Text == "")
                {
                    MessageBox.Show("Please enter the new name");
                }
                else
                {
                    if (Directory.Exists(Path.Combine(path+ textBoxNewName.Text)))
                    {
                        MessageBox.Show("Defect categories is already exist. Please enter a new name");
                    }
                    else
                    {
                        string oldname = listBoxFailCategories.SelectedItem.ToString();
                        string newname = textBoxNewName.Text;

                        Directory.Move(Path.Combine(path + oldname), Path.Combine(path + newname));
                        MessageBox.Show("Defect Categories Renamed");
                    }
                        
                }
                
            }
            else
            {
                MessageBox.Show("Please select the defect category");
            }
            textBoxOldName.Text = "";
            textBoxNewName.Text = "";



            //refresh listbox
            string pathb = Environment.CurrentDirectory + "/Upload/Fail/";
            listBoxFailCategories.Items.Clear();
            string[] dirs = Directory.GetDirectories(path);

            foreach (string dir in dirs)
            {
                listBoxFailCategories.Items.Add(Path.GetFileName(dir));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = labelcurrentpath.Text;
            //remove defect category
            if (listBoxFailCategories.SelectedIndex != -1)
            {
                string remove = listBoxFailCategories.SelectedItem.ToString();

                Directory.Delete(Path.Combine(path + remove));
                MessageBox.Show("Defect Categories Deleted");
            }

            else
            {
                MessageBox.Show("Please select a category first");
            }



            //refresh listbox
            string pathb = Environment.CurrentDirectory + "/Upload/Fail/";
            listBoxFailCategories.Items.Clear();
            string[] dirs = Directory.GetDirectories(path);

            foreach (string dir in dirs)
            {
                listBoxFailCategories.Items.Add(Path.GetFileName(dir));
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxOldName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
