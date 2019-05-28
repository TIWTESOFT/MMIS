namespace MMIS.UI
{
    public partial class frmEquipmentCheckList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentCheckList));
            this.lblEquipmentName = new MMIS.Component.XLabel();
            this.xQueryEditBox1 = new MMIS.Component.XQueryEditBox();
            this.xQueryEditBox2 = new MMIS.Component.XQueryEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.xQueryDatePicker1 = new MMIS.Component.XQueryDatePicker();
            this.xQueryDatePicker2 = new MMIS.Component.XQueryDatePicker();
            this.xSelectEquipmentCustEditBox1 = new MMIS.UI.XSelectEquipmentCustEditBox();
            this.xQueryEditBox3 = new MMIS.Component.XQueryEditBox();
            this.xLabel4 = new MMIS.Component.XLabel();
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
            this.grdData.Size = new System.Drawing.Size(1041, 297);
            // 
            // grpQuery
            // 
            this.grpQuery.Controls.Add(this.xQueryEditBox3);
            this.grpQuery.Controls.Add(this.xLabel4);
            this.grpQuery.Controls.Add(this.xQueryDatePicker2);
            this.grpQuery.Controls.Add(this.xQueryDatePicker1);
            this.grpQuery.Controls.Add(this.xLabel3);
            this.grpQuery.Controls.Add(this.xSelectEquipmentCustEditBox1);
            this.grpQuery.Controls.Add(this.xLabel2);
            this.grpQuery.Controls.Add(this.xQueryEditBox2);
            this.grpQuery.Controls.Add(this.xLabel1);
            this.grpQuery.Controls.Add(this.xQueryEditBox1);
            this.grpQuery.Controls.Add(this.lblEquipmentName);
            this.grpQuery.Size = new System.Drawing.Size(1050, 55);
            this.grpQuery.Controls.SetChildIndex(this.btnQuery, 0);
            this.grpQuery.Controls.SetChildIndex(this.chkChecked, 0);
            this.grpQuery.Controls.SetChildIndex(this.lblEquipmentName, 0);
            this.grpQuery.Controls.SetChildIndex(this.xQueryEditBox1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xQueryEditBox2, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel2, 0);
            this.grpQuery.Controls.SetChildIndex(this.xSelectEquipmentCustEditBox1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel3, 0);
            this.grpQuery.Controls.SetChildIndex(this.xQueryDatePicker1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xQueryDatePicker2, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel4, 0);
            this.grpQuery.Controls.SetChildIndex(this.xQueryEditBox3, 0);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(7636, 18);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1061, 73);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1061, 317);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(10, 307);
            this.panel7.Size = new System.Drawing.Size(1041, 10);
            // 
            // panel8
            // 
            this.panel8.Size = new System.Drawing.Size(1041, 297);
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
            this.chkChecked.Location = new System.Drawing.Point(7567, 20);
            // 
            // lblEquipmentName
            // 
            this.lblEquipmentName.AutoSize = true;
            this.lblEquipmentName.ForeColor = System.Drawing.Color.Black;
            this.lblEquipmentName.Location = new System.Drawing.Point(10, 25);
            this.lblEquipmentName.Name = "lblEquipmentName";
            this.lblEquipmentName.Size = new System.Drawing.Size(56, 17);
            this.lblEquipmentName.TabIndex = 1001;
            this.lblEquipmentName.Text = "设备名称";
            // 
            // xQueryEditBox1
            // 
            this.xQueryEditBox1.IsAllowEmpty = false;
            this.xQueryEditBox1.Location = new System.Drawing.Point(68, 22);
            this.xQueryEditBox1.Name = "xQueryEditBox1";
            this.xQueryEditBox1.QueryCheckBox = null;
            this.xQueryEditBox1.QueryFieldName = "EquipmentName";
            this.xQueryEditBox1.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox1.Size = new System.Drawing.Size(155, 23);
            this.xQueryEditBox1.TabIndex = 1002;
            this.xQueryEditBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xQueryEditBox2
            // 
            this.xQueryEditBox2.IsAllowEmpty = false;
            this.xQueryEditBox2.Location = new System.Drawing.Point(282, 22);
            this.xQueryEditBox2.Name = "xQueryEditBox2";
            this.xQueryEditBox2.QueryCheckBox = null;
            this.xQueryEditBox2.QueryFieldName = "FactoryNo";
            this.xQueryEditBox2.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox2.Size = new System.Drawing.Size(96, 23);
            this.xQueryEditBox2.TabIndex = 1004;
            this.xQueryEditBox2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(225, 25);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 1003;
            this.xLabel1.Text = "出厂编号";
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(380, 25);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 1005;
            this.xLabel2.Text = "送检单位";
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(750, 25);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 1007;
            this.xLabel3.Text = "溯源时间";
            // 
            // xQueryDatePicker1
            // 
            this.xQueryDatePicker1.Checked = false;
            // 
            // 
            // 
            this.xQueryDatePicker1.DropDownCalendar.Name = "";
            this.xQueryDatePicker1.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.xQueryDatePicker1.Location = new System.Drawing.Point(812, 22);
            this.xQueryDatePicker1.Name = "xQueryDatePicker1";
            this.xQueryDatePicker1.QueryCheckBox = null;
            this.xQueryDatePicker1.QueryFieldName = "SourceTime";
            this.xQueryDatePicker1.QueryOperateType = MMIS.Component.XQueryOperateType.MoreThanOrEqual;
            this.xQueryDatePicker1.ShowCheckBox = true;
            this.xQueryDatePicker1.Size = new System.Drawing.Size(112, 23);
            this.xQueryDatePicker1.TabIndex = 1008;
            this.xQueryDatePicker1.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xQueryDatePicker2
            // 
            this.xQueryDatePicker2.Checked = false;
            // 
            // 
            // 
            this.xQueryDatePicker2.DropDownCalendar.Name = "";
            this.xQueryDatePicker2.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.xQueryDatePicker2.Location = new System.Drawing.Point(930, 22);
            this.xQueryDatePicker2.Name = "xQueryDatePicker2";
            this.xQueryDatePicker2.QueryCheckBox = null;
            this.xQueryDatePicker2.QueryFieldName = "SourceTime";
            this.xQueryDatePicker2.QueryOperateType = MMIS.Component.XQueryOperateType.LessThanOrEqual;
            this.xQueryDatePicker2.ShowCheckBox = true;
            this.xQueryDatePicker2.Size = new System.Drawing.Size(112, 23);
            this.xQueryDatePicker2.TabIndex = 1009;
            this.xQueryDatePicker2.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xSelectEquipmentCustEditBox1
            // 
            this.xSelectEquipmentCustEditBox1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.xSelectEquipmentCustEditBox1.DisplayMember = "";
            this.xSelectEquipmentCustEditBox1.IsAllowEmpty = false;
            this.xSelectEquipmentCustEditBox1.Location = new System.Drawing.Point(437, 22);
            this.xSelectEquipmentCustEditBox1.Name = "xSelectEquipmentCustEditBox1";
            this.xSelectEquipmentCustEditBox1.QueryCheckBox = null;
            this.xSelectEquipmentCustEditBox1.QueryFieldName = "EquipmentCustId";
            this.xSelectEquipmentCustEditBox1.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.xSelectEquipmentCustEditBox1.ReadOnly = true;
            this.xSelectEquipmentCustEditBox1.SelectedModel = null;
            this.xSelectEquipmentCustEditBox1.Size = new System.Drawing.Size(167, 23);
            this.xSelectEquipmentCustEditBox1.TabIndex = 1006;
            this.xSelectEquipmentCustEditBox1.ValueMember = "";
            this.xSelectEquipmentCustEditBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xQueryEditBox3
            // 
            this.xQueryEditBox3.IsAllowEmpty = false;
            this.xQueryEditBox3.Location = new System.Drawing.Point(653, 22);
            this.xQueryEditBox3.Name = "xQueryEditBox3";
            this.xQueryEditBox3.QueryCheckBox = null;
            this.xQueryEditBox3.QueryFieldName = "LinkMan";
            this.xQueryEditBox3.QueryOperateType = MMIS.Component.XQueryOperateType.Contain;
            this.xQueryEditBox3.Size = new System.Drawing.Size(91, 23);
            this.xQueryEditBox3.TabIndex = 1011;
            this.xQueryEditBox3.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel4
            // 
            this.xLabel4.AutoSize = true;
            this.xLabel4.ForeColor = System.Drawing.Color.Black;
            this.xLabel4.Location = new System.Drawing.Point(609, 25);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(44, 17);
            this.xLabel4.TabIndex = 1010;
            this.xLabel4.Text = "联系人";
            // 
            // frmEquipmentCheckList
            // 
            this.ClientSize = new System.Drawing.Size(1061, 418);
            this.Name = "frmEquipmentCheckList";
            this.Text = "送检设备";
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

        private Component.XQueryEditBox xQueryEditBox1;
        private Component.XLabel lblEquipmentName;
        private Component.XQueryEditBox xQueryEditBox2;
        private Component.XLabel xLabel1;
        private Component.XLabel xLabel2;
        private XSelectEquipmentCustEditBox xSelectEquipmentCustEditBox1;
        private Component.XLabel xLabel3;
        private Component.XQueryDatePicker xQueryDatePicker2;
        private Component.XQueryDatePicker xQueryDatePicker1;
        private Component.XQueryEditBox xQueryEditBox3;
        private Component.XLabel xLabel4;
        
    }
}