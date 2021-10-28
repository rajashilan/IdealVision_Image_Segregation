
namespace WinFormsApp1
{
    partial class Form7
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
            this.PicBoxPassed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPassed)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxPassed
            // 
            this.PicBoxPassed.Location = new System.Drawing.Point(67, 52);
            this.PicBoxPassed.Name = "PicBoxPassed";
            this.PicBoxPassed.Size = new System.Drawing.Size(526, 321);
            this.PicBoxPassed.TabIndex = 11;
            this.PicBoxPassed.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(289, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Passed";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBoxPassed);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxPassed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxPassed;
        private System.Windows.Forms.Label label1;
    }
}