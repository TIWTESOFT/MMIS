namespace MMIS.UI
{
    public partial class frmEquipmentCheckEdit
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
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem13 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem14 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem15 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem16 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem17 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem18 = new Janus.Windows.EditControls.UIComboBoxItem();
            this.lblEquipmentType = new MMIS.Component.XLabel();
            this.lblEquipmentCustId = new MMIS.Component.XLabel();
            this.lblEquipmentName = new MMIS.Component.XLabel();
            this.lblFactoryNo = new MMIS.Component.XLabel();
            this.lblSpec = new MMIS.Component.XLabel();
            this.lblModel = new MMIS.Component.XLabel();
            this.lblFactoryName = new MMIS.Component.XLabel();
            this.lblSourceTime = new MMIS.Component.XLabel();
            this.lblUseTime = new MMIS.Component.XLabel();
            this.lblSourceCustId = new MMIS.Component.XLabel();
            this.lblSourceTypeId = new MMIS.Component.XLabel();
            this.lblEquipmentStatusId = new MMIS.Component.XLabel();
            this.lblSignStatus = new MMIS.Component.XLabel();
            this.lblQuanlity = new MMIS.Component.XLabel();
            this.lblLinkMan = new MMIS.Component.XLabel();
            this.lblTel = new MMIS.Component.XLabel();
            this.lblEmail = new MMIS.Component.XLabel();
            this.lblCheckAccord = new MMIS.Component.XLabel();
            this.lblLastCheckDate = new MMIS.Component.XLabel();
            this.lblCheckResult = new MMIS.Component.XLabel();
            this.lblValidDate = new MMIS.Component.XLabel();
            this.lblCertNo = new MMIS.Component.XLabel();
            this.lblEquipmentDesc = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtEquipmentName = new MMIS.Component.XEditBox();
            this.txtFactoryNo = new MMIS.Component.XEditBox();
            this.txtSpec = new MMIS.Component.XEditBox();
            this.txtModel = new MMIS.Component.XEditBox();
            this.txtFactoryName = new MMIS.Component.XEditBox();
            this.dtSourceTime = new MMIS.Component.XDateTimePicker();
            this.dtUseTime = new MMIS.Component.XDateTimePicker();
            this.txtSourceCustId = new MMIS.Component.XEditBox();
            this.nebQuanlity = new MMIS.Component.XNumberEditBox();
            this.txtLinkMan = new MMIS.Component.XEditBox();
            this.txtTel = new MMIS.Component.XEditBox();
            this.txtEmail = new MMIS.Component.XEditBox();
            this.txtCheckAccord = new MMIS.Component.XEditBox();
            this.dtLastCheckDate = new MMIS.Component.XDateTimePicker();
            this.txtCheckResult = new MMIS.Component.XEditBox();
            this.dtValidDate = new MMIS.Component.XDateTimePicker();
            this.txtCertNo = new MMIS.Component.XEditBox();
            this.txtEquipmentDesc = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.cboSourceTypeId = new MMIS.Component.XCombobox();
            this.cboSignStatus = new MMIS.Component.XCombobox();
            this.txtEquipmentNo = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.txtBillNo = new MMIS.Component.XEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.lblCheckUserId = new MMIS.Component.XLabel();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.cbodevselect = new MMIS.Component.XCombobox();
            this.txtCheckUserId = new MMIS.UI.XSelectStaffInfoEditBox();
            this.txtEquipmentType = new MMIS.UI.XSelectCodeEquipmentTypeEditBox();
            this.txtEquipmentStatusId = new MMIS.UI.XSelectCodeEquipmentStateEditBox();
            this.txtEquipmentCustId = new MMIS.UI.XSelectEquipmentCustEditBox();
            this.xLabel4 = new MMIS.Component.XLabel();
            this.chkcopy = new MMIS.Component.XCheckBox();
            this.chknumtb = new MMIS.Component.XCheckBox();
            this.cbospec = new MMIS.Component.XCombobox();
            this.xLabel5 = new MMIS.Component.XLabel();
            this.grpupdate = new MMIS.Component.XGroupBox();
            this.dtCheckedDate = new MMIS.Component.XDateTimePicker();
            this.dtVerifyedDate = new MMIS.Component.XDateTimePicker();
            this.dtSignedDate = new MMIS.Component.XDateTimePicker();
            this.chkCheckedDate = new MMIS.Component.XCheckBox();
            this.chkVerifyedDate = new MMIS.Component.XCheckBox();
            this.chkSignedDate = new MMIS.Component.XCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.grpupdate)).BeginInit();
            this.grpupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(608, 364);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(695, 364);
            // 
            // lblEquipmentType
            // 
            this.lblEquipmentType.AutoSize = true;
            this.lblEquipmentType.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentType.Location = new System.Drawing.Point(269, 16);
            this.lblEquipmentType.Name = "lblEquipmentType";
            this.lblEquipmentType.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentType.TabIndex = 1;
            this.lblEquipmentType.Text = "设备类型";
            // 
            // lblEquipmentCustId
            // 
            this.lblEquipmentCustId.AutoSize = true;
            this.lblEquipmentCustId.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentCustId.Location = new System.Drawing.Point(10, 14);
            this.lblEquipmentCustId.Name = "lblEquipmentCustId";
            this.lblEquipmentCustId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentCustId.TabIndex = 2;
            this.lblEquipmentCustId.Text = "送检单位";
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentName.Location = new System.Drawing.Point(10, 45);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentName.TabIndex = 3;
            this.lblEquipmentName.Text = "设备名称";
            // 
            // lblFactoryNo
            // 
            this.lblFactoryNo.AutoSize = true;
            this.lblFactoryNo.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryNo.Location = new System.Drawing.Point(269, 75);
            this.lblFactoryNo.Name = "lblFactoryNo";
            this.lblFactoryNo.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryNo.TabIndex = 4;
            this.lblFactoryNo.Text = "出厂编号";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.ForeColor = System.Drawing.Color.Black;
            this.lblSpec.Location = new System.Drawing.Point(522, 46);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(32, 17);
            this.lblSpec.TabIndex = 5;
            this.lblSpec.Text = "规格";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(10, 76);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(32, 17);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "型号";
            // 
            // lblFactoryName
            // 
            this.lblFactoryName.AutoSize = true;
            this.lblFactoryName.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryName.Location = new System.Drawing.Point(269, 104);
            this.lblFactoryName.Name = "lblFactoryName";
            this.lblFactoryName.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryName.TabIndex = 7;
            this.lblFactoryName.Text = "制造单位";
            // 
            // lblSourceTime
            // 
            this.lblSourceTime.AutoSize = true;
            this.lblSourceTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSourceTime.Location = new System.Drawing.Point(269, 135);
            this.lblSourceTime.Name = "lblSourceTime";
            this.lblSourceTime.Size = new System.Drawing.Size(56, 17);
            this.lblSourceTime.TabIndex = 8;
            this.lblSourceTime.Text = "溯源时间";
            // 
            // lblUseTime
            // 
            this.lblUseTime.AutoSize = true;
            this.lblUseTime.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUseTime.Location = new System.Drawing.Point(523, 135);
            this.lblUseTime.Name = "lblUseTime";
            this.lblUseTime.Size = new System.Drawing.Size(56, 17);
            this.lblUseTime.TabIndex = 9;
            this.lblUseTime.Text = "接收时间";
            // 
            // lblSourceCustId
            // 
            this.lblSourceCustId.AutoSize = true;
            this.lblSourceCustId.ForeColor = System.Drawing.Color.Black;
            this.lblSourceCustId.Location = new System.Drawing.Point(-1, 563);
            this.lblSourceCustId.Name = "lblSourceCustId";
            this.lblSourceCustId.Size = new System.Drawing.Size(56, 17);
            this.lblSourceCustId.TabIndex = 10;
            this.lblSourceCustId.Text = "溯源单位";
            this.lblSourceCustId.Visible = false;
            // 
            // lblSourceTypeId
            // 
            this.lblSourceTypeId.AutoSize = true;
            this.lblSourceTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblSourceTypeId.Location = new System.Drawing.Point(523, 105);
            this.lblSourceTypeId.Name = "lblSourceTypeId";
            this.lblSourceTypeId.Size = new System.Drawing.Size(56, 17);
            this.lblSourceTypeId.TabIndex = 11;
            this.lblSourceTypeId.Text = "溯源方式";
            // 
            // lblEquipmentStatusId
            // 
            this.lblEquipmentStatusId.AutoSize = true;
            this.lblEquipmentStatusId.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentStatusId.Location = new System.Drawing.Point(9, 189);
            this.lblEquipmentStatusId.Name = "lblEquipmentStatusId";
            this.lblEquipmentStatusId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentStatusId.TabIndex = 12;
            this.lblEquipmentStatusId.Text = "设备状态";
            this.lblEquipmentStatusId.Visible = false;
            // 
            // lblSignStatus
            // 
            this.lblSignStatus.AutoSize = true;
            this.lblSignStatus.ForeColor = System.Drawing.Color.Black;
            this.lblSignStatus.Location = new System.Drawing.Point(58, 566);
            this.lblSignStatus.Name = "lblSignStatus";
            this.lblSignStatus.Size = new System.Drawing.Size(56, 17);
            this.lblSignStatus.TabIndex = 13;
            this.lblSignStatus.Text = "标识状态";
            this.lblSignStatus.Visible = false;
            // 
            // lblQuanlity
            // 
            this.lblQuanlity.AutoSize = true;
            this.lblQuanlity.ForeColor = System.Drawing.Color.Black;
            this.lblQuanlity.Location = new System.Drawing.Point(126, 528);
            this.lblQuanlity.Name = "lblQuanlity";
            this.lblQuanlity.Size = new System.Drawing.Size(32, 17);
            this.lblQuanlity.TabIndex = 14;
            this.lblQuanlity.Text = "数量";
            this.lblQuanlity.Visible = false;
            // 
            // lblLinkMan
            // 
            this.lblLinkMan.AutoSize = true;
            this.lblLinkMan.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblLinkMan.Location = new System.Drawing.Point(10, 164);
            this.lblLinkMan.Name = "lblLinkMan";
            this.lblLinkMan.Size = new System.Drawing.Size(44, 17);
            this.lblLinkMan.TabIndex = 15;
            this.lblLinkMan.Text = "联系人";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTel.Location = new System.Drawing.Point(269, 165);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(32, 17);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "手机";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(523, -12);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 17);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "电子邮件";
            this.lblEmail.Visible = false;
            // 
            // lblCheckAccord
            // 
            this.lblCheckAccord.AutoSize = true;
            this.lblCheckAccord.ForeColor = System.Drawing.Color.Black;
            this.lblCheckAccord.Location = new System.Drawing.Point(268, -14);
            this.lblCheckAccord.Name = "lblCheckAccord";
            this.lblCheckAccord.Size = new System.Drawing.Size(56, 17);
            this.lblCheckAccord.TabIndex = 18;
            this.lblCheckAccord.Text = "检定依据";
            this.lblCheckAccord.Visible = false;
            // 
            // lblLastCheckDate
            // 
            this.lblLastCheckDate.AutoSize = true;
            this.lblLastCheckDate.ForeColor = System.Drawing.Color.Black;
            this.lblLastCheckDate.Location = new System.Drawing.Point(34, 509);
            this.lblLastCheckDate.Name = "lblLastCheckDate";
            this.lblLastCheckDate.Size = new System.Drawing.Size(80, 17);
            this.lblLastCheckDate.TabIndex = 19;
            this.lblLastCheckDate.Text = "最后检定日期";
            this.lblLastCheckDate.Visible = false;
            // 
            // lblCheckResult
            // 
            this.lblCheckResult.AutoSize = true;
            this.lblCheckResult.ForeColor = System.Drawing.Color.Black;
            this.lblCheckResult.Location = new System.Drawing.Point(12, 505);
            this.lblCheckResult.Name = "lblCheckResult";
            this.lblCheckResult.Size = new System.Drawing.Size(56, 17);
            this.lblCheckResult.TabIndex = 20;
            this.lblCheckResult.Text = "检定结论";
            this.lblCheckResult.Visible = false;
            // 
            // lblValidDate
            // 
            this.lblValidDate.AutoSize = true;
            this.lblValidDate.ForeColor = System.Drawing.Color.Black;
            this.lblValidDate.Location = new System.Drawing.Point(271, 505);
            this.lblValidDate.Name = "lblValidDate";
            this.lblValidDate.Size = new System.Drawing.Size(56, 17);
            this.lblValidDate.TabIndex = 21;
            this.lblValidDate.Text = "有效日期";
            this.lblValidDate.Visible = false;
            // 
            // lblCertNo
            // 
            this.lblCertNo.AutoSize = true;
            this.lblCertNo.ForeColor = System.Drawing.Color.Black;
            this.lblCertNo.Location = new System.Drawing.Point(523, 505);
            this.lblCertNo.Name = "lblCertNo";
            this.lblCertNo.Size = new System.Drawing.Size(80, 17);
            this.lblCertNo.TabIndex = 22;
            this.lblCertNo.Text = "检定证书编号";
            this.lblCertNo.Visible = false;
            // 
            // lblEquipmentDesc
            // 
            this.lblEquipmentDesc.AutoSize = true;
            this.lblEquipmentDesc.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentDesc.Location = new System.Drawing.Point(10, 193);
            this.lblEquipmentDesc.Name = "lblEquipmentDesc";
            this.lblEquipmentDesc.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentDesc.TabIndex = 23;
            this.lblEquipmentDesc.Text = "设备描述";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(10, 256);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 24;
            this.lblRemark.Text = "备注信息";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.IsAllowEmpty = false;
            this.txtEquipmentName.Location = new System.Drawing.Point(72, 42);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentName.TabIndex = 3;
            this.txtEquipmentName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFactoryNo
            // 
            this.txtFactoryNo.IsAllowEmpty = true;
            this.txtFactoryNo.Location = new System.Drawing.Point(331, 72);
            this.txtFactoryNo.Name = "txtFactoryNo";
            this.txtFactoryNo.Size = new System.Drawing.Size(185, 23);
            this.txtFactoryNo.TabIndex = 7;
            this.txtFactoryNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpec
            // 
            this.txtSpec.IsAllowEmpty = true;
            this.txtSpec.Location = new System.Drawing.Point(585, 43);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(185, 23);
            this.txtSpec.TabIndex = 5;
            this.txtSpec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtModel
            // 
            this.txtModel.IsAllowEmpty = true;
            this.txtModel.Location = new System.Drawing.Point(72, 73);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(185, 23);
            this.txtModel.TabIndex = 6;
            this.txtModel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFactoryName
            // 
            this.txtFactoryName.IsAllowEmpty = true;
            this.txtFactoryName.Location = new System.Drawing.Point(331, 101);
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.Size = new System.Drawing.Size(185, 23);
            this.txtFactoryName.TabIndex = 9;
            this.txtFactoryName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtSourceTime
            // 
            this.dtSourceTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtSourceTime.DropDownCalendar.Name = "";
            this.dtSourceTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtSourceTime.Location = new System.Drawing.Point(331, 132);
            this.dtSourceTime.Name = "dtSourceTime";
            this.dtSourceTime.Size = new System.Drawing.Size(185, 23);
            this.dtSourceTime.TabIndex = 12;
            this.dtSourceTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtUseTime
            // 
            this.dtUseTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtUseTime.DropDownCalendar.Name = "";
            this.dtUseTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtUseTime.Location = new System.Drawing.Point(585, 132);
            this.dtUseTime.Name = "dtUseTime";
            this.dtUseTime.Size = new System.Drawing.Size(185, 23);
            this.dtUseTime.TabIndex = 13;
            this.dtUseTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtSourceCustId
            // 
            this.txtSourceCustId.IsAllowEmpty = true;
            this.txtSourceCustId.Location = new System.Drawing.Point(776, 192);
            this.txtSourceCustId.Name = "txtSourceCustId";
            this.txtSourceCustId.Size = new System.Drawing.Size(15, 23);
            this.txtSourceCustId.TabIndex = 10;
            this.txtSourceCustId.Visible = false;
            this.txtSourceCustId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebQuanlity
            // 
            this.nebQuanlity.FormatString = "0";
            this.nebQuanlity.IsAllowEmpty = false;
            this.nebQuanlity.IsAllowLessThanZero = false;
            this.nebQuanlity.IsAllowZero = false;
            this.nebQuanlity.Location = new System.Drawing.Point(72, 102);
            this.nebQuanlity.Name = "nebQuanlity";
            this.nebQuanlity.Size = new System.Drawing.Size(185, 23);
            this.nebQuanlity.TabIndex = 8;
            this.nebQuanlity.Text = "0";
            this.nebQuanlity.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebQuanlity.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtLinkMan
            // 
            this.txtLinkMan.IsAllowEmpty = true;
            this.txtLinkMan.Location = new System.Drawing.Point(72, 161);
            this.txtLinkMan.Name = "txtLinkMan";
            this.txtLinkMan.Size = new System.Drawing.Size(185, 23);
            this.txtLinkMan.TabIndex = 14;
            this.txtLinkMan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtTel
            // 
            this.txtTel.IsAllowEmpty = true;
            this.txtTel.Location = new System.Drawing.Point(331, 161);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 23);
            this.txtTel.TabIndex = 15;
            this.txtTel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEmail
            // 
            this.txtEmail.IsAllowEmpty = true;
            this.txtEmail.Location = new System.Drawing.Point(585, -15);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 23);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Visible = false;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCheckAccord
            // 
            this.txtCheckAccord.IsAllowEmpty = true;
            this.txtCheckAccord.Location = new System.Drawing.Point(331, -16);
            this.txtCheckAccord.Name = "txtCheckAccord";
            this.txtCheckAccord.Size = new System.Drawing.Size(185, 23);
            this.txtCheckAccord.TabIndex = 16;
            this.txtCheckAccord.Visible = false;
            this.txtCheckAccord.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtLastCheckDate
            // 
            this.dtLastCheckDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtLastCheckDate.DropDownCalendar.Name = "";
            this.dtLastCheckDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtLastCheckDate.Location = new System.Drawing.Point(115, 506);
            this.dtLastCheckDate.Name = "dtLastCheckDate";
            this.dtLastCheckDate.Size = new System.Drawing.Size(185, 23);
            this.dtLastCheckDate.TabIndex = 19;
            this.dtLastCheckDate.Visible = false;
            this.dtLastCheckDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtCheckResult
            // 
            this.txtCheckResult.IsAllowEmpty = true;
            this.txtCheckResult.Location = new System.Drawing.Point(72, 338);
            this.txtCheckResult.Name = "txtCheckResult";
            this.txtCheckResult.Size = new System.Drawing.Size(185, 23);
            this.txtCheckResult.TabIndex = 20;
            this.txtCheckResult.Visible = false;
            this.txtCheckResult.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtValidDate
            // 
            this.dtValidDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtValidDate.DropDownCalendar.Name = "";
            this.dtValidDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtValidDate.Location = new System.Drawing.Point(333, 502);
            this.dtValidDate.Name = "dtValidDate";
            this.dtValidDate.Size = new System.Drawing.Size(185, 23);
            this.dtValidDate.TabIndex = 21;
            this.dtValidDate.Visible = false;
            this.dtValidDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtCertNo
            // 
            this.txtCertNo.IsAllowEmpty = true;
            this.txtCertNo.Location = new System.Drawing.Point(605, 502);
            this.txtCertNo.Name = "txtCertNo";
            this.txtCertNo.Size = new System.Drawing.Size(185, 23);
            this.txtCertNo.TabIndex = 22;
            this.txtCertNo.Visible = false;
            this.txtCertNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEquipmentDesc
            // 
            this.txtEquipmentDesc.IsAllowEmpty = true;
            this.txtEquipmentDesc.Location = new System.Drawing.Point(72, 193);
            this.txtEquipmentDesc.Multiline = true;
            this.txtEquipmentDesc.Name = "txtEquipmentDesc";
            this.txtEquipmentDesc.Size = new System.Drawing.Size(698, 51);
            this.txtEquipmentDesc.TabIndex = 18;
            this.txtEquipmentDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(72, 253);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(698, 58);
            this.txtRemark.TabIndex = 19;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cboSourceTypeId
            // 
            this.cboSourceTypeId.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboSourceTypeId.IsAllowEmpty = false;
            uiComboBoxItem13.FormatStyle.Alpha = 0;
            uiComboBoxItem13.IsSeparator = false;
            uiComboBoxItem13.Text = "检定";
            uiComboBoxItem13.Value = "检定";
            uiComboBoxItem14.FormatStyle.Alpha = 0;
            uiComboBoxItem14.IsSeparator = false;
            uiComboBoxItem14.Text = "校准";
            uiComboBoxItem14.Value = "校准";
            uiComboBoxItem15.FormatStyle.Alpha = 0;
            uiComboBoxItem15.IsSeparator = false;
            uiComboBoxItem15.Text = "测试";
            uiComboBoxItem15.Value = "测试";
            this.cboSourceTypeId.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem13,
            uiComboBoxItem14,
            uiComboBoxItem15});
            this.cboSourceTypeId.Location = new System.Drawing.Point(585, 102);
            this.cboSourceTypeId.Name = "cboSourceTypeId";
            this.cboSourceTypeId.Size = new System.Drawing.Size(185, 23);
            this.cboSourceTypeId.TabIndex = 10;
            this.cboSourceTypeId.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // cboSignStatus
            // 
            this.cboSignStatus.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboSignStatus.IsAllowEmpty = true;
            uiComboBoxItem16.FormatStyle.Alpha = 0;
            uiComboBoxItem16.IsSeparator = false;
            uiComboBoxItem16.Text = "绿色";
            uiComboBoxItem16.Value = "绿色";
            uiComboBoxItem17.FormatStyle.Alpha = 0;
            uiComboBoxItem17.IsSeparator = false;
            uiComboBoxItem17.Text = "黄色";
            uiComboBoxItem17.Value = "黄色";
            uiComboBoxItem18.FormatStyle.Alpha = 0;
            uiComboBoxItem18.IsSeparator = false;
            uiComboBoxItem18.Text = "红色";
            uiComboBoxItem18.Value = "红色";
            this.cboSignStatus.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem16,
            uiComboBoxItem17,
            uiComboBoxItem18});
            this.cboSignStatus.Location = new System.Drawing.Point(139, 563);
            this.cboSignStatus.Name = "cboSignStatus";
            this.cboSignStatus.Size = new System.Drawing.Size(185, 23);
            this.cboSignStatus.TabIndex = 105;
            this.cboSignStatus.Visible = false;
            this.cboSignStatus.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtEquipmentNo
            // 
            this.txtEquipmentNo.IsAllowEmpty = false;
            this.txtEquipmentNo.Location = new System.Drawing.Point(331, 43);
            this.txtEquipmentNo.Name = "txtEquipmentNo";
            this.txtEquipmentNo.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentNo.TabIndex = 4;
            this.txtEquipmentNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(268, 46);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 107;
            this.xLabel1.Text = "设备编号";
            // 
            // txtBillNo
            // 
            this.txtBillNo.IsAllowEmpty = true;
            this.txtBillNo.Location = new System.Drawing.Point(585, 161);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(185, 23);
            this.txtBillNo.TabIndex = 16;
            this.txtBillNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(524, 164);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 110;
            this.xLabel2.Text = "扫码编号";
            // 
            // lblCheckUserId
            // 
            this.lblCheckUserId.AutoSize = true;
            this.lblCheckUserId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCheckUserId.ForeColor = System.Drawing.Color.Blue;
            this.lblCheckUserId.Location = new System.Drawing.Point(6, 135);
            this.lblCheckUserId.Name = "lblCheckUserId";
            this.lblCheckUserId.Size = new System.Drawing.Size(68, 17);
            this.lblCheckUserId.TabIndex = 111;
            this.lblCheckUserId.Text = "指定检定员";
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(523, 15);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 7;
            this.xLabel3.Text = "设备选项";
            // 
            // cbodevselect
            // 
            this.cbodevselect.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cbodevselect.IsAllowEmpty = false;
            this.cbodevselect.Location = new System.Drawing.Point(585, 13);
            this.cbodevselect.Name = "cbodevselect";
            this.cbodevselect.Size = new System.Drawing.Size(185, 23);
            this.cbodevselect.TabIndex = 2;
            this.cbodevselect.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbodevselect.SelectedIndexChanged += new System.EventHandler(this.cbodevselect_SelectedIndexChanged);
            // 
            // txtCheckUserId
            // 
            this.txtCheckUserId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtCheckUserId.DisplayMember = "";
            this.txtCheckUserId.IsAllowEmpty = false;
            this.txtCheckUserId.Location = new System.Drawing.Point(72, 132);
            this.txtCheckUserId.Name = "txtCheckUserId";
            this.txtCheckUserId.QueryCheckBox = null;
            this.txtCheckUserId.QueryFieldName = null;
            this.txtCheckUserId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtCheckUserId.ReadOnly = true;
            this.txtCheckUserId.SelectedModel = null;
            this.txtCheckUserId.Size = new System.Drawing.Size(185, 23);
            this.txtCheckUserId.TabIndex = 11;
            this.txtCheckUserId.ValueMember = "";
            this.txtCheckUserId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEquipmentType
            // 
            this.txtEquipmentType.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtEquipmentType.DisplayMember = "";
            this.txtEquipmentType.IsAllowEmpty = false;
            this.txtEquipmentType.Location = new System.Drawing.Point(331, 13);
            this.txtEquipmentType.Name = "txtEquipmentType";
            this.txtEquipmentType.QueryCheckBox = null;
            this.txtEquipmentType.QueryFieldName = null;
            this.txtEquipmentType.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtEquipmentType.ReadOnly = true;
            this.txtEquipmentType.SelectedModel = null;
            this.txtEquipmentType.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentType.TabIndex = 1;
            this.txtEquipmentType.ValueMember = "";
            this.txtEquipmentType.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtEquipmentType.TextChanged += new System.EventHandler(this.txtEquipmentType_TextChanged);
            // 
            // txtEquipmentStatusId
            // 
            this.txtEquipmentStatusId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtEquipmentStatusId.DisplayMember = "";
            this.txtEquipmentStatusId.IsAllowEmpty = false;
            this.txtEquipmentStatusId.Location = new System.Drawing.Point(72, 186);
            this.txtEquipmentStatusId.Name = "txtEquipmentStatusId";
            this.txtEquipmentStatusId.QueryCheckBox = null;
            this.txtEquipmentStatusId.QueryFieldName = null;
            this.txtEquipmentStatusId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtEquipmentStatusId.ReadOnly = true;
            this.txtEquipmentStatusId.SelectedModel = null;
            this.txtEquipmentStatusId.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentStatusId.TabIndex = 17;
            this.txtEquipmentStatusId.ValueMember = "";
            this.txtEquipmentStatusId.Visible = false;
            this.txtEquipmentStatusId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEquipmentCustId
            // 
            this.txtEquipmentCustId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtEquipmentCustId.DisplayMember = "";
            this.txtEquipmentCustId.IsAllowEmpty = false;
            this.txtEquipmentCustId.Location = new System.Drawing.Point(72, 11);
            this.txtEquipmentCustId.Name = "txtEquipmentCustId";
            this.txtEquipmentCustId.QueryCheckBox = null;
            this.txtEquipmentCustId.QueryFieldName = null;
            this.txtEquipmentCustId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtEquipmentCustId.ReadOnly = true;
            this.txtEquipmentCustId.SelectedModel = null;
            this.txtEquipmentCustId.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentCustId.TabIndex = 0;
            this.txtEquipmentCustId.ValueMember = "";
            this.txtEquipmentCustId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtEquipmentCustId.TextChanged += new System.EventHandler(this.txtEquipmentCustId_TextChanged);
            // 
            // xLabel4
            // 
            this.xLabel4.AutoSize = true;
            this.xLabel4.ForeColor = System.Drawing.Color.DarkGreen;
            this.xLabel4.Location = new System.Drawing.Point(10, 106);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(32, 17);
            this.xLabel4.TabIndex = 16;
            this.xLabel4.Text = "数量";
            // 
            // chkcopy
            // 
            this.chkcopy.Location = new System.Drawing.Point(458, 369);
            this.chkcopy.Model = null;
            this.chkcopy.Name = "chkcopy";
            this.chkcopy.Size = new System.Drawing.Size(104, 23);
            this.chkcopy.TabIndex = 112;
            this.chkcopy.Text = "另存当前信息";
            this.chkcopy.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // chknumtb
            // 
            this.chknumtb.ForeColor = System.Drawing.Color.DarkGreen;
            this.chknumtb.Location = new System.Drawing.Point(75, 370);
            this.chknumtb.Model = null;
            this.chknumtb.Name = "chknumtb";
            this.chknumtb.Size = new System.Drawing.Size(144, 23);
            this.chknumtb.TabIndex = 113;
            this.chknumtb.Text = "数量同步至接检核签";
            this.chknumtb.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // cbospec
            // 
            this.cbospec.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cbospec.IsAllowEmpty = true;
            this.cbospec.Location = new System.Drawing.Point(585, 73);
            this.cbospec.Name = "cbospec";
            this.cbospec.Size = new System.Drawing.Size(185, 23);
            this.cbospec.TabIndex = 114;
            this.cbospec.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbospec.SelectedIndexChanged += new System.EventHandler(this.cbospec_SelectedIndexChanged);
            // 
            // xLabel5
            // 
            this.xLabel5.AutoSize = true;
            this.xLabel5.ForeColor = System.Drawing.Color.DarkRed;
            this.xLabel5.Location = new System.Drawing.Point(523, 75);
            this.xLabel5.Name = "xLabel5";
            this.xLabel5.Size = new System.Drawing.Size(64, 17);
            this.xLabel5.TabIndex = 115;
            this.xLabel5.Text = "规格(手选)";
            // 
            // grpupdate
            // 
            this.grpupdate.Controls.Add(this.dtSignedDate);
            this.grpupdate.Controls.Add(this.chkSignedDate);
            this.grpupdate.Controls.Add(this.dtVerifyedDate);
            this.grpupdate.Controls.Add(this.chkVerifyedDate);
            this.grpupdate.Controls.Add(this.dtCheckedDate);
            this.grpupdate.Controls.Add(this.chkCheckedDate);
            this.grpupdate.Location = new System.Drawing.Point(72, 312);
            this.grpupdate.Name = "grpupdate";
            this.grpupdate.Size = new System.Drawing.Size(698, 46);
            this.grpupdate.TabIndex = 116;
            this.grpupdate.Text = "同步更新检核签时间";
            this.grpupdate.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // dtCheckedDate
            // 
            this.dtCheckedDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtCheckedDate.DropDownCalendar.Name = "";
            this.dtCheckedDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtCheckedDate.Location = new System.Drawing.Point(89, 17);
            this.dtCheckedDate.Name = "dtCheckedDate";
            this.dtCheckedDate.Size = new System.Drawing.Size(117, 23);
            this.dtCheckedDate.TabIndex = 13;
            this.dtCheckedDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtVerifyedDate
            // 
            this.dtVerifyedDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtVerifyedDate.DropDownCalendar.Name = "";
            this.dtVerifyedDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtVerifyedDate.Location = new System.Drawing.Point(301, 17);
            this.dtVerifyedDate.Name = "dtVerifyedDate";
            this.dtVerifyedDate.Size = new System.Drawing.Size(117, 23);
            this.dtVerifyedDate.TabIndex = 13;
            this.dtVerifyedDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtSignedDate
            // 
            this.dtSignedDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtSignedDate.DropDownCalendar.Name = "";
            this.dtSignedDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtSignedDate.Location = new System.Drawing.Point(511, 17);
            this.dtSignedDate.Name = "dtSignedDate";
            this.dtSignedDate.Size = new System.Drawing.Size(117, 23);
            this.dtSignedDate.TabIndex = 13;
            this.dtSignedDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // chkCheckedDate
            // 
            this.chkCheckedDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkCheckedDate.Location = new System.Drawing.Point(6, 18);
            this.chkCheckedDate.Model = null;
            this.chkCheckedDate.Name = "chkCheckedDate";
            this.chkCheckedDate.Size = new System.Drawing.Size(92, 23);
            this.chkCheckedDate.TabIndex = 113;
            this.chkCheckedDate.Text = "检定时间";
            this.chkCheckedDate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // chkVerifyedDate
            // 
            this.chkVerifyedDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkVerifyedDate.Location = new System.Drawing.Point(214, 18);
            this.chkVerifyedDate.Model = null;
            this.chkVerifyedDate.Name = "chkVerifyedDate";
            this.chkVerifyedDate.Size = new System.Drawing.Size(92, 23);
            this.chkVerifyedDate.TabIndex = 114;
            this.chkVerifyedDate.Text = "核验时间";
            this.chkVerifyedDate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // chkSignedDate
            // 
            this.chkSignedDate.ForeColor = System.Drawing.Color.DarkGreen;
            this.chkSignedDate.Location = new System.Drawing.Point(428, 17);
            this.chkSignedDate.Model = null;
            this.chkSignedDate.Name = "chkSignedDate";
            this.chkSignedDate.Size = new System.Drawing.Size(92, 23);
            this.chkSignedDate.TabIndex = 115;
            this.chkSignedDate.Text = "签发时间";
            this.chkSignedDate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // frmEquipmentCheckEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(788, 403);
            this.Controls.Add(this.grpupdate);
            this.Controls.Add(this.cbospec);
            this.Controls.Add(this.xLabel5);
            this.Controls.Add(this.chknumtb);
            this.Controls.Add(this.chkcopy);
            this.Controls.Add(this.txtCheckUserId);
            this.Controls.Add(this.lblCheckUserId);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.txtEquipmentType);
            this.Controls.Add(this.txtEquipmentStatusId);
            this.Controls.Add(this.txtEquipmentNo);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.cboSignStatus);
            this.Controls.Add(this.cbodevselect);
            this.Controls.Add(this.cboSourceTypeId);
            this.Controls.Add(this.txtEquipmentCustId);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.txtFactoryNo);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtFactoryName);
            this.Controls.Add(this.dtSourceTime);
            this.Controls.Add(this.dtUseTime);
            this.Controls.Add(this.txtSourceCustId);
            this.Controls.Add(this.nebQuanlity);
            this.Controls.Add(this.txtLinkMan);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCheckAccord);
            this.Controls.Add(this.dtLastCheckDate);
            this.Controls.Add(this.txtCheckResult);
            this.Controls.Add(this.dtValidDate);
            this.Controls.Add(this.txtCertNo);
            this.Controls.Add(this.txtEquipmentDesc);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblEquipmentType);
            this.Controls.Add(this.lblEquipmentCustId);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.lblFactoryNo);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.xLabel3);
            this.Controls.Add(this.lblFactoryName);
            this.Controls.Add(this.lblSourceTime);
            this.Controls.Add(this.lblUseTime);
            this.Controls.Add(this.lblSourceCustId);
            this.Controls.Add(this.lblSourceTypeId);
            this.Controls.Add(this.lblEquipmentStatusId);
            this.Controls.Add(this.lblSignStatus);
            this.Controls.Add(this.lblQuanlity);
            this.Controls.Add(this.lblLinkMan);
            this.Controls.Add(this.xLabel4);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCheckAccord);
            this.Controls.Add(this.lblLastCheckDate);
            this.Controls.Add(this.lblCheckResult);
            this.Controls.Add(this.lblValidDate);
            this.Controls.Add(this.lblCertNo);
            this.Controls.Add(this.lblEquipmentDesc);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmEquipmentCheckEdit";
            this.Text = "送检设备";
            this.Load += new System.EventHandler(this.frmEquipmentCheckEdit_Load);
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblEquipmentDesc, 0);
            this.Controls.SetChildIndex(this.lblCertNo, 0);
            this.Controls.SetChildIndex(this.lblValidDate, 0);
            this.Controls.SetChildIndex(this.lblCheckResult, 0);
            this.Controls.SetChildIndex(this.lblLastCheckDate, 0);
            this.Controls.SetChildIndex(this.lblCheckAccord, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblTel, 0);
            this.Controls.SetChildIndex(this.xLabel4, 0);
            this.Controls.SetChildIndex(this.lblLinkMan, 0);
            this.Controls.SetChildIndex(this.lblQuanlity, 0);
            this.Controls.SetChildIndex(this.lblSignStatus, 0);
            this.Controls.SetChildIndex(this.lblEquipmentStatusId, 0);
            this.Controls.SetChildIndex(this.lblSourceTypeId, 0);
            this.Controls.SetChildIndex(this.lblSourceCustId, 0);
            this.Controls.SetChildIndex(this.lblUseTime, 0);
            this.Controls.SetChildIndex(this.lblSourceTime, 0);
            this.Controls.SetChildIndex(this.lblFactoryName, 0);
            this.Controls.SetChildIndex(this.xLabel3, 0);
            this.Controls.SetChildIndex(this.lblModel, 0);
            this.Controls.SetChildIndex(this.lblSpec, 0);
            this.Controls.SetChildIndex(this.lblFactoryNo, 0);
            this.Controls.SetChildIndex(this.lblEquipmentName, 0);
            this.Controls.SetChildIndex(this.lblEquipmentCustId, 0);
            this.Controls.SetChildIndex(this.lblEquipmentType, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtEquipmentDesc, 0);
            this.Controls.SetChildIndex(this.txtCertNo, 0);
            this.Controls.SetChildIndex(this.dtValidDate, 0);
            this.Controls.SetChildIndex(this.txtCheckResult, 0);
            this.Controls.SetChildIndex(this.dtLastCheckDate, 0);
            this.Controls.SetChildIndex(this.txtCheckAccord, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtTel, 0);
            this.Controls.SetChildIndex(this.txtLinkMan, 0);
            this.Controls.SetChildIndex(this.nebQuanlity, 0);
            this.Controls.SetChildIndex(this.txtSourceCustId, 0);
            this.Controls.SetChildIndex(this.dtUseTime, 0);
            this.Controls.SetChildIndex(this.dtSourceTime, 0);
            this.Controls.SetChildIndex(this.txtFactoryName, 0);
            this.Controls.SetChildIndex(this.txtModel, 0);
            this.Controls.SetChildIndex(this.txtSpec, 0);
            this.Controls.SetChildIndex(this.txtFactoryNo, 0);
            this.Controls.SetChildIndex(this.txtEquipmentName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtEquipmentCustId, 0);
            this.Controls.SetChildIndex(this.cboSourceTypeId, 0);
            this.Controls.SetChildIndex(this.cbodevselect, 0);
            this.Controls.SetChildIndex(this.cboSignStatus, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtEquipmentNo, 0);
            this.Controls.SetChildIndex(this.txtEquipmentStatusId, 0);
            this.Controls.SetChildIndex(this.txtEquipmentType, 0);
            this.Controls.SetChildIndex(this.xLabel2, 0);
            this.Controls.SetChildIndex(this.txtBillNo, 0);
            this.Controls.SetChildIndex(this.lblCheckUserId, 0);
            this.Controls.SetChildIndex(this.txtCheckUserId, 0);
            this.Controls.SetChildIndex(this.chkcopy, 0);
            this.Controls.SetChildIndex(this.chknumtb, 0);
            this.Controls.SetChildIndex(this.xLabel5, 0);
            this.Controls.SetChildIndex(this.cbospec, 0);
            this.Controls.SetChildIndex(this.grpupdate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grpupdate)).EndInit();
            this.grpupdate.ResumeLayout(false);
            this.grpupdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblEquipmentType;
        private MMIS.Component.XLabel lblEquipmentCustId;
        private MMIS.Component.XLabel lblEquipmentName;
        private MMIS.Component.XLabel lblFactoryNo;
        private MMIS.Component.XLabel lblSpec;
        private MMIS.Component.XLabel lblModel;
        private MMIS.Component.XLabel lblFactoryName;
        private MMIS.Component.XLabel lblSourceTime;
        private MMIS.Component.XLabel lblUseTime;
        private MMIS.Component.XLabel lblSourceCustId;
        private MMIS.Component.XLabel lblSourceTypeId;
        private MMIS.Component.XLabel lblEquipmentStatusId;
        private MMIS.Component.XLabel lblSignStatus;
        private MMIS.Component.XLabel lblQuanlity;
        private MMIS.Component.XLabel lblLinkMan;
        private MMIS.Component.XLabel lblTel;
        private MMIS.Component.XLabel lblEmail;
        private MMIS.Component.XLabel lblCheckAccord;
        private MMIS.Component.XLabel lblLastCheckDate;
        private MMIS.Component.XLabel lblCheckResult;
        private MMIS.Component.XLabel lblValidDate;
        private MMIS.Component.XLabel lblCertNo;
        private MMIS.Component.XLabel lblEquipmentDesc;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtEquipmentName;
        private MMIS.Component.XEditBox txtFactoryNo;
        private MMIS.Component.XEditBox txtSpec;
        private MMIS.Component.XEditBox txtModel;
        private MMIS.Component.XEditBox txtFactoryName;
        private MMIS.Component.XDateTimePicker dtSourceTime;
        private MMIS.Component.XDateTimePicker dtUseTime;
        private MMIS.Component.XEditBox txtSourceCustId;
        private MMIS.Component.XNumberEditBox nebQuanlity;
        private MMIS.Component.XEditBox txtLinkMan;
        private MMIS.Component.XEditBox txtTel;
        private MMIS.Component.XEditBox txtEmail;
        private MMIS.Component.XEditBox txtCheckAccord;
        private MMIS.Component.XDateTimePicker dtLastCheckDate;
        private MMIS.Component.XEditBox txtCheckResult;
        private MMIS.Component.XDateTimePicker dtValidDate;
        private MMIS.Component.XEditBox txtCertNo;
        private MMIS.Component.XEditBox txtEquipmentDesc;
        private MMIS.Component.XEditBox txtRemark;
        private XSelectEquipmentCustEditBox txtEquipmentCustId;
        private Component.XCombobox cboSourceTypeId;
        private Component.XCombobox cboSignStatus;
        private Component.XEditBox txtEquipmentNo;
        private Component.XLabel xLabel1;
        private XSelectCodeEquipmentStateEditBox txtEquipmentStatusId;
        private XSelectCodeEquipmentTypeEditBox txtEquipmentType;
        private Component.XEditBox txtBillNo;
        private Component.XLabel xLabel2;
        private XSelectStaffInfoEditBox txtCheckUserId;
        private Component.XLabel lblCheckUserId;
        private Component.XLabel xLabel3;
        private Component.XCombobox cbodevselect;
        private Component.XLabel xLabel4;
        private Component.XCheckBox chkcopy;
        private Component.XCheckBox chknumtb;
        private Component.XCombobox cbospec;
        private Component.XLabel xLabel5;
        private Component.XGroupBox grpupdate;
        private Component.XDateTimePicker dtSignedDate;
        private Component.XDateTimePicker dtVerifyedDate;
        private Component.XDateTimePicker dtCheckedDate;
        private Component.XCheckBox chkSignedDate;
        private Component.XCheckBox chkVerifyedDate;
        private Component.XCheckBox chkCheckedDate;
        
    }
}