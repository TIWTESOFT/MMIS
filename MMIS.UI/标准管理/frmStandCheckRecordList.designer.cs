﻿namespace MMIS.UI
{
    public partial class frmStandCheckRecordList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStandCheckRecordList));
            this.xLabel1 = new MMIS.Component.XLabel();
            this.xSelectStanderEditBox1 = new MMIS.UI.XSelectStanderEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.dtBegin = new MMIS.Component.XQueryDatePicker();
            this.dtEnd = new MMIS.Component.XQueryDatePicker();
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
            this.grdData.Size = new System.Drawing.Size(765, 268);
            // 
            // grpQuery
            // 
            this.grpQuery.Controls.Add(this.dtEnd);
            this.grpQuery.Controls.Add(this.dtBegin);
            this.grpQuery.Controls.Add(this.xLabel2);
            this.grpQuery.Controls.Add(this.xSelectStanderEditBox1);
            this.grpQuery.Controls.Add(this.xLabel1);
            this.grpQuery.Size = new System.Drawing.Size(774, 55);
            this.grpQuery.Controls.SetChildIndex(this.btnQuery, 0);
            this.grpQuery.Controls.SetChildIndex(this.chkChecked, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xSelectStanderEditBox1, 0);
            this.grpQuery.Controls.SetChildIndex(this.xLabel2, 0);
            this.grpQuery.Controls.SetChildIndex(this.dtBegin, 0);
            this.grpQuery.Controls.SetChildIndex(this.dtEnd, 0);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(848, 18);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(785, 73);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(785, 288);
            // 
            // panel7
            // 
            this.panel7.Size = new System.Drawing.Size(765, 10);
            // 
            // panel8
            // 
            this.panel8.Size = new System.Drawing.Size(765, 268);
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
            this.chkChecked.Location = new System.Drawing.Point(779, 20);
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(8, 24);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 1001;
            this.xLabel1.Text = "标准名称";
            // 
            // xSelectStanderEditBox1
            // 
            this.xSelectStanderEditBox1.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.xSelectStanderEditBox1.DisplayMember = "";
            this.xSelectStanderEditBox1.IsAllowEmpty = false;
            this.xSelectStanderEditBox1.Location = new System.Drawing.Point(69, 21);
            this.xSelectStanderEditBox1.Name = "xSelectStanderEditBox1";
            this.xSelectStanderEditBox1.QueryCheckBox = null;
            this.xSelectStanderEditBox1.QueryFieldName = "StandId";
            this.xSelectStanderEditBox1.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.xSelectStanderEditBox1.ReadOnly = true;
            this.xSelectStanderEditBox1.SelectedModel = null;
            this.xSelectStanderEditBox1.Size = new System.Drawing.Size(187, 23);
            this.xSelectStanderEditBox1.TabIndex = 1002;
            this.xSelectStanderEditBox1.ValueMember = "";
            this.xSelectStanderEditBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(262, 25);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 1003;
            this.xLabel2.Text = "标准日期";
            // 
            // dtBegin
            // 
            // 
            // 
            // 
            this.dtBegin.DropDownCalendar.Name = "";
            this.dtBegin.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtBegin.Location = new System.Drawing.Point(324, 21);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.QueryCheckBox = null;
            this.dtBegin.QueryFieldName = "CheckDate";
            this.dtBegin.QueryOperateType = MMIS.Component.XQueryOperateType.MoreThanOrEqual;
            this.dtBegin.ShowCheckBox = true;
            this.dtBegin.Size = new System.Drawing.Size(110, 23);
            this.dtBegin.TabIndex = 1004;
            this.dtBegin.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtEnd
            // 
            // 
            // 
            // 
            this.dtEnd.DropDownCalendar.Name = "";
            this.dtEnd.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtEnd.Location = new System.Drawing.Point(440, 21);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.QueryCheckBox = null;
            this.dtEnd.QueryFieldName = "CheckDate";
            this.dtEnd.QueryOperateType = MMIS.Component.XQueryOperateType.LessThanOrEqual;
            this.dtEnd.ShowCheckBox = true;
            this.dtEnd.Size = new System.Drawing.Size(110, 23);
            this.dtEnd.TabIndex = 1005;
            this.dtEnd.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // frmStandCheckRecordList
            // 
            this.ClientSize = new System.Drawing.Size(785, 389);
            this.Name = "frmStandCheckRecordList";
            this.Text = "标准送检";
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

        private Component.XLabel xLabel1;
        private XSelectStanderEditBox xSelectStanderEditBox1;
        private Component.XLabel xLabel2;
        private Component.XQueryDatePicker dtBegin;
        private Component.XQueryDatePicker dtEnd;
        
    }
}