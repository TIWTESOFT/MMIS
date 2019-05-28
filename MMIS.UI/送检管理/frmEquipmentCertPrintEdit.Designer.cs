namespace MMIS.UI
{
    partial class frmEquipmentCertPrintEdit
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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem6 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem7 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem8 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem9 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem10 = new Janus.Windows.EditControls.UIComboBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentCertPrintEdit));
            this.xGroupBox2 = new MMIS.Component.XGroupBox();
            this.txtDispatchUserName = new MMIS.Component.XEditBox();
            this.xLabel10 = new MMIS.Component.XLabel();
            this.txtSignedDesc = new MMIS.Component.XEditBox();
            this.xLabel9 = new MMIS.Component.XLabel();
            this.txtSignedUserName = new MMIS.Component.XEditBox();
            this.xLabel8 = new MMIS.Component.XLabel();
            this.txtVerifyUserName = new MMIS.Component.XEditBox();
            this.xLabel6 = new MMIS.Component.XLabel();
            this.txtVerifyDesc = new MMIS.Component.XEditBox();
            this.xLabel7 = new MMIS.Component.XLabel();
            this.txtCheckedUserName = new MMIS.Component.XEditBox();
            this.xLabel4 = new MMIS.Component.XLabel();
            this.txtCheckedDesc = new MMIS.Component.XEditBox();
            this.xLabel5 = new MMIS.Component.XLabel();
            this.txtReceiveUser = new MMIS.Component.XEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtReceiveDesc = new MMIS.Component.XEditBox();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.xGroupBox1 = new MMIS.Component.XGroupBox();
            this.txtEquipmentCustId = new MMIS.Component.XEditBox();
            this.txtEquipmentNo = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.cboSourceTypeId = new MMIS.Component.XCombobox();
            this.cboEquipmentType = new MMIS.Component.XCombobox();
            this.txtSpec = new MMIS.Component.XEditBox();
            this.dtSourceTime = new MMIS.Component.XDateTimePicker();
            this.lblEquipmentType = new MMIS.Component.XLabel();
            this.lblEquipmentCustId = new MMIS.Component.XLabel();
            this.lblSpec = new MMIS.Component.XLabel();
            this.lblSourceTime = new MMIS.Component.XLabel();
            this.lblSourceTypeId = new MMIS.Component.XLabel();
            this.txtEquipmentCheckId = new MMIS.UI.XSelectEquipmentCheckEditBox();
            this.lblEquipmentCheckId = new MMIS.Component.XLabel();
            this.btnPrint = new MMIS.Component.XButton();
            this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
            this.txtCheckAccord = new MMIS.Component.XEditBox();
            this.lblCheckAccord = new MMIS.Component.XLabel();
            this.txtFactoryNo = new MMIS.Component.XEditBox();
            this.lblFactoryNo = new MMIS.Component.XLabel();
            this.txtFactoryName = new MMIS.Component.XEditBox();
            this.lblFactoryName = new MMIS.Component.XLabel();
            this.nebQuanlity = new MMIS.Component.XNumberEditBox();
            this.lblQuanlity = new MMIS.Component.XLabel();
            this.txtModel = new MMIS.Component.XEditBox();
            this.lblModel = new MMIS.Component.XLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).BeginInit();
            this.xGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).BeginInit();
            this.xGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(10, 471);
            this.btnOk.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(740, 471);
            // 
            // xGroupBox2
            // 
            this.xGroupBox2.Controls.Add(this.txtDispatchUserName);
            this.xGroupBox2.Controls.Add(this.xLabel10);
            this.xGroupBox2.Controls.Add(this.txtSignedDesc);
            this.xGroupBox2.Controls.Add(this.xLabel9);
            this.xGroupBox2.Controls.Add(this.txtSignedUserName);
            this.xGroupBox2.Controls.Add(this.xLabel8);
            this.xGroupBox2.Controls.Add(this.txtVerifyUserName);
            this.xGroupBox2.Controls.Add(this.xLabel6);
            this.xGroupBox2.Controls.Add(this.txtVerifyDesc);
            this.xGroupBox2.Controls.Add(this.xLabel7);
            this.xGroupBox2.Controls.Add(this.txtCheckedUserName);
            this.xGroupBox2.Controls.Add(this.xLabel4);
            this.xGroupBox2.Controls.Add(this.txtCheckedDesc);
            this.xGroupBox2.Controls.Add(this.xLabel5);
            this.xGroupBox2.Controls.Add(this.txtReceiveUser);
            this.xGroupBox2.Controls.Add(this.xLabel2);
            this.xGroupBox2.Controls.Add(this.txtReceiveDesc);
            this.xGroupBox2.Controls.Add(this.xLabel3);
            this.xGroupBox2.Location = new System.Drawing.Point(10, 127);
            this.xGroupBox2.Name = "xGroupBox2";
            this.xGroupBox2.Size = new System.Drawing.Size(805, 335);
            this.xGroupBox2.TabIndex = 102;
            this.xGroupBox2.Text = "制证打印";
            this.xGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtDispatchUserName
            // 
            this.txtDispatchUserName.IsAllowEmpty = true;
            this.txtDispatchUserName.Location = new System.Drawing.Point(76, 305);
            this.txtDispatchUserName.Name = "txtDispatchUserName";
            this.txtDispatchUserName.ReadOnly = true;
            this.txtDispatchUserName.Size = new System.Drawing.Size(185, 23);
            this.txtDispatchUserName.TabIndex = 170;
            this.txtDispatchUserName.TabStop = false;
            this.txtDispatchUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel10
            // 
            this.xLabel10.AutoSize = true;
            this.xLabel10.ForeColor = System.Drawing.Color.Black;
            this.xLabel10.Location = new System.Drawing.Point(26, 308);
            this.xLabel10.Name = "xLabel10";
            this.xLabel10.Size = new System.Drawing.Size(44, 17);
            this.xLabel10.TabIndex = 171;
            this.xLabel10.Text = "收发员";
            // 
            // txtSignedDesc
            // 
            this.txtSignedDesc.IsAllowEmpty = true;
            this.txtSignedDesc.Location = new System.Drawing.Point(76, 259);
            this.txtSignedDesc.Multiline = true;
            this.txtSignedDesc.Name = "txtSignedDesc";
            this.txtSignedDesc.ReadOnly = true;
            this.txtSignedDesc.Size = new System.Drawing.Size(716, 42);
            this.txtSignedDesc.TabIndex = 168;
            this.txtSignedDesc.TabStop = false;
            this.txtSignedDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel9
            // 
            this.xLabel9.AutoSize = true;
            this.xLabel9.ForeColor = System.Drawing.Color.Black;
            this.xLabel9.Location = new System.Drawing.Point(14, 262);
            this.xLabel9.Name = "xLabel9";
            this.xLabel9.Size = new System.Drawing.Size(56, 17);
            this.xLabel9.TabIndex = 169;
            this.xLabel9.Text = "签发描述";
            // 
            // txtSignedUserName
            // 
            this.txtSignedUserName.IsAllowEmpty = true;
            this.txtSignedUserName.Location = new System.Drawing.Point(76, 232);
            this.txtSignedUserName.Name = "txtSignedUserName";
            this.txtSignedUserName.ReadOnly = true;
            this.txtSignedUserName.Size = new System.Drawing.Size(185, 23);
            this.txtSignedUserName.TabIndex = 166;
            this.txtSignedUserName.TabStop = false;
            this.txtSignedUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel8
            // 
            this.xLabel8.AutoSize = true;
            this.xLabel8.ForeColor = System.Drawing.Color.Black;
            this.xLabel8.Location = new System.Drawing.Point(26, 235);
            this.xLabel8.Name = "xLabel8";
            this.xLabel8.Size = new System.Drawing.Size(44, 17);
            this.xLabel8.TabIndex = 167;
            this.xLabel8.Text = "签发员";
            // 
            // txtVerifyUserName
            // 
            this.txtVerifyUserName.IsAllowEmpty = true;
            this.txtVerifyUserName.Location = new System.Drawing.Point(76, 162);
            this.txtVerifyUserName.Name = "txtVerifyUserName";
            this.txtVerifyUserName.ReadOnly = true;
            this.txtVerifyUserName.Size = new System.Drawing.Size(185, 23);
            this.txtVerifyUserName.TabIndex = 3;
            this.txtVerifyUserName.TabStop = false;
            this.txtVerifyUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel6
            // 
            this.xLabel6.AutoSize = true;
            this.xLabel6.ForeColor = System.Drawing.Color.Black;
            this.xLabel6.Location = new System.Drawing.Point(26, 165);
            this.xLabel6.Name = "xLabel6";
            this.xLabel6.Size = new System.Drawing.Size(44, 17);
            this.xLabel6.TabIndex = 165;
            this.xLabel6.Text = "核验员";
            // 
            // txtVerifyDesc
            // 
            this.txtVerifyDesc.IsAllowEmpty = true;
            this.txtVerifyDesc.Location = new System.Drawing.Point(76, 188);
            this.txtVerifyDesc.Multiline = true;
            this.txtVerifyDesc.Name = "txtVerifyDesc";
            this.txtVerifyDesc.ReadOnly = true;
            this.txtVerifyDesc.Size = new System.Drawing.Size(716, 42);
            this.txtVerifyDesc.TabIndex = 4;
            this.txtVerifyDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel7
            // 
            this.xLabel7.AutoSize = true;
            this.xLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xLabel7.ForeColor = System.Drawing.Color.Black;
            this.xLabel7.Location = new System.Drawing.Point(14, 191);
            this.xLabel7.Name = "xLabel7";
            this.xLabel7.Size = new System.Drawing.Size(56, 17);
            this.xLabel7.TabIndex = 164;
            this.xLabel7.Text = "核验描述";
            // 
            // txtCheckedUserName
            // 
            this.txtCheckedUserName.IsAllowEmpty = true;
            this.txtCheckedUserName.Location = new System.Drawing.Point(76, 91);
            this.txtCheckedUserName.Name = "txtCheckedUserName";
            this.txtCheckedUserName.ReadOnly = true;
            this.txtCheckedUserName.Size = new System.Drawing.Size(185, 23);
            this.txtCheckedUserName.TabIndex = 2;
            this.txtCheckedUserName.TabStop = false;
            this.txtCheckedUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel4
            // 
            this.xLabel4.AutoSize = true;
            this.xLabel4.ForeColor = System.Drawing.Color.Black;
            this.xLabel4.Location = new System.Drawing.Point(26, 94);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(44, 17);
            this.xLabel4.TabIndex = 161;
            this.xLabel4.Text = "检定员";
            // 
            // txtCheckedDesc
            // 
            this.txtCheckedDesc.IsAllowEmpty = true;
            this.txtCheckedDesc.Location = new System.Drawing.Point(76, 117);
            this.txtCheckedDesc.Multiline = true;
            this.txtCheckedDesc.Name = "txtCheckedDesc";
            this.txtCheckedDesc.ReadOnly = true;
            this.txtCheckedDesc.Size = new System.Drawing.Size(716, 42);
            this.txtCheckedDesc.TabIndex = 4;
            this.txtCheckedDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel5
            // 
            this.xLabel5.AutoSize = true;
            this.xLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xLabel5.ForeColor = System.Drawing.Color.Black;
            this.xLabel5.Location = new System.Drawing.Point(14, 120);
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
            this.txtReceiveUser.TabIndex = 0;
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
            this.txtReceiveDesc.Location = new System.Drawing.Point(76, 45);
            this.txtReceiveDesc.Multiline = true;
            this.txtReceiveDesc.Name = "txtReceiveDesc";
            this.txtReceiveDesc.ReadOnly = true;
            this.txtReceiveDesc.Size = new System.Drawing.Size(716, 42);
            this.txtReceiveDesc.TabIndex = 1;
            this.txtReceiveDesc.TabStop = false;
            this.txtReceiveDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(14, 48);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 15;
            this.xLabel3.Text = "接收描述";
            // 
            // xGroupBox1
            // 
            this.xGroupBox1.Controls.Add(this.txtCheckAccord);
            this.xGroupBox1.Controls.Add(this.lblCheckAccord);
            this.xGroupBox1.Controls.Add(this.txtFactoryNo);
            this.xGroupBox1.Controls.Add(this.lblFactoryNo);
            this.xGroupBox1.Controls.Add(this.txtFactoryName);
            this.xGroupBox1.Controls.Add(this.lblFactoryName);
            this.xGroupBox1.Controls.Add(this.nebQuanlity);
            this.xGroupBox1.Controls.Add(this.lblQuanlity);
            this.xGroupBox1.Controls.Add(this.txtModel);
            this.xGroupBox1.Controls.Add(this.lblModel);
            this.xGroupBox1.Controls.Add(this.txtEquipmentCustId);
            this.xGroupBox1.Controls.Add(this.txtEquipmentNo);
            this.xGroupBox1.Controls.Add(this.xLabel1);
            this.xGroupBox1.Controls.Add(this.cboSourceTypeId);
            this.xGroupBox1.Controls.Add(this.cboEquipmentType);
            this.xGroupBox1.Controls.Add(this.txtSpec);
            this.xGroupBox1.Controls.Add(this.dtSourceTime);
            this.xGroupBox1.Controls.Add(this.lblEquipmentType);
            this.xGroupBox1.Controls.Add(this.lblEquipmentCustId);
            this.xGroupBox1.Controls.Add(this.lblSpec);
            this.xGroupBox1.Controls.Add(this.lblSourceTime);
            this.xGroupBox1.Controls.Add(this.lblSourceTypeId);
            this.xGroupBox1.Controls.Add(this.txtEquipmentCheckId);
            this.xGroupBox1.Controls.Add(this.lblEquipmentCheckId);
            this.xGroupBox1.Location = new System.Drawing.Point(10, 1);
            this.xGroupBox1.Name = "xGroupBox1";
            this.xGroupBox1.Size = new System.Drawing.Size(806, 126);
            this.xGroupBox1.TabIndex = 101;
            this.xGroupBox1.Text = "设备信息";
            this.xGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtEquipmentCustId
            // 
            this.txtEquipmentCustId.IsAllowEmpty = false;
            this.txtEquipmentCustId.Location = new System.Drawing.Point(76, 42);
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
            this.txtEquipmentNo.Location = new System.Drawing.Point(592, 15);
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
            this.xLabel1.Location = new System.Drawing.Point(529, 18);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 149;
            this.xLabel1.Text = "设备编号";
            // 
            // cboSourceTypeId
            // 
            this.cboSourceTypeId.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboSourceTypeId.IsAllowEmpty = false;
            uiComboBoxItem6.FormatStyle.Alpha = 0;
            uiComboBoxItem6.IsSeparator = false;
            uiComboBoxItem6.Text = "检定";
            uiComboBoxItem6.Value = "检定";
            uiComboBoxItem7.FormatStyle.Alpha = 0;
            uiComboBoxItem7.IsSeparator = false;
            uiComboBoxItem7.Text = "标准";
            uiComboBoxItem7.Value = "标准";
            uiComboBoxItem8.FormatStyle.Alpha = 0;
            uiComboBoxItem8.IsSeparator = false;
            uiComboBoxItem8.Text = "测试";
            uiComboBoxItem8.Value = "测试";
            this.cboSourceTypeId.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem6,
            uiComboBoxItem7,
            uiComboBoxItem8});
            this.cboSourceTypeId.Location = new System.Drawing.Point(335, 96);
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
            uiComboBoxItem9.FormatStyle.Alpha = 0;
            uiComboBoxItem9.IsSeparator = false;
            uiComboBoxItem9.Text = "送检设备";
            uiComboBoxItem9.Value = "送检设备";
            uiComboBoxItem10.FormatStyle.Alpha = 0;
            uiComboBoxItem10.IsSeparator = false;
            uiComboBoxItem10.Text = "标准设备";
            uiComboBoxItem10.Value = "标准设备";
            this.cboEquipmentType.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem9,
            uiComboBoxItem10});
            this.cboEquipmentType.Location = new System.Drawing.Point(335, 15);
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
            this.txtSpec.Location = new System.Drawing.Point(592, 41);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(200, 23);
            this.txtSpec.TabIndex = 133;
            this.txtSpec.TabStop = false;
            this.txtSpec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtSourceTime
            // 
            this.dtSourceTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtSourceTime.DropDownCalendar.Name = "";
            this.dtSourceTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtSourceTime.Location = new System.Drawing.Point(76, 96);
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
            this.lblEquipmentType.Location = new System.Drawing.Point(273, 18);
            this.lblEquipmentType.Name = "lblEquipmentType";
            this.lblEquipmentType.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentType.TabIndex = 140;
            this.lblEquipmentType.Text = "设备类型";
            // 
            // lblEquipmentCustId
            // 
            this.lblEquipmentCustId.AutoSize = true;
            this.lblEquipmentCustId.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentCustId.Location = new System.Drawing.Point(9, 44);
            this.lblEquipmentCustId.Name = "lblEquipmentCustId";
            this.lblEquipmentCustId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentCustId.TabIndex = 141;
            this.lblEquipmentCustId.Text = "送检单位";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.ForeColor = System.Drawing.Color.Black;
            this.lblSpec.Location = new System.Drawing.Point(530, 44);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(32, 17);
            this.lblSpec.TabIndex = 142;
            this.lblSpec.Text = "规格";
            // 
            // lblSourceTime
            // 
            this.lblSourceTime.AutoSize = true;
            this.lblSourceTime.ForeColor = System.Drawing.Color.Black;
            this.lblSourceTime.Location = new System.Drawing.Point(10, 99);
            this.lblSourceTime.Name = "lblSourceTime";
            this.lblSourceTime.Size = new System.Drawing.Size(56, 17);
            this.lblSourceTime.TabIndex = 144;
            this.lblSourceTime.Text = "溯源时间";
            // 
            // lblSourceTypeId
            // 
            this.lblSourceTypeId.AutoSize = true;
            this.lblSourceTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblSourceTypeId.Location = new System.Drawing.Point(273, 99);
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
            this.txtEquipmentCheckId.Location = new System.Drawing.Point(76, 15);
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
            this.lblEquipmentCheckId.Location = new System.Drawing.Point(9, 17);
            this.lblEquipmentCheckId.Name = "lblEquipmentCheckId";
            this.lblEquipmentCheckId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentCheckId.TabIndex = 129;
            this.lblEquipmentCheckId.Text = "检定设备";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ImageIndex = 84;
            this.btnPrint.ImageList = this.ImageList2;
            this.btnPrint.Location = new System.Drawing.Point(598, 471);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(136, 27);
            this.btnPrint.TabIndex = 103;
            this.btnPrint.Text = "预览并打印报告";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ImageList2
            // 
            this.ImageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList2.ImageStream")));
            this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList2.Images.SetKeyName(0, "");
            this.ImageList2.Images.SetKeyName(1, "");
            this.ImageList2.Images.SetKeyName(2, "");
            this.ImageList2.Images.SetKeyName(3, "");
            this.ImageList2.Images.SetKeyName(4, "");
            this.ImageList2.Images.SetKeyName(5, "");
            this.ImageList2.Images.SetKeyName(6, "");
            this.ImageList2.Images.SetKeyName(7, "");
            this.ImageList2.Images.SetKeyName(8, "");
            this.ImageList2.Images.SetKeyName(9, "");
            this.ImageList2.Images.SetKeyName(10, "");
            this.ImageList2.Images.SetKeyName(11, "");
            this.ImageList2.Images.SetKeyName(12, "");
            this.ImageList2.Images.SetKeyName(13, "");
            this.ImageList2.Images.SetKeyName(14, "");
            this.ImageList2.Images.SetKeyName(15, "");
            this.ImageList2.Images.SetKeyName(16, "");
            this.ImageList2.Images.SetKeyName(17, "");
            this.ImageList2.Images.SetKeyName(18, "");
            this.ImageList2.Images.SetKeyName(19, "");
            this.ImageList2.Images.SetKeyName(20, "");
            this.ImageList2.Images.SetKeyName(21, "");
            this.ImageList2.Images.SetKeyName(22, "");
            this.ImageList2.Images.SetKeyName(23, "");
            this.ImageList2.Images.SetKeyName(24, "");
            this.ImageList2.Images.SetKeyName(25, "");
            this.ImageList2.Images.SetKeyName(26, "");
            this.ImageList2.Images.SetKeyName(27, "");
            this.ImageList2.Images.SetKeyName(28, "");
            this.ImageList2.Images.SetKeyName(29, "");
            this.ImageList2.Images.SetKeyName(30, "");
            this.ImageList2.Images.SetKeyName(31, "");
            this.ImageList2.Images.SetKeyName(32, "");
            this.ImageList2.Images.SetKeyName(33, "");
            this.ImageList2.Images.SetKeyName(34, "");
            this.ImageList2.Images.SetKeyName(35, "");
            this.ImageList2.Images.SetKeyName(36, "");
            this.ImageList2.Images.SetKeyName(37, "");
            this.ImageList2.Images.SetKeyName(38, "");
            this.ImageList2.Images.SetKeyName(39, "");
            this.ImageList2.Images.SetKeyName(40, "");
            this.ImageList2.Images.SetKeyName(41, "");
            this.ImageList2.Images.SetKeyName(42, "");
            this.ImageList2.Images.SetKeyName(43, "");
            this.ImageList2.Images.SetKeyName(44, "");
            this.ImageList2.Images.SetKeyName(45, "");
            this.ImageList2.Images.SetKeyName(46, "");
            this.ImageList2.Images.SetKeyName(47, "");
            this.ImageList2.Images.SetKeyName(48, "");
            this.ImageList2.Images.SetKeyName(49, "");
            this.ImageList2.Images.SetKeyName(50, "");
            this.ImageList2.Images.SetKeyName(51, "");
            this.ImageList2.Images.SetKeyName(52, "");
            this.ImageList2.Images.SetKeyName(53, "");
            this.ImageList2.Images.SetKeyName(54, "");
            this.ImageList2.Images.SetKeyName(55, "");
            this.ImageList2.Images.SetKeyName(56, "");
            this.ImageList2.Images.SetKeyName(57, "");
            this.ImageList2.Images.SetKeyName(58, "");
            this.ImageList2.Images.SetKeyName(59, "");
            this.ImageList2.Images.SetKeyName(60, "");
            this.ImageList2.Images.SetKeyName(61, "");
            this.ImageList2.Images.SetKeyName(62, "");
            this.ImageList2.Images.SetKeyName(63, "");
            this.ImageList2.Images.SetKeyName(64, "");
            this.ImageList2.Images.SetKeyName(65, "");
            this.ImageList2.Images.SetKeyName(66, "");
            this.ImageList2.Images.SetKeyName(67, "");
            this.ImageList2.Images.SetKeyName(68, "");
            this.ImageList2.Images.SetKeyName(69, "");
            this.ImageList2.Images.SetKeyName(70, "");
            this.ImageList2.Images.SetKeyName(71, "");
            this.ImageList2.Images.SetKeyName(72, "");
            this.ImageList2.Images.SetKeyName(73, "");
            this.ImageList2.Images.SetKeyName(74, "");
            this.ImageList2.Images.SetKeyName(75, "");
            this.ImageList2.Images.SetKeyName(76, "");
            this.ImageList2.Images.SetKeyName(77, "");
            this.ImageList2.Images.SetKeyName(78, "");
            this.ImageList2.Images.SetKeyName(79, "");
            this.ImageList2.Images.SetKeyName(80, "");
            this.ImageList2.Images.SetKeyName(81, "");
            this.ImageList2.Images.SetKeyName(82, "");
            this.ImageList2.Images.SetKeyName(83, "");
            this.ImageList2.Images.SetKeyName(84, "");
            this.ImageList2.Images.SetKeyName(85, "");
            this.ImageList2.Images.SetKeyName(86, "");
            this.ImageList2.Images.SetKeyName(87, "");
            this.ImageList2.Images.SetKeyName(88, "");
            this.ImageList2.Images.SetKeyName(89, "");
            this.ImageList2.Images.SetKeyName(90, "");
            this.ImageList2.Images.SetKeyName(91, "");
            this.ImageList2.Images.SetKeyName(92, "");
            this.ImageList2.Images.SetKeyName(93, "");
            this.ImageList2.Images.SetKeyName(94, "");
            this.ImageList2.Images.SetKeyName(95, "");
            this.ImageList2.Images.SetKeyName(96, "");
            this.ImageList2.Images.SetKeyName(97, "");
            this.ImageList2.Images.SetKeyName(98, "");
            this.ImageList2.Images.SetKeyName(99, "");
            this.ImageList2.Images.SetKeyName(100, "");
            this.ImageList2.Images.SetKeyName(101, "");
            this.ImageList2.Images.SetKeyName(102, "");
            this.ImageList2.Images.SetKeyName(103, "");
            this.ImageList2.Images.SetKeyName(104, "");
            this.ImageList2.Images.SetKeyName(105, "");
            this.ImageList2.Images.SetKeyName(106, "");
            this.ImageList2.Images.SetKeyName(107, "");
            this.ImageList2.Images.SetKeyName(108, "");
            this.ImageList2.Images.SetKeyName(109, "");
            this.ImageList2.Images.SetKeyName(110, "");
            this.ImageList2.Images.SetKeyName(111, "");
            this.ImageList2.Images.SetKeyName(112, "");
            this.ImageList2.Images.SetKeyName(113, "");
            this.ImageList2.Images.SetKeyName(114, "");
            this.ImageList2.Images.SetKeyName(115, "");
            this.ImageList2.Images.SetKeyName(116, "");
            this.ImageList2.Images.SetKeyName(117, "");
            this.ImageList2.Images.SetKeyName(118, "");
            this.ImageList2.Images.SetKeyName(119, "");
            this.ImageList2.Images.SetKeyName(120, "");
            this.ImageList2.Images.SetKeyName(121, "");
            this.ImageList2.Images.SetKeyName(122, "");
            this.ImageList2.Images.SetKeyName(123, "");
            // 
            // txtCheckAccord
            // 
            this.txtCheckAccord.IsAllowEmpty = true;
            this.txtCheckAccord.Location = new System.Drawing.Point(592, 96);
            this.txtCheckAccord.Name = "txtCheckAccord";
            this.txtCheckAccord.ReadOnly = true;
            this.txtCheckAccord.Size = new System.Drawing.Size(200, 23);
            this.txtCheckAccord.TabIndex = 186;
            this.txtCheckAccord.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblCheckAccord
            // 
            this.lblCheckAccord.AutoSize = true;
            this.lblCheckAccord.ForeColor = System.Drawing.Color.Black;
            this.lblCheckAccord.Location = new System.Drawing.Point(530, 100);
            this.lblCheckAccord.Name = "lblCheckAccord";
            this.lblCheckAccord.Size = new System.Drawing.Size(56, 17);
            this.lblCheckAccord.TabIndex = 187;
            this.lblCheckAccord.Text = "检定依据";
            // 
            // txtFactoryNo
            // 
            this.txtFactoryNo.IsAllowEmpty = true;
            this.txtFactoryNo.Location = new System.Drawing.Point(394, 69);
            this.txtFactoryNo.Name = "txtFactoryNo";
            this.txtFactoryNo.ReadOnly = true;
            this.txtFactoryNo.Size = new System.Drawing.Size(126, 23);
            this.txtFactoryNo.TabIndex = 184;
            this.txtFactoryNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblFactoryNo
            // 
            this.lblFactoryNo.AutoSize = true;
            this.lblFactoryNo.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryNo.Location = new System.Drawing.Point(334, 72);
            this.lblFactoryNo.Name = "lblFactoryNo";
            this.lblFactoryNo.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryNo.TabIndex = 185;
            this.lblFactoryNo.Text = "出厂编号";
            // 
            // txtFactoryName
            // 
            this.txtFactoryName.IsAllowEmpty = true;
            this.txtFactoryName.Location = new System.Drawing.Point(592, 69);
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.ReadOnly = true;
            this.txtFactoryName.Size = new System.Drawing.Size(200, 23);
            this.txtFactoryName.TabIndex = 182;
            this.txtFactoryName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblFactoryName
            // 
            this.lblFactoryName.AutoSize = true;
            this.lblFactoryName.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryName.Location = new System.Drawing.Point(530, 72);
            this.lblFactoryName.Name = "lblFactoryName";
            this.lblFactoryName.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryName.TabIndex = 183;
            this.lblFactoryName.Text = "制造单位";
            // 
            // nebQuanlity
            // 
            this.nebQuanlity.FormatString = "0";
            this.nebQuanlity.IsAllowEmpty = false;
            this.nebQuanlity.IsAllowLessThanZero = false;
            this.nebQuanlity.IsAllowZero = false;
            this.nebQuanlity.Location = new System.Drawing.Point(244, 69);
            this.nebQuanlity.Name = "nebQuanlity";
            this.nebQuanlity.ReadOnly = true;
            this.nebQuanlity.Size = new System.Drawing.Size(85, 23);
            this.nebQuanlity.TabIndex = 180;
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
            this.lblQuanlity.Location = new System.Drawing.Point(206, 72);
            this.lblQuanlity.Name = "lblQuanlity";
            this.lblQuanlity.Size = new System.Drawing.Size(32, 17);
            this.lblQuanlity.TabIndex = 181;
            this.lblQuanlity.Text = "数量";
            // 
            // txtModel
            // 
            this.txtModel.IsAllowEmpty = true;
            this.txtModel.Location = new System.Drawing.Point(76, 69);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(124, 23);
            this.txtModel.TabIndex = 178;
            this.txtModel.TabStop = false;
            this.txtModel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(11, 72);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(32, 17);
            this.lblModel.TabIndex = 179;
            this.lblModel.Text = "型号";
            // 
            // frmEquipmentCertPrintEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 510);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.xGroupBox2);
            this.Controls.Add(this.xGroupBox1);
            this.Name = "frmEquipmentCertPrintEdit";
            this.Text = "制证打印";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xGroupBox1, 0);
            this.Controls.SetChildIndex(this.xGroupBox2, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).EndInit();
            this.xGroupBox2.ResumeLayout(false);
            this.xGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).EndInit();
            this.xGroupBox1.ResumeLayout(false);
            this.xGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.XGroupBox xGroupBox2;
        private Component.XEditBox txtVerifyUserName;
        private Component.XLabel xLabel6;
        private Component.XEditBox txtVerifyDesc;
        private Component.XLabel xLabel7;
        private Component.XEditBox txtCheckedUserName;
        private Component.XLabel xLabel4;
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
        private Component.XDateTimePicker dtSourceTime;
        private Component.XLabel lblEquipmentType;
        private Component.XLabel lblEquipmentCustId;
        private Component.XLabel lblSpec;
        private Component.XLabel lblSourceTime;
        private Component.XLabel lblSourceTypeId;
        private XSelectEquipmentCheckEditBox txtEquipmentCheckId;
        private Component.XLabel lblEquipmentCheckId;
        private Component.XEditBox txtSignedUserName;
        private Component.XLabel xLabel8;
        private Component.XEditBox txtSignedDesc;
        private Component.XLabel xLabel9;
        private Component.XButton btnPrint;
        internal System.Windows.Forms.ImageList ImageList2;
        private Component.XEditBox txtDispatchUserName;
        private Component.XLabel xLabel10;
        private Component.XEditBox txtCheckAccord;
        private Component.XLabel lblCheckAccord;
        private Component.XEditBox txtFactoryNo;
        private Component.XLabel lblFactoryNo;
        private Component.XEditBox txtFactoryName;
        private Component.XLabel lblFactoryName;
        private Component.XNumberEditBox nebQuanlity;
        private Component.XLabel lblQuanlity;
        private Component.XEditBox txtModel;
        private Component.XLabel lblModel;
    }
}