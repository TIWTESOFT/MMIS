﻿namespace MMIS.UI
{
    partial class frmEquipmentCertPrintList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEquipmentCertPrintList));
            this.dtCheckedEnd = new MMIS.Component.XQueryDatePicker();
            this.dtCheckedStart = new MMIS.Component.XQueryDatePicker();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.cmdWord = new Janus.Windows.UI.CommandBars.UICommand("cmdWord");
            this.cmdWork1 = new Janus.Windows.UI.CommandBars.UICommand("cmdWord");
            this.cmdPdf = new Janus.Windows.UI.CommandBars.UICommand("cmdPdf");
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
            // xLabel1
            // 
            this.xLabel1.Location = new System.Drawing.Point(312, 67);
            this.xLabel1.Visible = false;
            // 
            // xSelectStaffInfoEditBox1
            // 
            this.xSelectStaffInfoEditBox1.Location = new System.Drawing.Point(362, 64);
            this.xSelectStaffInfoEditBox1.Visible = false;
            // 
            // xLabel2
            // 
            this.xLabel2.Location = new System.Drawing.Point(11, 67);
            this.xLabel2.Visible = false;
            // 
            // dtEnd
            // 
            // 
            // 
            // 
            this.dtEnd.DropDownCalendar.Name = "";
            this.dtEnd.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtEnd.Location = new System.Drawing.Point(194, 64);
            this.dtEnd.Visible = false;
            // 
            // dtStart
            // 
            // 
            // 
            // 
            this.dtStart.DropDownCalendar.Name = "";
            this.dtStart.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtStart.Location = new System.Drawing.Point(73, 64);
            this.dtStart.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(318, 25);
            // 
            // cboStatus
            // 
            this.cboStatus.Location = new System.Drawing.Point(378, 22);
            // 
            // grdData
            // 
            grdData_DesignTimeLayout.LayoutString = resources.GetString("grdData_DesignTimeLayout.LayoutString");
            this.grdData.DesignTimeLayout = grdData_DesignTimeLayout;
            this.grdData.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.grdData.Size = new System.Drawing.Size(771, 268);
            // 
            // grpQuery
            // 
            this.grpQuery.Controls.Add(this.dtCheckedEnd);
            this.grpQuery.Controls.Add(this.dtCheckedStart);
            this.grpQuery.Controls.Add(this.xLabel3);
            this.grpQuery.Size = new System.Drawing.Size(778, 55);
            this.grpQuery.Controls.SetChildIndex(this.btnQuery, 0);
            this.grpQuery.Controls.SetChildIndex(this.chkChecked, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xSelectStaffInfoEditBox1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel2, 0);
            this.grpQuery.Controls.SetChildIndex(this.dtStart, 0);
            this.grpQuery.Controls.SetChildIndex(this.dtEnd, 0);
            this.grpQuery.Controls.SetChildIndex(this.lblStatus, 0);
            this.grpQuery.Controls.SetChildIndex(this.cboStatus, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel3, 0);
            this.grpQuery.Controls.SetChildIndex(this.dtCheckedStart, 0);
            this.grpQuery.Controls.SetChildIndex(this.dtCheckedEnd, 0);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(2202, 18);
            // 
            // xCommandManager1
            // 
            this.xCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdWord,
            this.cmdPdf});
            // 
            // ListToolBar
            // 
            this.ListToolBar.Size = new System.Drawing.Size(517, 28);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(791, 288);
            // 
            // panel8
            // 
            this.panel8.Size = new System.Drawing.Size(771, 268);
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
            this.chkChecked.Location = new System.Drawing.Point(2133, 20);
            // 
            // cmdPrint
            // 
            this.cmdPrint.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdWork1});
            // 
            // dtCheckedEnd
            // 
            // 
            // 
            // 
            this.dtCheckedEnd.DropDownCalendar.Name = "";
            this.dtCheckedEnd.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtCheckedEnd.Location = new System.Drawing.Point(194, 22);
            this.dtCheckedEnd.Name = "dtCheckedEnd";
            this.dtCheckedEnd.QueryCheckBox = null;
            this.dtCheckedEnd.QueryFieldName = "SignedDate";
            this.dtCheckedEnd.QueryOperateType = MMIS.Component.XQueryOperateType.LessThanOrEqual;
            this.dtCheckedEnd.ShowCheckBox = true;
            this.dtCheckedEnd.Size = new System.Drawing.Size(115, 23);
            this.dtCheckedEnd.TabIndex = 1016;
            this.dtCheckedEnd.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtCheckedStart
            // 
            // 
            // 
            // 
            this.dtCheckedStart.DropDownCalendar.Name = "";
            this.dtCheckedStart.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtCheckedStart.Location = new System.Drawing.Point(73, 22);
            this.dtCheckedStart.Name = "dtCheckedStart";
            this.dtCheckedStart.QueryCheckBox = null;
            this.dtCheckedStart.QueryFieldName = "SignedDate";
            this.dtCheckedStart.QueryOperateType = MMIS.Component.XQueryOperateType.MoreThanOrEqual;
            this.dtCheckedStart.ShowCheckBox = true;
            this.dtCheckedStart.Size = new System.Drawing.Size(115, 23);
            this.dtCheckedStart.TabIndex = 1015;
            this.dtCheckedStart.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(11, 25);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 1014;
            this.xLabel3.Text = "签发时间";
            // 
            // cmdWord
            // 
            this.cmdWord.ImageIndex = 8;
            this.cmdWord.Key = "cmdWord";
            this.cmdWord.Name = "cmdWord";
            this.cmdWord.Text = "Word版";
            // 
            // cmdWork1
            // 
            this.cmdWork1.Key = "cmdWord";
            this.cmdWork1.Name = "cmdWork1";
            // 
            // cmdPdf
            // 
            this.cmdPdf.ImageIndex = 1;
            this.cmdPdf.Key = "cmdPdf";
            this.cmdPdf.Name = "cmdPdf";
            this.cmdPdf.Text = "PDF版";
            // 
            // frmEquipmentCertPrintList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 389);
            this.Name = "frmEquipmentCertPrintList";
            this.Text = "制证打印";
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

        protected Component.XQueryDatePicker dtCheckedEnd;
        protected Component.XQueryDatePicker dtCheckedStart;
        protected Component.XLabel xLabel3;
        private Janus.Windows.UI.CommandBars.UICommand cmdWord;
        private Janus.Windows.UI.CommandBars.UICommand cmdPdf;
        private Janus.Windows.UI.CommandBars.UICommand cmdWork1;
    }
}