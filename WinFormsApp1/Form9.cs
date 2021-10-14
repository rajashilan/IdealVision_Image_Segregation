using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form9 : Form
    {
        public Form9(string value)
        {
            InitializeComponent();
            this.Value = value;
        }
        public String Value { get; set; }

        string defect = Path.Combine(@"Defect List\");
        

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(defect+ TBoxDefect.Text);

            if (Directory.Exists(path))
            {
                MessageBox.Show("Defect Categories Exist");
            }
            else if (TBoxDefect.Text == "" || TBoxDefect.Text == "Key in new defect categories")
            {
                MessageBox.Show("Please fill in the defect category name");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Defect Categories Created");

                listBox1.Items.Clear();
                string[] dirs = Directory.GetDirectories(defect);

                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }

                TBoxDefect.Text = "";

            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(defect);
            listBox1.Items.Clear();
            string[] dirs = Directory.GetDirectories(defect);

            foreach (string dir in dirs)
            {
                listBox1.Items.Add(Path.GetFileName(dir));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select any defect category");
            }
            else
            {
                foreach (string item in listBox1.SelectedItems)
                {
                    string defectFolder = Path.Combine(Value, item);
                    Directory.CreateDirectory(defectFolder);
                }
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(defect + TBoxDefect.Text);
            //remove defect category
            if (listBox1.SelectedIndex != -1)
            {
                string remove = listBox1.SelectedItem.ToString();

                Directory.Delete(Path.Combine(defect + remove));
                MessageBox.Show("Defect Categories Deleted");
            }

            else
            {
                MessageBox.Show("Please select a category first");
            }

            //refresh listbox
            listBox1.Items.Clear();
            string[] dirs = Directory.GetDirectories(defect);

            foreach (string dir in dirs)
            {
                listBox1.Items.Add(Path.GetFileName(dir));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter the new name");
                }
                else
                {
                    if (Directory.Exists(Path.Combine(defect+ textBox1.Text)))
                    {
                        MessageBox.Show("Defect categories is already exist. Please enter a new name");
                    }
                    else
                    {
                        string oldname = listBox1.SelectedItem.ToString();
                        string newname = textBox1.Text;

                        Directory.Move(Path.Combine(defect+ oldname), Path.Combine(defect + newname));
                        MessageBox.Show("Defect Categories Renamed");
                    }

                }

            }
            else
            {
                MessageBox.Show("Please select the defect category");
            }
            textBox2.Text = "";
            textBox1.Text = "";
            //refresh listbox
            listBox1.Items.Clear();

            string[] dirs = Directory.GetDirectories(defect);

            foreach (string dir in dirs)
            {
                listBox1.Items.Add(Path.GetFileName(dir));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selected defect category name will copy to textbox
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                textBox2.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
