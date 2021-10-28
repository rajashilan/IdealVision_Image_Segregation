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
    public partial class Form2 : Form
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

        public Form2()
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

                //to show pass counter and fail counter
                getCount();

            }
            catch (Exception e)
            {
                string noImages = "No images found in last session folder.";
                MessageBox.Show(noImages);
                getCount();
                endOfSession();

            }

            if (ImageFileNames.Count > 0)
            {
                nTotalNumber = ImageFileNames.Count;
                ImageUploadCounter.Text = nTotalNumber.ToString();
                imgCounter.Text = firstImage.ToString() + " / " + nTotalNumber.ToString();

            }
        }

        //to show pass counter and fail counter
        public void getCount()
        {

            string passCount = Path.Combine(latestSession.ToString(), "Pass");
            DirectoryInfo d = new DirectoryInfo(Path.Combine(latestSession.ToString() + @"\Pass"));
            FileInfo[] file = d.GetFiles("*", SearchOption.AllDirectories);

            

            if (file != null)
            {
                passCounter.Text = file.Length.ToString();
            }

            string failCount = Path.Combine(latestSession.ToString(), "Fail");
            string curFileFailed = Path.Combine(failCount + @"\FailCounter.txt");

            if (File.Exists(curFileFailed))
            {

                using (StreamReader f1 = new StreamReader(Path.Combine(failCount + @"\FailCounter.txt")))
                {
                    //int fail_value = Convert.ToInt32(f1.ReadLine());
                    int failValue = int.Parse(f1.ReadLine());
                    f1.Close();

                    failCounter.Text = failValue.ToString();
                }
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

        //load images

        //List<string> ImageFilenames = new List<string>();
        string uploadDir = Path.Combine(@"Upload\");

        //pass image history
        int nImagePassed = 0;
        List<string> ImgPassHistory = new List<string>();

        //fail image history
        int nImageFailed = 0;
        List<string> ImgFailHistory = new List<string>();

        private void PicBox_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = latestSession.ToString();
            openFileDialog1.ShowDialog();
        }

        private void listViewPass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPass.SelectedIndices.Count > 0)
            {
                int selectedIndex = listViewPass.SelectedIndices[0];
                Form7 form7 = new Form7();
                form7.imgPathName = ImgPassHistory[selectedIndex].ToString(); //get full img pathname
                form7.Show();
            }
        }

        private void listViewFail_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void FailBtn_Click(object sender, EventArgs e)
        {
            string failFolder = Path.Combine(latestSession.ToString(), "Fail");

            try
            {

                if (PicBox.Image == null)
                {
                    MessageBox.Show("Please upload images.");
                }
                else if (listBoxFailCategories.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select any defect category");
                }
                else if (MessageBox.Show("Are u confirm with the defect categories?", "Fail image", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var tempDefectCategory = "";
                    string FullPathName = "";

                    foreach (string item in listBoxFailCategories.SelectedItems)
                    {
                        string defectFolder = Path.Combine(failFolder, item);
                        File.Copy(ImageFileNames[nCurrentItem], Path.Combine(defectFolder, Path.GetFileName(ImageFileNames[nCurrentItem])), true);

                        //added = true;

                        tempDefectCategory = tempDefectCategory + item.ToString() + ",";

                        FullPathName = Path.Combine(defectFolder, Path.GetFileName(ImageFileNames[nCurrentItem]));

                    }
                    string DefectCategory = tempDefectCategory;
                    File.Delete(ImageFileNames[nCurrentItem]);

                    var imgNameTemp = ImageFileNames[nImageFailed + nImagePassed];
                    var imgName = imgNameTemp.Split(latestSession.ToString() + @"\")[1]; //img name

                    var listViewItem = new ListViewItem(imgName + "::" + DefectCategory);
                    listViewFail.Items.Add(listViewItem);//add to list view

                    ImgFailHistory.Add(FullPathName);

                    nImageFailed++;

                    incrementImage();
                    listBoxFailCategories.ClearSelected();

                    int fail_value = Convert.ToInt32(failCounter.Text);
                    fail_value++;
                    failCounter.Text = fail_value.ToString();

                    using (StreamWriter f1 = new StreamWriter(Path.Combine(failFolder + @"\FailCounter.txt")))
                    {
                        f1.Flush();
                        f1.WriteLine(failCounter.Text);
                        f1.Close();
                    }
                }
            }
            catch (Exception ex)
                {
                    //MessageBox.Show("Screening Completed");
                    endOfSession();
                }
            
        }

        private void PassBtn_Click_1(object sender, EventArgs e)
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = latestSession.ToString();
            openFileDialog1.ShowDialog();
        }

        public void RefreshListView()
        {
            string failFolder = Path.Combine(latestSession.ToString(), "Fail");

            listBoxFailCategories.Items.Clear();
            string[] dirs = Directory.GetDirectories(failFolder);

            foreach (string dir in dirs)
            {
                listBoxFailCategories.Items.Add(Path.GetFileName(dir));
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            string failFolder = Path.Combine(latestSession.ToString(), "Fail");

            Form9 fm = new Form9();
            fm.Value = failFolder;
            fm.MyParent = this;
            fm.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string failFolder = Path.Combine(latestSession.ToString(), "Fail");

            listBoxFailCategories.Items.Clear();
            string[] dirs = Directory.GetDirectories(failFolder);

            foreach (string dir in dirs)
            {
                listBoxFailCategories.Items.Add(Path.GetFileName(dir));
            }
        }
    }
}
