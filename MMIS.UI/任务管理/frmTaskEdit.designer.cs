namespace MMIS.UI
{
    public partial class frmTaskEdit
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
            Janus.Windows.GridEX.GridEXLayout grdFiles_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskEdit));
            this.xLabel1 = new MMIS.Component.XLabel();
            this.txtParentTask = new MMIS.Component.XEditBox();
            this.grpParent = new MMIS.Component.XGroupBox();
            this.dtParentPreEndDate = new MMIS.Component.XDateTimePicker();
            this.xLabel4 = new MMIS.Component.XLabel();
            this.dtParentStartDate = new MMIS.Component.XDateTimePicker();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.txtParentNo = new MMIS.Component.XEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.xLabel5 = new MMIS.Component.XLabel();
            this.txtTaskStatus = new MMIS.Component.XEditBox();
            this.xTabControl1 = new MMIS.Component.XTabControl();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.txtAssignPeople = new MMIS.UI.XSelectUsersEditBox();
            this.txtTaskTypeId = new MMIS.UI.XSelectCodeTaskTypeEditBox();
            this.txtShortDesc = new MMIS.Component.XEditBox();
            this.txtRequire = new MMIS.Component.XEditBox();
            this.txtContent = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.lblShortDesc = new MMIS.Component.XLabel();
            this.lblRequire = new MMIS.Component.XLabel();
            this.lblContent = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.dtStartDate = new MMIS.Component.XDateTimePicker();
            this.dtPreEndDate = new MMIS.Component.XDateTimePicker();
            this.lblAssignPeople = new MMIS.Component.XLabel();
            this.lblStartDate = new MMIS.Component.XLabel();
            this.lblPreEndDate = new MMIS.Component.XLabel();
            this.dtDispatchDate = new MMIS.Component.XDateTimePicker();
            this.lblDispatchDate = new MMIS.Component.XLabel();
            this.txtStartPeople = new MMIS.Component.XEditBox();
            this.lblStartPeople = new MMIS.Component.XLabel();
            this.txtTaskNo = new MMIS.Component.XEditBox();
            this.lblTaskNo = new MMIS.Component.XLabel();
            this.txtTaskName = new MMIS.Component.XEditBox();
            this.lblTaskName = new MMIS.Component.XLabel();
            this.lblTaskTypeId = new MMIS.Component.XLabel();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.btnDeleteFile = new MMIS.Component.XButton();
            this.btnEditFile = new MMIS.Component.XButton();
            this.btnAddNewFile = new MMIS.Component.XButton();
            this.grdFiles = new MMIS.Component.XGridEx();
            ((System.ComponentModel.ISupportInitialize)(this.grpParent)).BeginInit();
            this.grpParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xTabControl1)).BeginInit();
            this.xTabControl1.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            this.uiTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(562, 447);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(649, 447);
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(12, 23);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 125;
            this.xLabel1.Text = "任务名称";
            // 
            // txtParentTask
            // 
            this.txtParentTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentTask.IsAllowEmpty = true;
            this.txtParentTask.Location = new System.Drawing.Point(73, 21);
            this.txtParentTask.Name = "txtParentTask";
            this.txtParentTask.ReadOnly = true;
            this.txtParentTask.Size = new System.Drawing.Size(362, 23);
            this.txtParentTask.TabIndex = 126;
            this.txtParentTask.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // grpParent
            // 
            this.grpParent.Controls.Add(this.dtParentPreEndDate);
            this.grpParent.Controls.Add(this.xLabel4);
            this.grpParent.Controls.Add(this.dtParentStartDate);
            this.grpParent.Controls.Add(this.xLabel3);
            this.grpParent.Controls.Add(this.txtParentNo);
            this.grpParent.Controls.Add(this.xLabel2);
            this.grpParent.Controls.Add(this.txtParentTask);
            this.grpParent.Controls.Add(this.xLabel1);
            this.grpParent.Location = new System.Drawing.Point(8, 3);
            this.grpParent.Name = "grpParent";
            this.grpParent.Size = new System.Drawing.Size(715, 86);
            this.grpParent.TabIndex = 0;
            this.grpParent.Text = "上级任务";
            this.grpParent.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // dtParentPreEndDate
            // 
            this.dtParentPreEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtParentPreEndDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtParentPreEndDate.DropDownCalendar.Name = "";
            this.dtParentPreEndDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtParentPreEndDate.Location = new System.Drawing.Point(520, 52);
            this.dtParentPreEndDate.Name = "dtParentPreEndDate";
            this.dtParentPreEndDate.ReadOnly = true;
            this.dtParentPreEndDate.Size = new System.Drawing.Size(185, 23);
            this.dtParentPreEndDate.TabIndex = 132;
            this.dtParentPreEndDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xLabel4
            // 
            this.xLabel4.AutoSize = true;
            this.xLabel4.ForeColor = System.Drawing.Color.Black;
            this.xLabel4.Location = new System.Drawing.Point(439, 55);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(80, 17);
            this.xLabel4.TabIndex = 131;
            this.xLabel4.Text = "预计完成日期";
            // 
            // dtParentStartDate
            // 
            this.dtParentStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtParentStartDate.DropDownCalendar.Name = "";
            this.dtParentStartDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtParentStartDate.Location = new System.Drawing.Point(73, 52);
            this.dtParentStartDate.Name = "dtParentStartDate";
            this.dtParentStartDate.ReadOnly = true;
            this.dtParentStartDate.Size = new System.Drawing.Size(362, 23);
            this.dtParentStartDate.TabIndex = 129;
            this.dtParentStartDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(12, 55);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 130;
            this.xLabel3.Text = "起始日期";
            // 
            // txtParentNo
            // 
            this.txtParentNo.IsAllowEmpty = true;
            this.txtParentNo.Location = new System.Drawing.Point(520, 21);
            this.txtParentNo.Name = "txtParentNo";
            this.txtParentNo.ReadOnly = true;
            this.txtParentNo.Size = new System.Drawing.Size(185, 23);
            this.txtParentNo.TabIndex = 128;
            this.txtParentNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(463, 23);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 127;
            this.xLabel2.Text = "任务编号";
            // 
            // xLabel5
            // 
            this.xLabel5.AutoSize = true;
            this.xLabel5.ForeColor = System.Drawing.Color.Black;
            this.xLabel5.Location = new System.Drawing.Point(19, 501);
            this.xLabel5.Name = "xLabel5";
            this.xLabel5.Size = new System.Drawing.Size(56, 17);
            this.xLabel5.TabIndex = 130;
            this.xLabel5.Text = "任务状态";
            this.xLabel5.Visible = false;
            // 
            // txtTaskStatus
            // 
            this.txtTaskStatus.IsAllowEmpty = false;
            this.txtTaskStatus.Location = new System.Drawing.Point(81, 499);
            this.txtTaskStatus.Name = "txtTaskStatus";
            this.txtTaskStatus.Size = new System.Drawing.Size(100, 23);
            this.txtTaskStatus.TabIndex = 131;
            this.txtTaskStatus.Text = "开始";
            this.txtTaskStatus.Visible = false;
            this.txtTaskStatus.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xTabControl1
            // 
            this.xTabControl1.Location = new System.Drawing.Point(8, 95);
            this.xTabControl1.Name = "xTabControl1";
            this.xTabControl1.Size = new System.Drawing.Size(716, 343);
            this.xTabControl1.TabIndex = 132;
            this.xTabControl1.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
            this.xTabControl1.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007;
            // 
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.txtAssignPeople);
            this.uiTabPage1.Controls.Add(this.txtTaskTypeId);
            this.uiTabPage1.Controls.Add(this.txtShortDesc);
            this.uiTabPage1.Controls.Add(this.txtRequire);
            this.uiTabPage1.Controls.Add(this.txtContent);
            this.uiTabPage1.Controls.Add(this.txtRemark);
            this.uiTabPage1.Controls.Add(this.lblShortDesc);
            this.uiTabPage1.Controls.Add(this.lblRequire);
            this.uiTabPage1.Controls.Add(this.lblContent);
            this.uiTabPage1.Controls.Add(this.lblRemark);
            this.uiTabPage1.Controls.Add(this.dtStartDate);
            this.uiTabPage1.Controls.Add(this.dtPreEndDate);
            this.uiTabPage1.Controls.Add(this.lblAssignPeople);
            this.uiTabPage1.Controls.Add(this.lblStartDate);
            this.uiTabPage1.Controls.Add(this.lblPreEndDate);
            this.uiTabPage1.Controls.Add(this.dtDispatchDate);
            this.uiTabPage1.Controls.Add(this.lblDispatchDate);
            this.uiTabPage1.Controls.Add(this.txtStartPeople);
            this.uiTabPage1.Controls.Add(this.lblStartPeople);
            this.uiTabPage1.Controls.Add(this.txtTaskNo);
            this.uiTabPage1.Controls.Add(this.lblTaskNo);
            this.uiTabPage1.Controls.Add(this.txtTaskName);
            this.uiTabPage1.Controls.Add(this.lblTaskName);
            this.uiTabPage1.Controls.Add(this.lblTaskTypeId);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 25);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.Size = new System.Drawing.Size(714, 317);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "任务信息";
            // 
            // txtAssignPeople
            // 
            this.txtAssignPeople.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtAssignPeople.DisplayMember = "";
            this.txtAssignPeople.IsAllowEmpty = false;
            this.txtAssignPeople.Location = new System.Drawing.Point(72, 61);
            this.txtAssignPeople.Name = "txtAssignPeople";
            this.txtAssignPeople.QueryCheckBox = null;
            this.txtAssignPeople.QueryFieldName = null;
            this.txtAssignPeople.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtAssignPeople.ReadOnly = true;
            this.txtAssignPeople.SelectedModel = null;
            this.txtAssignPeople.Size = new System.Drawing.Size(185, 23);
            this.txtAssignPeople.TabIndex = 156;
            this.txtAssignPeople.ValueMember = "";
            this.txtAssignPeople.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtTaskTypeId
            // 
            this.txtTaskTypeId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtTaskTypeId.DisplayMember = "";
            this.txtTaskTypeId.IsAllowEmpty = false;
            this.txtTaskTypeId.Location = new System.Drawing.Point(72, 6);
            this.txtTaskTypeId.Name = "txtTaskTypeId";
            this.txtTaskTypeId.QueryCheckBox = null;
            this.txtTaskTypeId.QueryFieldName = null;
            this.txtTaskTypeId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtTaskTypeId.ReadOnly = true;
            this.txtTaskTypeId.SelectedModel = null;
            this.txtTaskTypeId.Size = new System.Drawing.Size(185, 23);
            this.txtTaskTypeId.TabIndex = 151;
            this.txtTaskTypeId.ValueMember = "";
            this.txtTaskTypeId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtShortDesc
            // 
            this.txtShortDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShortDesc.IsAllowEmpty = true;
            this.txtShortDesc.Location = new System.Drawing.Point(72, 87);
            this.txtShortDesc.Multiline = true;
            this.txtShortDesc.Name = "txtShortDesc";
            this.txtShortDesc.Size = new System.Drawing.Size(632, 53);
            this.txtShortDesc.TabIndex = 159;
            this.txtShortDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRequire
            // 
            this.txtRequire.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequire.IsAllowEmpty = true;
            this.txtRequire.Location = new System.Drawing.Point(72, 143);
            this.txtRequire.Multiline = true;
            this.txtRequire.Name = "txtRequire";
            this.txtRequire.Size = new System.Drawing.Size(632, 52);
            this.txtRequire.TabIndex = 160;
            this.txtRequire.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.IsAllowEmpty = true;
            this.txtContent.Location = new System.Drawing.Point(72, 198);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(632, 53);
            this.txtContent.TabIndex = 161;
            this.txtContent.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(72, 254);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(632, 57);
            this.txtRemark.TabIndex = 162;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblShortDesc
            // 
            this.lblShortDesc.AutoSize = true;
            this.lblShortDesc.ForeColor = System.Drawing.Color.Black;
            this.lblShortDesc.Location = new System.Drawing.Point(10, 90);
            this.lblShortDesc.Name = "lblShortDesc";
            this.lblShortDesc.Size = new System.Drawing.Size(56, 17);
            this.lblShortDesc.TabIndex = 171;
            this.lblShortDesc.Text = "任务简介";
            // 
            // lblRequire
            // 
            this.lblRequire.AutoSize = true;
            this.lblRequire.ForeColor = System.Drawing.Color.Black;
            this.lblRequire.Location = new System.Drawing.Point(10, 146);
            this.lblRequire.Name = "lblRequire";
            this.lblRequire.Size = new System.Drawing.Size(56, 17);
            this.lblRequire.TabIndex = 172;
            this.lblRequire.Text = "任务要求";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.ForeColor = System.Drawing.Color.Black;
            this.lblContent.Location = new System.Drawing.Point(10, 201);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(56, 17);
            this.lblContent.TabIndex = 173;
            this.lblContent.Text = "工作内容";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(10, 256);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 174;
            this.lblRemark.Text = "备注信息";
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtStartDate.DropDownCalendar.Name = "";
            this.dtStartDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtStartDate.Location = new System.Drawing.Point(328, 61);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(136, 23);
            this.dtStartDate.TabIndex = 157;
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
            this.dtPreEndDate.Location = new System.Drawing.Point(556, 61);
            this.dtPreEndDate.Name = "dtPreEndDate";
            this.dtPreEndDate.Size = new System.Drawing.Size(148, 23);
            this.dtPreEndDate.TabIndex = 158;
            this.dtPreEndDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // lblAssignPeople
            // 
            this.lblAssignPeople.AutoSize = true;
            this.lblAssignPeople.ForeColor = System.Drawing.Color.Black;
            this.lblAssignPeople.Location = new System.Drawing.Point(10, 64);
            this.lblAssignPeople.Name = "lblAssignPeople";
            this.lblAssignPeople.Size = new System.Drawing.Size(44, 17);
            this.lblAssignPeople.TabIndex = 168;
            this.lblAssignPeople.Text = "负责人";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(266, 64);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(56, 17);
            this.lblStartDate.TabIndex = 169;
            this.lblStartDate.Text = "起始日期";
            // 
            // lblPreEndDate
            // 
            this.lblPreEndDate.AutoSize = true;
            this.lblPreEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblPreEndDate.Location = new System.Drawing.Point(470, 64);
            this.lblPreEndDate.Name = "lblPreEndDate";
            this.lblPreEndDate.Size = new System.Drawing.Size(80, 17);
            this.lblPreEndDate.TabIndex = 170;
            this.lblPreEndDate.Text = "预计完成日期";
            // 
            // dtDispatchDate
            // 
            this.dtDispatchDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDispatchDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtDispatchDate.DropDownCalendar.Name = "";
            this.dtDispatchDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtDispatchDate.Location = new System.Drawing.Point(556, 34);
            this.dtDispatchDate.Name = "dtDispatchDate";
            this.dtDispatchDate.Size = new System.Drawing.Size(148, 23);
            this.dtDispatchDate.TabIndex = 155;
            this.dtDispatchDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // lblDispatchDate
            // 
            this.lblDispatchDate.AutoSize = true;
            this.lblDispatchDate.ForeColor = System.Drawing.Color.Black;
            this.lblDispatchDate.Location = new System.Drawing.Point(470, 37);
            this.lblDispatchDate.Name = "lblDispatchDate";
            this.lblDispatchDate.Size = new System.Drawing.Size(56, 17);
            this.lblDispatchDate.TabIndex = 167;
            this.lblDispatchDate.Text = "发派日期";
            // 
            // txtStartPeople
            // 
            this.txtStartPeople.IsAllowEmpty = true;
            this.txtStartPeople.Location = new System.Drawing.Point(328, 34);
            this.txtStartPeople.Name = "txtStartPeople";
            this.txtStartPeople.Size = new System.Drawing.Size(136, 23);
            this.txtStartPeople.TabIndex = 154;
            this.txtStartPeople.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblStartPeople
            // 
            this.lblStartPeople.AutoSize = true;
            this.lblStartPeople.ForeColor = System.Drawing.Color.Black;
            this.lblStartPeople.Location = new System.Drawing.Point(266, 37);
            this.lblStartPeople.Name = "lblStartPeople";
            this.lblStartPeople.Size = new System.Drawing.Size(44, 17);
            this.lblStartPeople.TabIndex = 165;
            this.lblStartPeople.Text = "发起人";
            // 
            // txtTaskNo
            // 
            this.txtTaskNo.IsAllowEmpty = true;
            this.txtTaskNo.Location = new System.Drawing.Point(72, 34);
            this.txtTaskNo.Name = "txtTaskNo";
            this.txtTaskNo.Size = new System.Drawing.Size(185, 23);
            this.txtTaskNo.TabIndex = 153;
            this.txtTaskNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblTaskNo
            // 
            this.lblTaskNo.AutoSize = true;
            this.lblTaskNo.ForeColor = System.Drawing.Color.Black;
            this.lblTaskNo.Location = new System.Drawing.Point(10, 37);
            this.lblTaskNo.Name = "lblTaskNo";
            this.lblTaskNo.Size = new System.Drawing.Size(56, 17);
            this.lblTaskNo.TabIndex = 166;
            this.lblTaskNo.Text = "任务编号";
            // 
            // txtTaskName
            // 
            this.txtTaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskName.IsAllowEmpty = false;
            this.txtTaskName.Location = new System.Drawing.Point(328, 6);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(376, 23);
            this.txtTaskName.TabIndex = 152;
            this.txtTaskName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.ForeColor = System.Drawing.Color.Black;
            this.lblTaskName.Location = new System.Drawing.Point(266, 9);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(56, 17);
            this.lblTaskName.TabIndex = 164;
            this.lblTaskName.Text = "任务名称";
            // 
            // lblTaskTypeId
            // 
            this.lblTaskTypeId.AutoSize = true;
            this.lblTaskTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblTaskTypeId.Location = new System.Drawing.Point(10, 9);
            this.lblTaskTypeId.Name = "lblTaskTypeId";
            this.lblTaskTypeId.Size = new System.Drawing.Size(56, 17);
            this.lblTaskTypeId.TabIndex = 163;
            this.lblTaskTypeId.Text = "任务类型";
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.Controls.Add(this.btnDeleteFile);
            this.uiTabPage2.Controls.Add(this.btnEditFile);
            this.uiTabPage2.Controls.Add(this.btnAddNewFile);
            this.uiTabPage2.Controls.Add(this.grdFiles);
            this.uiTabPage2.Location = new System.Drawing.Point(1, 25);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.Size = new System.Drawing.Size(714, 317);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "任务附件";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFile.Location = new System.Drawing.Point(629, 66);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFile.TabIndex = 13;
            this.btnDeleteFile.Text = "删除";
            this.btnDeleteFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnEditFile
            // 
            this.btnEditFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFile.Location = new System.Drawing.Point(629, 37);
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.Size = new System.Drawing.Size(75, 23);
            this.btnEditFile.TabIndex = 12;
            this.btnEditFile.Text = "修改";
            this.btnEditFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnEditFile.Click += new System.EventHandler(this.btnEditFile_Click);
            // 
            // btnAddNewFile
            // 
            this.btnAddNewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewFile.Location = new System.Drawing.Point(629, 8);
            this.btnAddNewFile.Name = "btnAddNewFile";
            this.btnAddNewFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewFile.TabIndex = 11;
            this.btnAddNewFile.Text = "添加";
            this.btnAddNewFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnAddNewFile.Click += new System.EventHandler(this.btnAddNewFile_Click);
            // 
            // grdFiles
            // 
            this.grdFiles.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdFiles.AlternatingColors = true;
            this.grdFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFiles.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>拖动列名至此" +
    "进行分组</GroupByBoxInfo></LocalizableData>";
            grdFiles_DesignTimeLayout.LayoutString = resources.GetString("grdFiles_DesignTimeLayout.LayoutString");
            this.grdFiles.DesignTimeLayout = grdFiles_DesignTimeLayout;
            this.grdFiles.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdFiles.GroupByBoxVisible = false;
            this.grdFiles.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdFiles.Location = new System.Drawing.Point(8, 8);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdFiles.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdFiles.Size = new System.Drawing.Size(613, 302);
            this.grdFiles.TabIndex = 10;
            this.grdFiles.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmTaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(736, 484);
            this.Controls.Add(this.xTabControl1);
            this.Controls.Add(this.txtTaskStatus);
            this.Controls.Add(this.xLabel5);
            this.Controls.Add(this.grpParent);
            this.Name = "frmTaskEdit";
            this.Text = "任务管理";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.grpParent, 0);
            this.Controls.SetChildIndex(this.xLabel5, 0);
            this.Controls.SetChildIndex(this.txtTaskStatus, 0);
            this.Controls.SetChildIndex(this.xTabControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grpParent)).EndInit();
            this.grpParent.ResumeLayout(false);
            this.grpParent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xTabControl1)).EndInit();
            this.xTabControl1.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            this.uiTabPage1.PerformLayout();
            this.uiTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Component.XLabel xLabel1;
        private Component.XEditBox txtParentTask;
        private Component.XGroupBox grpParent;
        private Component.XDateTimePicker dtParentPreEndDate;
        private Component.XLabel xLabel4;
        private Component.XDateTimePicker dtParentStartDate;
        private Component.XLabel xLabel3;
        private Component.XEditBox txtParentNo;
        private Component.XLabel xLabel2;
        private Component.XLabel xLabel5;
        private Component.XEditBox txtTaskStatus;
        private Component.XTabControl xTabControl1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private XSelectUsersEditBox txtAssignPeople;
        private XSelectCodeTaskTypeEditBox txtTaskTypeId;
        private Component.XEditBox txtShortDesc;
        private Component.XEditBox txtRequire;
        private Component.XEditBox txtContent;
        private Component.XEditBox txtRemark;
        private Component.XLabel lblShortDesc;
        private Component.XLabel lblRequire;
        private Component.XLabel lblContent;
        private Component.XLabel lblRemark;
        private Component.XDateTimePicker dtStartDate;
        private Component.XDateTimePicker dtPreEndDate;
        private Component.XLabel lblAssignPeople;
        private Component.XLabel lblStartDate;
        private Component.XLabel lblPreEndDate;
        private Component.XDateTimePicker dtDispatchDate;
        private Component.XLabel lblDispatchDate;
        private Component.XEditBox txtStartPeople;
        private Component.XLabel lblStartPeople;
        private Component.XEditBox txtTaskNo;
        private Component.XLabel lblTaskNo;
        private Component.XEditBox txtTaskName;
        private Component.XLabel lblTaskName;
        private Component.XLabel lblTaskTypeId;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        protected Component.XGridEx grdFiles;
        protected Component.XButton btnDeleteFile;
        protected Component.XButton btnEditFile;
        protected Component.XButton btnAddNewFile;


    }
}