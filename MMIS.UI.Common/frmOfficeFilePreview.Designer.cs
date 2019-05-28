namespace MMIS.UI.Common
{
    partial class frmOfficeFilePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfficeFilePreview));
            this.fcWord = new AxDSOFramer.AxFramerControl();
            ((System.ComponentModel.ISupportInitialize)(this.fcWord)).BeginInit();
            this.SuspendLayout();
            // 
            // fcWord
            // 
            this.fcWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcWord.Enabled = true;
            this.fcWord.Location = new System.Drawing.Point(0, 0);
            this.fcWord.Name = "fcWord";
            this.fcWord.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fcWord.OcxState")));
            this.fcWord.Size = new System.Drawing.Size(750, 437);
            this.fcWord.TabIndex = 2;
            // 
            // frmOfficeFilePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 437);
            this.Controls.Add(this.fcWord);
            this.Name = "frmOfficeFilePreview";
            this.Text = "文件预览";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.fcWord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxDSOFramer.AxFramerControl fcWord;

    }
}