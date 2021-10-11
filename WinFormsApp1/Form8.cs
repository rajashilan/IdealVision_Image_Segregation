using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form8 : Form
    {

        public string path;
        public string defectCategories;

        public string imgPathName
        {
            get { return path; }
            set { path = value; }
        }

        public string defectCategoriesList
        {
            get { return defectCategories; }
            set { defectCategories = value; }
        }

        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            Image img;
            using (var bmpTemp = new Bitmap(path))
            {
                img = new Bitmap(bmpTemp);
            }
            PicBoxFailed.Image = img;
            PicBoxFailed.SizeMode = PictureBoxSizeMode.StretchImage;

            var tempDefectCategories = defectCategories.Split("::")[1];
            string[] defectCategoriesArray = tempDefectCategories.Split(",");

            foreach(string defectCategory in defectCategoriesArray)
            {
                if(defectCategory != "")
                {
                    var listViewItem = new ListViewItem(defectCategory);
                    listViewDefectCategories.Items.Add(listViewItem);//add to list view (img name only)
                }
            }
        }
    }
}
