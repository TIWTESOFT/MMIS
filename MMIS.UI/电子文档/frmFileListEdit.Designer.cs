namespace MMIS.UI
{
    public partial class frmFileListEdit
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
            this.lblFileNo = new MMIS.Component.XLabel();
            this.lblFileName = new MMIS.Component.XLabel();
            this.lblFileDesc = new MMIS.Component.XLabel();
            this.lblFolderTypeId = new MMIS.Component.XLabel();
            this.lblFileTypeId = new MMIS.Component.XLabel();
            this.lblFileLevelId = new MMIS.Component.XLabel();
            this.lblFileStateId = new MMIS.Component.XLabel();
            this.lblPageNum = new MMIS.Component.XLabel();
            this.lblUserId = new MMIS.Component.XLabel();
            this.lblDeptId = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtFileNo = new MMIS.Component.XEditBox();
            this.txtFileName = new MMIS.Component.XEditBox();
            this.txtFileDesc = new MMIS.Component.XEditBox();
            this.nebPageNum = new MMIS.Component.XNumberEditBox();
            this.txtUserId = new MMIS.Component.XEditBox();
            this.txtDeptId = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.txtFilePath = new MMIS.Component.XEditBox();
            this.txtFolderTypeId = new MMIS.UI.XSelectCodeFolderTypeEditBox();
            this.txtFileStateId = new MMIS.UI.XSelectFileStatusEditBox();
            this.txtFileLevelId = new MMIS.UI.XSelectFileLvelEditBox();
            this.txtFileTypeId = new MMIS.UI.XSelectFileTypeEditBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(356, 250);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(443, 250);
            // 
            // lblFileNo
            // 
            this.lblFileNo.AutoSize = true;
            this.lblFileNo.ForeColor = System.Drawing.Color.Black;
            this.lblFileNo.Location = new System.Drawing.Point(14, 47);
            this.lblFileNo.Name = "lblFileNo";
            this.lblFileNo.Size = new System.Drawing.Size(56, 17);
            this.lblFileNo.TabIndex = 1;
            this.lblFileNo.Text = "文档编号";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(207, 47);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(56, 17);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "文档名称";
            // 
            // lblFileDesc
            // 
            this.lblFileDesc.AutoSize = true;
            this.lblFileDesc.ForeColor = System.Drawing.Color.Black;
            this.lblFileDesc.Location = new System.Drawing.Point(14, 79);
            this.lblFileDesc.Name = "lblFileDesc";
            this.lblFileDesc.Size = new System.Drawing.Size(56, 17);
            this.lblFileDesc.TabIndex = 3;
            this.lblFileDesc.Text = "文档描述";
            // 
            // lblFolderTypeId
            // 
            this.lblFolderTypeId.AutoSize = true;
            this.lblFolderTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblFolderTypeId.Location = new System.Drawing.Point(5, 112);
            this.lblFolderTypeId.Name = "lblFolderTypeId";
            this.lblFolderTypeId.Size = new System.Drawing.Size(68, 17);
            this.lblFolderTypeId.TabIndex = 4;
            this.lblFolderTypeId.Text = "文件夹类型";
            // 
            // lblFileTypeId
            // 
            this.lblFileTypeId.AutoSize = true;
            this.lblFileTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblFileTypeId.Location = new System.Drawing.Point(272, 111);
            this.lblFileTypeId.Name = "lblFileTypeId";
            this.lblFileTypeId.Size = new System.Drawing.Size(56, 17);
            this.lblFileTypeId.TabIndex = 5;
            this.lblFileTypeId.Text = "文档类型";
            // 
            // lblFileLevelId
            // 
            this.lblFileLevelId.AutoSize = true;
            this.lblFileLevelId.ForeColor = System.Drawing.Color.Black;
            this.lblFileLevelId.Location = new System.Drawing.Point(14, 142);
            this.lblFileLevelId.Name = "lblFileLevelId";
            this.lblFileLevelId.Size = new System.Drawing.Size(56, 17);
            this.lblFileLevelId.TabIndex = 6;
            this.lblFileLevelId.Text = "文档级别";
            // 
            // lblFileStateId
            // 
            this.lblFileStateId.AutoSize = true;
            this.lblFileStateId.ForeColor = System.Drawing.Color.Black;
            this.lblFileStateId.Location = new System.Drawing.Point(272, 142);
            this.lblFileStateId.Name = "lblFileStateId";
            this.lblFileStateId.Size = new System.Drawing.Size(56, 17);
            this.lblFileStateId.TabIndex = 7;
            this.lblFileStateId.Text = "文档状态";
            // 
            // lblPageNum
            // 
            this.lblPageNum.AutoSize = true;
            this.lblPageNum.ForeColor = System.Drawing.Color.Black;
            this.lblPageNum.Location = new System.Drawing.Point(15, 327);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(56, 17);
            this.lblPageNum.TabIndex = 8;
            this.lblPageNum.Text = "文档页数";
            this.lblPageNum.Visible = false;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.ForeColor = System.Drawing.Color.Black;
            this.lblUserId.Location = new System.Drawing.Point(21, 356);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(45, 17);
            this.lblUserId.TabIndex = 9;
            this.lblUserId.Text = "用户ID";
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.ForeColor = System.Drawing.Color.Black;
            this.lblDeptId.Location = new System.Drawing.Point(21, 387);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(45, 17);
            this.lblDeptId.TabIndex = 10;
            this.lblDeptId.Text = "部门ID";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(14, 174);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 11;
            this.lblRemark.Text = "备注信息";
            // 
            // txtFileNo
            // 
            this.txtFileNo.IsAllowEmpty = true;
            this.txtFileNo.Location = new System.Drawing.Point(76, 44);
            this.txtFileNo.Name = "txtFileNo";
            this.txtFileNo.Size = new System.Drawing.Size(125, 23);
            this.txtFileNo.TabIndex = 1;
            this.txtFileNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileName
            // 
            this.txtFileName.IsAllowEmpty = true;
            this.txtFileName.Location = new System.Drawing.Point(269, 44);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(249, 23);
            this.txtFileName.TabIndex = 3;
            this.txtFileName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileDesc
            // 
            this.txtFileDesc.IsAllowEmpty = true;
            this.txtFileDesc.Location = new System.Drawing.Point(76, 76);
            this.txtFileDesc.Name = "txtFileDesc";
            this.txtFileDesc.Size = new System.Drawing.Size(442, 23);
            this.txtFileDesc.TabIndex = 4;
            this.txtFileDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebPageNum
            // 
            this.nebPageNum.FormatString = "0";
            this.nebPageNum.IsAllowEmpty = false;
            this.nebPageNum.IsAllowLessThanZero = false;
            this.nebPageNum.IsAllowZero = true;
            this.nebPageNum.Location = new System.Drawing.Point(77, 324);
            this.nebPageNum.Name = "nebPageNum";
            this.nebPageNum.Size = new System.Drawing.Size(185, 23);
            this.nebPageNum.TabIndex = 2;
            this.nebPageNum.Text = "0";
            this.nebPageNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebPageNum.Visible = false;
            this.nebPageNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtUserId
            // 
            this.txtUserId.IsAllowEmpty = true;
            this.txtUserId.Location = new System.Drawing.Point(83, 353);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(185, 23);
            this.txtUserId.TabIndex = 9;
            this.txtUserId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtDeptId
            // 
            this.txtDeptId.IsAllowEmpty = true;
            this.txtDeptId.Location = new System.Drawing.Point(83, 384);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.Size = new System.Drawing.Size(185, 23);
            this.txtDeptId.TabIndex = 10;
            this.txtDeptId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(76, 171);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(442, 70);
            this.txtRemark.TabIndex = 9;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(14, 14);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 102;
            this.xLabel1.Text = "文档附件";
            // 
            // txtFilePath
            // 
            this.txtFilePath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFilePath.IsAllowEmpty = true;
            this.txtFilePath.Location = new System.Drawing.Point(76, 11);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(442, 23);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFilePath.ButtonClick += new System.EventHandler(this.txtFilePath_ButtonClick);
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            this.txtFilePath.DoubleClick += new System.EventHandler(this.txtFilePath_DoubleClick);
            // 
            // txtFolderTypeId
            // 
            this.txtFolderTypeId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFolderTypeId.DisplayMember = "";
            this.txtFolderTypeId.IsAllowEmpty = false;
            this.txtFolderTypeId.Location = new System.Drawing.Point(76, 109);
            this.txtFolderTypeId.Name = "txtFolderTypeId";
            this.txtFolderTypeId.QueryCheckBox = null;
            this.txtFolderTypeId.QueryFieldName = null;
            this.txtFolderTypeId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtFolderTypeId.ReadOnly = true;
            this.txtFolderTypeId.SelectedModel = null;
            this.txtFolderTypeId.Size = new System.Drawing.Size(185, 23);
            this.txtFolderTypeId.TabIndex = 106;
            this.txtFolderTypeId.ValueMember = "";
            this.txtFolderTypeId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileStateId
            // 
            this.txtFileStateId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFileStateId.DisplayMember = "";
            this.txtFileStateId.IsAllowEmpty = true;
            this.txtFileStateId.Location = new System.Drawing.Point(334, 140);
            this.txtFileStateId.Name = "txtFileStateId";
            this.txtFileStateId.QueryCheckBox = null;
            this.txtFileStateId.QueryFieldName = null;
            this.txtFileStateId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtFileStateId.ReadOnly = true;
            this.txtFileStateId.SelectedModel = null;
            this.txtFileStateId.Size = new System.Drawing.Size(184, 23);
            this.txtFileStateId.TabIndex = 105;
            this.txtFileStateId.ValueMember = "";
            this.txtFileStateId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileLevelId
            // 
            this.txtFileLevelId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFileLevelId.DisplayMember = "";
            this.txtFileLevelId.IsAllowEmpty = true;
            this.txtFileLevelId.Location = new System.Drawing.Point(76, 140);
            this.txtFileLevelId.Name = "txtFileLevelId";
            this.txtFileLevelId.QueryCheckBox = null;
            this.txtFileLevelId.QueryFieldName = null;
            this.txtFileLevelId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtFileLevelId.ReadOnly = true;
            this.txtFileLevelId.SelectedModel = null;
            this.txtFileLevelId.Size = new System.Drawing.Size(185, 23);
            this.txtFileLevelId.TabIndex = 104;
            this.txtFileLevelId.ValueMember = "";
            this.txtFileLevelId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileTypeId
            // 
            this.txtFileTypeId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFileTypeId.DisplayMember = "";
            this.txtFileTypeId.IsAllowEmpty = true;
            this.txtFileTypeId.Location = new System.Drawing.Point(333, 109);
            this.txtFileTypeId.Name = "txtFileTypeId";
            this.txtFileTypeId.QueryCheckBox = null;
            this.txtFileTypeId.QueryFieldName = null;
            this.txtFileTypeId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtFileTypeId.ReadOnly = true;
            this.txtFileTypeId.SelectedModel = null;
            this.txtFileTypeId.Size = new System.Drawing.Size(185, 23);
            this.txtFileTypeId.TabIndex = 103;
            this.txtFileTypeId.ValueMember = "";
            this.txtFileTypeId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmFileListEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(530, 289);
            this.Controls.Add(this.txtFolderTypeId);
            this.Controls.Add(this.txtFileStateId);
            this.Controls.Add(this.txtFileLevelId);
            this.Controls.Add(this.txtFileTypeId);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtFileNo);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtFileDesc);
            this.Controls.Add(this.nebPageNum);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblFileNo);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblFileDesc);
            this.Controls.Add(this.lblFolderTypeId);
            this.Controls.Add(this.lblFileTypeId);
            this.Controls.Add(this.lblFileLevelId);
            this.Controls.Add(this.lblFileStateId);
            this.Controls.Add(this.lblPageNum);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmFileListEdit";
            this.Text = "文档信息";
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblDeptId, 0);
            this.Controls.SetChildIndex(this.lblUserId, 0);
            this.Controls.SetChildIndex(this.lblPageNum, 0);
            this.Controls.SetChildIndex(this.lblFileStateId, 0);
            this.Controls.SetChildIndex(this.lblFileLevelId, 0);
            this.Controls.SetChildIndex(this.lblFileTypeId, 0);
            this.Controls.SetChildIndex(this.lblFolderTypeId, 0);
            this.Controls.SetChildIndex(this.lblFileDesc, 0);
            this.Controls.SetChildIndex(this.lblFileName, 0);
            this.Controls.SetChildIndex(this.lblFileNo, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtDeptId, 0);
            this.Controls.SetChildIndex(this.txtUserId, 0);
            this.Controls.SetChildIndex(this.nebPageNum, 0);
            this.Controls.SetChildIndex(this.txtFileDesc, 0);
            this.Controls.SetChildIndex(this.txtFileName, 0);
            this.Controls.SetChildIndex(this.txtFileNo, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtFilePath, 0);
            this.Controls.SetChildIndex(this.txtFileTypeId, 0);
            this.Controls.SetChildIndex(this.txtFileLevelId, 0);
            this.Controls.SetChildIndex(this.txtFileStateId, 0);
            this.Controls.SetChildIndex(this.txtFolderTypeId, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblFileNo;
        private MMIS.Component.XLabel lblFileName;
        private MMIS.Component.XLabel lblFileDesc;
        private MMIS.Component.XLabel lblFolderTypeId;
        private MMIS.Component.XLabel lblFileTypeId;
        private MMIS.Component.XLabel lblFileLevelId;
        private MMIS.Component.XLabel lblFileStateId;
        private MMIS.Component.XLabel lblPageNum;
        private MMIS.Component.XLabel lblUserId;
        private MMIS.Component.XLabel lblDeptId;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtFileNo;
        private MMIS.Component.XEditBox txtFileName;
        private MMIS.Component.XEditBox txtFileDesc;
        private MMIS.Component.XNumberEditBox nebPageNum;
        private MMIS.Component.XEditBox txtUserId;
        private MMIS.Component.XEditBox txtDeptId;
        private MMIS.Component.XEditBox txtRemark;
        private Component.XLabel xLabel1;
        private Component.XEditBox txtFilePath;
        private XSelectFileTypeEditBox txtFileTypeId;
        private XSelectFileLvelEditBox txtFileLevelId;
        private XSelectFileStatusEditBox txtFileStateId;
        private XSelectCodeFolderTypeEditBox txtFolderTypeId;
        
    }
}