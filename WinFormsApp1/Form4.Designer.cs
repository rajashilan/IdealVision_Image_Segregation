
namespace WinFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passCounter = new System.Windows.Forms.Label();
            this.failCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImageUploadCounter = new System.Windows.Forms.Label();
            this.FailBtn = new System.Windows.Forms.Button();
            this.PassBtn = new System.Windows.Forms.Button();
            this.imgCounter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.listViewPass = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.listViewFail = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.labelTest = new System.Windows.Forms.Label();
            this.labelTest1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.listBoxFailCategories = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "History";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // passCounter
            // 
            this.passCounter.AutoSize = true;
            this.passCounter.BackColor = System.Drawing.Color.ForestGreen;
            this.passCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passCounter.Location = new System.Drawing.Point(138, 121);
            this.passCounter.Name = "passCounter";
            this.passCounter.Size = new System.Drawing.Size(17, 20);
            this.passCounter.TabIndex = 8;
            this.passCounter.Text = "0";
            this.passCounter.Click += new System.EventHandler(this.label2_Click);
            // 
            // failCounter
            // 
            this.failCounter.AutoSize = true;
            this.failCounter.BackColor = System.Drawing.Color.Red;
            this.failCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.failCounter.Location = new System.Drawing.Point(306, 121);
            this.failCounter.Name = "failCounter";
            this.failCounter.Size = new System.Drawing.Size(17, 20);
            this.failCounter.TabIndex = 9;
            this.failCounter.Text = "0";
            this.failCounter.Click += new System.EventHandler(this.failCounter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Image Uploaded:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // ImageUploadCounter
            // 
            this.ImageUploadCounter.AutoSize = true;
            this.ImageUploadCounter.Location = new System.Drawing.Point(746, 31);
            this.ImageUploadCounter.Name = "ImageUploadCounter";
            this.ImageUploadCounter.Size = new System.Drawing.Size(17, 20);
            this.ImageUploadCounter.TabIndex = 12;
            this.ImageUploadCounter.Text = "0";
            // 
            // FailBtn
            // 
            this.FailBtn.BackColor = System.Drawing.Color.Red;
            this.FailBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FailBtn.Location = new System.Drawing.Point(905, 524);
            this.FailBtn.Name = "FailBtn";
            this.FailBtn.Size = new System.Drawing.Size(128, 41);
            this.FailBtn.TabIndex = 13;
            this.FailBtn.Text = "Fail";
            this.FailBtn.UseVisualStyleBackColor = false;
            this.FailBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassBtn
            // 
            this.PassBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.PassBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassBtn.Location = new System.Drawing.Point(375, 521);
            this.PassBtn.Name = "PassBtn";
            this.PassBtn.Size = new System.Drawing.Size(128, 44);
            this.PassBtn.TabIndex = 14;
            this.PassBtn.Text = "Pass";
            this.PassBtn.UseVisualStyleBackColor = false;
            this.PassBtn.Click += new System.EventHandler(this.PassBtn_Click);
            // 
            // imgCounter
            // 
            this.imgCounter.Location = new System.Drawing.Point(653, 488);
            this.imgCounter.Name = "imgCounter";
            this.imgCounter.Size = new System.Drawing.Size(81, 27);
            this.imgCounter.TabIndex = 16;
            this.imgCounter.Text = "0/0";
            this.imgCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.ForestGreen;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pass Counter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(216, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fail Counter: ";
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(375, 70);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(658, 404);
            this.PicBox.TabIndex = 10;
            this.PicBox.TabStop = false;
            // 
            // listViewPass
            // 
            this.listViewPass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewPass.HideSelection = false;
            this.listViewPass.Location = new System.Drawing.Point(18, 169);
            this.listViewPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewPass.MultiSelect = false;
            this.listViewPass.Name = "listViewPass";
            this.listViewPass.ShowGroups = false;
            this.listViewPass.Size = new System.Drawing.Size(149, 457);
            this.listViewPass.TabIndex = 20;
            this.listViewPass.UseCompatibleStateImageBehavior = false;
            this.listViewPass.View = System.Windows.Forms.View.List;
            this.listViewPass.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 94;
            // 
            // listViewFail
            // 
            this.listViewFail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listViewFail.HideSelection = false;
            this.listViewFail.Location = new System.Drawing.Point(202, 169);
            this.listViewFail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewFail.MultiSelect = false;
            this.listViewFail.Name = "listViewFail";
            this.listViewFail.ShowGroups = false;
            this.listViewFail.Size = new System.Drawing.Size(149, 457);
            this.listViewFail.TabIndex = 21;
            this.listViewFail.UseCompatibleStateImageBehavior = false;
            this.listViewFail.View = System.Windows.Forms.View.List;
            this.listViewFail.SelectedIndexChanged += new System.EventHandler(this.listViewFail_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 94;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(14, 488);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 20);
            this.labelTest.TabIndex = 22;
            // 
            // labelTest1
            // 
            this.labelTest1.AutoSize = true;
            this.labelTest1.Location = new System.Drawing.Point(22, 472);
            this.labelTest1.Name = "labelTest1";
            this.labelTest1.Size = new System.Drawing.Size(0, 20);
            this.labelTest1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(616, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Screening Completed!";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(625, 604);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 20);
            this.linkLabel1.TabIndex = 25;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back to Homepage";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(647, 580);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(87, 20);
            this.linkLabel2.TabIndex = 26;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View Folder";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // listBoxFailCategories
            // 
            this.listBoxFailCategories.FormattingEnabled = true;
            this.listBoxFailCategories.ItemHeight = 20;
            this.listBoxFailCategories.Location = new System.Drawing.Point(1049, 70);
            this.listBoxFailCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxFailCategories.Name = "listBoxFailCategories";
            this.listBoxFailCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxFailCategories.Size = new System.Drawing.Size(369, 404);
            this.listBoxFailCategories.TabIndex = 41;
            this.listBoxFailCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxFailCategories_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1099, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "+ Add defect categories for this session";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1435, 670);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxFailCategories);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTest1);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.listViewFail);
            this.Controls.Add(this.listViewPass);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imgCounter);
            this.Controls.Add(this.PassBtn);
            this.Controls.Add(this.FailBtn);
            this.Controls.Add(this.ImageUploadCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.failCounter);
            this.Controls.Add(this.passCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passCounter;
        private System.Windows.Forms.Label failCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ImageUploadCounter;
        private System.Windows.Forms.Button FailBtn;
        private System.Windows.Forms.Button PassBtn;
        private System.Windows.Forms.TextBox imgCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.ListView listViewPass;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewFail;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label labelTest1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ListBox listBoxFailCategories;
        private System.Windows.Forms.Label label6;
    }
}