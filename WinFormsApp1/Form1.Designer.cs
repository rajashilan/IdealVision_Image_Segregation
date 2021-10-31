
namespace WinFormsApp1
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnResume = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Back";
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(156)))), ((int)(((byte)(12)))));
            this.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSelect.ForeColor = System.Drawing.Color.White;
            this.BtnSelect.Location = new System.Drawing.Point(60, 91);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnSelect.Size = new System.Drawing.Size(158, 42);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Select Folder";
            this.BtnSelect.UseVisualStyleBackColor = false;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnResume
            // 
            this.BtnResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(156)))), ((int)(((byte)(12)))));
            this.BtnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResume.ForeColor = System.Drawing.Color.White;
            this.BtnResume.Location = new System.Drawing.Point(60, 139);
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnResume.Size = new System.Drawing.Size(158, 42);
            this.BtnResume.TabIndex = 2;
            this.BtnResume.Text = "Resume Previous Session";
            this.BtnResume.UseVisualStyleBackColor = false;
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Location = new System.Drawing.Point(60, 187);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.BtnEdit.Size = new System.Drawing.Size(158, 42);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Text = "Edit Defect Categories (Select Session)";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 53);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnResume);
            this.panel1.Controls.Add(this.BtnSelect);
            this.panel1.Location = new System.Drawing.Point(168, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 301);
            this.panel1.TabIndex = 5;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnResume;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

