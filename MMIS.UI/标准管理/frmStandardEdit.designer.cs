namespace MMIS.UI
{
    public partial class frmStandardEdit
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
            Janus.Windows.GridEX.GridEXLayout grdFiles_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStandardEdit));
            Janus.Windows.GridEX.GridEXLayout grdEquipments_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            this.lblStandNo = new MMIS.Component.XLabel();
            this.lblStandName = new MMIS.Component.XLabel();
            this.lblCreateTime = new MMIS.Component.XLabel();
            this.lblNextCheckTime = new MMIS.Component.XLabel();
            this.lblCheckTimes = new MMIS.Component.XLabel();
            this.lblChargeUserId = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtStandNo = new MMIS.Component.XEditBox();
            this.txtStandName = new MMIS.Component.XEditBox();
            this.dtCreateTime = new MMIS.Component.XDateTimePicker();
            this.dtNextCheckTime = new MMIS.Component.XDateTimePicker();
            this.nebCheckTimes = new MMIS.Component.XNumberEditBox();
            this.txtChargeUserId = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtStandDesc = new MMIS.Component.XEditBox();
            this.grdFiles = new MMIS.Component.XGridEx();
            this.btnDeleteFile = new MMIS.Component.XButton();
            this.btnEditFile = new MMIS.Component.XButton();
            this.btnAddNewFile = new MMIS.Component.XButton();
            this.grdEquipments = new MMIS.Component.XGridEx();
            this.btnDeleteEquipment = new MMIS.Component.XButton();
            this.btnEditEquipment = new MMIS.Component.XButton();
            this.btnAddNewEquipment = new MMIS.Component.XButton();
            this.cboStatus = new MMIS.Component.XCombobox();
            this.txtStatus111 = new MMIS.UI.XSelectCodeStandStatusEditBox();
            this.pageFiles = new Janus.Windows.UI.Tab.UITabPage();
            this.pageEquipments = new Janus.Windows.UI.Tab.UITabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.tabDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipments)).BeginInit();
            this.pageFiles.SuspendLayout();
            this.pageEquipments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDetail
            // 
            this.tabDetail.Location = new System.Drawing.Point(12, 130);
            this.tabDetail.Size = new System.Drawing.Size(785, 313);
            this.tabDetail.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.pageFiles,
            this.pageEquipments});
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(635, 452);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(722, 452);
            // 
            // lblStandNo
            // 
            this.lblStandNo.AutoSize = true;
            this.lblStandNo.ForeColor = System.Drawing.Color.Black;
            this.lblStandNo.Location = new System.Drawing.Point(18, 15);
            this.lblStandNo.Name = "lblStandNo";
            this.lblStandNo.Size = new System.Drawing.Size(56, 17);
            this.lblStandNo.TabIndex = 1;
            this.lblStandNo.Text = "标准编号";
            // 
            // lblStandName
            // 
            this.lblStandName.AutoSize = true;
            this.lblStandName.ForeColor = System.Drawing.Color.Black;
            this.lblStandName.Location = new System.Drawing.Point(270, 15);
            this.lblStandName.Name = "lblStandName";
            this.lblStandName.Size = new System.Drawing.Size(56, 17);
            this.lblStandName.TabIndex = 2;
            this.lblStandName.Text = "标准名称";
            // 
            // lblCreateTime
            // 
            this.lblCreateTime.AutoSize = true;
            this.lblCreateTime.ForeColor = System.Drawing.Color.Black;
            this.lblCreateTime.Location = new System.Drawing.Point(550, 15);
            this.lblCreateTime.Name = "lblCreateTime";
            this.lblCreateTime.Size = new System.Drawing.Size(56, 17);
            this.lblCreateTime.TabIndex = 3;
            this.lblCreateTime.Text = "创建时间";
            // 
            // lblNextCheckTime
            // 
            this.lblNextCheckTime.AutoSize = true;
            this.lblNextCheckTime.ForeColor = System.Drawing.Color.Black;
            this.lblNextCheckTime.Location = new System.Drawing.Point(18, 44);
            this.lblNextCheckTime.Name = "lblNextCheckTime";
            this.lblNextCheckTime.Size = new System.Drawing.Size(80, 17);
            this.lblNextCheckTime.TabIndex = 4;
            this.lblNextCheckTime.Text = "下次考核时间";
            // 
            // lblCheckTimes
            // 
            this.lblCheckTimes.AutoSize = true;
            this.lblCheckTimes.ForeColor = System.Drawing.Color.Black;
            this.lblCheckTimes.Location = new System.Drawing.Point(258, 44);
            this.lblCheckTimes.Name = "lblCheckTimes";
            this.lblCheckTimes.Size = new System.Drawing.Size(68, 17);
            this.lblCheckTimes.TabIndex = 5;
            this.lblCheckTimes.Text = "已考核次数";
            // 
            // lblChargeUserId
            // 
            this.lblChargeUserId.AutoSize = true;
            this.lblChargeUserId.ForeColor = System.Drawing.Color.Black;
            this.lblChargeUserId.Location = new System.Drawing.Point(436, 44);
            this.lblChargeUserId.Name = "lblChargeUserId";
            this.lblChargeUserId.Size = new System.Drawing.Size(44, 17);
            this.lblChargeUserId.TabIndex = 6;
            this.lblChargeUserId.Text = "负责人";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(18, 101);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 7;
            this.lblRemark.Text = "备注信息";
            // 
            // txtStandNo
            // 
            this.txtStandNo.IsAllowEmpty = false;
            this.txtStandNo.Location = new System.Drawing.Point(79, 12);
            this.txtStandNo.Name = "txtStandNo";
            this.txtStandNo.Size = new System.Drawing.Size(185, 23);
            this.txtStandNo.TabIndex = 0;
            this.txtStandNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtStandName
            // 
            this.txtStandName.IsAllowEmpty = false;
            this.txtStandName.Location = new System.Drawing.Point(349, 12);
            this.txtStandName.Name = "txtStandName";
            this.txtStandName.Size = new System.Drawing.Size(185, 23);
            this.txtStandName.TabIndex = 1;
            this.txtStandName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtCreateTime
            // 
            this.dtCreateTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtCreateTime.DropDownCalendar.Name = "";
            this.dtCreateTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtCreateTime.Location = new System.Drawing.Point(612, 12);
            this.dtCreateTime.Name = "dtCreateTime";
            this.dtCreateTime.Size = new System.Drawing.Size(185, 23);
            this.dtCreateTime.TabIndex = 2;
            this.dtCreateTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtNextCheckTime
            // 
            this.dtNextCheckTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtNextCheckTime.DropDownCalendar.Name = "";
            this.dtNextCheckTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtNextCheckTime.Location = new System.Drawing.Point(104, 41);
            this.dtNextCheckTime.Name = "dtNextCheckTime";
            this.dtNextCheckTime.Size = new System.Drawing.Size(148, 23);
            this.dtNextCheckTime.TabIndex = 3;
            this.dtNextCheckTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // nebCheckTimes
            // 
            this.nebCheckTimes.FormatString = "0";
            this.nebCheckTimes.IsAllowEmpty = false;
            this.nebCheckTimes.IsAllowLessThanZero = false;
            this.nebCheckTimes.IsAllowZero = true;
            this.nebCheckTimes.Location = new System.Drawing.Point(332, 41);
            this.nebCheckTimes.Name = "nebCheckTimes";
            this.nebCheckTimes.Size = new System.Drawing.Size(98, 23);
            this.nebCheckTimes.TabIndex = 4;
            this.nebCheckTimes.Text = "0";
            this.nebCheckTimes.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebCheckTimes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtChargeUserId
            // 
            this.txtChargeUserId.IsAllowEmpty = false;
            this.txtChargeUserId.Location = new System.Drawing.Point(486, 41);
            this.txtChargeUserId.Name = "txtChargeUserId";
            this.txtChargeUserId.Size = new System.Drawing.Size(127, 23);
            this.txtChargeUserId.TabIndex = 5;
            this.txtChargeUserId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(79, 99);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(718, 23);
            this.txtRemark.TabIndex = 8;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(621, 44);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 101;
            this.xLabel1.Text = "标准状态";
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(18, 72);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 103;
            this.xLabel2.Text = "标准描述";
            // 
            // txtStandDesc
            // 
            this.txtStandDesc.IsAllowEmpty = true;
            this.txtStandDesc.Location = new System.Drawing.Point(80, 70);
            this.txtStandDesc.Name = "txtStandDesc";
            this.txtStandDesc.Size = new System.Drawing.Size(717, 23);
            this.txtStandDesc.TabIndex = 7;
            this.txtStandDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // grdFiles
            // 
            this.grdFiles.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdFiles.AlternatingColors = true;
            this.grdFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFiles.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>拖动列名至此" +
    "进行分组</GroupByBoxInfo></LocalizableData>";
            grdFiles_DesignTimeLayout.LayoutString = resources.GetString("grdFiles_DesignTimeLayout.LayoutString");
            this.grdFiles.DesignTimeLayout = grdFiles_DesignTimeLayout;
            this.grdFiles.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdFiles.GroupByBoxVisible = false;
            this.grdFiles.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdFiles.Location = new System.Drawing.Point(8, 9);
            this.grdFiles.Name = "grdFiles";
            this.grdFiles.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdFiles.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdFiles.Size = new System.Drawing.Size(681, 270);
            this.grdFiles.TabIndex = 5;
            this.grdFiles.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFile.Location = new System.Drawing.Point(698, 67);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFile.TabIndex = 4;
            this.btnDeleteFile.Text = "删除";
            this.btnDeleteFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // btnEditFile
            // 
            this.btnEditFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditFile.Location = new System.Drawing.Point(698, 38);
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.Size = new System.Drawing.Size(75, 23);
            this.btnEditFile.TabIndex = 3;
            this.btnEditFile.Text = "修改";
            this.btnEditFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // btnAddNewFile
            // 
            this.btnAddNewFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewFile.Location = new System.Drawing.Point(698, 9);
            this.btnAddNewFile.Name = "btnAddNewFile";
            this.btnAddNewFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewFile.TabIndex = 2;
            this.btnAddNewFile.Text = "添加";
            this.btnAddNewFile.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // grdEquipments
            // 
            this.grdEquipments.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdEquipments.AlternatingColors = true;
            this.grdEquipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEquipments.BuiltInTextsData = "<LocalizableData ID=\"LocalizableStrings\" Collection=\"true\"><GroupByBoxInfo>拖动列名至此" +
    "进行分组</GroupByBoxInfo></LocalizableData>";
            grdEquipments_DesignTimeLayout.LayoutString = resources.GetString("grdEquipments_DesignTimeLayout.LayoutString");
            this.grdEquipments.DesignTimeLayout = grdEquipments_DesignTimeLayout;
            this.grdEquipments.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grdEquipments.GroupByBoxVisible = false;
            this.grdEquipments.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.grdEquipments.Location = new System.Drawing.Point(8, 9);
            this.grdEquipments.Name = "grdEquipments";
            this.grdEquipments.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdEquipments.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdEquipments.Size = new System.Drawing.Size(681, 270);
            this.grdEquipments.TabIndex = 9;
            this.grdEquipments.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteEquipment.Location = new System.Drawing.Point(698, 67);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEquipment.TabIndex = 8;
            this.btnDeleteEquipment.Text = "删除";
            this.btnDeleteEquipment.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditEquipment.Location = new System.Drawing.Point(698, 38);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnEditEquipment.TabIndex = 7;
            this.btnEditEquipment.Text = "修改";
            this.btnEditEquipment.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // btnAddNewEquipment
            // 
            this.btnAddNewEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewEquipment.Location = new System.Drawing.Point(698, 9);
            this.btnAddNewEquipment.Name = "btnAddNewEquipment";
            this.btnAddNewEquipment.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewEquipment.TabIndex = 6;
            this.btnAddNewEquipment.Text = "添加";
            this.btnAddNewEquipment.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // cboStatus
            // 
            this.cboStatus.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cboStatus.IsAllowEmpty = false;
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.IsSeparator = false;
            uiComboBoxItem1.Text = "正常";
            uiComboBoxItem1.Value = "正常";
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.IsSeparator = false;
            uiComboBoxItem2.Text = "送检";
            uiComboBoxItem2.Value = "送检";
            this.cboStatus.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2});
            this.cboStatus.Location = new System.Drawing.Point(694, 41);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(103, 23);
            this.cboStatus.TabIndex = 104;
            this.cboStatus.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // txtStatus111
            // 
            this.txtStatus111.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtStatus111.DisplayMember = "";
            this.txtStatus111.IsAllowEmpty = false;
            this.txtStatus111.Location = new System.Drawing.Point(12, 456);
            this.txtStatus111.Name = "txtStatus111";
            this.txtStatus111.QueryCheckBox = null;
            this.txtStatus111.QueryFieldName = null;
            this.txtStatus111.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtStatus111.ReadOnly = true;
            this.txtStatus111.SelectedModel = null;
            this.txtStatus111.Size = new System.Drawing.Size(114, 23);
            this.txtStatus111.TabIndex = 6;
            this.txtStatus111.ValueMember = "";
            this.txtStatus111.Visible = false;
            this.txtStatus111.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // pageFiles
            // 
            this.pageFiles.Controls.Add(this.grdFiles);
            this.pageFiles.Controls.Add(this.btnDeleteFile);
            this.pageFiles.Controls.Add(this.btnEditFile);
            this.pageFiles.Controls.Add(this.btnAddNewFile);
            this.pageFiles.Location = new System.Drawing.Point(1, 25);
            this.pageFiles.Name = "pageFiles";
            this.pageFiles.Size = new System.Drawing.Size(783, 287);
            this.pageFiles.TabStop = true;
            this.pageFiles.Text = "标准文件集";
            // 
            // pageEquipments
            // 
            this.pageEquipments.Controls.Add(this.grdEquipments);
            this.pageEquipments.Controls.Add(this.btnDeleteEquipment);
            this.pageEquipments.Controls.Add(this.btnEditEquipment);
            this.pageEquipments.Controls.Add(this.btnAddNewEquipment);
            this.pageEquipments.Location = new System.Drawing.Point(1, 25);
            this.pageEquipments.Name = "pageEquipments";
            this.pageEquipments.Size = new System.Drawing.Size(783, 287);
            this.pageEquipments.TabStop = true;
            this.pageEquipments.Text = "标准设备";
            // 
            // frmStandardEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(813, 489);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtStatus111);
            this.Controls.Add(this.txtStandDesc);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtStandNo);
            this.Controls.Add(this.txtStandName);
            this.Controls.Add(this.dtCreateTime);
            this.Controls.Add(this.dtNextCheckTime);
            this.Controls.Add(this.nebCheckTimes);
            this.Controls.Add(this.txtChargeUserId);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblStandNo);
            this.Controls.Add(this.lblStandName);
            this.Controls.Add(this.lblCreateTime);
            this.Controls.Add(this.lblNextCheckTime);
            this.Controls.Add(this.lblCheckTimes);
            this.Controls.Add(this.lblChargeUserId);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmStandardEdit";
            this.Text = "计量标准";
            this.Controls.SetChildIndex(this.tabDetail, 0);
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblChargeUserId, 0);
            this.Controls.SetChildIndex(this.lblCheckTimes, 0);
            this.Controls.SetChildIndex(this.lblNextCheckTime, 0);
            this.Controls.SetChildIndex(this.lblCreateTime, 0);
            this.Controls.SetChildIndex(this.lblStandName, 0);
            this.Controls.SetChildIndex(this.lblStandNo, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtChargeUserId, 0);
            this.Controls.SetChildIndex(this.nebCheckTimes, 0);
            this.Controls.SetChildIndex(this.dtNextCheckTime, 0);
            this.Controls.SetChildIndex(this.dtCreateTime, 0);
            this.Controls.SetChildIndex(this.txtStandName, 0);
            this.Controls.SetChildIndex(this.txtStandNo, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.xLabel2, 0);
            this.Controls.SetChildIndex(this.txtStandDesc, 0);
            this.Controls.SetChildIndex(this.txtStatus111, 0);
            this.Controls.SetChildIndex(this.cboStatus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.tabDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEquipments)).EndInit();
            this.pageFiles.ResumeLayout(false);
            this.pageEquipments.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblStandNo;
        private MMIS.Component.XLabel lblStandName;
        private MMIS.Component.XLabel lblCreateTime;
        private MMIS.Component.XLabel lblNextCheckTime;
        private MMIS.Component.XLabel lblCheckTimes;
        private MMIS.Component.XLabel lblChargeUserId;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtStandNo;
        private MMIS.Component.XEditBox txtStandName;
        private MMIS.Component.XDateTimePicker dtCreateTime;
        private MMIS.Component.XDateTimePicker dtNextCheckTime;
        private MMIS.Component.XNumberEditBox nebCheckTimes;
        private MMIS.Component.XEditBox txtChargeUserId;
        private MMIS.Component.XEditBox txtRemark;
        private Component.XLabel xLabel1;
        private Component.XLabel xLabel2;
        private Component.XEditBox txtStandDesc;
        private XSelectCodeStandStatusEditBox txtStatus111;
        private Janus.Windows.UI.Tab.UITabPage pageFiles;
        private Janus.Windows.UI.Tab.UITabPage pageEquipments;
        protected Component.XButton btnAddNewFile;
        protected Component.XButton btnEditFile;
        protected Component.XButton btnDeleteFile;
        protected Component.XGridEx grdFiles;
        protected Component.XGridEx grdEquipments;
        protected Component.XButton btnDeleteEquipment;
        protected Component.XButton btnEditEquipment;
        protected Component.XButton btnAddNewEquipment;
        private Component.XCombobox cboStatus;
        
    }
}