namespace MMIS.UI
{
    partial class frmSystemConfig
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
            this.xGroupBox1 = new MMIS.Component.XGroupBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.nebWidth = new MMIS.Component.XNumberEditBox();
            this.nebHeight = new MMIS.Component.XNumberEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.xGroupBox2 = new MMIS.Component.XGroupBox();
            this.xLabel4 = new MMIS.Component.XLabel();
            this.nebRefreshMinutes = new MMIS.Component.XNumberEditBox();
            this.xLabel3 = new MMIS.Component.XLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).BeginInit();
            this.xGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).BeginInit();
            this.xGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(155, 154);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(242, 154);
            // 
            // xGroupBox1
            // 
            this.xGroupBox1.Controls.Add(this.xLabel2);
            this.xGroupBox1.Controls.Add(this.nebWidth);
            this.xGroupBox1.Controls.Add(this.nebHeight);
            this.xGroupBox1.Controls.Add(this.xLabel1);
            this.xGroupBox1.Location = new System.Drawing.Point(6, 6);
            this.xGroupBox1.Name = "xGroupBox1";
            this.xGroupBox1.Size = new System.Drawing.Size(313, 63);
            this.xGroupBox1.TabIndex = 101;
            this.xGroupBox1.Text = "检定报告电子签名设置";
            this.xGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(156, 30);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(32, 17);
            this.xLabel2.TabIndex = 3;
            this.xLabel2.Text = "宽度";
            // 
            // nebWidth
            // 
            this.nebWidth.FormatString = "0";
            this.nebWidth.IsAllowEmpty = false;
            this.nebWidth.IsAllowLessThanZero = false;
            this.nebWidth.IsAllowZero = false;
            this.nebWidth.Location = new System.Drawing.Point(194, 27);
            this.nebWidth.Name = "nebWidth";
            this.nebWidth.Size = new System.Drawing.Size(100, 23);
            this.nebWidth.TabIndex = 2;
            this.nebWidth.Text = "0";
            this.nebWidth.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebWidth.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebHeight
            // 
            this.nebHeight.FormatString = "0";
            this.nebHeight.IsAllowEmpty = false;
            this.nebHeight.IsAllowLessThanZero = false;
            this.nebHeight.IsAllowZero = false;
            this.nebHeight.Location = new System.Drawing.Point(50, 27);
            this.nebHeight.Name = "nebHeight";
            this.nebHeight.Size = new System.Drawing.Size(100, 23);
            this.nebHeight.TabIndex = 1;
            this.nebHeight.Text = "0";
            this.nebHeight.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebHeight.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(12, 30);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(32, 17);
            this.xLabel1.TabIndex = 0;
            this.xLabel1.Text = "高度";
            // 
            // xGroupBox2
            // 
            this.xGroupBox2.Controls.Add(this.xLabel3);
            this.xGroupBox2.Controls.Add(this.nebRefreshMinutes);
            this.xGroupBox2.Controls.Add(this.xLabel4);
            this.xGroupBox2.Location = new System.Drawing.Point(6, 75);
            this.xGroupBox2.Name = "xGroupBox2";
            this.xGroupBox2.Size = new System.Drawing.Size(313, 63);
            this.xGroupBox2.TabIndex = 102;
            this.xGroupBox2.Text = "定时刷新时间设置";
            this.xGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // xLabel4
            // 
            this.xLabel4.AutoSize = true;
            this.xLabel4.ForeColor = System.Drawing.Color.Black;
            this.xLabel4.Location = new System.Drawing.Point(12, 30);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(32, 17);
            this.xLabel4.TabIndex = 0;
            this.xLabel4.Text = "每隔";
            // 
            // nebRefreshMinutes
            // 
            this.nebRefreshMinutes.FormatString = "0";
            this.nebRefreshMinutes.IsAllowEmpty = false;
            this.nebRefreshMinutes.IsAllowLessThanZero = false;
            this.nebRefreshMinutes.IsAllowZero = false;
            this.nebRefreshMinutes.Location = new System.Drawing.Point(50, 27);
            this.nebRefreshMinutes.Name = "nebRefreshMinutes";
            this.nebRefreshMinutes.Size = new System.Drawing.Size(100, 23);
            this.nebRefreshMinutes.TabIndex = 2;
            this.nebRefreshMinutes.Text = "1";
            this.nebRefreshMinutes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nebRefreshMinutes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(156, 30);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(80, 17);
            this.xLabel3.TabIndex = 3;
            this.xLabel3.Text = "分钟刷新一次";
            // 
            // frmSystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 193);
            this.Controls.Add(this.xGroupBox2);
            this.Controls.Add(this.xGroupBox1);
            this.Name = "frmSystemConfig";
            this.Text = "系统设置";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xGroupBox1, 0);
            this.Controls.SetChildIndex(this.xGroupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).EndInit();
            this.xGroupBox1.ResumeLayout(false);
            this.xGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).EndInit();
            this.xGroupBox2.ResumeLayout(false);
            this.xGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.XGroupBox xGroupBox1;
        private Component.XLabel xLabel2;
        private Component.XNumberEditBox nebWidth;
        private Component.XNumberEditBox nebHeight;
        private Component.XLabel xLabel1;
        private Component.XGroupBox xGroupBox2;
        private Component.XLabel xLabel3;
        private Component.XNumberEditBox nebRefreshMinutes;
        private Component.XLabel xLabel4;
    }
}