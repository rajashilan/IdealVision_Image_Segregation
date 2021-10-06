using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        DirectoryInfo latestSession = new DirectoryInfo(@"Upload\").GetDirectories().OrderByDescending(d => d.LastWriteTimeUtc).First();
        public Form4()
        {
            InitializeComponent();
        }

        //proceed to next image after pressing pass / fail button
        public void incrementImage()
        {
            nCurrentItem++;
            firstImage++;

            if (nCurrentItem > nTotalNumber)
                nCurrentItem = nTotalNumber;

            else if (nCurrentItem < nTotalNumber)
                PicBox.Image = Image.FromFile(ImageFilenames[nCurrentItem]);

            imgCounter.Text = firstImage.ToString() + " / " + nTotalNumber.ToString();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void failCounter_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        //load images
        int nTotalNumber = 0;
        int nCurrentItem = 0;
        int firstImage = 1;
        List<string> ImageFilenames = new List<string>();
        string uploadDir = Path.Combine(@"Upload\");
        

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Multiselect = true;

                //set the initial directory to last modified folder
                open.InitialDirectory = latestSession.ToString();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    string sFileName = open.FileName;
                    ImageFilenames = open.FileNames.ToList();
                    PicBox.Image = Image.FromFile(ImageFilenames[0]);

                    //stretch images to the size of picbox
                    PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
            if (ImageFilenames.Count > 0)
            {
                nTotalNumber = ImageFilenames.Count;
                ImageUploadCounter.Text = nTotalNumber.ToString();
                imgCounter.Text = firstImage.ToString() + " / " + nTotalNumber.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            incrementImage();
        }
    }
}
