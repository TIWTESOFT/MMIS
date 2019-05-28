namespace MMIS.UI
{
    public partial class frmEquipmentReceiveEdit
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
            this.lblCheckUserId = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.xGroupBox1 = new MMIS.Component.XGroupBox();
            this.txtCheckAccord = new MMIS.Component.XEditBox();
            this.lblCheckAccord = new MMIS.Component.XLabel();
            this.txtFactoryName = new MMIS.Component.XEditBox();
            this.lblFactoryName = new MMIS.Component.XLabel();
            this.txtFactoryNo = new MMIS.Component.XEditBox();
            this.lblFactoryNo = new MMIS.Component.XLabel();
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
            this.txtSourceCustId = new MMIS.Component.XEditBox();
            this.dtLastCheckDate = new MMIS.Component.XDateTimePicker();
            this.lblSourceCustId = new MMIS.Component.XLabel();
            this.lblLastCheckDate = new MMIS.Component.XLabel();
            this.nebQuanlity = new MMIS.Component.XNumberEditBox();
            this.lblQuanlity = new MMIS.Component.XLabel();
            this.xGroupBox2 = new MMIS.Component.XGroupBox();
            this.txtReceiveDesc = new MMIS.Component.XEditBox();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.dtReceive = new MMIS.Component.XDateTimePicker();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtCheckUserId = new MMIS.UI.XSelectStaffInfoEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).BeginInit();
            this.xGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).BeginInit();
            this.xGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(652, 339);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(739, 339);
            // 
            // lblCheckUserId
            // 
            this.lblCheckUserId.AutoSize = true;
            this.lblCheckUserId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCheckUserId.ForeColor = System.Drawing.Color.Blue;
            this.lblCheckUserId.Location = new System.Drawing.Point(267, 22);
            this.lblCheckUserId.Name = "lblCheckUserId";
            this.lblCheckUserId.Size = new System.Drawing.Size(68, 17);
            this.lblCheckUserId.TabIndex = 2;
            this.lblCheckUserId.Text = "指定检定员";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(14, 110);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 3;
            this.lblRemark.Text = "备注信息";
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(76, 108);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(716, 51);
            this.txtRemark.TabIndex = 12;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xGroupBox1
            // 
            this.xGroupBox1.Controls.Add(this.txtCheckAccord);
            this.xGroupBox1.Controls.Add(this.lblCheckAccord);
            this.xGroupBox1.Controls.Add(this.txtFactoryName);
            this.xGroupBox1.Controls.Add(this.lblFactoryName);
            this.xGroupBox1.Controls.Add(this.txtFactoryNo);
            this.xGroupBox1.Controls.Add(this.lblFactoryNo);
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
            this.xGroupBox1.Location = new System.Drawing.Point(9, 4);
            this.xGroupBox1.Name = "xGroupBox1";
            this.xGroupBox1.Size = new System.Drawing.Size(806, 145);
            this.xGroupBox1.TabIndex = 0;
            this.xGroupBox1.Text = "设备信息";
            this.xGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtCheckAccord
            // 
            this.txtCheckAccord.IsAllowEmpty = true;
            this.txtCheckAccord.Location = new System.Drawing.Point(607, 111);
            this.txtCheckAccord.Name = "txtCheckAccord";
            this.txtCheckAccord.ReadOnly = true;
            this.txtCheckAccord.Size = new System.Drawing.Size(185, 23);
            this.txtCheckAccord.TabIndex = 154;
            this.txtCheckAccord.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblCheckAccord
            // 
            this.lblCheckAccord.AutoSize = true;
            this.lblCheckAccord.ForeColor = System.Drawing.Color.Black;
            this.lblCheckAccord.Location = new System.Drawing.Point(545, 114);
            this.lblCheckAccord.Name = "lblCheckAccord";
            this.lblCheckAccord.Size = new System.Drawing.Size(56, 17);
            this.lblCheckAccord.TabIndex = 155;
            this.lblCheckAccord.Text = "检定依据";
            // 
            // txtFactoryName
            // 
            this.txtFactoryName.IsAllowEmpty = true;
            this.txtFactoryName.Location = new System.Drawing.Point(607, 81);
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.ReadOnly = true;
            this.txtFactoryName.Size = new System.Drawing.Size(185, 23);
            this.txtFactoryName.TabIndex = 152;
            this.txtFactoryName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblFactoryName
            // 
            this.lblFactoryName.AutoSize = true;
            this.lblFactoryName.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryName.Location = new System.Drawing.Point(545, 83);
            this.lblFactoryName.Name = "lblFactoryName";
            this.lblFactoryName.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryName.TabIndex = 153;
            this.lblFactoryName.Text = "制造单位";
            // 
            // txtFactoryNo
            // 
            this.txtFactoryNo.IsAllowEmpty = true;
            this.txtFactoryNo.Location = new System.Drawing.Point(335, 81);
            this.txtFactoryNo.Name = "txtFactoryNo";
            this.txtFactoryNo.ReadOnly = true;
            this.txtFactoryNo.Size = new System.Drawing.Size(204, 23);
            this.txtFactoryNo.TabIndex = 150;
            this.txtFactoryNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblFactoryNo
            // 
            this.lblFactoryNo.AutoSize = true;
            this.lblFactoryNo.ForeColor = System.Drawing.Color.Black;
            this.lblFactoryNo.Location = new System.Drawing.Point(273, 84);
            this.lblFactoryNo.Name = "lblFactoryNo";
            this.lblFactoryNo.Size = new System.Drawing.Size(56, 17);
            this.lblFactoryNo.TabIndex = 151;
            this.lblFactoryNo.Text = "出厂编号";
            // 
            // txtEquipmentCustId
            // 
            this.txtEquipmentCustId.IsAllowEmpty = false;
            this.txtEquipmentCustId.Location = new System.Drawing.Point(76, 52);
            this.txtEquipmentCustId.Name = "txtEquipmentCustId";
            this.txtEquipmentCustId.ReadOnly = true;
            this.txtEquipmentCustId.Size = new System.Drawing.Size(463, 23);
            this.txtEquipmentCustId.TabIndex = 132;
            this.txtEquipmentCustId.TabStop = false;
            this.txtEquipmentCustId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEquipmentNo
            // 
            this.txtEquipmentNo.IsAllowEmpty = false;
            this.txtEquipmentNo.Location = new System.Drawing.Point(607, 20);
            this.txtEquipmentNo.Name = "txtEquipmentNo";
            this.txtEquipmentNo.ReadOnly = true;
            this.txtEquipmentNo.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentNo.TabIndex = 131;
            this.txtEquipmentNo.TabStop = false;
            this.txtEquipmentNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(544, 22);
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
            this.cboSourceTypeId.Location = new System.Drawing.Point(335, 111);
            this.cboSourceTypeId.Name = "cboSourceTypeId";
            this.cboSourceTypeId.ReadOnly = true;
            this.cboSourceTypeId.Size = new System.Drawing.Size(204, 23);
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
            this.cboEquipmentType.Location = new System.Drawing.Point(335, 20);
            this.cboEquipmentType.Name = "cboEquipmentType";
            this.cboEquipmentType.ReadOnly = true;
            this.cboEquipmentType.Size = new System.Drawing.Size(204, 23);
            this.cboEquipmentType.TabIndex = 130;
            this.cboEquipmentType.TabStop = false;
            this.cboEquipmentType.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtSpec
            // 
            this.txtSpec.IsAllowEmpty = true;
            this.txtSpec.Location = new System.Drawing.Point(607, 51);
            this.txtSpec.Name = "txtSpec";
            this.txtSpec.ReadOnly = true;
            this.txtSpec.Size = new System.Drawing.Size(185, 23);
            this.txtSpec.TabIndex = 133;
            this.txtSpec.TabStop = false;
            this.txtSpec.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtModel
            // 
            this.txtModel.IsAllowEmpty = true;
            this.txtModel.Location = new System.Drawing.Point(76, 81);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(185, 23);
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
            this.dtSourceTime.Location = new System.Drawing.Point(76, 111);
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
            this.lblEquipmentType.Location = new System.Drawing.Point(273, 23);
            this.lblEquipmentType.Name = "lblEquipmentType";
            this.lblEquipmentType.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentType.TabIndex = 140;
            this.lblEquipmentType.Text = "设备类型";
            // 
            // lblEquipmentCustId
            // 
            this.lblEquipmentCustId.AutoSize = true;
            this.lblEquipmentCustId.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentCustId.Location = new System.Drawing.Point(9, 54);
            this.lblEquipmentCustId.Name = "lblEquipmentCustId";
            this.lblEquipmentCustId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentCustId.TabIndex = 141;
            this.lblEquipmentCustId.Text = "送检单位";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.ForeColor = System.Drawing.Color.Black;
            this.lblSpec.Location = new System.Drawing.Point(545, 53);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(32, 17);
            this.lblSpec.TabIndex = 142;
            this.lblSpec.Text = "规格";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.Black;
            this.lblModel.Location = new System.Drawing.Point(9, 84);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(32, 17);
            this.lblModel.TabIndex = 143;
            this.lblModel.Text = "型号";
            // 
            // lblSourceTime
            // 
            this.lblSourceTime.AutoSize = true;
            this.lblSourceTime.ForeColor = System.Drawing.Color.Black;
            this.lblSourceTime.Location = new System.Drawing.Point(10, 114);
            this.lblSourceTime.Name = "lblSourceTime";
            this.lblSourceTime.Size = new System.Drawing.Size(56, 17);
            this.lblSourceTime.TabIndex = 144;
            this.lblSourceTime.Text = "溯源时间";
            // 
            // lblSourceTypeId
            // 
            this.lblSourceTypeId.AutoSize = true;
            this.lblSourceTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblSourceTypeId.Location = new System.Drawing.Point(273, 114);
            this.lblSourceTypeId.Name = "lblSourceTypeId";
            this.lblSourceTypeId.Size = new System.Drawing.Size(56, 17);
            this.lblSourceTypeId.TabIndex = 146;
            this.lblSourceTypeId.Text = "溯源方式";
            // 
            // txtEquipmentCheckId
            // 
            this.txtEquipmentCheckId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtEquipmentCheckId.DisplayMember = "";
            this.txtEquipmentCheckId.IsAllowEmpty = false;
            this.txtEquipmentCheckId.Location = new System.Drawing.Point(76, 20);
            this.txtEquipmentCheckId.Name = "txtEquipmentCheckId";
            this.txtEquipmentCheckId.QueryCheckBox = null;
            this.txtEquipmentCheckId.QueryFieldName = null;
            this.txtEquipmentCheckId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtEquipmentCheckId.ReadOnly = true;
            this.txtEquipmentCheckId.SelectedModel = null;
            this.txtEquipmentCheckId.Size = new System.Drawing.Size(185, 23);
            this.txtEquipmentCheckId.TabIndex = 128;
            this.txtEquipmentCheckId.ValueMember = "";
            this.txtEquipmentCheckId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtEquipmentCheckId.TextChanged += new System.EventHandler(this.txtEquipmentCheckId_TextChanged);
            // 
            // lblEquipmentCheckId
            // 
            this.lblEquipmentCheckId.AutoSize = true;
            this.lblEquipmentCheckId.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEquipmentCheckId.ForeColor = System.Drawing.Color.Blue;
            this.lblEquipmentCheckId.Location = new System.Drawing.Point(9, 22);
            this.lblEquipmentCheckId.Name = "lblEquipmentCheckId";
            this.lblEquipmentCheckId.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentCheckId.TabIndex = 129;
            this.lblEquipmentCheckId.Text = "接收设备";
            // 
            // txtSourceCustId
            // 
            this.txtSourceCustId.IsAllowEmpty = true;
            this.txtSourceCustId.Location = new System.Drawing.Point(231, 380);
            this.txtSourceCustId.Name = "txtSourceCustId";
            this.txtSourceCustId.ReadOnly = true;
            this.txtSourceCustId.Size = new System.Drawing.Size(185, 23);
            this.txtSourceCustId.TabIndex = 139;
            this.txtSourceCustId.TabStop = false;
            this.txtSourceCustId.Visible = false;
            this.txtSourceCustId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtLastCheckDate
            // 
            this.dtLastCheckDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtLastCheckDate.DropDownCalendar.Name = "";
            this.dtLastCheckDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtLastCheckDate.Location = new System.Drawing.Point(231, 349);
            this.dtLastCheckDate.Name = "dtLastCheckDate";
            this.dtLastCheckDate.ReadOnly = true;
            this.dtLastCheckDate.Size = new System.Drawing.Size(185, 23);
            this.dtLastCheckDate.TabIndex = 136;
            this.dtLastCheckDate.TabStop = false;
            this.dtLastCheckDate.Visible = false;
            this.dtLastCheckDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // lblSourceCustId
            // 
            this.lblSourceCustId.AutoSize = true;
            this.lblSourceCustId.ForeColor = System.Drawing.Color.Black;
            this.lblSourceCustId.Location = new System.Drawing.Point(153, 383);
            this.lblSourceCustId.Name = "lblSourceCustId";
            this.lblSourceCustId.Size = new System.Drawing.Size(56, 17);
            this.lblSourceCustId.TabIndex = 145;
            this.lblSourceCustId.Text = "溯源单位";
            this.lblSourceCustId.Visible = false;
            // 
            // lblLastCheckDate
            // 
            this.lblLastCheckDate.AutoSize = true;
            this.lblLastCheckDate.ForeColor = System.Drawing.Color.Black;
            this.lblLastCheckDate.Location = new System.Drawing.Point(150, 352);
            this.lblLastCheckDate.Name = "lblLastCheckDate";
            this.lblLastCheckDate.Size = new System.Drawing.Size(80, 17);
            this.lblLastCheckDate.TabIndex = 148;
            this.lblLastCheckDate.Text = "最后检定日期";
            this.lblLastCheckDate.Visible = false;
            // 
            // nebQuanlity
            // 
            this.nebQuanlity.FormatString = "0";
            this.nebQuanlity.IsAllowEmpty = false;
            this.nebQuanlity.IsAllowLessThanZero = false;
            this.nebQuanlity.IsAllowZero = false;
            this.nebQuanlity.Location = new System.Drawing.Point(76, 19);
            this.nebQuanlity.Name = "nebQuanlity";
            this.nebQuanlity.Size = new System.Drawing.Size(185, 23);
            this.nebQuanlity.TabIndex = 135;
            this.nebQuanlity.TabStop = false;
            this.nebQuanlity.Text = "1";
            this.nebQuanlity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nebQuanlity.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblQuanlity
            // 
            this.lblQuanlity.AutoSize = true;
            this.lblQuanlity.ForeColor = System.Drawing.Color.Black;
            this.lblQuanlity.Location = new System.Drawing.Point(34, 22);
            this.lblQuanlity.Name = "lblQuanlity";
            this.lblQuanlity.Size = new System.Drawing.Size(32, 17);
            this.lblQuanlity.TabIndex = 147;
            this.lblQuanlity.Text = "数量";
            // 
            // xGroupBox2
            // 
            this.xGroupBox2.Controls.Add(this.txtReceiveDesc);
            this.xGroupBox2.Controls.Add(this.xLabel3);
            this.xGroupBox2.Controls.Add(this.dtReceive);
            this.xGroupBox2.Controls.Add(this.xLabel2);
            this.xGroupBox2.Controls.Add(this.txtCheckUserId);
            this.xGroupBox2.Controls.Add(this.lblCheckUserId);
            this.xGroupBox2.Controls.Add(this.txtRemark);
            this.xGroupBox2.Controls.Add(this.lblRemark);
            this.xGroupBox2.Controls.Add(this.nebQuanlity);
            this.xGroupBox2.Controls.Add(this.lblQuanlity);
            this.xGroupBox2.Location = new System.Drawing.Point(9, 155);
            this.xGroupBox2.Name = "xGroupBox2";
            this.xGroupBox2.Size = new System.Drawing.Size(805, 172);
            this.xGroupBox2.TabIndex = 1;
            this.xGroupBox2.Text = "接收信息";
            this.xGroupBox2.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // txtReceiveDesc
            // 
            this.txtReceiveDesc.IsAllowEmpty = true;
            this.txtReceiveDesc.Location = new System.Drawing.Point(76, 51);
            this.txtReceiveDesc.Multiline = true;
            this.txtReceiveDesc.Name = "txtReceiveDesc";
            this.txtReceiveDesc.Size = new System.Drawing.Size(716, 51);
            this.txtReceiveDesc.TabIndex = 16;
            this.txtReceiveDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(14, 53);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 15;
            this.xLabel3.Text = "接收描述";
            // 
            // dtReceive
            // 
            // 
            // 
            // 
            this.dtReceive.DropDownCalendar.Name = "";
            this.dtReceive.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtReceive.Location = new System.Drawing.Point(607, 19);
            this.dtReceive.Name = "dtReceive";
            this.dtReceive.Size = new System.Drawing.Size(185, 23);
            this.dtReceive.TabIndex = 14;
            this.dtReceive.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xLabel2.ForeColor = System.Drawing.Color.Blue;
            this.xLabel2.Location = new System.Drawing.Point(545, 22);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 13;
            this.xLabel2.Text = "接收时间";
            // 
            // txtCheckUserId
            // 
            this.txtCheckUserId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtCheckUserId.DisplayMember = "";
            this.txtCheckUserId.IsAllowEmpty = false;
            this.txtCheckUserId.Location = new System.Drawing.Point(335, 19);
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
            // frmEquipmentReceiveEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(826, 378);
            this.Controls.Add(this.xGroupBox2);
            this.Controls.Add(this.xGroupBox1);
            this.Controls.Add(this.lblLastCheckDate);
            this.Controls.Add(this.lblSourceCustId);
            this.Controls.Add(this.dtLastCheckDate);
            this.Controls.Add(this.txtSourceCustId);
            this.Name = "frmEquipmentReceiveEdit";
            this.Text = "设备接收";
            this.Controls.SetChildIndex(this.txtSourceCustId, 0);
            this.Controls.SetChildIndex(this.dtLastCheckDate, 0);
            this.Controls.SetChildIndex(this.lblSourceCustId, 0);
            this.Controls.SetChildIndex(this.lblLastCheckDate, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xGroupBox1, 0);
            this.Controls.SetChildIndex(this.xGroupBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox1)).EndInit();
            this.xGroupBox1.ResumeLayout(false);
            this.xGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xGroupBox2)).EndInit();
            this.xGroupBox2.ResumeLayout(false);
            this.xGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MMIS.Component.XLabel lblCheckUserId;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtRemark;
        private XSelectStaffInfoEditBox txtCheckUserId;
        private Component.XGroupBox xGroupBox1;
        private Component.XEditBox txtEquipmentCustId;
        private Component.XEditBox txtEquipmentNo;
        private Component.XLabel xLabel1;
        private Component.XCombobox cboSourceTypeId;
        private Component.XCombobox cboEquipmentType;
        private Component.XEditBox txtSpec;
        private Component.XEditBox txtModel;
        private Component.XDateTimePicker dtSourceTime;
        private Component.XEditBox txtSourceCustId;
        private Component.XNumberEditBox nebQuanlity;
        private Component.XDateTimePicker dtLastCheckDate;
        private Component.XLabel lblEquipmentType;
        private Component.XLabel lblEquipmentCustId;
        private Component.XLabel lblSpec;
        private Component.XLabel lblModel;
        private Component.XLabel lblSourceTime;
        private Component.XLabel lblSourceCustId;
        private Component.XLabel lblSourceTypeId;
        private Component.XLabel lblQuanlity;
        private Component.XLabel lblLastCheckDate;
        private XSelectEquipmentCheckEditBox txtEquipmentCheckId;
        private Component.XLabel lblEquipmentCheckId;
        private Component.XGroupBox xGroupBox2;
        private Component.XLabel xLabel2;
        private Component.XEditBox txtReceiveDesc;
        private Component.XLabel xLabel3;
        private Component.XDateTimePicker dtReceive;
        private Component.XEditBox txtFactoryNo;
        private Component.XLabel lblFactoryNo;
        private Component.XEditBox txtFactoryName;
        private Component.XLabel lblFactoryName;
        private Component.XEditBox txtCheckAccord;
        private Component.XLabel lblCheckAccord;
        
    }
}