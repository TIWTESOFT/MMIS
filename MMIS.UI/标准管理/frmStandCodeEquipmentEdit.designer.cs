namespace MMIS.UI
{
    public partial class frmStandCodeEquipmentEdit
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
            this.lblEquipmentNo = new MMIS.Component.XLabel();
            this.txtEquipmentCustId = new MMIS.Component.XEditBox();
            this.txtEquipmentName = new MMIS.Component.XEditBox();
            this.txtFactoryNo = new MMIS.Component.XEditBox();
            this.txtSpec = new MMIS.Component.XEditBox();
            this.txtModel = new MMIS.Component.XEditBox();
            this.txtFactoryName = new MMIS.Component.XEditBox();
            this.dtSourceTime = new MMIS.Component.XDateTimePicker();
            this.dtUseTime = new MMIS.Component.XDateTimePicker();
            this.txtSourceCustId = new MMIS.Component.XEditBox();
            this.txtSignStatus = new MMIS.Component.XEditBox();
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
            this.txtEquipmentNo = new MMIS.Component.XEditBox();
            this.cboEquipmentType = new MMIS.Component.XCombobox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.cboSourceTypeId = new MMIS.Component.XCombobox();
            this.txtEquipmentStatusId = new MMIS.UI.XSelectCodeEquipmentStateEditBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(610, 194);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(697, 194);
            // 
            // lblEquipmentType
            // 
            this.lblEquipmentType.AutoSize = true;
            this.lblEquipmentType.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentType.Location = new System.Drawing.Point(11, 16);
            this.lblEquipmentType.Name = "lblEquipmentType";
            this.lblEquipmentType.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentType.TabIndex = 1;
            this.lblEquipmentType.Text = "设备类型";
            // 
            // lblEquipmentCustId
            // 
            this.lblEquipmentCustId.AutoSize = true;
            this.lblEquipmentCustId.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentCustId.Location = new System.Drawing.Point(22, 364);
            this.lblEquipmentCustId.Name = "lblEquipmentCustId";
            this.lblEquipmentCustId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentCustId.TabIndex = 2;
            this.lblEquipmentCustId.Text = "送检单位";
            this.lblEquipmentCustId.Visible = false;
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentName.Location = new System.Drawing.Point(268, 17);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentName.TabIndex = 3;
            this.lblEquipmentName.Text = "设备名称";
            // 
            // lblFactoryNo
            // 
            this.lblFactoryNo.AutoSize = true;
            this.lblFactoryNo.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryNo.Location = new System.Drawing.Point(525, 17);
            this.lblFactoryNo.Name = "lblFactoryNo";
            this.lblFactoryNo.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryNo.TabIndex = 4;
            this.lblFactoryNo.Text = "出厂编号";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.ForeColor = System.Drawing.Color.Black;
            this.lblSpec.Location = new System.Drawing.Point(268, 47);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(32, 17);
            this.lblSpec.TabIndex = 5;
            this.lblSpec.Text = "规格";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(22, 321);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(32, 17);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "型号";
            this.lblModel.Visible = false;
            // 
            // lblFactoryName
            // 
            this.lblFactoryName.AutoSize = true;
            this.lblFactoryName.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryName.Location = new System.Drawing.Point(525, 47);
            this.lblFactoryName.Name = "lblFactoryName";
            this.lblFactoryName.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryName.TabIndex = 7;
            this.lblFactoryName.Text = "制造单位";
            // 
            // lblSourceTime
            // 
            this.lblSourceTime.AutoSize = true;
            this.lblSourceTime.ForeColor = System.Drawing.Color.Black;
            this.lblSourceTime.Location = new System.Drawing.Point(11, 76);
            this.lblSourceTime.Name = "lblSourceTime";
            this.lblSourceTime.Size = new System.Drawing.Size(56, 17);
            this.lblSourceTime.TabIndex = 8;
            this.lblSourceTime.Text = "溯源时间";
            // 
            // lblUseTime
            // 
            this.lblUseTime.AutoSize = true;
            this.lblUseTime.ForeColor = System.Drawing.Color.Black;
            this.lblUseTime.Location = new System.Drawing.Point(268, 76);
            this.lblUseTime.Name = "lblUseTime";
            this.lblUseTime.Size = new System.Drawing.Size(56, 17);
            this.lblUseTime.TabIndex = 9;
            this.lblUseTime.Text = "使用时间";
            // 
            // lblSourceCustId
            // 
            this.lblSourceCustId.AutoSize = true;
            this.lblSourceCustId.ForeColor = System.Drawing.Color.Black;
            this.lblSourceCustId.Location = new System.Drawing.Point(11, 105);
            this.lblSourceCustId.Name = "lblSourceCustId";
            this.lblSourceCustId.Size = new System.Drawing.Size(56, 17);
            this.lblSourceCustId.TabIndex = 10;
            this.lblSourceCustId.Text = "溯源单位";
            // 
            // lblSourceTypeId
            // 
            this.lblSourceTypeId.AutoSize = true;
            this.lblSourceTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblSourceTypeId.Location = new System.Drawing.Point(525, 76);
            this.lblSourceTypeId.Name = "lblSourceTypeId";
            this.lblSourceTypeId.Size = new System.Drawing.Size(56, 17);
            this.lblSourceTypeId.TabIndex = 11;
            this.lblSourceTypeId.Text = "溯源方式";
            // 
            // lblEquipmentStatusId
            // 
            this.lblEquipmentStatusId.AutoSize = true;
            this.lblEquipmentStatusId.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentStatusId.Location = new System.Drawing.Point(525, 105);
            this.lblEquipmentStatusId.Name = "lblEquipmentStatusId";
            this.lblEquipmentStatusId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentStatusId.TabIndex = 12;
            this.lblEquipmentStatusId.Text = "设备状态";
            // 
            // lblSignStatus
            // 
            this.lblSignStatus.AutoSize = true;
            this.lblSignStatus.ForeColor = System.Drawing.Color.Black;
            this.lblSignStatus.Location = new System.Drawing.Point(22, 393);
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
            this.lblQuanlity.Location = new System.Drawing.Point(22, 423);
            this.lblQuanlity.Name = "lblQuanlity";
            this.lblQuanlity.Size = new System.Drawing.Size(32, 17);
            this.lblQuanlity.TabIndex = 14;
            this.lblQuanlity.Text = "数量";
            // 
            // lblLinkMan
            // 
            this.lblLinkMan.AutoSize = true;
            this.lblLinkMan.ForeColor = System.Drawing.Color.Black;
            this.lblLinkMan.Location = new System.Drawing.Point(22, 453);
            this.lblLinkMan.Name = "lblLinkMan";
            this.lblLinkMan.Size = new System.Drawing.Size(44, 17);
            this.lblLinkMan.TabIndex = 15;
            this.lblLinkMan.Text = "联系人";
            this.lblLinkMan.Visible = false;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(22, 483);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(32, 17);
            this.lblTel.TabIndex = 16;
            this.lblTel.Text = "电话";
            this.lblTel.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(22, 513);
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
            this.lblCheckAccord.Location = new System.Drawing.Point(22, 543);
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
            this.lblLastCheckDate.Location = new System.Drawing.Point(22, 573);
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
            this.lblCheckResult.Location = new System.Drawing.Point(22, 603);
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
            this.lblValidDate.Location = new System.Drawing.Point(22, 633);
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
            this.lblCertNo.Location = new System.Drawing.Point(22, 663);
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
            this.lblEquipmentDesc.Location = new System.Drawing.Point(11, 134);
            this.lblEquipmentDesc.Name = "lblEquipmentDesc";
            this.lblEquipmentDesc.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentDesc.TabIndex = 23;
            this.lblEquipmentDesc.Text = "设备描述";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(11, 163);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 24;
            this.lblRemark.Text = "备注信息";
            // 
            // lblEquipmentNo
            // 
            this.lblEquipmentNo.AutoSize = true;
            this.lblEquipmentNo.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentNo.Location = new System.Drawing.Point(22, 873);
            this.lblEquipmentNo.Name = "lblEquipmentNo";
            this.lblEquipmentNo.Size = new System.Drawing.Size(0, 17);
            this.lblEquipmentNo.TabIndex = 29;
            // 
            // txtEquipmentCustId
            // 
            this.txtEquipmentCustId.IsAllowEmpty = true;
            this.txtEquipmentCustId.Location = new System.Drawing.Point(84, 361);
            this.txtEquipmentCustId.Name = "txtEquipmentCustId";
            this.txtEquipmentCustId.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentCustId.TabIndex = 2;
            this.txtEquipmentCustId.Visible = false;
            this.txtEquipmentCustId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.IsAllowEmpty = false;
            this.txtEquipmentName.Location = new System.Drawing.Point(330, 14);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentName.TabIndex = 1;
            this.txtEquipmentName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFactoryNo
            // 
            this.txtFactoryNo.IsAllowEmpty = true;
            this.txtFactoryNo.Location = new System.Drawing.Point(587, 14);
            this.txtFactoryNo.Name = "txtFactoryNo";
            this.txtFactoryNo.Size = new System.Drawing.Size(185, 23);
            this.txtFactoryNo.TabIndex = 2;
            this.txtFactoryNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpec
            // 
            this.txtSpec.IsAllowEmpty = false;
            this.txtSpec.Location = new System.Drawing.Point(330, 44);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.Size = new System.Drawing.Size(185, 23);
            this.txtSpec.TabIndex = 4;
            this.txtSpec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtModel
            // 
            this.txtModel.IsAllowEmpty = false;
            this.txtModel.Location = new System.Drawing.Point(84, 318);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(185, 23);
            this.txtModel.TabIndex = 4;
            this.txtModel.Visible = false;
            this.txtModel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFactoryName
            // 
            this.txtFactoryName.IsAllowEmpty = true;
            this.txtFactoryName.Location = new System.Drawing.Point(587, 44);
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.Size = new System.Drawing.Size(185, 23);
            this.txtFactoryName.TabIndex = 5;
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
            this.dtSourceTime.Location = new System.Drawing.Point(73, 73);
            this.dtSourceTime.Name = "dtSourceTime";
            this.dtSourceTime.Size = new System.Drawing.Size(185, 23);
            this.dtSourceTime.TabIndex = 6;
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
            this.dtUseTime.Location = new System.Drawing.Point(330, 73);
            this.dtUseTime.Name = "dtUseTime";
            this.dtUseTime.Size = new System.Drawing.Size(185, 23);
            this.dtUseTime.TabIndex = 7;
            this.dtUseTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtSourceCustId
            // 
            this.txtSourceCustId.IsAllowEmpty = true;
            this.txtSourceCustId.Location = new System.Drawing.Point(73, 102);
            this.txtSourceCustId.Name = "txtSourceCustId";
            this.txtSourceCustId.Size = new System.Drawing.Size(442, 23);
            this.txtSourceCustId.TabIndex = 9;
            this.txtSourceCustId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSignStatus
            // 
            this.txtSignStatus.IsAllowEmpty = false;
            this.txtSignStatus.Location = new System.Drawing.Point(84, 390);
            this.txtSignStatus.Name = "txtSignStatus";
            this.txtSignStatus.Size = new System.Drawing.Size(185, 23);
            this.txtSignStatus.TabIndex = 13;
            this.txtSignStatus.Visible = false;
            this.txtSignStatus.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebQuanlity
            // 
            this.nebQuanlity.FormatString = "0";
            this.nebQuanlity.IsAllowEmpty = false;
            this.nebQuanlity.IsAllowLessThanZero = false;
            this.nebQuanlity.IsAllowZero = false;
            this.nebQuanlity.Location = new System.Drawing.Point(84, 420);
            this.nebQuanlity.Name = "nebQuanlity";
            this.nebQuanlity.Size = new System.Drawing.Size(185, 23);
            this.nebQuanlity.TabIndex = 101;
            this.nebQuanlity.Text = "1";
            this.nebQuanlity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nebQuanlity.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtLinkMan
            // 
            this.txtLinkMan.IsAllowEmpty = false;
            this.txtLinkMan.Location = new System.Drawing.Point(84, 450);
            this.txtLinkMan.Name = "txtLinkMan";
            this.txtLinkMan.Size = new System.Drawing.Size(185, 23);
            this.txtLinkMan.TabIndex = 15;
            this.txtLinkMan.Visible = false;
            this.txtLinkMan.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtTel
            // 
            this.txtTel.IsAllowEmpty = false;
            this.txtTel.Location = new System.Drawing.Point(84, 480);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 23);
            this.txtTel.TabIndex = 16;
            this.txtTel.Visible = false;
            this.txtTel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEmail
            // 
            this.txtEmail.IsAllowEmpty = false;
            this.txtEmail.Location = new System.Drawing.Point(84, 510);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 23);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Visible = false;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCheckAccord
            // 
            this.txtCheckAccord.IsAllowEmpty = false;
            this.txtCheckAccord.Location = new System.Drawing.Point(84, 540);
            this.txtCheckAccord.Name = "txtCheckAccord";
            this.txtCheckAccord.Size = new System.Drawing.Size(185, 23);
            this.txtCheckAccord.TabIndex = 18;
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
            this.dtLastCheckDate.Location = new System.Drawing.Point(84, 570);
            this.dtLastCheckDate.Name = "dtLastCheckDate";
            this.dtLastCheckDate.Size = new System.Drawing.Size(185, 23);
            this.dtLastCheckDate.TabIndex = 19;
            this.dtLastCheckDate.Visible = false;
            this.dtLastCheckDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtCheckResult
            // 
            this.txtCheckResult.IsAllowEmpty = false;
            this.txtCheckResult.Location = new System.Drawing.Point(84, 600);
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
            this.dtValidDate.Location = new System.Drawing.Point(84, 630);
            this.dtValidDate.Name = "dtValidDate";
            this.dtValidDate.Size = new System.Drawing.Size(185, 23);
            this.dtValidDate.TabIndex = 21;
            this.dtValidDate.Visible = false;
            this.dtValidDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtCertNo
            // 
            this.txtCertNo.IsAllowEmpty = false;
            this.txtCertNo.Location = new System.Drawing.Point(84, 660);
            this.txtCertNo.Name = "txtCertNo";
            this.txtCertNo.Size = new System.Drawing.Size(185, 23);
            this.txtCertNo.TabIndex = 22;
            this.txtCertNo.Visible = false;
            this.txtCertNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEquipmentDesc
            // 
            this.txtEquipmentDesc.IsAllowEmpty = true;
            this.txtEquipmentDesc.Location = new System.Drawing.Point(73, 131);
            this.txtEquipmentDesc.Name = "txtEquipmentDesc";
            this.txtEquipmentDesc.Size = new System.Drawing.Size(699, 23);
            this.txtEquipmentDesc.TabIndex = 11;
            this.txtEquipmentDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(73, 160);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(699, 23);
            this.txtRemark.TabIndex = 12;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEquipmentNo
            // 
            this.txtEquipmentNo.IsAllowEmpty = false;
            this.txtEquipmentNo.Location = new System.Drawing.Point(73, 44);
            this.txtEquipmentNo.Name = "txtEquipmentNo";
            this.txtEquipmentNo.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentNo.TabIndex = 3;
            this.txtEquipmentNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cboEquipmentType
            // 
            this.cboEquipmentType.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboEquipmentType.IsAllowEmpty = false;
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.IsSeparator = false;
            uiComboBoxItem1.Text = "送检设备";
            uiComboBoxItem1.Value = "送检设备";
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.IsSeparator = false;
            uiComboBoxItem2.Text = "标准设备";
            uiComboBoxItem2.Value = "标准设备";
            this.cboEquipmentType.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2});
            this.cboEquipmentType.Location = new System.Drawing.Point(73, 14);
            this.cboEquipmentType.Name = "cboEquipmentType";
            this.cboEquipmentType.Size = new System.Drawing.Size(185, 23);
            this.cboEquipmentType.TabIndex = 0;
            this.cboEquipmentType.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(11, 47);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 102;
            this.xLabel1.Text = "设备编号";
            // 
            // cboSourceTypeId
            // 
            this.cboSourceTypeId.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboSourceTypeId.IsAllowEmpty = true;
            uiComboBoxItem3.FormatStyle.Alpha = 0;
            uiComboBoxItem3.IsSeparator = false;
            uiComboBoxItem3.Text = "检定";
            uiComboBoxItem3.Value = "检定";
            uiComboBoxItem4.FormatStyle.Alpha = 0;
            uiComboBoxItem4.IsSeparator = false;
            uiComboBoxItem4.Text = "标准";
            uiComboBoxItem4.Value = "标准";
            uiComboBoxItem5.FormatStyle.Alpha = 0;
            uiComboBoxItem5.IsSeparator = false;
            uiComboBoxItem5.Text = "测试";
            uiComboBoxItem5.Value = "测试";
            this.cboSourceTypeId.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem3,
            uiComboBoxItem4,
            uiComboBoxItem5});
            this.cboSourceTypeId.Location = new System.Drawing.Point(587, 73);
            this.cboSourceTypeId.Name = "cboSourceTypeId";
            this.cboSourceTypeId.Size = new System.Drawing.Size(185, 23);
            this.cboSourceTypeId.TabIndex = 105;
            this.cboSourceTypeId.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtEquipmentStatusId
            // 
            this.txtEquipmentStatusId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtEquipmentStatusId.DisplayMember = "";
            this.txtEquipmentStatusId.IsAllowEmpty = false;
            this.txtEquipmentStatusId.Location = new System.Drawing.Point(587, 102);
            this.txtEquipmentStatusId.Name = "txtEquipmentStatusId";
            this.txtEquipmentStatusId.QueryCheckBox = null;
            this.txtEquipmentStatusId.QueryFieldName = null;
            this.txtEquipmentStatusId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtEquipmentStatusId.ReadOnly = true;
            this.txtEquipmentStatusId.SelectedModel = null;
            this.txtEquipmentStatusId.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentStatusId.TabIndex = 10;
            this.txtEquipmentStatusId.ValueMember = "";
            this.txtEquipmentStatusId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmStandCodeEquipmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(784, 233);
            this.Controls.Add(this.txtEquipmentStatusId);
            this.Controls.Add(this.cboSourceTypeId);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.cboEquipmentType);
            this.Controls.Add(this.txtEquipmentCustId);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.txtFactoryNo);
            this.Controls.Add(this.txtSpec);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtFactoryName);
            this.Controls.Add(this.dtSourceTime);
            this.Controls.Add(this.dtUseTime);
            this.Controls.Add(this.txtSourceCustId);
            this.Controls.Add(this.txtSignStatus);
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
            this.Controls.Add(this.txtEquipmentNo);
            this.Controls.Add(this.lblEquipmentType);
            this.Controls.Add(this.lblEquipmentCustId);
            this.Controls.Add(this.lblEquipmentName);
            this.Controls.Add(this.lblFactoryNo);
            this.Controls.Add(this.lblSpec);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblFactoryName);
            this.Controls.Add(this.lblSourceTime);
            this.Controls.Add(this.lblUseTime);
            this.Controls.Add(this.lblSourceCustId);
            this.Controls.Add(this.lblSourceTypeId);
            this.Controls.Add(this.lblEquipmentStatusId);
            this.Controls.Add(this.lblSignStatus);
            this.Controls.Add(this.lblQuanlity);
            this.Controls.Add(this.lblLinkMan);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCheckAccord);
            this.Controls.Add(this.lblLastCheckDate);
            this.Controls.Add(this.lblCheckResult);
            this.Controls.Add(this.lblValidDate);
            this.Controls.Add(this.lblCertNo);
            this.Controls.Add(this.lblEquipmentDesc);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.lblEquipmentNo);
            this.Name = "frmStandCodeEquipmentEdit";
            this.Text = "设备档案";
            this.Controls.SetChildIndex(this.lblEquipmentNo, 0);
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblEquipmentDesc, 0);
            this.Controls.SetChildIndex(this.lblCertNo, 0);
            this.Controls.SetChildIndex(this.lblValidDate, 0);
            this.Controls.SetChildIndex(this.lblCheckResult, 0);
            this.Controls.SetChildIndex(this.lblLastCheckDate, 0);
            this.Controls.SetChildIndex(this.lblCheckAccord, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblTel, 0);
            this.Controls.SetChildIndex(this.lblLinkMan, 0);
            this.Controls.SetChildIndex(this.lblQuanlity, 0);
            this.Controls.SetChildIndex(this.lblSignStatus, 0);
            this.Controls.SetChildIndex(this.lblEquipmentStatusId, 0);
            this.Controls.SetChildIndex(this.lblSourceTypeId, 0);
            this.Controls.SetChildIndex(this.lblSourceCustId, 0);
            this.Controls.SetChildIndex(this.lblUseTime, 0);
            this.Controls.SetChildIndex(this.lblSourceTime, 0);
            this.Controls.SetChildIndex(this.lblFactoryName, 0);
            this.Controls.SetChildIndex(this.lblModel, 0);
            this.Controls.SetChildIndex(this.lblSpec, 0);
            this.Controls.SetChildIndex(this.lblFactoryNo, 0);
            this.Controls.SetChildIndex(this.lblEquipmentName, 0);
            this.Controls.SetChildIndex(this.lblEquipmentCustId, 0);
            this.Controls.SetChildIndex(this.lblEquipmentType, 0);
            this.Controls.SetChildIndex(this.txtEquipmentNo, 0);
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
            this.Controls.SetChildIndex(this.txtSignStatus, 0);
            this.Controls.SetChildIndex(this.txtSourceCustId, 0);
            this.Controls.SetChildIndex(this.dtUseTime, 0);
            this.Controls.SetChildIndex(this.dtSourceTime, 0);
            this.Controls.SetChildIndex(this.txtFactoryName, 0);
            this.Controls.SetChildIndex(this.txtModel, 0);
            this.Controls.SetChildIndex(this.txtSpec, 0);
            this.Controls.SetChildIndex(this.txtFactoryNo, 0);
            this.Controls.SetChildIndex(this.txtEquipmentName, 0);
            this.Controls.SetChildIndex(this.txtEquipmentCustId, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.cboEquipmentType, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.cboSourceTypeId, 0);
            this.Controls.SetChildIndex(this.txtEquipmentStatusId, 0);
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
        private MMIS.Component.XLabel lblEquipmentNo;
        private MMIS.Component.XEditBox txtEquipmentCustId;
        private MMIS.Component.XEditBox txtEquipmentName;
        private MMIS.Component.XEditBox txtFactoryNo;
        private MMIS.Component.XEditBox txtSpec;
        private MMIS.Component.XEditBox txtModel;
        private MMIS.Component.XEditBox txtFactoryName;
        private MMIS.Component.XDateTimePicker dtSourceTime;
        private MMIS.Component.XDateTimePicker dtUseTime;
        private MMIS.Component.XEditBox txtSourceCustId;
        private MMIS.Component.XEditBox txtSignStatus;
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
        private MMIS.Component.XEditBox txtEquipmentNo;
        private Component.XCombobox cboEquipmentType;
        private Component.XLabel xLabel1;
        private Component.XCombobox cboSourceTypeId;
        private XSelectCodeEquipmentStateEditBox txtEquipmentStatusId;
        
    }
}