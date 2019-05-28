namespace MMIS.UI
{
    public partial class frmStaffCertificateEdit
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
            this.lblUserId = new MMIS.Component.XLabel();
            this.lblCertName = new MMIS.Component.XLabel();
            this.lblCertNo = new MMIS.Component.XLabel();
            this.lblCertGetTime = new MMIS.Component.XLabel();
            this.lblCertItem = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtCertName = new MMIS.Component.XEditBox();
            this.txtCertNo = new MMIS.Component.XEditBox();
            this.dtCertGetTime = new MMIS.Component.XDateTimePicker();
            this.txtCertItem = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.txtUserId = new MMIS.UI.XSelectStaffInfoEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.txtFilePath = new MMIS.Component.XEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.dtRegisterDate = new MMIS.Component.XDateTimePicker();
            this.dtNextRegisterDate = new MMIS.Component.XDateTimePicker();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.btnPreviewCert = new MMIS.Component.XButton();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(352, 305);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(439, 305);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.ForeColor = System.Drawing.Color.Black;
            this.lblUserId.Location = new System.Drawing.Point(12, 13);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(56, 17);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "人员姓名";
            // 
            // lblCertName
            // 
            this.lblCertName.AutoSize = true;
            this.lblCertName.ForeColor = System.Drawing.Color.Black;
            this.lblCertName.Location = new System.Drawing.Point(267, 14);
            this.lblCertName.Name = "lblCertName";
            this.lblCertName.Size = new System.Drawing.Size(56, 17);
            this.lblCertName.TabIndex = 2;
            this.lblCertName.Text = "证书名称";
            // 
            // lblCertNo
            // 
            this.lblCertNo.AutoSize = true;
            this.lblCertNo.ForeColor = System.Drawing.Color.Black;
            this.lblCertNo.Location = new System.Drawing.Point(12, 45);
            this.lblCertNo.Name = "lblCertNo";
            this.lblCertNo.Size = new System.Drawing.Size(56, 17);
            this.lblCertNo.TabIndex = 3;
            this.lblCertNo.Text = "证书编号";
            // 
            // lblCertGetTime
            // 
            this.lblCertGetTime.AutoSize = true;
            this.lblCertGetTime.ForeColor = System.Drawing.Color.Black;
            this.lblCertGetTime.Location = new System.Drawing.Point(267, 45);
            this.lblCertGetTime.Name = "lblCertGetTime";
            this.lblCertGetTime.Size = new System.Drawing.Size(56, 17);
            this.lblCertGetTime.TabIndex = 4;
            this.lblCertGetTime.Text = "获得时间";
            // 
            // lblCertItem
            // 
            this.lblCertItem.AutoSize = true;
            this.lblCertItem.ForeColor = System.Drawing.Color.Black;
            this.lblCertItem.Location = new System.Drawing.Point(12, 131);
            this.lblCertItem.Name = "lblCertItem";
            this.lblCertItem.Size = new System.Drawing.Size(80, 17);
            this.lblCertItem.TabIndex = 5;
            this.lblCertItem.Text = "检定项目描述";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(12, 222);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 6;
            this.lblRemark.Text = "备注信息";
            this.lblRemark.Click += new System.EventHandler(this.lblRemark_Click);
            // 
            // txtCertName
            // 
            this.txtCertName.IsAllowEmpty = false;
            this.txtCertName.Location = new System.Drawing.Point(329, 11);
            this.txtCertName.Name = "txtCertName";
            this.txtCertName.Size = new System.Drawing.Size(185, 23);
            this.txtCertName.TabIndex = 1;
            this.txtCertName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCertNo
            // 
            this.txtCertNo.IsAllowEmpty = true;
            this.txtCertNo.Location = new System.Drawing.Point(74, 42);
            this.txtCertNo.Name = "txtCertNo";
            this.txtCertNo.Size = new System.Drawing.Size(185, 23);
            this.txtCertNo.TabIndex = 2;
            this.txtCertNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtCertGetTime
            // 
            this.dtCertGetTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtCertGetTime.DropDownCalendar.Name = "";
            this.dtCertGetTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtCertGetTime.Location = new System.Drawing.Point(329, 42);
            this.dtCertGetTime.Name = "dtCertGetTime";
            this.dtCertGetTime.Size = new System.Drawing.Size(185, 23);
            this.dtCertGetTime.TabIndex = 3;
            this.dtCertGetTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtCertItem
            // 
            this.txtCertItem.IsAllowEmpty = true;
            this.txtCertItem.Location = new System.Drawing.Point(12, 154);
            this.txtCertItem.Multiline = true;
            this.txtCertItem.Name = "txtCertItem";
            this.txtCertItem.Size = new System.Drawing.Size(502, 56);
            this.txtCertItem.TabIndex = 4;
            this.txtCertItem.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(12, 242);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(502, 55);
            this.txtRemark.TabIndex = 5;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtRemark.TextChanged += new System.EventHandler(this.txtRemark_TextChanged);
            // 
            // txtUserId
            // 
            this.txtUserId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtUserId.DisplayMember = "";
            this.txtUserId.IsAllowEmpty = false;
            this.txtUserId.Location = new System.Drawing.Point(74, 11);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.QueryCheckBox = null;
            this.txtUserId.QueryFieldName = null;
            this.txtUserId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtUserId.ReadOnly = true;
            this.txtUserId.SelectedModel = null;
            this.txtUserId.Size = new System.Drawing.Size(185, 23);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.ValueMember = "";
            this.txtUserId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(12, 75);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 101;
            this.xLabel1.Text = "电子证书";
            // 
            // txtFilePath
            // 
            this.txtFilePath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFilePath.IsAllowEmpty = true;
            this.txtFilePath.Location = new System.Drawing.Point(74, 73);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(440, 23);
            this.txtFilePath.TabIndex = 102;
            this.txtFilePath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFilePath.ButtonClick += new System.EventHandler(this.txtFilePath_ButtonClick);
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            this.txtFilePath.DoubleClick += new System.EventHandler(this.txtFilePath_DoubleClick);
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(12, 106);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 103;
            this.xLabel2.Text = "注册时间";
            // 
            // dtRegisterDate
            // 
            this.dtRegisterDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtRegisterDate.DropDownCalendar.Name = "";
            this.dtRegisterDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtRegisterDate.Location = new System.Drawing.Point(74, 104);
            this.dtRegisterDate.Name = "dtRegisterDate";
            this.dtRegisterDate.Size = new System.Drawing.Size(159, 23);
            this.dtRegisterDate.TabIndex = 104;
            this.dtRegisterDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtNextRegisterDate
            // 
            this.dtNextRegisterDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtNextRegisterDate.DropDownCalendar.Name = "";
            this.dtNextRegisterDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtNextRegisterDate.Location = new System.Drawing.Point(329, 104);
            this.dtNextRegisterDate.Name = "dtNextRegisterDate";
            this.dtNextRegisterDate.Size = new System.Drawing.Size(185, 23);
            this.dtNextRegisterDate.TabIndex = 106;
            this.dtNextRegisterDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(243, 106);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(80, 17);
            this.xLabel3.TabIndex = 105;
            this.xLabel3.Text = "下次注册时间";
            // 
            // btnPreviewCert
            // 
            this.btnPreviewCert.Enabled = false;
            this.btnPreviewCert.Location = new System.Drawing.Point(12, 303);
            this.btnPreviewCert.Name = "btnPreviewCert";
            this.btnPreviewCert.Size = new System.Drawing.Size(80, 29);
            this.btnPreviewCert.TabIndex = 107;
            this.btnPreviewCert.Text = "预览证书";
            this.btnPreviewCert.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPreviewCert.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // frmStaffCertificateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(526, 344);
            this.Controls.Add(this.btnPreviewCert);
            this.Controls.Add(this.dtNextRegisterDate);
            this.Controls.Add(this.xLabel3);
            this.Controls.Add(this.dtRegisterDate);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtCertName);
            this.Controls.Add(this.txtCertNo);
            this.Controls.Add(this.dtCertGetTime);
            this.Controls.Add(this.txtCertItem);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblCertName);
            this.Controls.Add(this.lblCertNo);
            this.Controls.Add(this.lblCertGetTime);
            this.Controls.Add(this.lblCertItem);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmStaffCertificateEdit";
            this.Text = "人员资质证书";
            this.Load += new System.EventHandler(this.frmStaffCertificateEdit_Load);
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblCertItem, 0);
            this.Controls.SetChildIndex(this.lblCertGetTime, 0);
            this.Controls.SetChildIndex(this.lblCertNo, 0);
            this.Controls.SetChildIndex(this.lblCertName, 0);
            this.Controls.SetChildIndex(this.lblUserId, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtCertItem, 0);
            this.Controls.SetChildIndex(this.dtCertGetTime, 0);
            this.Controls.SetChildIndex(this.txtCertNo, 0);
            this.Controls.SetChildIndex(this.txtCertName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtUserId, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtFilePath, 0);
            this.Controls.SetChildIndex(this.xLabel2, 0);
            this.Controls.SetChildIndex(this.dtRegisterDate, 0);
            this.Controls.SetChildIndex(this.xLabel3, 0);
            this.Controls.SetChildIndex(this.dtNextRegisterDate, 0);
            this.Controls.SetChildIndex(this.btnPreviewCert, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblUserId;
        private MMIS.Component.XLabel lblCertName;
        private MMIS.Component.XLabel lblCertNo;
        private MMIS.Component.XLabel lblCertGetTime;
        private MMIS.Component.XLabel lblCertItem;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtCertName;
        private MMIS.Component.XEditBox txtCertNo;
        private MMIS.Component.XDateTimePicker dtCertGetTime;
        private MMIS.Component.XEditBox txtCertItem;
        private MMIS.Component.XEditBox txtRemark;
        private XSelectStaffInfoEditBox txtUserId;
        private Component.XLabel xLabel1;
        private Component.XEditBox txtFilePath;
        private Component.XLabel xLabel2;
        private Component.XDateTimePicker dtRegisterDate;
        private Component.XDateTimePicker dtNextRegisterDate;
        private Component.XLabel xLabel3;
        private Component.XButton btnPreviewCert;
        
    }
}