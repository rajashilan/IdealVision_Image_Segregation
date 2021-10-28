
namespace WinFormsApp1
{
    partial class Form8
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
            this.PicBoxFailed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewDefectCategories = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFailed)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxFailed
            // 
            this.PicBoxFailed.Location = new System.Drawing.Point(62, 57);
            this.PicBoxFailed.Name = "PicBoxFailed";
            this.PicBoxFailed.Size = new System.Drawing.Size(526, 321);
            this.PicBoxFailed.TabIndex = 12;
            this.PicBoxFailed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(298, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Failed";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(250, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Defect Categories:";
            // 
            // listViewDefectCategories
            // 
            this.listViewDefectCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewDefectCategories.Enabled = false;
            this.listViewDefectCategories.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDefectCategories.HideSelection = false;
            this.listViewDefectCategories.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewDefectCategories.Location = new System.Drawing.Point(165, 512);
            this.listViewDefectCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewDefectCategories.MultiSelect = false;
            this.listViewDefectCategories.Name = "listViewDefectCategories";
            this.listViewDefectCategories.ShowGroups = false;
            this.listViewDefectCategories.Size = new System.Drawing.Size(329, 95);
            this.listViewDefectCategories.TabIndex = 21;
            this.listViewDefectCategories.UseCompatibleStateImageBehavior = false;
            this.listViewDefectCategories.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 94;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 644);
            this.Controls.Add(this.listViewDefectCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBoxFailed);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFailed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxFailed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewDefectCategories;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}