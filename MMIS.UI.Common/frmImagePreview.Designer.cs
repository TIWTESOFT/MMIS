namespace MMIS.UI.Common
{
    partial class frmImagePreview
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
            this.picFile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).BeginInit();
            this.SuspendLayout();
            // 
            // picFile
            // 
            this.picFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFile.Location = new System.Drawing.Point(0, 0);
            this.picFile.Name = "picFile";
            this.picFile.Size = new System.Drawing.Size(762, 409);
            this.picFile.TabIndex = 0;
            this.picFile.TabStop = false;
            // 
            // frmImagePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 409);
            this.Controls.Add(this.picFile);
            this.Name = "frmImagePreview";
            this.Text = "图片预览";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmImagePreview_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFile;
    }
}