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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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
            /*listBoxFailCategories.Items.Clear();
            string[] dirs = Directory.GetDirectories(Value);

            foreach (string dir in dirs)
            {
                listBoxFailCategories.Items.Add(Path.GetFileName(dir));
            }*/
        }
    }
}
