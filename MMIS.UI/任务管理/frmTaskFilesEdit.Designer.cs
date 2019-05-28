namespace MMIS.UI
{
    public partial class frmTaskFilesEdit
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
            this.txtMainId = new MMIS.Component.XEditBox();
            this.xGroupBox1 = new MMIS.Component.XGroupBox();
            this.dtStartDate = new MMIS.Component.XDateTimePicker();
            this.dtPreEndDate = new MMIS.Component.XDateTimePicker();
            this.lblStartDate = new MMIS.Component.XLabel();
            this.lblPreEndDate = new MMIS.Component.XLabel();
            this.txtTaskNo = new MMIS.Component.XEditBox();
            this.lblTaskNo = new MMIS.Component.XLabel();
            this.xGroupBox2 = new MMIS.Component.XGroupBox();
            this.dtChildTaskStartDate = new MMIS.Component.XDateTimePicker();
            this.dtChildTaskPreEnd = new MMIS.Component.XDateTimePicker();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtChildTaskNo = new MMIS.Component.XEditBox();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.txtChildTaskName = new MMIS.Component.XEditBox();
            this.xLabel4 = new MMIS.Component.XLabel();
            this.xGroupBox3 = new MMIS.Component.XGroupBox();
            this.txtFilePath = new MMIS.Component.XEditBox();
            this.xLabel5 = new MMIS.Component.XLabel();
            this.txtFileName = new MMIS.Component.XEditBox();
            this.txtFileDesc = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.lblFileName = new MMIS.Component.XLabel();
            this.lblFileDesc = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).BeginInit();
            this.xGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).BeginInit();
            this.xGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox3)).BeginInit();
            this.xGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(483, 387);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(570, 387);
            // 
            // lblMainId
            // 
            this.lblMainId.AutoSize = true;
            this.lblMainId.ForeColor = System.Drawing.Color.Black;
            this.lblMainId.Location = new System.Drawing.Point(9, 20);
            this.lblMainId.Name = "lblMainId";
            this.lblMainId.Size = new System.Drawing.Size(56, 17);
            this.lblMainId.TabIndex = 1;
            this.lblMainId.Text = "任务名称";
            // 
            // txtMainId
            // 
            this.txtMainId.IsAllowEmpty = true;
            this.txtMainId.Location = new System.Drawing.Point(71, 17);
            this.txtMainId.Name = "txtMainId";
            this.txtMainId.ReadOnly = true;
            this.txtMainId.Size = new System.Drawing.Size(275, 23);
            this.txtMainId.TabIndex = 1;
            this.txtMainId.TabStop = false;
            this.txtMainId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xGroupBox1
            // 
            this.xGroupBox1.Controls.Add(this.dtStartDate);
            this.xGroupBox1.Controls.Add(this.dtPreEndDate);
            this.xGroupBox1.Controls.Add(this.lblStartDate);
            this.xGroupBox1.Controls.Add(this.lblPreEndDate);
            this.xGroupBox1.Controls.Add(this.txtTaskNo);
            this.xGroupBox1.Controls.Add(this.lblTaskNo);
            this.xGroupBox1.Controls.Add(this.txtMainId);
            this.xGroupBox1.Controls.Add(this.lblMainId);
            this.xGroupBox1.Location = new System.Drawing.Point(8, 7);
            this.xGroupBox1.Name = "xGroupBox1";
            this.xGroupBox1.Size = new System.Drawing.Size(640, 80);
            this.xGroupBox1.TabIndex = 0;
            this.xGroupBox1.Text = "任务信息";
            this.xGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtStartDate.DropDownCalendar.Name = "";
            this.dtStartDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtStartDate.Location = new System.Drawing.Point(71, 48);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.ReadOnly = true;
            this.dtStartDate.Size = new System.Drawing.Size(275, 23);
            this.dtStartDate.TabIndex = 40;
            this.dtStartDate.TabStop = false;
            this.dtStartDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtPreEndDate
            // 
            this.dtPreEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPreEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtPreEndDate.DropDownCalendar.Name = "";
            this.dtPreEndDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtPreEndDate.Location = new System.Drawing.Point(438, 48);
            this.dtPreEndDate.Name = "dtPreEndDate";
            this.dtPreEndDate.ReadOnly = true;
            this.dtPreEndDate.Size = new System.Drawing.Size(191, 23);
            this.dtPreEndDate.TabIndex = 42;
            this.dtPreEndDate.TabStop = false;
            this.dtPreEndDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(9, 51);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(56, 17);
            this.lblStartDate.TabIndex = 41;
            this.lblStartDate.Text = "起始日期";
            // 
            // lblPreEndDate
            // 
            this.lblPreEndDate.AutoSize = true;
            this.lblPreEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblPreEndDate.Location = new System.Drawing.Point(352, 51);
            this.lblPreEndDate.Name = "lblPreEndDate";
            this.lblPreEndDate.Size = new System.Drawing.Size(80, 17);
            this.lblPreEndDate.TabIndex = 43;
            this.lblPreEndDate.Text = "预计完成日期";
            // 
            // txtTaskNo
            // 
            this.txtTaskNo.IsAllowEmpty = true;
            this.txtTaskNo.Location = new System.Drawing.Point(438, 17);
            this.txtTaskNo.Name = "txtTaskNo";
            this.txtTaskNo.ReadOnly = true;
            this.txtTaskNo.Size = new System.Drawing.Size(191, 23);
            this.txtTaskNo.TabIndex = 32;
            this.txtTaskNo.TabStop = false;
            this.txtTaskNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblTaskNo
            // 
            this.lblTaskNo.AutoSize = true;
            this.lblTaskNo.ForeColor = System.Drawing.Color.Black;
            this.lblTaskNo.Location = new System.Drawing.Point(376, 20);
            this.lblTaskNo.Name = "lblTaskNo";
            this.lblTaskNo.Size = new System.Drawing.Size(56, 17);
            this.lblTaskNo.TabIndex = 33;
            this.lblTaskNo.Text = "任务编号";
            // 
            // xGroupBox2
            // 
            this.xGroupBox2.Controls.Add(this.dtChildTaskStartDate);
            this.xGroupBox2.Controls.Add(this.dtChildTaskPreEnd);
            this.xGroupBox2.Controls.Add(this.xLabel1);
            this.xGroupBox2.Controls.Add(this.xLabel2);
            this.xGroupBox2.Controls.Add(this.txtChildTaskNo);
            this.xGroupBox2.Controls.Add(this.xLabel3);
            this.xGroupBox2.Controls.Add(this.txtChildTaskName);
            this.xGroupBox2.Controls.Add(this.xLabel4);
            this.xGroupBox2.Location = new System.Drawing.Point(8, 91);
            this.xGroupBox2.Name = "xGroupBox2";
            this.xGroupBox2.Size = new System.Drawing.Size(640, 82);
            this.xGroupBox2.TabIndex = 1;
            this.xGroupBox2.Text = "子任务信息";
            this.xGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // dtChildTaskStartDate
            // 
            this.dtChildTaskStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtChildTaskStartDate.DropDownCalendar.Name = "";
            this.dtChildTaskStartDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtChildTaskStartDate.Location = new System.Drawing.Point(71, 51);
            this.dtChildTaskStartDate.Name = "dtChildTaskStartDate";
            this.dtChildTaskStartDate.ReadOnly = true;
            this.dtChildTaskStartDate.Size = new System.Drawing.Size(275, 23);
            this.dtChildTaskStartDate.TabIndex = 40;
            this.dtChildTaskStartDate.TabStop = false;
            this.dtChildTaskStartDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtChildTaskPreEnd
            // 
            this.dtChildTaskPreEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtChildTaskPreEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtChildTaskPreEnd.DropDownCalendar.Name = "";
            this.dtChildTaskPreEnd.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtChildTaskPreEnd.Location = new System.Drawing.Point(438, 51);
            this.dtChildTaskPreEnd.Name = "dtChildTaskPreEnd";
            this.dtChildTaskPreEnd.ReadOnly = true;
            this.dtChildTaskPreEnd.Size = new System.Drawing.Size(191, 23);
            this.dtChildTaskPreEnd.TabIndex = 42;
            this.dtChildTaskPreEnd.TabStop = false;
            this.dtChildTaskPreEnd.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(9, 54);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 41;
            this.xLabel1.Text = "起始日期";
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(352, 54);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(80, 17);
            this.xLabel2.TabIndex = 43;
            this.xLabel2.Text = "预计完成日期";
            // 
            // txtChildTaskNo
            // 
            this.txtChildTaskNo.IsAllowEmpty = true;
            this.txtChildTaskNo.Location = new System.Drawing.Point(438, 20);
            this.txtChildTaskNo.Name = "txtChildTaskNo";
            this.txtChildTaskNo.ReadOnly = true;
            this.txtChildTaskNo.Size = new System.Drawing.Size(191, 23);
            this.txtChildTaskNo.TabIndex = 32;
            this.txtChildTaskNo.TabStop = false;
            this.txtChildTaskNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(376, 23);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 33;
            this.xLabel3.Text = "任务编号";
            // 
            // txtChildTaskName
            // 
            this.txtChildTaskName.IsAllowEmpty = true;
            this.txtChildTaskName.Location = new System.Drawing.Point(71, 20);
            this.txtChildTaskName.Name = "txtChildTaskName";
            this.txtChildTaskName.ReadOnly = true;
            this.txtChildTaskName.Size = new System.Drawing.Size(275, 23);
            this.txtChildTaskName.TabIndex = 1;
            this.txtChildTaskName.TabStop = false;
            this.txtChildTaskName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel4
            // 
            this.xLabel4.AutoSize = true;
            this.xLabel4.ForeColor = System.Drawing.Color.Black;
            this.xLabel4.Location = new System.Drawing.Point(9, 23);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(56, 17);
            this.xLabel4.TabIndex = 1;
            this.xLabel4.Text = "任务名称";
            // 
            // xGroupBox3
            // 
            this.xGroupBox3.Controls.Add(this.txtFilePath);
            this.xGroupBox3.Controls.Add(this.xLabel5);
            this.xGroupBox3.Controls.Add(this.txtFileName);
            this.xGroupBox3.Controls.Add(this.txtFileDesc);
            this.xGroupBox3.Controls.Add(this.txtRemark);
            this.xGroupBox3.Controls.Add(this.lblFileName);
            this.xGroupBox3.Controls.Add(this.lblFileDesc);
            this.xGroupBox3.Controls.Add(this.lblRemark);
            this.xGroupBox3.Location = new System.Drawing.Point(8, 179);
            this.xGroupBox3.Name = "xGroupBox3";
            this.xGroupBox3.Size = new System.Drawing.Size(640, 197);
            this.xGroupBox3.TabIndex = 2;
            this.xGroupBox3.Text = "任务文档";
            this.xGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtFilePath
            // 
            this.txtFilePath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFilePath.IsAllowEmpty = true;
            this.txtFilePath.Location = new System.Drawing.Point(71, 22);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(558, 23);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFilePath.ButtonClick += new System.EventHandler(this.txtFilePath_ButtonClick);
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            this.txtFilePath.DoubleClick += new System.EventHandler(this.txtFilePath_DoubleClick);
            // 
            // xLabel5
            // 
            this.xLabel5.AutoSize = true;
            this.xLabel5.ForeColor = System.Drawing.Color.Black;
            this.xLabel5.Location = new System.Drawing.Point(9, 24);
            this.xLabel5.Name = "xLabel5";
            this.xLabel5.Size = new System.Drawing.Size(56, 17);
            this.xLabel5.TabIndex = 111;
            this.xLabel5.Text = "任务文档";
            // 
            // txtFileName
            // 
            this.txtFileName.IsAllowEmpty = false;
            this.txtFileName.Location = new System.Drawing.Point(71, 53);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(558, 23);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileDesc
            // 
            this.txtFileDesc.IsAllowEmpty = true;
            this.txtFileDesc.Location = new System.Drawing.Point(71, 84);
            this.txtFileDesc.Multiline = true;
            this.txtFileDesc.Name = "txtFileDesc";
            this.txtFileDesc.Size = new System.Drawing.Size(558, 70);
            this.txtFileDesc.TabIndex = 2;
            this.txtFileDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(71, 163);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(558, 23);
            this.txtRemark.TabIndex = 3;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(9, 55);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(56, 17);
            this.lblFileName.TabIndex = 106;
            this.lblFileName.Text = "文档名称";
            // 
            // lblFileDesc
            // 
            this.lblFileDesc.AutoSize = true;
            this.lblFileDesc.ForeColor = System.Drawing.Color.Black;
            this.lblFileDesc.Location = new System.Drawing.Point(9, 84);
            this.lblFileDesc.Name = "lblFileDesc";
            this.lblFileDesc.Size = new System.Drawing.Size(56, 17);
            this.lblFileDesc.TabIndex = 108;
            this.lblFileDesc.Text = "文档描述";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(9, 166);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 110;
            this.lblRemark.Text = "备注信息";
            // 
            // frmTaskFilesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(657, 426);
            this.Controls.Add(this.xGroupBox3);
            this.Controls.Add(this.xGroupBox2);
            this.Controls.Add(this.xGroupBox1);
            this.Name = "frmTaskFilesEdit";
            this.Text = "任务文档";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xGroupBox1, 0);
            this.Controls.SetChildIndex(this.xGroupBox2, 0);
            this.Controls.SetChildIndex(this.xGroupBox3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).EndInit();
            this.xGroupBox1.ResumeLayout(false);
            this.xGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).EndInit();
            this.xGroupBox2.ResumeLayout(false);
            this.xGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox3)).EndInit();
            this.xGroupBox3.ResumeLayout(false);
            this.xGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MMIS.Component.XLabel lblMainId;
        private MMIS.Component.XEditBox txtMainId;
        private Component.XGroupBox xGroupBox1;
        private Component.XEditBox txtTaskNo;
        private Component.XLabel lblTaskNo;
        private Component.XDateTimePicker dtStartDate;
        private Component.XDateTimePicker dtPreEndDate;
        private Component.XLabel lblStartDate;
        private Component.XLabel lblPreEndDate;
        private Component.XGroupBox xGroupBox2;
        private Component.XDateTimePicker dtChildTaskStartDate;
        private Component.XDateTimePicker dtChildTaskPreEnd;
        private Component.XLabel xLabel1;
        private Component.XLabel xLabel2;
        private Component.XEditBox txtChildTaskNo;
        private Component.XLabel xLabel3;
        private Component.XEditBox txtChildTaskName;
        private Component.XLabel xLabel4;
        private Component.XGroupBox xGroupBox3;
        protected Component.XEditBox txtFilePath;
        private Component.XLabel xLabel5;
        private Component.XEditBox txtFileName;
        private Component.XEditBox txtFileDesc;
        private Component.XEditBox txtRemark;
        private Component.XLabel lblFileName;
        private Component.XLabel lblFileDesc;
        private Component.XLabel lblRemark;
        
    }
}