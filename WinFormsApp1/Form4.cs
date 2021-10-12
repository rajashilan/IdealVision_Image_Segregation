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
            {
                Image img;
                using (var bmpTemp = new Bitmap(ImageFilenames[nCurrentItem]))
                {
                    img = new Bitmap(bmpTemp);
                }
                PicBox.Image = img;

            }

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

        //pass image history
        int nImagePassed = 0;
        List<string> ImgPassHistory = new List<string>();

        //fail image history
        int nImageFailed = 0;
        List<string> ImgFailHistory = new List<string>();

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

                    Image img;
                    using (var bmpTemp = new Bitmap(ImageFilenames[0]))
                    {
                        img = new Bitmap(bmpTemp);
                    }
                    PicBox.Image = img;

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
            if (PicBox.Image == null)
            {
                MessageBox.Show("Please upload images.");
            }
            else { 
                try
                {
                    string failFolder = Path.Combine(latestSession.ToString(), "Fail");
                    string img = ImageFilenames[nCurrentItem];

                    Form6 fm = new Form6(failFolder, img);
                    fm.ShowDialog();
                    incrementImage();

                    var imgNameTemp = ImageFilenames[nImageFailed + nImagePassed];
                    var imgName = imgNameTemp.Split(latestSession.ToString() + @"\")[1]; //img name

                    var listViewItem = new ListViewItem(imgName + "::" + fm.sendDefectCategory());
                    listViewFail.Items.Add(listViewItem);//add to list view

                    ImgFailHistory.Add(fm.sendPathName());

                    nImageFailed++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Screening Completed");
                }
            }

            DirectoryInfo d2 = new DirectoryInfo(Path.Combine(latestSession.ToString() + @"\Fail"));
            FileInfo[] file = d2.GetFiles("*", SearchOption.AllDirectories);

            failCounter.Text = file.Length.ToString();


        }

        private void PassBtn_Click(object sender, EventArgs e)
        {
            string passFolder = Path.Combine(latestSession.ToString(), "Pass");

            if (PicBox.Image == null)
            {
                MessageBox.Show("Please upload images.");
            }
            else
            {
                try
                {
                    File.Move(ImageFilenames[nCurrentItem], Path.Combine(passFolder, Path.GetFileName(ImageFilenames[nCurrentItem])), true);
                    incrementImage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Screening Completed");
                }
            }
            DirectoryInfo d = new DirectoryInfo(Path.Combine(latestSession.ToString() + @"\Pass"));
            FileInfo[] file = d.GetFiles("*", SearchOption.AllDirectories);

            var latestFile = file[nImagePassed].ToString();
            var latestFileDisplay = latestFile.Split(@"Pass\")[1];
            var listViewItem = new ListViewItem(latestFileDisplay);

            ImgPassHistory.Add(latestFile);//add to pass history array (full path)
            listViewPass.Items.Add(listViewItem);//add to list view (img name only)

            passCounter.Text = file.Length.ToString();
            nImagePassed++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DirectoryInfo d2 = new DirectoryInfo(Path.Combine(latestSession.ToString() + @"\Fail"));
            FileInfo[] file = d2.GetFiles("*", SearchOption.AllDirectories);
            failCounter.Text = file.Length.ToString();

            DirectoryInfo d = new DirectoryInfo(Path.Combine(latestSession.ToString() + @"\Pass"));
            FileInfo[] files = d.GetFiles("*", SearchOption.AllDirectories);
            passCounter.Text = files.Length.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewPass.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewPass.SelectedIndices[0];
                Form7 form7 = new Form7();
                form7.imgPathName = ImgPassHistory[selectedIndex].ToString(); //get full img pathname
                form7.Show();
            }
        }

        private void listViewFail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFail.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewFail.SelectedIndices[0];
                Form8 form8 = new Form8();
                form8.imgPathName = ImgFailHistory[selectedIndex].ToString(); //get full img pathname
                form8.defectCategoriesList = listViewFail.SelectedItems[0].ToString();
                form8.Show();
            }
        }
    }
}
