namespace MMIS.UI
{
    partial class frmEquipmentStatusQueryList
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
            Janus.Windows.GridEX.GridEXLayout grdData_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentStatusQueryList));
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem5 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem6 = new Janus.Windows.EditControls.UIComboBoxItem();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.xQueryEditBox1 = new MMIS.Component.XQueryEditBox();
            this.cboStatus = new MMIS.Component.XQueryCombobox();
            this.lblStatus = new MMIS.Component.XLabel();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.dtBegin = new MMIS.Component.XQueryDatePicker();
            this.dtEnd = new MMIS.Component.XQueryDatePicker();
            this.xSelectEquipmentCustEditBox1 = new MMIS.UI.XSelectEquipmentCustEditBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuery)).BeginInit();
            this.grpQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListToolBar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            grdData_DesignTimeLayout.LayoutString = resources.GetString("grdData_DesignTimeLayout.LayoutString");
            this.grdData.DesignTimeLayout = grdData_DesignTimeLayout;
            this.grdData.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.grdData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdData.Size = new System.Drawing.Size(989, 435);
            // 
            // grpQuery
            // 
            this.grpQuery.Controls.Add(this.dtEnd);
            this.grpQuery.Controls.Add(this.dtBegin);
            this.grpQuery.Controls.Add(this.xLabel3);
            this.grpQuery.Controls.Add(this.cboStatus);
            this.grpQuery.Controls.Add(this.lblStatus);
            this.grpQuery.Controls.Add(this.xQueryEditBox1);
            this.grpQuery.Controls.Add(this.xLabel2);
            this.grpQuery.Controls.Add(this.xSelectEquipmentCustEditBox1);
            this.grpQuery.Controls.Add(this.xLabel1);
            this.grpQuery.Location = new System.Drawing.Point(7, 5);
            this.grpQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpQuery.Size = new System.Drawing.Size(996, 53);
            this.grpQuery.Controls.SetChildIndex(this.btnQuery, 0);
            this.grpQuery.Controls.SetChildIndex(this.chkChecked, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xSelectEquipmentCustEditBox1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel2, 0);
            this.grpQuery.Controls.SetChildIndex(this.xQueryEditBox1, 0);
            this.grpQuery.Controls.SetChildIndex(this.lblStatus, 0);
            this.grpQuery.Controls.SetChildIndex(this.cboStatus, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel3, 0);
            this.grpQuery.Controls.SetChildIndex(this.dtBegin, 0);
            this.grpQuery.Controls.SetChildIndex(this.dtEnd, 0);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(2441, 16);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Size = new System.Drawing.Size(73, 26);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Size = new System.Drawing.Size(1009, 64);
            // 
            // ListToolBar
            // 
            this.ListToolBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Size = new System.Drawing.Size(1009, 459);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(10, 445);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Size = new System.Drawing.Size(989, 14);
            // 
            // panel8
            // 
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Size = new System.Drawing.Size(989, 435);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "");
            this.imageList.Images.SetKeyName(4, "");
            this.imageList.Images.SetKeyName(5, "");
            this.imageList.Images.SetKeyName(6, "");
            this.imageList.Images.SetKeyName(7, "");
            this.imageList.Images.SetKeyName(8, "");
            this.imageList.Images.SetKeyName(9, "");
            this.imageList.Images.SetKeyName(10, "");
            this.imageList.Images.SetKeyName(11, "");
            this.imageList.Images.SetKeyName(12, "");
            this.imageList.Images.SetKeyName(13, "");
            this.imageList.Images.SetKeyName(14, "");
            this.imageList.Images.SetKeyName(15, "");
            this.imageList.Images.SetKeyName(16, "");
            this.imageList.Images.SetKeyName(17, "");
            this.imageList.Images.SetKeyName(18, "");
            this.imageList.Images.SetKeyName(19, "");
            this.imageList.Images.SetKeyName(20, "");
            this.imageList.Images.SetKeyName(21, "");
            this.imageList.Images.SetKeyName(22, "");
            this.imageList.Images.SetKeyName(23, "");
            this.imageList.Images.SetKeyName(24, "");
            this.imageList.Images.SetKeyName(25, "");
            this.imageList.Images.SetKeyName(26, "");
            this.imageList.Images.SetKeyName(27, "");
            this.imageList.Images.SetKeyName(28, "");
            this.imageList.Images.SetKeyName(29, "");
            this.imageList.Images.SetKeyName(30, "");
            this.imageList.Images.SetKeyName(31, "");
            this.imageList.Images.SetKeyName(32, "");
            this.imageList.Images.SetKeyName(33, "");
            this.imageList.Images.SetKeyName(34, "");
            this.imageList.Images.SetKeyName(35, "");
            this.imageList.Images.SetKeyName(36, "");
            this.imageList.Images.SetKeyName(37, "");
            this.imageList.Images.SetKeyName(38, "");
            this.imageList.Images.SetKeyName(39, "");
            this.imageList.Images.SetKeyName(40, "");
            this.imageList.Images.SetKeyName(41, "");
            this.imageList.Images.SetKeyName(42, "");
            this.imageList.Images.SetKeyName(43, "");
            this.imageList.Images.SetKeyName(44, "");
            this.imageList.Images.SetKeyName(45, "");
            this.imageList.Images.SetKeyName(46, "");
            this.imageList.Images.SetKeyName(47, "");
            this.imageList.Images.SetKeyName(48, "");
            this.imageList.Images.SetKeyName(49, "");
            this.imageList.Images.SetKeyName(50, "");
            this.imageList.Images.SetKeyName(51, "");
            this.imageList.Images.SetKeyName(52, "");
            this.imageList.Images.SetKeyName(53, "");
            this.imageList.Images.SetKeyName(54, "");
            this.imageList.Images.SetKeyName(55, "");
            this.imageList.Images.SetKeyName(56, "");
            this.imageList.Images.SetKeyName(57, "");
            this.imageList.Images.SetKeyName(58, "");
            this.imageList.Images.SetKeyName(59, "");
            this.imageList.Images.SetKeyName(60, "");
            this.imageList.Images.SetKeyName(61, "");
            this.imageList.Images.SetKeyName(62, "");
            this.imageList.Images.SetKeyName(63, "");
            this.imageList.Images.SetKeyName(64, "");
            this.imageList.Images.SetKeyName(65, "");
            this.imageList.Images.SetKeyName(66, "");
            this.imageList.Images.SetKeyName(67, "");
            this.imageList.Images.SetKeyName(68, "");
            this.imageList.Images.SetKeyName(69, "");
            this.imageList.Images.SetKeyName(70, "");
            this.imageList.Images.SetKeyName(71, "");
            this.imageList.Images.SetKeyName(72, "");
            this.imageList.Images.SetKeyName(73, "");
            this.imageList.Images.SetKeyName(74, "");
            this.imageList.Images.SetKeyName(75, "");
            this.imageList.Images.SetKeyName(76, "");
            this.imageList.Images.SetKeyName(77, "");
            this.imageList.Images.SetKeyName(78, "");
            this.imageList.Images.SetKeyName(79, "");
            this.imageList.Images.SetKeyName(80, "");
            this.imageList.Images.SetKeyName(81, "");
            this.imageList.Images.SetKeyName(82, "");
            this.imageList.Images.SetKeyName(83, "");
            this.imageList.Images.SetKeyName(84, "");
            this.imageList.Images.SetKeyName(85, "");
            this.imageList.Images.SetKeyName(86, "");
            this.imageList.Images.SetKeyName(87, "");
            this.imageList.Images.SetKeyName(88, "");
            this.imageList.Images.SetKeyName(89, "");
            this.imageList.Images.SetKeyName(90, "");
            this.imageList.Images.SetKeyName(91, "");
            this.imageList.Images.SetKeyName(92, "");
            this.imageList.Images.SetKeyName(93, "");
            this.imageList.Images.SetKeyName(94, "");
            this.imageList.Images.SetKeyName(95, "");
            this.imageList.Images.SetKeyName(96, "");
            this.imageList.Images.SetKeyName(97, "");
            this.imageList.Images.SetKeyName(98, "");
            this.imageList.Images.SetKeyName(99, "");
            this.imageList.Images.SetKeyName(100, "");
            this.imageList.Images.SetKeyName(101, "");
            this.imageList.Images.SetKeyName(102, "");
            this.imageList.Images.SetKeyName(103, "");
            this.imageList.Images.SetKeyName(104, "");
            this.imageList.Images.SetKeyName(105, "");
            this.imageList.Images.SetKeyName(106, "");
            this.imageList.Images.SetKeyName(107, "");
            this.imageList.Images.SetKeyName(108, "");
            this.imageList.Images.SetKeyName(109, "");
            this.imageList.Images.SetKeyName(110, "");
            this.imageList.Images.SetKeyName(111, "");
            this.imageList.Images.SetKeyName(112, "");
            this.imageList.Images.SetKeyName(113, "");
            this.imageList.Images.SetKeyName(114, "");
            this.imageList.Images.SetKeyName(115, "");
            this.imageList.Images.SetKeyName(116, "");
            this.imageList.Images.SetKeyName(117, "");
            this.imageList.Images.SetKeyName(118, "");
            this.imageList.Images.SetKeyName(119, "");
            this.imageList.Images.SetKeyName(120, "");
            this.imageList.Images.SetKeyName(121, "");
            this.imageList.Images.SetKeyName(122, "");
            this.imageList.Images.SetKeyName(123, "");
            // 
            // chkChecked
            // 
            this.chkChecked.Location = new System.Drawing.Point(2362, 18);
            this.chkChecked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkChecked.Size = new System.Drawing.Size(73, 22);
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(10, 22);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 1001;
            this.xLabel1.Text = "送检单位";
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(262, 22);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 1003;
            this.xLabel2.Text = "设备名称";
            // 
            // xQueryEditBox1
            // 
            this.xQueryEditBox1.IsAllowEmpty = false;
            this.xQueryEditBox1.Location = new System.Drawing.Point(320, 19);
            this.xQueryEditBox1.Name = "xQueryEditBox1";
            this.xQueryEditBox1.QueryCheckBox = null;
            this.xQueryEditBox1.QueryFieldName = "EquipmentName";
            this.xQueryEditBox1.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox1.Size = new System.Drawing.Size(105, 23);
            this.xQueryEditBox1.TabIndex = 1004;
            this.xQueryEditBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cboStatus
            // 
            this.cboStatus.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboStatus.IsAllowEmpty = false;
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.IsSeparator = false;
            uiComboBoxItem1.Text = "";
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.IsSeparator = false;
            uiComboBoxItem2.Text = "接收";
            uiComboBoxItem2.Value = "接收";
            uiComboBoxItem3.FormatStyle.Alpha = 0;
            uiComboBoxItem3.IsSeparator = false;
            uiComboBoxItem3.Text = "检定";
            uiComboBoxItem3.Value = "检定";
            uiComboBoxItem4.FormatStyle.Alpha = 0;
            uiComboBoxItem4.IsSeparator = false;
            uiComboBoxItem4.Text = "核验";
            uiComboBoxItem4.Value = "核验";
            uiComboBoxItem5.FormatStyle.Alpha = 0;
            uiComboBoxItem5.IsSeparator = false;
            uiComboBoxItem5.Text = "签发";
            uiComboBoxItem5.Value = "签发";
            uiComboBoxItem6.FormatStyle.Alpha = 0;
            uiComboBoxItem6.IsSeparator = false;
            uiComboBoxItem6.Text = "制证";
            uiComboBoxItem6.Value = "制证";
            this.cboStatus.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2,
            uiComboBoxItem3,
            uiComboBoxItem4,
            uiComboBoxItem5,
            uiComboBoxItem6});
            this.cboStatus.Location = new System.Drawing.Point(493, 19);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.QueryCheckBox = null;
            this.cboStatus.QueryFieldName = "CurrentStatus";
            this.cboStatus.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.cboStatus.SelectedIndex = 0;
            this.cboStatus.Size = new System.Drawing.Size(103, 23);
            this.cboStatus.TabIndex = 1009;
            this.cboStatus.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(433, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 17);
            this.lblStatus.TabIndex = 1008;
            this.lblStatus.Text = "当前状态";
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(602, 22);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 1010;
            this.xLabel3.Text = "接收时间";
            // 
            // dtBegin
            // 
            // 
            // 
            // 
            this.dtBegin.DropDownCalendar.Name = "";
            this.dtBegin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtBegin.Location = new System.Drawing.Point(664, 19);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.QueryCheckBox = null;
            this.dtBegin.QueryFieldName = "ReceiveDate";
            this.dtBegin.QueryOperateType = MMIS.Component.XQueryOperateType.MoreThanOrEqual;
            this.dtBegin.ShowCheckBox = true;
            this.dtBegin.Size = new System.Drawing.Size(109, 23);
            this.dtBegin.TabIndex = 1011;
            this.dtBegin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtEnd
            // 
            // 
            // 
            // 
            this.dtEnd.DropDownCalendar.Name = "";
            this.dtEnd.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtEnd.Location = new System.Drawing.Point(776, 19);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.QueryCheckBox = null;
            this.dtEnd.QueryFieldName = "ReceiveDate";
            this.dtEnd.QueryOperateType = MMIS.Component.XQueryOperateType.LessThanOrEqual;
            this.dtEnd.ShowCheckBox = true;
            this.dtEnd.Size = new System.Drawing.Size(111, 23);
            this.dtEnd.TabIndex = 1012;
            this.dtEnd.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xSelectEquipmentCustEditBox1
            // 
            this.xSelectEquipmentCustEditBox1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.xSelectEquipmentCustEditBox1.DisplayMember = "";
            this.xSelectEquipmentCustEditBox1.IsAllowEmpty = false;
            this.xSelectEquipmentCustEditBox1.Location = new System.Drawing.Point(70, 19);
            this.xSelectEquipmentCustEditBox1.Name = "xSelectEquipmentCustEditBox1";
            this.xSelectEquipmentCustEditBox1.QueryCheckBox = null;
            this.xSelectEquipmentCustEditBox1.QueryFieldName = "EquipmentCustId";
            this.xSelectEquipmentCustEditBox1.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.xSelectEquipmentCustEditBox1.ReadOnly = true;
            this.xSelectEquipmentCustEditBox1.SelectedModel = null;
            this.xSelectEquipmentCustEditBox1.Size = new System.Drawing.Size(186, 23);
            this.xSelectEquipmentCustEditBox1.TabIndex = 1002;
            this.xSelectEquipmentCustEditBox1.ValueMember = "";
            this.xSelectEquipmentCustEditBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmEquipmentStatusQueryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 551);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEquipmentStatusQueryList";
            this.Text = "检验状态查询";
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpQuery)).EndInit();
            this.grpQuery.ResumeLayout(false);
            this.grpQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmRight)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListToolBar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Component.XLabel xLabel2;
        private XSelectEquipmentCustEditBox xSelectEquipmentCustEditBox1;
        private Component.XLabel xLabel1;
        private Component.XQueryEditBox xQueryEditBox1;
        protected Component.XQueryCombobox cboStatus;
        protected Component.XLabel lblStatus;
        private Component.XQueryDatePicker dtEnd;
        private Component.XQueryDatePicker dtBegin;
        protected Component.XLabel xLabel3;
    }
}