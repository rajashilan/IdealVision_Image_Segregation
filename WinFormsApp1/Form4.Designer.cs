
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
            this.uploadBtn = new System.Windows.Forms.Button();
            this.imgCounter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 92);
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
            this.passCounter.Location = new System.Drawing.Point(195, 126);
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
            this.failCounter.Location = new System.Drawing.Point(331, 126);
            this.failCounter.Name = "failCounter";
            this.failCounter.Size = new System.Drawing.Size(17, 20);
            this.failCounter.TabIndex = 9;
            this.failCounter.Text = "0";
            this.failCounter.Click += new System.EventHandler(this.failCounter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Image Uploaded:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // ImageUploadCounter
            // 
            this.ImageUploadCounter.AutoSize = true;
            this.ImageUploadCounter.Location = new System.Drawing.Point(720, 31);
            this.ImageUploadCounter.Name = "ImageUploadCounter";
            this.ImageUploadCounter.Size = new System.Drawing.Size(61, 20);
            this.ImageUploadCounter.TabIndex = 12;
            this.ImageUploadCounter.Text = "Counter";
            // 
            // FailBtn
            // 
            this.FailBtn.BackColor = System.Drawing.Color.Red;
            this.FailBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FailBtn.Location = new System.Drawing.Point(389, 525);
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
            this.PassBtn.Location = new System.Drawing.Point(796, 522);
            this.PassBtn.Name = "PassBtn";
            this.PassBtn.Size = new System.Drawing.Size(128, 44);
            this.PassBtn.TabIndex = 14;
            this.PassBtn.Text = "Pass";
            this.PassBtn.UseVisualStyleBackColor = false;
            this.PassBtn.Click += new System.EventHandler(this.PassBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(460, 31);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(94, 29);
            this.uploadBtn.TabIndex = 15;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // imgCounter
            // 
            this.imgCounter.Location = new System.Drawing.Point(627, 430);
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
            this.label3.Location = new System.Drawing.Point(103, 126);
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
            this.label4.Location = new System.Drawing.Point(241, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fail Counter: ";
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(398, 92);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(526, 321);
            this.PicBox.TabIndex = 10;
            this.PicBox.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(955, 602);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imgCounter);
            this.Controls.Add(this.uploadBtn);
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
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TextBox imgCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PicBox;
    }
}