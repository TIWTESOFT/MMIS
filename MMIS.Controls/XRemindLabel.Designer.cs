namespace MMIS.Controls
{
    partial class XRemindLabel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XRemindLabel));
            this.pcRemind = new System.Windows.Forms.PictureBox();
            this.lblRemindText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcRemind)).BeginInit();
            this.SuspendLayout();
            // 
            // pcRemind
            // 
            this.pcRemind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcRemind.BackgroundImage")));
            this.pcRemind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcRemind.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcRemind.Location = new System.Drawing.Point(0, 0);
            this.pcRemind.Name = "pcRemind";
            this.pcRemind.Size = new System.Drawing.Size(29, 24);
            this.pcRemind.TabIndex = 0;
            this.pcRemind.TabStop = false;
            // 
            // lblRemindText
            // 
            this.lblRemindText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemindText.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRemindText.Location = new System.Drawing.Point(27, -2);
            this.lblRemindText.Name = "lblRemindText";
            this.lblRemindText.Size = new System.Drawing.Size(391, 25);
            this.lblRemindText.TabIndex = 1;
            this.lblRemindText.Text = "label1";
            this.lblRemindText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // XRemindLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcRemind);
            this.Controls.Add(this.lblRemindText);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "XRemindLabel";
            this.Size = new System.Drawing.Size(421, 24);
            ((System.ComponentModel.ISupportInitialize)(this.pcRemind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcRemind;
        private System.Windows.Forms.Label lblRemindText;
    }
}
