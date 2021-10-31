
namespace WinFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label3 = new System.Windows.Forms.Label();
            this.TBoxDefect = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFailCategories = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelcurrentpath = new System.Windows.Forms.Label();
            this.BtnRename = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxOldName = new System.Windows.Forms.TextBox();
            this.textBoxNewName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(160, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Defect Categories";
            // 
            // TBoxDefect
            // 
            this.TBoxDefect.BackColor = System.Drawing.Color.Gainsboro;
            this.TBoxDefect.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TBoxDefect.Location = new System.Drawing.Point(519, 97);
            this.TBoxDefect.Multiline = true;
            this.TBoxDefect.Name = "TBoxDefect";
            this.TBoxDefect.Size = new System.Drawing.Size(325, 170);
            this.TBoxDefect.TabIndex = 23;
            this.TBoxDefect.Text = "Key in new defect categories";
            this.TBoxDefect.Enter += new System.EventHandler(this.TBoxDefect_Enter);
            this.TBoxDefect.Leave += new System.EventHandler(this.TBoxDefect_Leave);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(685, 289);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(113, 40);
            this.BtnCancel.TabIndex = 22;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(156)))), ((int)(((byte)(12)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(558, 289);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(113, 40);
            this.BtnAdd.TabIndex = 21;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(578, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Create new defect categories";
            // 
            // listBoxFailCategories
            // 
            this.listBoxFailCategories.FormattingEnabled = true;
            this.listBoxFailCategories.ItemHeight = 15;
            this.listBoxFailCategories.Location = new System.Drawing.Point(45, 97);
            this.listBoxFailCategories.Name = "listBoxFailCategories";
            this.listBoxFailCategories.Size = new System.Drawing.Size(385, 169);
            this.listBoxFailCategories.TabIndex = 27;
            this.listBoxFailCategories.SelectedIndexChanged += new System.EventHandler(this.listBoxFailCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Current Path:";
            // 
            // labelcurrentpath
            // 
            this.labelcurrentpath.AutoSize = true;
            this.labelcurrentpath.Location = new System.Drawing.Point(243, 10);
            this.labelcurrentpath.Name = "labelcurrentpath";
            this.labelcurrentpath.Size = new System.Drawing.Size(0, 15);
            this.labelcurrentpath.TabIndex = 29;
            // 
            // BtnRename
            // 
            this.BtnRename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(156)))), ((int)(((byte)(12)))));
            this.BtnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRename.ForeColor = System.Drawing.Color.White;
            this.BtnRename.Location = new System.Drawing.Point(126, 345);
            this.BtnRename.Name = "BtnRename";
            this.BtnRename.Size = new System.Drawing.Size(100, 40);
            this.BtnRename.TabIndex = 31;
            this.BtnRename.Text = "Rename";
            this.BtnRename.UseVisualStyleBackColor = false;
            this.BtnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(243, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "Delete ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOldName
            // 
            this.textBoxOldName.Location = new System.Drawing.Point(194, 279);
            this.textBoxOldName.Name = "textBoxOldName";
            this.textBoxOldName.ReadOnly = true;
            this.textBoxOldName.Size = new System.Drawing.Size(170, 23);
            this.textBoxOldName.TabIndex = 32;
            this.textBoxOldName.Text = "Select a Category from the list";
            this.textBoxOldName.TextChanged += new System.EventHandler(this.textBoxOldName_TextChanged);
            // 
            // textBoxNewName
            // 
            this.textBoxNewName.Location = new System.Drawing.Point(194, 308);
            this.textBoxNewName.Name = "textBoxNewName";
            this.textBoxNewName.Size = new System.Drawing.Size(170, 23);
            this.textBoxNewName.TabIndex = 33;
            this.textBoxNewName.TextChanged += new System.EventHandler(this.textBoxNewName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Current Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "New Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNewName);
            this.Controls.Add(this.textBoxOldName);
            this.Controls.Add(this.BtnRename);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelcurrentpath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFailCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBoxDefect);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Edit Previous Defect Categories";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBoxDefect;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFailCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelcurrentpath;
        private System.Windows.Forms.Button BtnRename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxOldName;
        private System.Windows.Forms.TextBox textBoxNewName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}