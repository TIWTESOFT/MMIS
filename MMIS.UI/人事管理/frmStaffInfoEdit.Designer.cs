namespace MMIS.UI
{
    public partial class frmStaffInfoEdit
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
            Janus.Windows.GridEX.GridEXLayout grdDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem7 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem8 = new Janus.Windows.EditControls.UIComboBoxItem();
            this.lblUserName = new MMIS.Component.XLabel();
            this.lblUserSex = new MMIS.Component.XLabel();
            this.lblNationality = new MMIS.Component.XLabel();
            this.lblUserAge = new MMIS.Component.XLabel();
            this.lblBirthday = new MMIS.Component.XLabel();
            this.lblNativePlace = new MMIS.Component.XLabel();
            this.lblStartWorkDate = new MMIS.Component.XLabel();
            this.lblToCompWorkDate = new MMIS.Component.XLabel();
            this.lblPersonID = new MMIS.Component.XLabel();
            this.lblSpecialty = new MMIS.Component.XLabel();
            this.lblHouseHoldAddr = new MMIS.Component.XLabel();
            this.lblHomeAddress = new MMIS.Component.XLabel();
            this.lblHomeTel = new MMIS.Component.XLabel();
            this.lblMobileNo = new MMIS.Component.XLabel();
            this.lblWorkTel = new MMIS.Component.XLabel();
            this.lblEducation = new MMIS.Component.XLabel();
            this.lblMajor = new MMIS.Component.XLabel();
            this.lblUniversity = new MMIS.Component.XLabel();
            this.lblMeasureWorkYears = new MMIS.Component.XLabel();
            this.lblMeasureWorkContent = new MMIS.Component.XLabel();
            this.lblDeptId = new MMIS.Component.XLabel();
            this.lblPost = new MMIS.Component.XLabel();
            this.lblRoleId = new MMIS.Component.XLabel();
            this.lblUserId = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtUserName = new MMIS.Component.XEditBox();
            this.txtNationality = new MMIS.Component.XEditBox();
            this.nebUserAge = new MMIS.Component.XNumberEditBox();
            this.dtBirthday = new MMIS.Component.XDateTimePicker();
            this.txtNativePlace = new MMIS.Component.XEditBox();
            this.dtStartWorkDate = new MMIS.Component.XDateTimePicker();
            this.dtToCompWorkDate = new MMIS.Component.XDateTimePicker();
            this.txtPersonID = new MMIS.Component.XEditBox();
            this.txtSpecialty = new MMIS.Component.XEditBox();
            this.txtHouseHoldAddr = new MMIS.Component.XEditBox();
            this.txtHomeAddress = new MMIS.Component.XEditBox();
            this.txtHomeTel = new MMIS.Component.XEditBox();
            this.txtMobileNo = new MMIS.Component.XEditBox();
            this.txtWorkTel = new MMIS.Component.XEditBox();
            this.txtEducation = new MMIS.Component.XEditBox();
            this.txtMajor = new MMIS.Component.XEditBox();
            this.txtUniversity = new MMIS.Component.XEditBox();
            this.nebMeasureWorkYears = new MMIS.Component.XNumberEditBox();
            this.txtMeasureWorkContent = new MMIS.Component.XEditBox();
            this.txtPost = new MMIS.Component.XEditBox();
            this.txtRoleId = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.txtUserSex = new MMIS.Component.XCombobox();
            this.txtUserId = new MMIS.UI.XSelectUsersEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.txtDeptId = new MMIS.UI.XSelectUseDeptEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtFilePath = new MMIS.Component.XEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).BeginInit();
            this.xGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // xGroupBox1
            // 
            this.xGroupBox1.Location = new System.Drawing.Point(347, 491);
            this.xGroupBox1.Size = new System.Drawing.Size(296, 65);
            this.xGroupBox1.Visible = false;
            // 
            // grdDetail
            // 
            grdDetail_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>";
            this.grdDetail.DesignTimeLayout = grdDetail_DesignTimeLayout;
            this.grdDetail.Size = new System.Drawing.Size(441, 37);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(637, 491);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(724, 491);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(22, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(32, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "姓名";
            // 
            // lblUserSex
            // 
            this.lblUserSex.AutoSize = true;
            this.lblUserSex.ForeColor = System.Drawing.Color.Black;
            this.lblUserSex.Location = new System.Drawing.Point(280, 15);
            this.lblUserSex.Name = "lblUserSex";
            this.lblUserSex.Size = new System.Drawing.Size(32, 17);
            this.lblUserSex.TabIndex = 2;
            this.lblUserSex.Text = "性别";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.ForeColor = System.Drawing.Color.Black;
            this.lblNationality.Location = new System.Drawing.Point(552, 15);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(32, 17);
            this.lblNationality.TabIndex = 3;
            this.lblNationality.Text = "民族";
            // 
            // lblUserAge
            // 
            this.lblUserAge.AutoSize = true;
            this.lblUserAge.ForeColor = System.Drawing.Color.Black;
            this.lblUserAge.Location = new System.Drawing.Point(22, 46);
            this.lblUserAge.Name = "lblUserAge";
            this.lblUserAge.Size = new System.Drawing.Size(32, 17);
            this.lblUserAge.TabIndex = 4;
            this.lblUserAge.Text = "年龄";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.ForeColor = System.Drawing.Color.Black;
            this.lblBirthday.Location = new System.Drawing.Point(280, 46);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(56, 17);
            this.lblBirthday.TabIndex = 5;
            this.lblBirthday.Text = "出生日期";
            // 
            // lblNativePlace
            // 
            this.lblNativePlace.AutoSize = true;
            this.lblNativePlace.ForeColor = System.Drawing.Color.Black;
            this.lblNativePlace.Location = new System.Drawing.Point(552, 46);
            this.lblNativePlace.Name = "lblNativePlace";
            this.lblNativePlace.Size = new System.Drawing.Size(32, 17);
            this.lblNativePlace.TabIndex = 6;
            this.lblNativePlace.Text = "籍贯";
            // 
            // lblStartWorkDate
            // 
            this.lblStartWorkDate.AutoSize = true;
            this.lblStartWorkDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartWorkDate.Location = new System.Drawing.Point(22, 77);
            this.lblStartWorkDate.Name = "lblStartWorkDate";
            this.lblStartWorkDate.Size = new System.Drawing.Size(80, 17);
            this.lblStartWorkDate.TabIndex = 7;
            this.lblStartWorkDate.Text = "参加工作时间";
            // 
            // lblToCompWorkDate
            // 
            this.lblToCompWorkDate.AutoSize = true;
            this.lblToCompWorkDate.ForeColor = System.Drawing.Color.Black;
            this.lblToCompWorkDate.Location = new System.Drawing.Point(280, 77);
            this.lblToCompWorkDate.Name = "lblToCompWorkDate";
            this.lblToCompWorkDate.Size = new System.Drawing.Size(104, 17);
            this.lblToCompWorkDate.TabIndex = 8;
            this.lblToCompWorkDate.Text = "到本单位工作时间";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.ForeColor = System.Drawing.Color.Black;
            this.lblPersonID.Location = new System.Drawing.Point(552, 77);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(56, 17);
            this.lblPersonID.TabIndex = 9;
            this.lblPersonID.Text = "身份证号";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.ForeColor = System.Drawing.Color.Black;
            this.lblSpecialty.Location = new System.Drawing.Point(22, 109);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(32, 17);
            this.lblSpecialty.TabIndex = 10;
            this.lblSpecialty.Text = "特长";
            // 
            // lblHouseHoldAddr
            // 
            this.lblHouseHoldAddr.AutoSize = true;
            this.lblHouseHoldAddr.ForeColor = System.Drawing.Color.Black;
            this.lblHouseHoldAddr.Location = new System.Drawing.Point(278, 109);
            this.lblHouseHoldAddr.Name = "lblHouseHoldAddr";
            this.lblHouseHoldAddr.Size = new System.Drawing.Size(68, 17);
            this.lblHouseHoldAddr.TabIndex = 11;
            this.lblHouseHoldAddr.Text = "户口所在地";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.ForeColor = System.Drawing.Color.Black;
            this.lblHomeAddress.Location = new System.Drawing.Point(552, 109);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(56, 17);
            this.lblHomeAddress.TabIndex = 12;
            this.lblHomeAddress.Text = "家庭地址";
            // 
            // lblHomeTel
            // 
            this.lblHomeTel.AutoSize = true;
            this.lblHomeTel.ForeColor = System.Drawing.Color.Black;
            this.lblHomeTel.Location = new System.Drawing.Point(22, 141);
            this.lblHomeTel.Name = "lblHomeTel";
            this.lblHomeTel.Size = new System.Drawing.Size(56, 17);
            this.lblHomeTel.TabIndex = 13;
            this.lblHomeTel.Text = "家庭电话";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.ForeColor = System.Drawing.Color.Black;
            this.lblMobileNo.Location = new System.Drawing.Point(280, 141);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(44, 17);
            this.lblMobileNo.TabIndex = 14;
            this.lblMobileNo.Text = "手机号";
            // 
            // lblWorkTel
            // 
            this.lblWorkTel.AutoSize = true;
            this.lblWorkTel.ForeColor = System.Drawing.Color.Black;
            this.lblWorkTel.Location = new System.Drawing.Point(552, 141);
            this.lblWorkTel.Name = "lblWorkTel";
            this.lblWorkTel.Size = new System.Drawing.Size(56, 17);
            this.lblWorkTel.TabIndex = 15;
            this.lblWorkTel.Text = "工作电话";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.ForeColor = System.Drawing.Color.Black;
            this.lblEducation.Location = new System.Drawing.Point(22, 173);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(56, 17);
            this.lblEducation.TabIndex = 16;
            this.lblEducation.Text = "文化程度";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.ForeColor = System.Drawing.Color.Black;
            this.lblMajor.Location = new System.Drawing.Point(285, 173);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(56, 17);
            this.lblMajor.TabIndex = 17;
            this.lblMajor.Text = "所学专业";
            // 
            // lblUniversity
            // 
            this.lblUniversity.AutoSize = true;
            this.lblUniversity.ForeColor = System.Drawing.Color.Black;
            this.lblUniversity.Location = new System.Drawing.Point(552, 173);
            this.lblUniversity.Name = "lblUniversity";
            this.lblUniversity.Size = new System.Drawing.Size(56, 17);
            this.lblUniversity.TabIndex = 18;
            this.lblUniversity.Text = "毕业院校";
            // 
            // lblMeasureWorkYears
            // 
            this.lblMeasureWorkYears.AutoSize = true;
            this.lblMeasureWorkYears.ForeColor = System.Drawing.Color.Black;
            this.lblMeasureWorkYears.Location = new System.Drawing.Point(22, 204);
            this.lblMeasureWorkYears.Name = "lblMeasureWorkYears";
            this.lblMeasureWorkYears.Size = new System.Drawing.Size(80, 17);
            this.lblMeasureWorkYears.TabIndex = 19;
            this.lblMeasureWorkYears.Text = "计量工作年限";
            // 
            // lblMeasureWorkContent
            // 
            this.lblMeasureWorkContent.AutoSize = true;
            this.lblMeasureWorkContent.ForeColor = System.Drawing.Color.Black;
            this.lblMeasureWorkContent.Location = new System.Drawing.Point(278, 204);
            this.lblMeasureWorkContent.Name = "lblMeasureWorkContent";
            this.lblMeasureWorkContent.Size = new System.Drawing.Size(104, 17);
            this.lblMeasureWorkContent.TabIndex = 20;
            this.lblMeasureWorkContent.Text = "负责计量工作内容";
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.ForeColor = System.Drawing.Color.Black;
            this.lblDeptId.Location = new System.Drawing.Point(22, 235);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(32, 17);
            this.lblDeptId.TabIndex = 21;
            this.lblDeptId.Text = "部门";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.ForeColor = System.Drawing.Color.Black;
            this.lblPost.Location = new System.Drawing.Point(285, 237);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(32, 17);
            this.lblPost.TabIndex = 22;
            this.lblPost.Text = "职务";
            // 
            // lblRoleId
            // 
            this.lblRoleId.AutoSize = true;
            this.lblRoleId.ForeColor = System.Drawing.Color.Black;
            this.lblRoleId.Location = new System.Drawing.Point(22, 498);
            this.lblRoleId.Name = "lblRoleId";
            this.lblRoleId.Size = new System.Drawing.Size(32, 17);
            this.lblRoleId.TabIndex = 23;
            this.lblRoleId.Text = "角色";
            this.lblRoleId.Visible = false;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.ForeColor = System.Drawing.Color.Black;
            this.lblUserId.Location = new System.Drawing.Point(552, 237);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(56, 17);
            this.lblUserId.TabIndex = 24;
            this.lblUserId.Text = "关联用户";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(22, 268);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(32, 17);
            this.lblRemark.TabIndex = 25;
            this.lblRemark.Text = "备注";
            // 
            // txtUserName
            // 
            this.txtUserName.IsAllowEmpty = false;
            this.txtUserName.Location = new System.Drawing.Point(84, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(185, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNationality
            // 
            this.txtNationality.IsAllowEmpty = true;
            this.txtNationality.Location = new System.Drawing.Point(614, 12);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(185, 23);
            this.txtNationality.TabIndex = 3;
            this.txtNationality.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebUserAge
            // 
            this.nebUserAge.FormatString = "0";
            this.nebUserAge.IsAllowEmpty = false;
            this.nebUserAge.IsAllowLessThanZero = false;
            this.nebUserAge.IsAllowZero = true;
            this.nebUserAge.Location = new System.Drawing.Point(84, 43);
            this.nebUserAge.Name = "nebUserAge";
            this.nebUserAge.Size = new System.Drawing.Size(185, 23);
            this.nebUserAge.TabIndex = 101;
            this.nebUserAge.Text = "0";
            this.nebUserAge.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebUserAge.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtBirthday
            // 
            this.dtBirthday.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtBirthday.DropDownCalendar.Name = "";
            this.dtBirthday.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtBirthday.Location = new System.Drawing.Point(347, 43);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(185, 23);
            this.dtBirthday.TabIndex = 5;
            this.dtBirthday.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtNativePlace
            // 
            this.txtNativePlace.IsAllowEmpty = true;
            this.txtNativePlace.Location = new System.Drawing.Point(614, 43);
            this.txtNativePlace.Name = "txtNativePlace";
            this.txtNativePlace.Size = new System.Drawing.Size(185, 23);
            this.txtNativePlace.TabIndex = 6;
            this.txtNativePlace.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtStartWorkDate
            // 
            this.dtStartWorkDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtStartWorkDate.DropDownCalendar.Name = "";
            this.dtStartWorkDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtStartWorkDate.Location = new System.Drawing.Point(108, 74);
            this.dtStartWorkDate.Name = "dtStartWorkDate";
            this.dtStartWorkDate.Size = new System.Drawing.Size(161, 23);
            this.dtStartWorkDate.TabIndex = 7;
            this.dtStartWorkDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtToCompWorkDate
            // 
            this.dtToCompWorkDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtToCompWorkDate.DropDownCalendar.Name = "";
            this.dtToCompWorkDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtToCompWorkDate.Location = new System.Drawing.Point(395, 74);
            this.dtToCompWorkDate.Name = "dtToCompWorkDate";
            this.dtToCompWorkDate.Size = new System.Drawing.Size(137, 23);
            this.dtToCompWorkDate.TabIndex = 8;
            this.dtToCompWorkDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtPersonID
            // 
            this.txtPersonID.IsAllowEmpty = true;
            this.txtPersonID.Location = new System.Drawing.Point(614, 74);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(185, 23);
            this.txtPersonID.TabIndex = 9;
            this.txtPersonID.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.IsAllowEmpty = true;
            this.txtSpecialty.Location = new System.Drawing.Point(84, 106);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(185, 23);
            this.txtSpecialty.TabIndex = 10;
            this.txtSpecialty.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtHouseHoldAddr
            // 
            this.txtHouseHoldAddr.IsAllowEmpty = true;
            this.txtHouseHoldAddr.Location = new System.Drawing.Point(347, 106);
            this.txtHouseHoldAddr.Name = "txtHouseHoldAddr";
            this.txtHouseHoldAddr.Size = new System.Drawing.Size(185, 23);
            this.txtHouseHoldAddr.TabIndex = 11;
            this.txtHouseHoldAddr.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtHomeAddress
            // 
            this.txtHomeAddress.IsAllowEmpty = true;
            this.txtHomeAddress.Location = new System.Drawing.Point(614, 106);
            this.txtHomeAddress.Name = "txtHomeAddress";
            this.txtHomeAddress.Size = new System.Drawing.Size(185, 23);
            this.txtHomeAddress.TabIndex = 12;
            this.txtHomeAddress.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtHomeTel
            // 
            this.txtHomeTel.IsAllowEmpty = true;
            this.txtHomeTel.Location = new System.Drawing.Point(84, 137);
            this.txtHomeTel.Name = "txtHomeTel";
            this.txtHomeTel.Size = new System.Drawing.Size(185, 23);
            this.txtHomeTel.TabIndex = 13;
            this.txtHomeTel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.IsAllowEmpty = true;
            this.txtMobileNo.Location = new System.Drawing.Point(347, 137);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(185, 23);
            this.txtMobileNo.TabIndex = 14;
            this.txtMobileNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtWorkTel
            // 
            this.txtWorkTel.IsAllowEmpty = true;
            this.txtWorkTel.Location = new System.Drawing.Point(614, 137);
            this.txtWorkTel.Name = "txtWorkTel";
            this.txtWorkTel.Size = new System.Drawing.Size(185, 23);
            this.txtWorkTel.TabIndex = 15;
            this.txtWorkTel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEducation
            // 
            this.txtEducation.IsAllowEmpty = true;
            this.txtEducation.Location = new System.Drawing.Point(84, 170);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(185, 23);
            this.txtEducation.TabIndex = 16;
            this.txtEducation.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtMajor
            // 
            this.txtMajor.IsAllowEmpty = true;
            this.txtMajor.Location = new System.Drawing.Point(347, 170);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(185, 23);
            this.txtMajor.TabIndex = 17;
            this.txtMajor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtUniversity
            // 
            this.txtUniversity.IsAllowEmpty = true;
            this.txtUniversity.Location = new System.Drawing.Point(614, 170);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(185, 23);
            this.txtUniversity.TabIndex = 18;
            this.txtUniversity.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebMeasureWorkYears
            // 
            this.nebMeasureWorkYears.FormatString = "0";
            this.nebMeasureWorkYears.IsAllowEmpty = false;
            this.nebMeasureWorkYears.IsAllowLessThanZero = false;
            this.nebMeasureWorkYears.IsAllowZero = true;
            this.nebMeasureWorkYears.Location = new System.Drawing.Point(108, 201);
            this.nebMeasureWorkYears.Name = "nebMeasureWorkYears";
            this.nebMeasureWorkYears.Size = new System.Drawing.Size(161, 23);
            this.nebMeasureWorkYears.TabIndex = 101;
            this.nebMeasureWorkYears.Text = "0";
            this.nebMeasureWorkYears.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebMeasureWorkYears.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtMeasureWorkContent
            // 
            this.txtMeasureWorkContent.IsAllowEmpty = true;
            this.txtMeasureWorkContent.Location = new System.Drawing.Point(395, 201);
            this.txtMeasureWorkContent.Name = "txtMeasureWorkContent";
            this.txtMeasureWorkContent.Size = new System.Drawing.Size(404, 23);
            this.txtMeasureWorkContent.TabIndex = 20;
            this.txtMeasureWorkContent.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPost
            // 
            this.txtPost.IsAllowEmpty = true;
            this.txtPost.Location = new System.Drawing.Point(347, 234);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(185, 23);
            this.txtPost.TabIndex = 22;
            this.txtPost.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRoleId
            // 
            this.txtRoleId.IsAllowEmpty = true;
            this.txtRoleId.Location = new System.Drawing.Point(84, 495);
            this.txtRoleId.Name = "txtRoleId";
            this.txtRoleId.Size = new System.Drawing.Size(185, 23);
            this.txtRoleId.TabIndex = 23;
            this.txtRoleId.Visible = false;
            this.txtRoleId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(84, 265);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(715, 23);
            this.txtRemark.TabIndex = 25;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtUserSex
            // 
            this.txtUserSex.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.txtUserSex.IsAllowEmpty = true;
            uiComboBoxItem7.FormatStyle.Alpha = 0;
            uiComboBoxItem7.IsSeparator = false;
            uiComboBoxItem7.Text = "男";
            uiComboBoxItem7.Value = "男";
            uiComboBoxItem8.FormatStyle.Alpha = 0;
            uiComboBoxItem8.IsSeparator = false;
            uiComboBoxItem8.Text = "女";
            uiComboBoxItem8.Value = "女";
            this.txtUserSex.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem7,
            uiComboBoxItem8});
            this.txtUserSex.Location = new System.Drawing.Point(347, 12);
            this.txtUserSex.Name = "txtUserSex";
            this.txtUserSex.Size = new System.Drawing.Size(185, 23);
            this.txtUserSex.TabIndex = 102;
            this.txtUserSex.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtUserId
            // 
            this.txtUserId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtUserId.DisplayMember = "";
            this.txtUserId.IsAllowEmpty = true;
            this.txtUserId.Location = new System.Drawing.Point(614, 234);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.QueryCheckBox = null;
            this.txtUserId.QueryFieldName = null;
            this.txtUserId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtUserId.ReadOnly = true;
            this.txtUserId.SelectedModel = null;
            this.txtUserId.Size = new System.Drawing.Size(185, 23);
            this.txtUserId.TabIndex = 103;
            this.txtUserId.ValueMember = "";
            this.txtUserId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(22, 327);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(80, 17);
            this.xLabel1.TabIndex = 104;
            this.xLabel1.Text = "默认检定项目";
            // 
            // pnlItems
            // 
            this.pnlItems.AutoScroll = true;
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Location = new System.Drawing.Point(25, 361);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(774, 121);
            this.pnlItems.TabIndex = 105;
            // 
            // txtDeptId
            // 
            this.txtDeptId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtDeptId.DisplayMember = "";
            this.txtDeptId.IsAllowEmpty = false;
            this.txtDeptId.Location = new System.Drawing.Point(84, 235);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.QueryCheckBox = null;
            this.txtDeptId.QueryFieldName = null;
            this.txtDeptId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtDeptId.ReadOnly = true;
            this.txtDeptId.SelectedModel = null;
            this.txtDeptId.Size = new System.Drawing.Size(185, 23);
            this.txtDeptId.TabIndex = 21;
            this.txtDeptId.ValueMember = "";
            this.txtDeptId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(22, 298);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 106;
            this.xLabel2.Text = "电子签章";
            // 
            // txtFilePath
            // 
            this.txtFilePath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFilePath.IsAllowEmpty = true;
            this.txtFilePath.Location = new System.Drawing.Point(84, 296);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(715, 23);
            this.txtFilePath.TabIndex = 107;
            this.txtFilePath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFilePath.ButtonClick += new System.EventHandler(this.txtFilePath_ButtonClick);
            this.txtFilePath.DoubleClick += new System.EventHandler(this.txtFilePath_DoubleClick);
            // 
            // frmStaffInfoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(811, 530);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtUserSex);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.nebUserAge);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.txtNativePlace);
            this.Controls.Add(this.dtStartWorkDate);
            this.Controls.Add(this.dtToCompWorkDate);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.txtHouseHoldAddr);
            this.Controls.Add(this.txtHomeAddress);
            this.Controls.Add(this.txtHomeTel);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtWorkTel);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtUniversity);
            this.Controls.Add(this.nebMeasureWorkYears);
            this.Controls.Add(this.txtMeasureWorkContent);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.txtRoleId);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserSex);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblUserAge);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblNativePlace);
            this.Controls.Add(this.lblStartWorkDate);
            this.Controls.Add(this.lblToCompWorkDate);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.lblHouseHoldAddr);
            this.Controls.Add(this.lblHomeAddress);
            this.Controls.Add(this.lblHomeTel);
            this.Controls.Add(this.lblMobileNo);
            this.Controls.Add(this.lblWorkTel);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblUniversity);
            this.Controls.Add(this.lblMeasureWorkYears);
            this.Controls.Add(this.lblMeasureWorkContent);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblRoleId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmStaffInfoEdit";
            this.Text = "人员信息";
            this.Controls.SetChildIndex(this.xGroupBox1, 0);
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblUserId, 0);
            this.Controls.SetChildIndex(this.lblRoleId, 0);
            this.Controls.SetChildIndex(this.lblPost, 0);
            this.Controls.SetChildIndex(this.lblDeptId, 0);
            this.Controls.SetChildIndex(this.lblMeasureWorkContent, 0);
            this.Controls.SetChildIndex(this.lblMeasureWorkYears, 0);
            this.Controls.SetChildIndex(this.lblUniversity, 0);
            this.Controls.SetChildIndex(this.lblMajor, 0);
            this.Controls.SetChildIndex(this.lblEducation, 0);
            this.Controls.SetChildIndex(this.lblWorkTel, 0);
            this.Controls.SetChildIndex(this.lblMobileNo, 0);
            this.Controls.SetChildIndex(this.lblHomeTel, 0);
            this.Controls.SetChildIndex(this.lblHomeAddress, 0);
            this.Controls.SetChildIndex(this.lblHouseHoldAddr, 0);
            this.Controls.SetChildIndex(this.lblSpecialty, 0);
            this.Controls.SetChildIndex(this.lblPersonID, 0);
            this.Controls.SetChildIndex(this.lblToCompWorkDate, 0);
            this.Controls.SetChildIndex(this.lblStartWorkDate, 0);
            this.Controls.SetChildIndex(this.lblNativePlace, 0);
            this.Controls.SetChildIndex(this.lblBirthday, 0);
            this.Controls.SetChildIndex(this.lblUserAge, 0);
            this.Controls.SetChildIndex(this.lblNationality, 0);
            this.Controls.SetChildIndex(this.lblUserSex, 0);
            this.Controls.SetChildIndex(this.lblUserName, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtRoleId, 0);
            this.Controls.SetChildIndex(this.txtPost, 0);
            this.Controls.SetChildIndex(this.txtMeasureWorkContent, 0);
            this.Controls.SetChildIndex(this.nebMeasureWorkYears, 0);
            this.Controls.SetChildIndex(this.txtUniversity, 0);
            this.Controls.SetChildIndex(this.txtMajor, 0);
            this.Controls.SetChildIndex(this.txtEducation, 0);
            this.Controls.SetChildIndex(this.txtWorkTel, 0);
            this.Controls.SetChildIndex(this.txtMobileNo, 0);
            this.Controls.SetChildIndex(this.txtHomeTel, 0);
            this.Controls.SetChildIndex(this.txtHomeAddress, 0);
            this.Controls.SetChildIndex(this.txtHouseHoldAddr, 0);
            this.Controls.SetChildIndex(this.txtSpecialty, 0);
            this.Controls.SetChildIndex(this.txtPersonID, 0);
            this.Controls.SetChildIndex(this.dtToCompWorkDate, 0);
            this.Controls.SetChildIndex(this.dtStartWorkDate, 0);
            this.Controls.SetChildIndex(this.txtNativePlace, 0);
            this.Controls.SetChildIndex(this.dtBirthday, 0);
            this.Controls.SetChildIndex(this.nebUserAge, 0);
            this.Controls.SetChildIndex(this.txtNationality, 0);
            this.Controls.SetChildIndex(this.txtUserName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtUserSex, 0);
            this.Controls.SetChildIndex(this.txtUserId, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.pnlItems, 0);
            this.Controls.SetChildIndex(this.txtDeptId, 0);
            this.Controls.SetChildIndex(this.xLabel2, 0);
            this.Controls.SetChildIndex(this.txtFilePath, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).EndInit();
            this.xGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblUserName;
        private MMIS.Component.XLabel lblUserSex;
        private MMIS.Component.XLabel lblNationality;
        private MMIS.Component.XLabel lblUserAge;
        private MMIS.Component.XLabel lblBirthday;
        private MMIS.Component.XLabel lblNativePlace;
        private MMIS.Component.XLabel lblStartWorkDate;
        private MMIS.Component.XLabel lblToCompWorkDate;
        private MMIS.Component.XLabel lblPersonID;
        private MMIS.Component.XLabel lblSpecialty;
        private MMIS.Component.XLabel lblHouseHoldAddr;
        private MMIS.Component.XLabel lblHomeAddress;
        private MMIS.Component.XLabel lblHomeTel;
        private MMIS.Component.XLabel lblMobileNo;
        private MMIS.Component.XLabel lblWorkTel;
        private MMIS.Component.XLabel lblEducation;
        private MMIS.Component.XLabel lblMajor;
        private MMIS.Component.XLabel lblUniversity;
        private MMIS.Component.XLabel lblMeasureWorkYears;
        private MMIS.Component.XLabel lblMeasureWorkContent;
        private MMIS.Component.XLabel lblDeptId;
        private MMIS.Component.XLabel lblPost;
        private MMIS.Component.XLabel lblRoleId;
        private MMIS.Component.XLabel lblUserId;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtUserName;
        private MMIS.Component.XEditBox txtNationality;
        private MMIS.Component.XNumberEditBox nebUserAge;
        private MMIS.Component.XDateTimePicker dtBirthday;
        private MMIS.Component.XEditBox txtNativePlace;
        private MMIS.Component.XDateTimePicker dtStartWorkDate;
        private MMIS.Component.XDateTimePicker dtToCompWorkDate;
        private MMIS.Component.XEditBox txtPersonID;
        private MMIS.Component.XEditBox txtSpecialty;
        private MMIS.Component.XEditBox txtHouseHoldAddr;
        private MMIS.Component.XEditBox txtHomeAddress;
        private MMIS.Component.XEditBox txtHomeTel;
        private MMIS.Component.XEditBox txtMobileNo;
        private MMIS.Component.XEditBox txtWorkTel;
        private MMIS.Component.XEditBox txtEducation;
        private MMIS.Component.XEditBox txtMajor;
        private MMIS.Component.XEditBox txtUniversity;
        private MMIS.Component.XNumberEditBox nebMeasureWorkYears;
        private MMIS.Component.XEditBox txtMeasureWorkContent;
        private MMIS.Component.XEditBox txtPost;
        private MMIS.Component.XEditBox txtRoleId;
        private MMIS.Component.XEditBox txtRemark;
        private Component.XCombobox txtUserSex;
        private XSelectUsersEditBox txtUserId;
        private Component.XLabel xLabel1;
        private System.Windows.Forms.Panel pnlItems;
        private XSelectUseDeptEditBox txtDeptId;
        private Component.XLabel xLabel2;
        private Component.XEditBox txtFilePath;
        
    }
}