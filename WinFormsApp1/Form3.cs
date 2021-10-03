using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void TBoxDefect_Enter(object sender, EventArgs e)
        {
            if(TBoxDefect.Text == "Key in new defect categories"){
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

        private void TBoxDefect_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
