namespace MMIS.UI
{
    public partial class frmStandFilesCheckRecordEdit
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
            this.lblStandFileId = new MMIS.Component.XLabel();
            this.lblCheckUserName = new MMIS.Component.XLabel();
            this.lblCheckDesc = new MMIS.Component.XLabel();
            this.lblCheckDate = new MMIS.Component.XLabel();
            this.lblNextCheckDate = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtCheckUserName = new MMIS.Component.XEditBox();
            this.txtCheckDesc = new MMIS.Component.XEditBox();
            this.dtCheckDate = new MMIS.Component.XDateTimePicker();
            this.dtNextCheckDate = new MMIS.Component.XDateTimePicker();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.txtStandFileId = new MMIS.UI.XSelectStandFilesEditBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(355, 250);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 250);
            // 
            // lblStandFileId
            // 
            this.lblStandFileId.AutoSize = true;
            this.lblStandFileId.ForeColor = System.Drawing.Color.Black;
            this.lblStandFileId.Location = new System.Drawing.Point(14, 14);
            this.lblStandFileId.Name = "lblStandFileId";
            this.lblStandFileId.Size = new System.Drawing.Size(56, 17);
            this.lblStandFileId.TabIndex = 1;
            this.lblStandFileId.Text = "文件名称";
            // 
            // lblCheckUserName
            // 
            this.lblCheckUserName.AutoSize = true;
            this.lblCheckUserName.ForeColor = System.Drawing.Color.Black;
            this.lblCheckUserName.Location = new System.Drawing.Point(14, 46);
            this.lblCheckUserName.Name = "lblCheckUserName";
            this.lblCheckUserName.Size = new System.Drawing.Size(44, 17);
            this.lblCheckUserName.TabIndex = 2;
            this.lblCheckUserName.Text = "检定人";
            // 
            // lblCheckDesc
            // 
            this.lblCheckDesc.AutoSize = true;
            this.lblCheckDesc.ForeColor = System.Drawing.Color.Black;
            this.lblCheckDesc.Location = new System.Drawing.Point(14, 107);
            this.lblCheckDesc.Name = "lblCheckDesc";
            this.lblCheckDesc.Size = new System.Drawing.Size(56, 17);
            this.lblCheckDesc.TabIndex = 3;
            this.lblCheckDesc.Text = "检定描述";
            // 
            // lblCheckDate
            // 
            this.lblCheckDate.AutoSize = true;
            this.lblCheckDate.ForeColor = System.Drawing.Color.Black;
            this.lblCheckDate.Location = new System.Drawing.Point(270, 46);
            this.lblCheckDate.Name = "lblCheckDate";
            this.lblCheckDate.Size = new System.Drawing.Size(56, 17);
            this.lblCheckDate.TabIndex = 4;
            this.lblCheckDate.Text = "检定日期";
            // 
            // lblNextCheckDate
            // 
            this.lblNextCheckDate.AutoSize = true;
            this.lblNextCheckDate.ForeColor = System.Drawing.Color.Black;
            this.lblNextCheckDate.Location = new System.Drawing.Point(14, 76);
            this.lblNextCheckDate.Name = "lblNextCheckDate";
            this.lblNextCheckDate.Size = new System.Drawing.Size(80, 17);
            this.lblNextCheckDate.TabIndex = 5;
            this.lblNextCheckDate.Text = "下次送检时间";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(14, 175);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 6;
            this.lblRemark.Text = "备注信息";
            // 
            // txtCheckUserName
            // 
            this.txtCheckUserName.IsAllowEmpty = true;
            this.txtCheckUserName.Location = new System.Drawing.Point(76, 43);
            this.txtCheckUserName.Name = "txtCheckUserName";
            this.txtCheckUserName.Size = new System.Drawing.Size(185, 23);
            this.txtCheckUserName.TabIndex = 1;
            this.txtCheckUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCheckDesc
            // 
            this.txtCheckDesc.IsAllowEmpty = true;
            this.txtCheckDesc.Location = new System.Drawing.Point(76, 104);
            this.txtCheckDesc.Multiline = true;
            this.txtCheckDesc.Name = "txtCheckDesc";
            this.txtCheckDesc.Size = new System.Drawing.Size(441, 62);
            this.txtCheckDesc.TabIndex = 4;
            this.txtCheckDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtCheckDate
            // 
            this.dtCheckDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtCheckDate.DropDownCalendar.Name = "";
            this.dtCheckDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtCheckDate.Location = new System.Drawing.Point(332, 43);
            this.dtCheckDate.Name = "dtCheckDate";
            this.dtCheckDate.Size = new System.Drawing.Size(185, 23);
            this.dtCheckDate.TabIndex = 2;
            this.dtCheckDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtNextCheckDate
            // 
            this.dtNextCheckDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtNextCheckDate.DropDownCalendar.Name = "";
            this.dtNextCheckDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtNextCheckDate.Location = new System.Drawing.Point(98, 73);
            this.dtNextCheckDate.Name = "dtNextCheckDate";
            this.dtNextCheckDate.Size = new System.Drawing.Size(419, 23);
            this.dtNextCheckDate.TabIndex = 3;
            this.dtNextCheckDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(76, 174);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(441, 67);
            this.txtRemark.TabIndex = 5;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtStandFileId
            // 
            this.txtStandFileId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtStandFileId.DisplayMember = "";
            this.txtStandFileId.IsAllowEmpty = false;
            this.txtStandFileId.Location = new System.Drawing.Point(76, 12);
            this.txtStandFileId.Name = "txtStandFileId";
            this.txtStandFileId.QueryCheckBox = null;
            this.txtStandFileId.QueryFieldName = null;
            this.txtStandFileId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtStandFileId.ReadOnly = true;
            this.txtStandFileId.SelectedModel = null;
            this.txtStandFileId.Size = new System.Drawing.Size(441, 23);
            this.txtStandFileId.TabIndex = 0;
            this.txtStandFileId.ValueMember = "";
            this.txtStandFileId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmStandFilesCheckRecordEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(529, 289);
            this.Controls.Add(this.txtStandFileId);
            this.Controls.Add(this.txtCheckUserName);
            this.Controls.Add(this.txtCheckDesc);
            this.Controls.Add(this.dtCheckDate);
            this.Controls.Add(this.dtNextCheckDate);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblStandFileId);
            this.Controls.Add(this.lblCheckUserName);
            this.Controls.Add(this.lblCheckDesc);
            this.Controls.Add(this.lblCheckDate);
            this.Controls.Add(this.lblNextCheckDate);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmStandFilesCheckRecordEdit";
            this.Text = "标准文件集送检";
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblNextCheckDate, 0);
            this.Controls.SetChildIndex(this.lblCheckDate, 0);
            this.Controls.SetChildIndex(this.lblCheckDesc, 0);
            this.Controls.SetChildIndex(this.lblCheckUserName, 0);
            this.Controls.SetChildIndex(this.lblStandFileId, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.dtNextCheckDate, 0);
            this.Controls.SetChildIndex(this.dtCheckDate, 0);
            this.Controls.SetChildIndex(this.txtCheckDesc, 0);
            this.Controls.SetChildIndex(this.txtCheckUserName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtStandFileId, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblStandFileId;
        private MMIS.Component.XLabel lblCheckUserName;
        private MMIS.Component.XLabel lblCheckDesc;
        private MMIS.Component.XLabel lblCheckDate;
        private MMIS.Component.XLabel lblNextCheckDate;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtCheckUserName;
        private MMIS.Component.XEditBox txtCheckDesc;
        private MMIS.Component.XDateTimePicker dtCheckDate;
        private MMIS.Component.XDateTimePicker dtNextCheckDate;
        private MMIS.Component.XEditBox txtRemark;
        private XSelectStandFilesEditBox txtStandFileId;
        
    }
}