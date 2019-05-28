namespace MMIS.UI
{
    public partial class frmRemindConfigEdit
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
            this.lblConfigType = new MMIS.Component.XLabel();
            this.lblRemindDays = new MMIS.Component.XLabel();
            this.lblRemindInfoTemplate = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtConfigType = new MMIS.Component.XEditBox();
            this.nebRemindDays = new MMIS.Component.XNumberEditBox();
            this.txtRemindInfoTemplate = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(239, 107);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 107);
            // 
            // lblConfigType
            // 
            this.lblConfigType.AutoSize = true;
            this.lblConfigType.ForeColor = System.Drawing.Color.Black;
            this.lblConfigType.Location = new System.Drawing.Point(8, 15);
            this.lblConfigType.Name = "lblConfigType";
            this.lblConfigType.Size = new System.Drawing.Size(56, 17);
            this.lblConfigType.TabIndex = 1;
            this.lblConfigType.Text = "提醒类型";
            // 
            // lblRemindDays
            // 
            this.lblRemindDays.AutoSize = true;
            this.lblRemindDays.ForeColor = System.Drawing.Color.Black;
            this.lblRemindDays.Location = new System.Drawing.Point(8, 45);
            this.lblRemindDays.Name = "lblRemindDays";
            this.lblRemindDays.Size = new System.Drawing.Size(56, 17);
            this.lblRemindDays.TabIndex = 2;
            this.lblRemindDays.Text = "提醒时间";
            // 
            // lblRemindInfoTemplate
            // 
            this.lblRemindInfoTemplate.AutoSize = true;
            this.lblRemindInfoTemplate.ForeColor = System.Drawing.Color.Black;
            this.lblRemindInfoTemplate.Location = new System.Drawing.Point(4, 231);
            this.lblRemindInfoTemplate.Name = "lblRemindInfoTemplate";
            this.lblRemindInfoTemplate.Size = new System.Drawing.Size(80, 17);
            this.lblRemindInfoTemplate.TabIndex = 3;
            this.lblRemindInfoTemplate.Text = "提醒信息模版";
            this.lblRemindInfoTemplate.Visible = false;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(8, 75);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 4;
            this.lblRemark.Text = "备注信息";
            // 
            // txtConfigType
            // 
            this.txtConfigType.IsAllowEmpty = false;
            this.txtConfigType.Location = new System.Drawing.Point(70, 12);
            this.txtConfigType.Name = "txtConfigType";
            this.txtConfigType.ReadOnly = true;
            this.txtConfigType.Size = new System.Drawing.Size(331, 23);
            this.txtConfigType.TabIndex = 0;
            this.txtConfigType.TabStop = false;
            this.txtConfigType.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebRemindDays
            // 
            this.nebRemindDays.FormatString = "0";
            this.nebRemindDays.IsAllowEmpty = false;
            this.nebRemindDays.IsAllowLessThanZero = false;
            this.nebRemindDays.IsAllowZero = false;
            this.nebRemindDays.Location = new System.Drawing.Point(70, 42);
            this.nebRemindDays.Name = "nebRemindDays";
            this.nebRemindDays.Size = new System.Drawing.Size(245, 23);
            this.nebRemindDays.TabIndex = 1;
            this.nebRemindDays.Text = "0";
            this.nebRemindDays.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebRemindDays.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemindInfoTemplate
            // 
            this.txtRemindInfoTemplate.IsAllowEmpty = false;
            this.txtRemindInfoTemplate.Location = new System.Drawing.Point(66, 228);
            this.txtRemindInfoTemplate.Name = "txtRemindInfoTemplate";
            this.txtRemindInfoTemplate.Size = new System.Drawing.Size(185, 23);
            this.txtRemindInfoTemplate.TabIndex = 3;
            this.txtRemindInfoTemplate.Visible = false;
            this.txtRemindInfoTemplate.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(70, 72);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(331, 23);
            this.txtRemark.TabIndex = 2;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(321, 45);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(80, 17);
            this.xLabel1.TabIndex = 101;
            this.xLabel1.Text = "天前开始提醒";
            // 
            // frmRemindConfigEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(413, 146);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtConfigType);
            this.Controls.Add(this.nebRemindDays);
            this.Controls.Add(this.txtRemindInfoTemplate);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblConfigType);
            this.Controls.Add(this.lblRemindDays);
            this.Controls.Add(this.lblRemindInfoTemplate);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmRemindConfigEdit";
            this.Text = "提醒设置";
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblRemindInfoTemplate, 0);
            this.Controls.SetChildIndex(this.lblRemindDays, 0);
            this.Controls.SetChildIndex(this.lblConfigType, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtRemindInfoTemplate, 0);
            this.Controls.SetChildIndex(this.nebRemindDays, 0);
            this.Controls.SetChildIndex(this.txtConfigType, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblConfigType;
        private MMIS.Component.XLabel lblRemindDays;
        private MMIS.Component.XLabel lblRemindInfoTemplate;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtConfigType;
        private MMIS.Component.XNumberEditBox nebRemindDays;
        private MMIS.Component.XEditBox txtRemindInfoTemplate;
        private MMIS.Component.XEditBox txtRemark;
        private Component.XLabel xLabel1;
        
    }
}