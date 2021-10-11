using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form7 : Form
    {

        public string path;

        public string imgPathName
        {
            get { return path; }
            set { path = value; } 
        }

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Image img;
            using (var bmpTemp = new Bitmap(path))
            {
                img = new Bitmap(bmpTemp);
            }
            PicBoxPassed.Image = img;
            PicBoxPassed.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
