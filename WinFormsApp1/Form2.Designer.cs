
namespace WinFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewFail = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.listViewPass = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgCounter = new System.Windows.Forms.TextBox();
            this.PassBtn = new System.Windows.Forms.Button();
            this.FailBtn = new System.Windows.Forms.Button();
            this.ImageUploadCounter = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.failCounter = new System.Windows.Forms.Label();
            this.passCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxFailCategories = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(674, 592);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(87, 20);
            this.linkLabel2.TabIndex = 43;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "View Folder";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(652, 616);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 20);
            this.linkLabel1.TabIndex = 42;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back to Homepage";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(643, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Screening Completed!";
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
            this.listViewFail.Size = new System.Drawing.Size(153, 457);
            this.listViewFail.TabIndex = 40;
            this.listViewFail.UseCompatibleStateImageBehavior = false;
            this.listViewFail.View = System.Windows.Forms.View.List;
            this.listViewFail.SelectedIndexChanged += new System.EventHandler(this.listViewFail_SelectedIndexChanged_1);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 94;
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
            this.listViewPass.TabIndex = 39;
            this.listViewPass.UseCompatibleStateImageBehavior = false;
            this.listViewPass.View = System.Windows.Forms.View.List;
            this.listViewPass.SelectedIndexChanged += new System.EventHandler(this.listViewPass_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 94;
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(375, 70);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(658, 404);
            this.PicBox.TabIndex = 31;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(222, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fail Counter: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.ForestGreen;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Pass Counter:";
            // 
            // imgCounter
            // 
            this.imgCounter.Location = new System.Drawing.Point(681, 507);
            this.imgCounter.Name = "imgCounter";
            this.imgCounter.Size = new System.Drawing.Size(81, 27);
            this.imgCounter.TabIndex = 36;
            this.imgCounter.Text = "0/0";
            this.imgCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassBtn
            // 
            this.PassBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.PassBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassBtn.Location = new System.Drawing.Point(375, 580);
            this.PassBtn.Name = "PassBtn";
            this.PassBtn.Size = new System.Drawing.Size(128, 44);
            this.PassBtn.TabIndex = 35;
            this.PassBtn.Text = "Pass";
            this.PassBtn.UseVisualStyleBackColor = false;
            this.PassBtn.Click += new System.EventHandler(this.PassBtn_Click_1);
            // 
            // FailBtn
            // 
            this.FailBtn.BackColor = System.Drawing.Color.Red;
            this.FailBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FailBtn.Location = new System.Drawing.Point(905, 585);
            this.FailBtn.Name = "FailBtn";
            this.FailBtn.Size = new System.Drawing.Size(128, 41);
            this.FailBtn.TabIndex = 34;
            this.FailBtn.Text = "Fail";
            this.FailBtn.UseVisualStyleBackColor = false;
            this.FailBtn.Click += new System.EventHandler(this.FailBtn_Click);
            // 
            // ImageUploadCounter
            // 
            this.ImageUploadCounter.AutoSize = true;
            this.ImageUploadCounter.Location = new System.Drawing.Point(767, 29);
            this.ImageUploadCounter.Name = "ImageUploadCounter";
            this.ImageUploadCounter.Size = new System.Drawing.Size(17, 20);
            this.ImageUploadCounter.TabIndex = 33;
            this.ImageUploadCounter.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Image Uploaded:";
            // 
            // failCounter
            // 
            this.failCounter.AutoSize = true;
            this.failCounter.BackColor = System.Drawing.Color.Red;
            this.failCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.failCounter.Location = new System.Drawing.Point(312, 127);
            this.failCounter.Name = "failCounter";
            this.failCounter.Size = new System.Drawing.Size(17, 20);
            this.failCounter.TabIndex = 30;
            this.failCounter.Text = "0";
            // 
            // passCounter
            // 
            this.passCounter.AutoSize = true;
            this.passCounter.BackColor = System.Drawing.Color.ForestGreen;
            this.passCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passCounter.Location = new System.Drawing.Point(122, 127);
            this.passCounter.Name = "passCounter";
            this.passCounter.Size = new System.Drawing.Size(17, 20);
            this.passCounter.TabIndex = 29;
            this.passCounter.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 71);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1110, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "+ Add defect categories for this session";
            this.label6.Click += new System.EventHandler(this.label6_Click);
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
            this.listBoxFailCategories.TabIndex = 44;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1434, 672);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxFailCategories);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewFail;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewPass;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imgCounter;
        private System.Windows.Forms.Button PassBtn;
        private System.Windows.Forms.Button FailBtn;
        private System.Windows.Forms.Label ImageUploadCounter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label failCounter;
        private System.Windows.Forms.Label passCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxFailCategories;
    }
}