namespace MMIS.Controls
{
    partial class XBarCode
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
            this.panelContaioner = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ctlBarcode = new Cobainsoft.Windows.Forms.BarcodeControl();
            this.panelContaioner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContaioner
            // 
            this.panelContaioner.BackColor = System.Drawing.Color.White;
            this.panelContaioner.Controls.Add(this.lblPrice);
            this.panelContaioner.Controls.Add(this.lblName);
            this.panelContaioner.Controls.Add(this.ctlBarcode);
            this.panelContaioner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContaioner.Location = new System.Drawing.Point(0, 0);
            this.panelContaioner.Name = "panelContaioner";
            this.panelContaioner.Size = new System.Drawing.Size(486, 284);
            this.panelContaioner.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPrice.Location = new System.Drawing.Point(34, 84);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(96, 27);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "label2";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(34, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 27);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // ctlBarcode
            // 
            this.ctlBarcode.AccessibleName = "";
            this.ctlBarcode.AddOnCaption = null;
            this.ctlBarcode.AddOnData = "";
            this.ctlBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlBarcode.BackColor = System.Drawing.Color.White;
            this.ctlBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ctlBarcode.BarcodeType = Cobainsoft.Windows.Forms.BarcodeType.CODE39;
            this.ctlBarcode.CopyRight = "";
            this.ctlBarcode.Data = "123456";
            this.ctlBarcode.Font = new System.Drawing.Font("Arial", 11F);
            this.ctlBarcode.ForeColor = System.Drawing.Color.Black;
            this.ctlBarcode.InvalidDataAction = Cobainsoft.Windows.Forms.InvalidDataAction.DisplayInvalid;
            this.ctlBarcode.Location = new System.Drawing.Point(5, 126);
            this.ctlBarcode.LowerTopTextBy = 0F;
            this.ctlBarcode.Name = "ctlBarcode";
            this.ctlBarcode.RaiseBottomTextBy = 0F;
            this.ctlBarcode.Size = new System.Drawing.Size(480, 155);
            this.ctlBarcode.StretchText = false;
            this.ctlBarcode.TabIndex = 1;
            // 
            // XBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContaioner);
            this.Name = "XBarCode";
            this.Size = new System.Drawing.Size(486, 284);
            this.panelContaioner.ResumeLayout(false);
            this.panelContaioner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContaioner;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblName;
        private Cobainsoft.Windows.Forms.BarcodeControl ctlBarcode;
    }
}
