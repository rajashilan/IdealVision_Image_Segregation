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
        //get latest modified session folder
        DirectoryInfo latestSession = new DirectoryInfo(@"Upload\").GetDirectories().OrderByDescending(d => d.LastWriteTimeUtc).First();

        //new list to store images from session folder
        List<String> ImageFileNames = new List<String>();
        int nTotalNumber = 0;
        int nCurrentItem = 0;
        int firstImage = 1;

        public void endOfSession() //taken from pass and fail button catch section
        {
            imgCounter.Visible = false;
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            PassBtn.Visible = false;
            FailBtn.Visible = false;
        }

        public Form4()
        {
            InitializeComponent();
            label5.Visible = false;
            linkLabel1.Visible = false;
            linkLabel2.Visible = false;

            String sessionFolder = latestSession.ToString();
            ImageFileNames = Directory.GetFiles(sessionFolder).ToList();

            try
            {
                Image image;
                using (var bmpTemp = new Bitmap(ImageFileNames[0]))
                {
                    image = new Bitmap(bmpTemp);
                }
                PicBox.Image = image;
                PicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch (Exception e)
            {
                string noImages = "No images found in last session folder.";
                MessageBox.Show(noImages);
                endOfSession();
                
            }

            if (ImageFileNames.Count > 0)
            {
                nTotalNumber = ImageFileNames.Count;
                ImageUploadCounter.Text = nTotalNumber.ToString();
                imgCounter.Text = firstImage.ToString() + " / " + nTotalNumber.ToString();

            }
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
                using (var bmpTemp = new Bitmap(ImageFileNames[nCurrentItem]))
                {
                    img = new Bitmap(bmpTemp);
                }
                PicBox.Image = img;

            } 
            else if (nCurrentItem == nTotalNumber) //added this, not sure if try and catch in pass and fail still needed
            {
                label5.Visible = true;
                endOfSession();
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
        
        //List<string> ImageFilenames = new List<string>();
        string uploadDir = Path.Combine(@"Upload\");

        //pass image history
        int nImagePassed = 0;
        List<string> ImgPassHistory = new List<string>();

        //fail image history
        int nImageFailed = 0;
        List<string> ImgFailHistory = new List<string>();

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
                    string img = ImageFileNames[nCurrentItem];

                    Form6 fm = new Form6();
                    fm.Value = failFolder;
                    fm.Image = img;
                    fm.ShowDialog();
                    incrementImage();

                    var imgNameTemp = ImageFileNames[nImageFailed + nImagePassed];
                    var imgName = imgNameTemp.Split(latestSession.ToString() + @"\")[1]; //img name

                    var listViewItem = new ListViewItem(imgName + "::" + fm.sendDefectCategory());
                    listViewFail.Items.Add(listViewItem);//add to list view

                    ImgFailHistory.Add(fm.sendPathName());

                    nImageFailed++;
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Screening Completed");
                    endOfSession();
                }
            }
            int fail_value = Convert.ToInt32(failCounter.Text);
            fail_value++;
            failCounter.Text = fail_value.ToString();
            //DirectoryInfo d2 = new DirectoryInfo(Path.Combine(latestSession.ToString() + @"\Fail"));
            //FileInfo[] file = d2.GetFiles("*", SearchOption.AllDirectories);

            //failCounter.Text = file.Length.ToString();


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
                    File.Move(ImageFileNames[nCurrentItem], Path.Combine(passFolder, Path.GetFileName(ImageFileNames[nCurrentItem])), true);
                    incrementImage();

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
                catch (Exception ex)
                {
                    //MessageBox.Show("Screening Completed");
                    endOfSession();
                }
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //for the refresh button in counter, but not used already

            //DirectoryInfo d2 = new DirectoryInfo(Path.Combine(latestSession.ToString() + @"\Fail"));
            //FileInfo[] file = d2.GetFiles("*", SearchOption.AllDirectories);
            //failCounter.Text = file.Length.ToString();

            //DirectoryInfo d = new DirectoryInfo(Path.Combine(latestSession.ToString() + @"\Pass"));
            //FileInfo[] files = d.GetFiles("*", SearchOption.AllDirectories);
            //passCounter.Text = files.Length.ToString();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = latestSession.ToString();
            openFileDialog1.ShowDialog();
        }

    }
}
