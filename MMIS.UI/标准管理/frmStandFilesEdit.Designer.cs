namespace MMIS.UI
{
    public partial class frmStandFilesEdit
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
            this.lblMainId = new MMIS.Component.XLabel();
            this.lblFileName = new MMIS.Component.XLabel();
            this.lblFileNo = new MMIS.Component.XLabel();
            this.lblFileDesc = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtFileName = new MMIS.Component.XEditBox();
            this.txtFileNo = new MMIS.Component.XEditBox();
            this.txtFileDesc = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.txtFilePath = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.chkIsMaxVersion = new MMIS.Component.XCheckBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.dtNextCheckDate = new MMIS.Component.XDateTimePicker();
            this.chkIsNeedCheck = new MMIS.Component.XCheckBox();
            this.txtMainId = new MMIS.UI.XSelectStanderEditBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(346, 250);
            this.btnOk.Size = new System.Drawing.Size(83, 27);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(433, 250);
            this.btnCancel.Size = new System.Drawing.Size(83, 27);
            // 
            // lblMainId
            // 
            this.lblMainId.AutoSize = true;
            this.lblMainId.ForeColor = System.Drawing.Color.Black;
            this.lblMainId.Location = new System.Drawing.Point(12, 14);
            this.lblMainId.Name = "lblMainId";
            this.lblMainId.Size = new System.Drawing.Size(56, 17);
            this.lblMainId.TabIndex = 1;
            this.lblMainId.Text = "标准名称";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(12, 74);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(56, 17);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "文件名称";
            // 
            // lblFileNo
            // 
            this.lblFileNo.AutoSize = true;
            this.lblFileNo.ForeColor = System.Drawing.Color.Black;
            this.lblFileNo.Location = new System.Drawing.Point(269, 74);
            this.lblFileNo.Name = "lblFileNo";
            this.lblFileNo.Size = new System.Drawing.Size(56, 17);
            this.lblFileNo.TabIndex = 3;
            this.lblFileNo.Text = "文件编号";
            // 
            // lblFileDesc
            // 
            this.lblFileDesc.AutoSize = true;
            this.lblFileDesc.ForeColor = System.Drawing.Color.Black;
            this.lblFileDesc.Location = new System.Drawing.Point(12, 103);
            this.lblFileDesc.Name = "lblFileDesc";
            this.lblFileDesc.Size = new System.Drawing.Size(56, 17);
            this.lblFileDesc.TabIndex = 4;
            this.lblFileDesc.Text = "文件描述";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(12, 219);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 5;
            this.lblRemark.Text = "备注信息";
            // 
            // txtFileName
            // 
            this.txtFileName.IsAllowEmpty = false;
            this.txtFileName.Location = new System.Drawing.Point(74, 71);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(185, 23);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileNo
            // 
            this.txtFileNo.IsAllowEmpty = false;
            this.txtFileNo.Location = new System.Drawing.Point(331, 71);
            this.txtFileNo.Name = "txtFileNo";
            this.txtFileNo.Size = new System.Drawing.Size(185, 23);
            this.txtFileNo.TabIndex = 3;
            this.txtFileNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileDesc
            // 
            this.txtFileDesc.IsAllowEmpty = true;
            this.txtFileDesc.Location = new System.Drawing.Point(74, 100);
            this.txtFileDesc.Multiline = true;
            this.txtFileDesc.Name = "txtFileDesc";
            this.txtFileDesc.Size = new System.Drawing.Size(442, 74);
            this.txtFileDesc.TabIndex = 4;
            this.txtFileDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(74, 216);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(442, 23);
            this.txtRemark.TabIndex = 5;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFilePath
            // 
            this.txtFilePath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFilePath.IsAllowEmpty = true;
            this.txtFilePath.Location = new System.Drawing.Point(74, 42);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(442, 23);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFilePath.ButtonClick += new System.EventHandler(this.txtFilePath_ButtonClick);
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            this.txtFilePath.DoubleClick += new System.EventHandler(this.txtFilePath_DoubleClick);
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(12, 45);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 104;
            this.xLabel1.Text = "文件附件";
            // 
            // chkIsMaxVersion
            // 
            this.chkIsMaxVersion.Location = new System.Drawing.Point(12, 252);
            this.chkIsMaxVersion.Model = null;
            this.chkIsMaxVersion.Name = "chkIsMaxVersion";
            this.chkIsMaxVersion.Size = new System.Drawing.Size(76, 23);
            this.chkIsMaxVersion.TabIndex = 105;
            this.chkIsMaxVersion.Text = "最新版本";
            this.chkIsMaxVersion.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(121, 187);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(80, 17);
            this.xLabel2.TabIndex = 106;
            this.xLabel2.Text = "下次送检时间";
            // 
            // dtNextCheckDate
            // 
            // 
            // 
            // 
            this.dtNextCheckDate.DropDownCalendar.Name = "";
            this.dtNextCheckDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtNextCheckDate.Location = new System.Drawing.Point(207, 185);
            this.dtNextCheckDate.Name = "dtNextCheckDate";
            this.dtNextCheckDate.Size = new System.Drawing.Size(309, 23);
            this.dtNextCheckDate.TabIndex = 107;
            this.dtNextCheckDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // chkIsNeedCheck
            // 
            this.chkIsNeedCheck.Checked = true;
            this.chkIsNeedCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsNeedCheck.Location = new System.Drawing.Point(15, 184);
            this.chkIsNeedCheck.Model = null;
            this.chkIsNeedCheck.Name = "chkIsNeedCheck";
            this.chkIsNeedCheck.Size = new System.Drawing.Size(100, 23);
            this.chkIsNeedCheck.TabIndex = 108;
            this.chkIsNeedCheck.Text = "是否需要送检";
            this.chkIsNeedCheck.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtMainId
            // 
            this.txtMainId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtMainId.DisplayMember = "";
            this.txtMainId.IsAllowEmpty = false;
            this.txtMainId.Location = new System.Drawing.Point(74, 12);
            this.txtMainId.Name = "txtMainId";
            this.txtMainId.QueryCheckBox = null;
            this.txtMainId.QueryFieldName = null;
            this.txtMainId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtMainId.ReadOnly = true;
            this.txtMainId.SelectedModel = null;
            this.txtMainId.Size = new System.Drawing.Size(442, 23);
            this.txtMainId.TabIndex = 0;
            this.txtMainId.ValueMember = "";
            this.txtMainId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmStandFilesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(531, 289);
            this.Controls.Add(this.chkIsNeedCheck);
            this.Controls.Add(this.dtNextCheckDate);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.chkIsMaxVersion);
            this.Controls.Add(this.txtMainId);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtFileNo);
            this.Controls.Add(this.txtFileDesc);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblMainId);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblFileNo);
            this.Controls.Add(this.lblFileDesc);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmStandFilesEdit";
            this.Text = "标准文件集";
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblFileDesc, 0);
            this.Controls.SetChildIndex(this.lblFileNo, 0);
            this.Controls.SetChildIndex(this.lblFileName, 0);
            this.Controls.SetChildIndex(this.lblMainId, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtFileDesc, 0);
            this.Controls.SetChildIndex(this.txtFileNo, 0);
            this.Controls.SetChildIndex(this.txtFileName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtFilePath, 0);
            this.Controls.SetChildIndex(this.txtMainId, 0);
            this.Controls.SetChildIndex(this.chkIsMaxVersion, 0);
            this.Controls.SetChildIndex(this.xLabel2, 0);
            this.Controls.SetChildIndex(this.dtNextCheckDate, 0);
            this.Controls.SetChildIndex(this.chkIsNeedCheck, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Component.XLabel lblMainId;
        protected Component.XLabel lblFileName;
        protected Component.XLabel lblFileNo;
        protected Component.XLabel lblFileDesc;
        protected Component.XLabel lblRemark;
        protected Component.XEditBox txtFileName;
        protected Component.XEditBox txtFileNo;
        protected Component.XEditBox txtFileDesc;
        protected Component.XEditBox txtRemark;
        protected Component.XEditBox txtFilePath;
        protected Component.XLabel xLabel1;
        protected XSelectStanderEditBox txtMainId;
        protected Component.XCheckBox chkIsMaxVersion;
        protected Component.XLabel xLabel2;
        private Component.XDateTimePicker dtNextCheckDate;
        protected Component.XCheckBox chkIsNeedCheck;


    }
}