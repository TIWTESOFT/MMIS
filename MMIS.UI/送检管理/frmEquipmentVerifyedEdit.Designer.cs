namespace MMIS.UI
{
    partial class frmEquipmentVerifyedEdit
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
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem5 = new Janus.Windows.EditControls.UIComboBoxItem();
            this.xGroupBox2 = new MMIS.Component.XGroupBox();
            this.txtVerifyedDesc = new MMIS.Component.XEditBox();
            this.xLabel7 = new MMIS.Component.XLabel();
            this.dtVerifyedDate = new MMIS.Component.XDateTimePicker();
            this.xLabel6 = new MMIS.Component.XLabel();
            this.txtSignUserId = new MMIS.UI.XSelectStaffInfoEditBox();
            this.lblDetectUserId = new MMIS.Component.XLabel();
            this.txtCheckedUserName = new MMIS.Component.XEditBox();
            this.xLabel4 = new MMIS.Component.XLabel();
            this.txtCheckedDesc = new MMIS.Component.XEditBox();
            this.xLabel5 = new MMIS.Component.XLabel();
            this.txtReceiveUser = new MMIS.Component.XEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtReceiveDesc = new MMIS.Component.XEditBox();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.xGroupBox1 = new MMIS.Component.XGroupBox();
            this.dtCheckedDate = new MMIS.Component.XDateTimePicker();
            this.xLabel8 = new MMIS.Component.XLabel();
            this.txtCheckAccord = new MMIS.Component.XEditBox();
            this.lblCheckAccord = new MMIS.Component.XLabel();
            this.txtFactoryNo = new MMIS.Component.XEditBox();
            this.lblFactoryNo = new MMIS.Component.XLabel();
            this.txtFactoryName = new MMIS.Component.XEditBox();
            this.lblFactoryName = new MMIS.Component.XLabel();
            this.nebQuanlity = new MMIS.Component.XNumberEditBox();
            this.lblQuanlity = new MMIS.Component.XLabel();
            this.txtEquipmentCustId = new MMIS.Component.XEditBox();
            this.txtEquipmentNo = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.cboSourceTypeId = new MMIS.Component.XCombobox();
            this.cboEquipmentType = new MMIS.Component.XCombobox();
            this.txtSpec = new MMIS.Component.XEditBox();
            this.txtModel = new MMIS.Component.XEditBox();
            this.dtSourceTime = new MMIS.Component.XDateTimePicker();
            this.lblEquipmentType = new MMIS.Component.XLabel();
            this.lblEquipmentCustId = new MMIS.Component.XLabel();
            this.lblSpec = new MMIS.Component.XLabel();
            this.lblModel = new MMIS.Component.XLabel();
            this.lblSourceTime = new MMIS.Component.XLabel();
            this.lblSourceTypeId = new MMIS.Component.XLabel();
            this.txtEquipmentCheckId = new MMIS.UI.XSelectEquipmentCheckEditBox();
            this.lblEquipmentCheckId = new MMIS.Component.XLabel();
            this.xGroupBox3 = new MMIS.Component.XGroupBox();
            this.txtBackReason = new MMIS.Component.XEditBox();
            this.chkIsBack = new MMIS.Component.XCheckBox();
            this.btnPrint = new MMIS.Component.XButton();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).BeginInit();
            this.xGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).BeginInit();
            this.xGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox3)).BeginInit();
            this.xGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(655, 435);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(742, 435);
            // 
            // xGroupBox2
            // 
            this.xGroupBox2.Controls.Add(this.txtVerifyedDesc);
            this.xGroupBox2.Controls.Add(this.xLabel7);
            this.xGroupBox2.Controls.Add(this.dtVerifyedDate);
            this.xGroupBox2.Controls.Add(this.xLabel6);
            this.xGroupBox2.Controls.Add(this.txtSignUserId);
            this.xGroupBox2.Controls.Add(this.lblDetectUserId);
            this.xGroupBox2.Controls.Add(this.txtCheckedUserName);
            this.xGroupBox2.Controls.Add(this.xLabel4);
            this.xGroupBox2.Controls.Add(this.txtCheckedDesc);
            this.xGroupBox2.Controls.Add(this.xLabel5);
            this.xGroupBox2.Controls.Add(this.txtReceiveUser);
            this.xGroupBox2.Controls.Add(this.xLabel2);
            this.xGroupBox2.Controls.Add(this.txtReceiveDesc);
            this.xGroupBox2.Controls.Add(this.xLabel3);
            this.xGroupBox2.Location = new System.Drawing.Point(12, 126);
            this.xGroupBox2.Name = "xGroupBox2";
            this.xGroupBox2.Size = new System.Drawing.Size(805, 247);
            this.xGroupBox2.TabIndex = 1;
            this.xGroupBox2.Text = "核验信息";
            this.xGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtVerifyedDesc
            // 
            this.txtVerifyedDesc.IsAllowEmpty = true;
            this.txtVerifyedDesc.Location = new System.Drawing.Point(76, 195);
            this.txtVerifyedDesc.Multiline = true;
            this.txtVerifyedDesc.Name = "txtVerifyedDesc";
            this.txtVerifyedDesc.Size = new System.Drawing.Size(716, 45);
            this.txtVerifyedDesc.TabIndex = 7;
            this.txtVerifyedDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel7
            // 
            this.xLabel7.AutoSize = true;
            this.xLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xLabel7.ForeColor = System.Drawing.Color.Blue;
            this.xLabel7.Location = new System.Drawing.Point(14, 198);
            this.xLabel7.Name = "xLabel7";
            this.xLabel7.Size = new System.Drawing.Size(56, 17);
            this.xLabel7.TabIndex = 168;
            this.xLabel7.Text = "核验描述";
            // 
            // dtVerifyedDate
            // 
            // 
            // 
            // 
            this.dtVerifyedDate.DropDownCalendar.Name = "";
            this.dtVerifyedDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtVerifyedDate.Location = new System.Drawing.Point(229, 168);
            this.dtVerifyedDate.Name = "dtVerifyedDate";
            this.dtVerifyedDate.Size = new System.Drawing.Size(106, 23);
            this.dtVerifyedDate.TabIndex = 6;
            this.dtVerifyedDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xLabel6
            // 
            this.xLabel6.AutoSize = true;
            this.xLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xLabel6.ForeColor = System.Drawing.Color.Blue;
            this.xLabel6.Location = new System.Drawing.Point(167, 171);
            this.xLabel6.Name = "xLabel6";
            this.xLabel6.Size = new System.Drawing.Size(56, 17);
            this.xLabel6.TabIndex = 166;
            this.xLabel6.Text = "核验时间";
            // 
            // txtSignUserId
            // 
            this.txtSignUserId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtSignUserId.DisplayMember = "";
            this.txtSignUserId.IsAllowEmpty = true;
            this.txtSignUserId.Location = new System.Drawing.Point(76, 168);
            this.txtSignUserId.Name = "txtSignUserId";
            this.txtSignUserId.QueryCheckBox = null;
            this.txtSignUserId.QueryFieldName = null;
            this.txtSignUserId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtSignUserId.ReadOnly = true;
            this.txtSignUserId.SelectedModel = null;
            this.txtSignUserId.Size = new System.Drawing.Size(85, 23);
            this.txtSignUserId.TabIndex = 5;
            this.txtSignUserId.ValueMember = "";
            this.txtSignUserId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblDetectUserId
            // 
            this.lblDetectUserId.AutoSize = true;
            this.lblDetectUserId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetectUserId.ForeColor = System.Drawing.Color.Blue;
            this.lblDetectUserId.Location = new System.Drawing.Point(4, 171);
            this.lblDetectUserId.Name = "lblDetectUserId";
            this.lblDetectUserId.Size = new System.Drawing.Size(68, 17);
            this.lblDetectUserId.TabIndex = 164;
            this.lblDetectUserId.Text = "指定签发员";
            // 
            // txtCheckedUserName
            // 
            this.txtCheckedUserName.IsAllowEmpty = true;
            this.txtCheckedUserName.Location = new System.Drawing.Point(76, 94);
            this.txtCheckedUserName.Name = "txtCheckedUserName";
            this.txtCheckedUserName.ReadOnly = true;
            this.txtCheckedUserName.Size = new System.Drawing.Size(185, 23);
            this.txtCheckedUserName.TabIndex = 3;
            this.txtCheckedUserName.TabStop = false;
            this.txtCheckedUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel4
            // 
            this.xLabel4.AutoSize = true;
            this.xLabel4.ForeColor = System.Drawing.Color.Black;
            this.xLabel4.Location = new System.Drawing.Point(26, 97);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(44, 17);
            this.xLabel4.TabIndex = 161;
            this.xLabel4.Text = "检定员";
            // 
            // txtCheckedDesc
            // 
            this.txtCheckedDesc.IsAllowEmpty = true;
            this.txtCheckedDesc.Location = new System.Drawing.Point(76, 120);
            this.txtCheckedDesc.Multiline = true;
            this.txtCheckedDesc.Name = "txtCheckedDesc";
            this.txtCheckedDesc.ReadOnly = true;
            this.txtCheckedDesc.Size = new System.Drawing.Size(716, 45);
            this.txtCheckedDesc.TabIndex = 4;
            this.txtCheckedDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel5
            // 
            this.xLabel5.AutoSize = true;
            this.xLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xLabel5.ForeColor = System.Drawing.Color.Black;
            this.xLabel5.Location = new System.Drawing.Point(14, 123);
            this.xLabel5.Name = "xLabel5";
            this.xLabel5.Size = new System.Drawing.Size(56, 17);
            this.xLabel5.TabIndex = 158;
            this.xLabel5.Text = "检定描述";
            // 
            // txtReceiveUser
            // 
            this.txtReceiveUser.IsAllowEmpty = true;
            this.txtReceiveUser.Location = new System.Drawing.Point(76, 19);
            this.txtReceiveUser.Name = "txtReceiveUser";
            this.txtReceiveUser.ReadOnly = true;
            this.txtReceiveUser.Size = new System.Drawing.Size(185, 23);
            this.txtReceiveUser.TabIndex = 1;
            this.txtReceiveUser.TabStop = false;
            this.txtReceiveUser.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(26, 22);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(44, 17);
            this.xLabel2.TabIndex = 0;
            this.xLabel2.Text = "接收人";
            // 
            // txtReceiveDesc
            // 
            this.txtReceiveDesc.IsAllowEmpty = true;
            this.txtReceiveDesc.Location = new System.Drawing.Point(76, 46);
            this.txtReceiveDesc.Multiline = true;
            this.txtReceiveDesc.Name = "txtReceiveDesc";
            this.txtReceiveDesc.ReadOnly = true;
            this.txtReceiveDesc.Size = new System.Drawing.Size(716, 45);
            this.txtReceiveDesc.TabIndex = 2;
            this.txtReceiveDesc.TabStop = false;
            this.txtReceiveDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(14, 49);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 15;
            this.xLabel3.Text = "接收描述";
            // 
            // xGroupBox1
            // 
            this.xGroupBox1.Controls.Add(this.dtCheckedDate);
            this.xGroupBox1.Controls.Add(this.xLabel8);
            this.xGroupBox1.Controls.Add(this.txtCheckAccord);
            this.xGroupBox1.Controls.Add(this.lblCheckAccord);
            this.xGroupBox1.Controls.Add(this.txtFactoryNo);
            this.xGroupBox1.Controls.Add(this.lblFactoryNo);
            this.xGroupBox1.Controls.Add(this.txtFactoryName);
            this.xGroupBox1.Controls.Add(this.lblFactoryName);
            this.xGroupBox1.Controls.Add(this.nebQuanlity);
            this.xGroupBox1.Controls.Add(this.lblQuanlity);
            this.xGroupBox1.Controls.Add(this.txtEquipmentCustId);
            this.xGroupBox1.Controls.Add(this.txtEquipmentNo);
            this.xGroupBox1.Controls.Add(this.xLabel1);
            this.xGroupBox1.Controls.Add(this.cboSourceTypeId);
            this.xGroupBox1.Controls.Add(this.cboEquipmentType);
            this.xGroupBox1.Controls.Add(this.txtSpec);
            this.xGroupBox1.Controls.Add(this.txtModel);
            this.xGroupBox1.Controls.Add(this.dtSourceTime);
            this.xGroupBox1.Controls.Add(this.lblEquipmentType);
            this.xGroupBox1.Controls.Add(this.lblEquipmentCustId);
            this.xGroupBox1.Controls.Add(this.lblSpec);
            this.xGroupBox1.Controls.Add(this.lblModel);
            this.xGroupBox1.Controls.Add(this.lblSourceTime);
            this.xGroupBox1.Controls.Add(this.lblSourceTypeId);
            this.xGroupBox1.Controls.Add(this.txtEquipmentCheckId);
            this.xGroupBox1.Controls.Add(this.lblEquipmentCheckId);
            this.xGroupBox1.Location = new System.Drawing.Point(12, -1);
            this.xGroupBox1.Name = "xGroupBox1";
            this.xGroupBox1.Size = new System.Drawing.Size(806, 126);
            this.xGroupBox1.TabIndex = 0;
            this.xGroupBox1.Text = "设备信息";
            this.xGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // dtCheckedDate
            // 
            this.dtCheckedDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtCheckedDate.DropDownCalendar.Name = "";
            this.dtCheckedDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtCheckedDate.Location = new System.Drawing.Point(592, 97);
            this.dtCheckedDate.Name = "dtCheckedDate";
            this.dtCheckedDate.ReadOnly = true;
            this.dtCheckedDate.Size = new System.Drawing.Size(200, 23);
            this.dtCheckedDate.TabIndex = 170;
            this.dtCheckedDate.TabStop = false;
            this.dtCheckedDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xLabel8
            // 
            this.xLabel8.AutoSize = true;
            this.xLabel8.ForeColor = System.Drawing.Color.Black;
            this.xLabel8.Location = new System.Drawing.Point(530, 100);
            this.xLabel8.Name = "xLabel8";
            this.xLabel8.Size = new System.Drawing.Size(56, 17);
            this.xLabel8.TabIndex = 171;
            this.xLabel8.Text = "检定时间";
            // 
            // txtCheckAccord
            // 
            this.txtCheckAccord.IsAllowEmpty = true;
            this.txtCheckAccord.Location = new System.Drawing.Point(592, 118);
            this.txtCheckAccord.Name = "txtCheckAccord";
            this.txtCheckAccord.ReadOnly = true;
            this.txtCheckAccord.Size = new System.Drawing.Size(200, 23);
            this.txtCheckAccord.TabIndex = 168;
            this.txtCheckAccord.Visible = false;
            this.txtCheckAccord.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblCheckAccord
            // 
            this.lblCheckAccord.AutoSize = true;
            this.lblCheckAccord.ForeColor = System.Drawing.Color.Black;
            this.lblCheckAccord.Location = new System.Drawing.Point(530, 122);
            this.lblCheckAccord.Name = "lblCheckAccord";
            this.lblCheckAccord.Size = new System.Drawing.Size(56, 17);
            this.lblCheckAccord.TabIndex = 169;
            this.lblCheckAccord.Text = "检定依据";
            this.lblCheckAccord.Visible = false;
            // 
            // txtFactoryNo
            // 
            this.txtFactoryNo.IsAllowEmpty = true;
            this.txtFactoryNo.Location = new System.Drawing.Point(394, 70);
            this.txtFactoryNo.Name = "txtFactoryNo";
            this.txtFactoryNo.ReadOnly = true;
            this.txtFactoryNo.Size = new System.Drawing.Size(126, 23);
            this.txtFactoryNo.TabIndex = 166;
            this.txtFactoryNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblFactoryNo
            // 
            this.lblFactoryNo.AutoSize = true;
            this.lblFactoryNo.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryNo.Location = new System.Drawing.Point(334, 73);
            this.lblFactoryNo.Name = "lblFactoryNo";
            this.lblFactoryNo.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryNo.TabIndex = 167;
            this.lblFactoryNo.Text = "出厂编号";
            // 
            // txtFactoryName
            // 
            this.txtFactoryName.IsAllowEmpty = true;
            this.txtFactoryName.Location = new System.Drawing.Point(592, 70);
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.ReadOnly = true;
            this.txtFactoryName.Size = new System.Drawing.Size(200, 23);
            this.txtFactoryName.TabIndex = 164;
            this.txtFactoryName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblFactoryName
            // 
            this.lblFactoryName.AutoSize = true;
            this.lblFactoryName.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryName.Location = new System.Drawing.Point(530, 73);
            this.lblFactoryName.Name = "lblFactoryName";
            this.lblFactoryName.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryName.TabIndex = 165;
            this.lblFactoryName.Text = "制造单位";
            // 
            // nebQuanlity
            // 
            this.nebQuanlity.FormatString = "0";
            this.nebQuanlity.IsAllowEmpty = false;
            this.nebQuanlity.IsAllowLessThanZero = false;
            this.nebQuanlity.IsAllowZero = false;
            this.nebQuanlity.Location = new System.Drawing.Point(244, 70);
            this.nebQuanlity.Name = "nebQuanlity";
            this.nebQuanlity.ReadOnly = true;
            this.nebQuanlity.Size = new System.Drawing.Size(85, 23);
            this.nebQuanlity.TabIndex = 162;
            this.nebQuanlity.TabStop = false;
            this.nebQuanlity.Text = "0";
            this.nebQuanlity.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebQuanlity.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblQuanlity
            // 
            this.lblQuanlity.AutoSize = true;
            this.lblQuanlity.ForeColor = System.Drawing.Color.Black;
            this.lblQuanlity.Location = new System.Drawing.Point(206, 73);
            this.lblQuanlity.Name = "lblQuanlity";
            this.lblQuanlity.Size = new System.Drawing.Size(32, 17);
            this.lblQuanlity.TabIndex = 163;
            this.lblQuanlity.Text = "数量";
            // 
            // txtEquipmentCustId
            // 
            this.txtEquipmentCustId.IsAllowEmpty = false;
            this.txtEquipmentCustId.Location = new System.Drawing.Point(76, 44);
            this.txtEquipmentCustId.Name = "txtEquipmentCustId";
            this.txtEquipmentCustId.ReadOnly = true;
            this.txtEquipmentCustId.Size = new System.Drawing.Size(444, 23);
            this.txtEquipmentCustId.TabIndex = 132;
            this.txtEquipmentCustId.TabStop = false;
            this.txtEquipmentCustId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEquipmentNo
            // 
            this.txtEquipmentNo.IsAllowEmpty = false;
            this.txtEquipmentNo.Location = new System.Drawing.Point(592, 18);
            this.txtEquipmentNo.Name = "txtEquipmentNo";
            this.txtEquipmentNo.ReadOnly = true;
            this.txtEquipmentNo.Size = new System.Drawing.Size(200, 23);
            this.txtEquipmentNo.TabIndex = 131;
            this.txtEquipmentNo.TabStop = false;
            this.txtEquipmentNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(529, 21);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 149;
            this.xLabel1.Text = "设备编号";
            // 
            // cboSourceTypeId
            // 
            this.cboSourceTypeId.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboSourceTypeId.IsAllowEmpty = false;
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.IsSeparator = false;
            uiComboBoxItem1.Text = "检定";
            uiComboBoxItem1.Value = "检定";
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.IsSeparator = false;
            uiComboBoxItem2.Text = "标准";
            uiComboBoxItem2.Value = "标准";
            uiComboBoxItem3.FormatStyle.Alpha = 0;
            uiComboBoxItem3.IsSeparator = false;
            uiComboBoxItem3.Text = "测试";
            uiComboBoxItem3.Value = "测试";
            this.cboSourceTypeId.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2,
            uiComboBoxItem3});
            this.cboSourceTypeId.Location = new System.Drawing.Point(335, 97);
            this.cboSourceTypeId.Name = "cboSourceTypeId";
            this.cboSourceTypeId.ReadOnly = true;
            this.cboSourceTypeId.Size = new System.Drawing.Size(185, 23);
            this.cboSourceTypeId.TabIndex = 138;
            this.cboSourceTypeId.TabStop = false;
            this.cboSourceTypeId.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // cboEquipmentType
            // 
            this.cboEquipmentType.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboEquipmentType.IsAllowEmpty = false;
            uiComboBoxItem4.FormatStyle.Alpha = 0;
            uiComboBoxItem4.IsSeparator = false;
            uiComboBoxItem4.Text = "送检设备";
            uiComboBoxItem4.Value = "送检设备";
            uiComboBoxItem5.FormatStyle.Alpha = 0;
            uiComboBoxItem5.IsSeparator = false;
            uiComboBoxItem5.Text = "标准设备";
            uiComboBoxItem5.Value = "标准设备";
            this.cboEquipmentType.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem4,
            uiComboBoxItem5});
            this.cboEquipmentType.Location = new System.Drawing.Point(335, 18);
            this.cboEquipmentType.Name = "cboEquipmentType";
            this.cboEquipmentType.ReadOnly = true;
            this.cboEquipmentType.Size = new System.Drawing.Size(185, 23);
            this.cboEquipmentType.TabIndex = 130;
            this.cboEquipmentType.TabStop = false;
            this.cboEquipmentType.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtSpec
            // 
            this.txtSpec.IsAllowEmpty = true;
            this.txtSpec.Location = new System.Drawing.Point(592, 43);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(200, 23);
            this.txtSpec.TabIndex = 133;
            this.txtSpec.TabStop = false;
            this.txtSpec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtModel
            // 
            this.txtModel.IsAllowEmpty = true;
            this.txtModel.Location = new System.Drawing.Point(76, 70);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(124, 23);
            this.txtModel.TabIndex = 134;
            this.txtModel.TabStop = false;
            this.txtModel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtSourceTime
            // 
            this.dtSourceTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtSourceTime.DropDownCalendar.Name = "";
            this.dtSourceTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtSourceTime.Location = new System.Drawing.Point(76, 97);
            this.dtSourceTime.Name = "dtSourceTime";
            this.dtSourceTime.ReadOnly = true;
            this.dtSourceTime.Size = new System.Drawing.Size(185, 23);
            this.dtSourceTime.TabIndex = 137;
            this.dtSourceTime.TabStop = false;
            this.dtSourceTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // lblEquipmentType
            // 
            this.lblEquipmentType.AutoSize = true;
            this.lblEquipmentType.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentType.Location = new System.Drawing.Point(273, 21);
            this.lblEquipmentType.Name = "lblEquipmentType";
            this.lblEquipmentType.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentType.TabIndex = 140;
            this.lblEquipmentType.Text = "设备类型";
            // 
            // lblEquipmentCustId
            // 
            this.lblEquipmentCustId.AutoSize = true;
            this.lblEquipmentCustId.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentCustId.Location = new System.Drawing.Point(9, 46);
            this.lblEquipmentCustId.Name = "lblEquipmentCustId";
            this.lblEquipmentCustId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentCustId.TabIndex = 141;
            this.lblEquipmentCustId.Text = "送检单位";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.ForeColor = System.Drawing.Color.Black;
            this.lblSpec.Location = new System.Drawing.Point(530, 46);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(32, 17);
            this.lblSpec.TabIndex = 142;
            this.lblSpec.Text = "规格";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(11, 73);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(32, 17);
            this.lblModel.TabIndex = 143;
            this.lblModel.Text = "型号";
            // 
            // lblSourceTime
            // 
            this.lblSourceTime.AutoSize = true;
            this.lblSourceTime.ForeColor = System.Drawing.Color.Black;
            this.lblSourceTime.Location = new System.Drawing.Point(10, 100);
            this.lblSourceTime.Name = "lblSourceTime";
            this.lblSourceTime.Size = new System.Drawing.Size(56, 17);
            this.lblSourceTime.TabIndex = 144;
            this.lblSourceTime.Text = "溯源时间";
            // 
            // lblSourceTypeId
            // 
            this.lblSourceTypeId.AutoSize = true;
            this.lblSourceTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblSourceTypeId.Location = new System.Drawing.Point(273, 100);
            this.lblSourceTypeId.Name = "lblSourceTypeId";
            this.lblSourceTypeId.Size = new System.Drawing.Size(56, 17);
            this.lblSourceTypeId.TabIndex = 146;
            this.lblSourceTypeId.Text = "溯源方式";
            // 
            // txtEquipmentCheckId
            // 
            this.txtEquipmentCheckId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtEquipmentCheckId.DisplayMember = "";
            this.txtEquipmentCheckId.Enabled = false;
            this.txtEquipmentCheckId.IsAllowEmpty = false;
            this.txtEquipmentCheckId.Location = new System.Drawing.Point(76, 18);
            this.txtEquipmentCheckId.Name = "txtEquipmentCheckId";
            this.txtEquipmentCheckId.QueryCheckBox = null;
            this.txtEquipmentCheckId.QueryFieldName = null;
            this.txtEquipmentCheckId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtEquipmentCheckId.ReadOnly = true;
            this.txtEquipmentCheckId.SelectedModel = null;
            this.txtEquipmentCheckId.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentCheckId.TabIndex = 128;
            this.txtEquipmentCheckId.TabStop = false;
            this.txtEquipmentCheckId.ValueMember = "";
            this.txtEquipmentCheckId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblEquipmentCheckId
            // 
            this.lblEquipmentCheckId.AutoSize = true;
            this.lblEquipmentCheckId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEquipmentCheckId.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentCheckId.Location = new System.Drawing.Point(9, 20);
            this.lblEquipmentCheckId.Name = "lblEquipmentCheckId";
            this.lblEquipmentCheckId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentCheckId.TabIndex = 129;
            this.lblEquipmentCheckId.Text = "检定设备";
            // 
            // xGroupBox3
            // 
            this.xGroupBox3.Controls.Add(this.txtBackReason);
            this.xGroupBox3.Controls.Add(this.chkIsBack);
            this.xGroupBox3.Location = new System.Drawing.Point(8, 376);
            this.xGroupBox3.Name = "xGroupBox3";
            this.xGroupBox3.Size = new System.Drawing.Size(806, 51);
            this.xGroupBox3.TabIndex = 101;
            this.xGroupBox3.Text = "核验退回";
            this.xGroupBox3.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtBackReason
            // 
            this.txtBackReason.IsAllowEmpty = true;
            this.txtBackReason.Location = new System.Drawing.Point(115, 18);
            this.txtBackReason.Name = "txtBackReason";
            this.txtBackReason.Size = new System.Drawing.Size(678, 23);
            this.txtBackReason.TabIndex = 172;
            this.txtBackReason.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // chkIsBack
            // 
            this.chkIsBack.Location = new System.Drawing.Point(13, 18);
            this.chkIsBack.Model = null;
            this.chkIsBack.Name = "chkIsBack";
            this.chkIsBack.Size = new System.Drawing.Size(96, 23);
            this.chkIsBack.TabIndex = 171;
            this.chkIsBack.Text = "退出重新检定";
            this.chkIsBack.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ImageIndex = 84;
            this.btnPrint.Location = new System.Drawing.Point(8, 435);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 27);
            this.btnPrint.TabIndex = 104;
            this.btnPrint.Text = "预览报告";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmEquipmentVerifyedEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 471);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.xGroupBox3);
            this.Controls.Add(this.xGroupBox2);
            this.Controls.Add(this.xGroupBox1);
            this.Name = "frmEquipmentVerifyedEdit";
            this.Text = "设备核验";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xGroupBox1, 0);
            this.Controls.SetChildIndex(this.xGroupBox2, 0);
            this.Controls.SetChildIndex(this.xGroupBox3, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).EndInit();
            this.xGroupBox2.ResumeLayout(false);
            this.xGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).EndInit();
            this.xGroupBox1.ResumeLayout(false);
            this.xGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox3)).EndInit();
            this.xGroupBox3.ResumeLayout(false);
            this.xGroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.XGroupBox xGroupBox2;
        private Component.XEditBox txtCheckedDesc;
        private Component.XLabel xLabel5;
        private Component.XEditBox txtReceiveUser;
        private Component.XLabel xLabel2;
        private Component.XEditBox txtReceiveDesc;
        private Component.XLabel xLabel3;
        private Component.XGroupBox xGroupBox1;
        private Component.XEditBox txtEquipmentCustId;
        private Component.XEditBox txtEquipmentNo;
        private Component.XLabel xLabel1;
        private Component.XCombobox cboSourceTypeId;
        private Component.XCombobox cboEquipmentType;
        private Component.XEditBox txtSpec;
        private Component.XEditBox txtModel;
        private Component.XDateTimePicker dtSourceTime;
        private Component.XLabel lblEquipmentType;
        private Component.XLabel lblEquipmentCustId;
        private Component.XLabel lblSpec;
        private Component.XLabel lblModel;
        private Component.XLabel lblSourceTime;
        private Component.XLabel lblSourceTypeId;
        private XSelectEquipmentCheckEditBox txtEquipmentCheckId;
        private Component.XLabel lblEquipmentCheckId;
        private Component.XEditBox txtCheckedUserName;
        private Component.XLabel xLabel4;
        private XSelectStaffInfoEditBox txtSignUserId;
        private Component.XLabel lblDetectUserId;
        private Component.XDateTimePicker dtVerifyedDate;
        private Component.XLabel xLabel6;
        private Component.XEditBox txtVerifyedDesc;
        private Component.XLabel xLabel7;
        private Component.XGroupBox xGroupBox3;
        private Component.XEditBox txtBackReason;
        private Component.XCheckBox chkIsBack;
        private Component.XButton btnPrint;
        private Component.XEditBox txtFactoryNo;
        private Component.XLabel lblFactoryNo;
        private Component.XEditBox txtFactoryName;
        private Component.XLabel lblFactoryName;
        private Component.XNumberEditBox nebQuanlity;
        private Component.XLabel lblQuanlity;
        private Component.XEditBox txtCheckAccord;
        private Component.XLabel lblCheckAccord;
        private Component.XDateTimePicker dtCheckedDate;
        private Component.XLabel xLabel8;
    }
}