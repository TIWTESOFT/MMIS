namespace MMIS.UI
{
    public partial class frmMeetingProjectEdit
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
            this.lblProjectName = new MMIS.Component.XLabel();
            this.lblProjectDesc = new MMIS.Component.XLabel();
            this.lblStartTime = new MMIS.Component.XLabel();
            this.lblEndTime = new MMIS.Component.XLabel();
            this.lblPurveyor = new MMIS.Component.XLabel();
            this.lblLinkman = new MMIS.Component.XLabel();
            this.lblTel = new MMIS.Component.XLabel();
            this.lblProjectTypeId = new MMIS.Component.XLabel();
            this.lblDeptId = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtProjectName = new MMIS.Component.XEditBox();
            this.txtProjectDesc = new MMIS.Component.XEditBox();
            this.dtStartTime = new MMIS.Component.XDateTimePicker();
            this.dtEndTime = new MMIS.Component.XDateTimePicker();
            this.txtPurveyor = new MMIS.Component.XEditBox();
            this.txtLinkman = new MMIS.Component.XEditBox();
            this.txtTel = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.txtDeptId = new MMIS.UI.XSelectUseDeptEditBox();
            this.txtProjectTypeId = new MMIS.UI.XSelectProjectTypeEditBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(380, 232);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(467, 232);
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.ForeColor = System.Drawing.Color.Black;
            this.lblProjectName.Location = new System.Drawing.Point(11, 15);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(56, 17);
            this.lblProjectName.TabIndex = 1;
            this.lblProjectName.Text = "工程名称";
            // 
            // lblProjectDesc
            // 
            this.lblProjectDesc.AutoSize = true;
            this.lblProjectDesc.ForeColor = System.Drawing.Color.Black;
            this.lblProjectDesc.Location = new System.Drawing.Point(11, 45);
            this.lblProjectDesc.Name = "lblProjectDesc";
            this.lblProjectDesc.Size = new System.Drawing.Size(56, 17);
            this.lblProjectDesc.TabIndex = 2;
            this.lblProjectDesc.Text = "工程描述";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.ForeColor = System.Drawing.Color.Black;
            this.lblStartTime.Location = new System.Drawing.Point(11, 75);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(80, 17);
            this.lblStartTime.TabIndex = 3;
            this.lblStartTime.Text = "预计开始时间";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.ForeColor = System.Drawing.Color.Black;
            this.lblEndTime.Location = new System.Drawing.Point(276, 75);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(80, 17);
            this.lblEndTime.TabIndex = 4;
            this.lblEndTime.Text = "预计结束时间";
            // 
            // lblPurveyor
            // 
            this.lblPurveyor.AutoSize = true;
            this.lblPurveyor.ForeColor = System.Drawing.Color.Black;
            this.lblPurveyor.Location = new System.Drawing.Point(11, 104);
            this.lblPurveyor.Name = "lblPurveyor";
            this.lblPurveyor.Size = new System.Drawing.Size(44, 17);
            this.lblPurveyor.TabIndex = 5;
            this.lblPurveyor.Text = "承办商";
            // 
            // lblLinkman
            // 
            this.lblLinkman.AutoSize = true;
            this.lblLinkman.ForeColor = System.Drawing.Color.Black;
            this.lblLinkman.Location = new System.Drawing.Point(12, 136);
            this.lblLinkman.Name = "lblLinkman";
            this.lblLinkman.Size = new System.Drawing.Size(44, 17);
            this.lblLinkman.TabIndex = 6;
            this.lblLinkman.Text = "联系人";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(300, 136);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(56, 17);
            this.lblTel.TabIndex = 7;
            this.lblTel.Text = "联系电话";
            // 
            // lblProjectTypeId
            // 
            this.lblProjectTypeId.AutoSize = true;
            this.lblProjectTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblProjectTypeId.Location = new System.Drawing.Point(11, 168);
            this.lblProjectTypeId.Name = "lblProjectTypeId";
            this.lblProjectTypeId.Size = new System.Drawing.Size(80, 17);
            this.lblProjectTypeId.TabIndex = 8;
            this.lblProjectTypeId.Text = "工程资料类别";
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.ForeColor = System.Drawing.Color.Black;
            this.lblDeptId.Location = new System.Drawing.Point(300, 168);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(56, 17);
            this.lblDeptId.TabIndex = 9;
            this.lblDeptId.Text = "部门名称";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(11, 201);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 10;
            this.lblRemark.Text = "备注信息";
            // 
            // txtProjectName
            // 
            this.txtProjectName.IsAllowEmpty = false;
            this.txtProjectName.Location = new System.Drawing.Point(73, 12);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(469, 23);
            this.txtProjectName.TabIndex = 0;
            this.txtProjectName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtProjectDesc
            // 
            this.txtProjectDesc.IsAllowEmpty = true;
            this.txtProjectDesc.Location = new System.Drawing.Point(73, 42);
            this.txtProjectDesc.Name = "txtProjectDesc";
            this.txtProjectDesc.Size = new System.Drawing.Size(469, 23);
            this.txtProjectDesc.TabIndex = 1;
            this.txtProjectDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtStartTime.DropDownCalendar.Name = "";
            this.dtStartTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtStartTime.Location = new System.Drawing.Point(94, 72);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(175, 23);
            this.dtStartTime.TabIndex = 2;
            this.dtStartTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtEndTime
            // 
            this.dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            // 
            // 
            // 
            this.dtEndTime.DropDownCalendar.Name = "";
            this.dtEndTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            this.dtEndTime.Location = new System.Drawing.Point(357, 72);
            this.dtEndTime.Name = "dtEndTime";
            this.dtEndTime.Size = new System.Drawing.Size(185, 23);
            this.dtEndTime.TabIndex = 3;
            this.dtEndTime.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // txtPurveyor
            // 
            this.txtPurveyor.IsAllowEmpty = true;
            this.txtPurveyor.Location = new System.Drawing.Point(73, 104);
            this.txtPurveyor.Name = "txtPurveyor";
            this.txtPurveyor.Size = new System.Drawing.Size(469, 23);
            this.txtPurveyor.TabIndex = 4;
            this.txtPurveyor.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtLinkman
            // 
            this.txtLinkman.IsAllowEmpty = true;
            this.txtLinkman.Location = new System.Drawing.Point(73, 134);
            this.txtLinkman.Name = "txtLinkman";
            this.txtLinkman.Size = new System.Drawing.Size(196, 23);
            this.txtLinkman.TabIndex = 5;
            this.txtLinkman.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtTel
            // 
            this.txtTel.IsAllowEmpty = true;
            this.txtTel.Location = new System.Drawing.Point(357, 134);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 23);
            this.txtTel.TabIndex = 6;
            this.txtTel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(73, 198);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(469, 23);
            this.txtRemark.TabIndex = 9;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtDeptId
            // 
            this.txtDeptId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtDeptId.DisplayMember = "";
            this.txtDeptId.IsAllowEmpty = false;
            this.txtDeptId.Location = new System.Drawing.Point(357, 165);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.QueryCheckBox = null;
            this.txtDeptId.QueryFieldName = null;
            this.txtDeptId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtDeptId.ReadOnly = true;
            this.txtDeptId.SelectedModel = null;
            this.txtDeptId.Size = new System.Drawing.Size(185, 23);
            this.txtDeptId.TabIndex = 101;
            this.txtDeptId.ValueMember = "";
            this.txtDeptId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtProjectTypeId
            // 
            this.txtProjectTypeId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtProjectTypeId.DisplayMember = "";
            this.txtProjectTypeId.IsAllowEmpty = false;
            this.txtProjectTypeId.Location = new System.Drawing.Point(97, 165);
            this.txtProjectTypeId.Name = "txtProjectTypeId";
            this.txtProjectTypeId.QueryCheckBox = null;
            this.txtProjectTypeId.QueryFieldName = null;
            this.txtProjectTypeId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtProjectTypeId.ReadOnly = true;
            this.txtProjectTypeId.SelectedModel = null;
            this.txtProjectTypeId.Size = new System.Drawing.Size(172, 23);
            this.txtProjectTypeId.TabIndex = 102;
            this.txtProjectTypeId.ValueMember = "";
            this.txtProjectTypeId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmMeetingProjectEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(554, 271);
            this.Controls.Add(this.txtProjectTypeId);
            this.Controls.Add(this.txtDeptId);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtProjectDesc);
            this.Controls.Add(this.dtStartTime);
            this.Controls.Add(this.dtEndTime);
            this.Controls.Add(this.txtPurveyor);
            this.Controls.Add(this.txtLinkman);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.lblProjectDesc);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblPurveyor);
            this.Controls.Add(this.lblLinkman);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblProjectTypeId);
            this.Controls.Add(this.lblDeptId);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmMeetingProjectEdit";
            this.Text = "工程信息";
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblDeptId, 0);
            this.Controls.SetChildIndex(this.lblProjectTypeId, 0);
            this.Controls.SetChildIndex(this.lblTel, 0);
            this.Controls.SetChildIndex(this.lblLinkman, 0);
            this.Controls.SetChildIndex(this.lblPurveyor, 0);
            this.Controls.SetChildIndex(this.lblEndTime, 0);
            this.Controls.SetChildIndex(this.lblStartTime, 0);
            this.Controls.SetChildIndex(this.lblProjectDesc, 0);
            this.Controls.SetChildIndex(this.lblProjectName, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtTel, 0);
            this.Controls.SetChildIndex(this.txtLinkman, 0);
            this.Controls.SetChildIndex(this.txtPurveyor, 0);
            this.Controls.SetChildIndex(this.dtEndTime, 0);
            this.Controls.SetChildIndex(this.dtStartTime, 0);
            this.Controls.SetChildIndex(this.txtProjectDesc, 0);
            this.Controls.SetChildIndex(this.txtProjectName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtDeptId, 0);
            this.Controls.SetChildIndex(this.txtProjectTypeId, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblProjectName;
        private MMIS.Component.XLabel lblProjectDesc;
        private MMIS.Component.XLabel lblStartTime;
        private MMIS.Component.XLabel lblEndTime;
        private MMIS.Component.XLabel lblPurveyor;
        private MMIS.Component.XLabel lblLinkman;
        private MMIS.Component.XLabel lblTel;
        private MMIS.Component.XLabel lblProjectTypeId;
        private MMIS.Component.XLabel lblDeptId;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtProjectName;
        private MMIS.Component.XEditBox txtProjectDesc;
        private MMIS.Component.XDateTimePicker dtStartTime;
        private MMIS.Component.XDateTimePicker dtEndTime;
        private MMIS.Component.XEditBox txtPurveyor;
        private MMIS.Component.XEditBox txtLinkman;
        private MMIS.Component.XEditBox txtTel;
        private MMIS.Component.XEditBox txtRemark;
        private XSelectUseDeptEditBox txtDeptId;
        private XSelectProjectTypeEditBox txtProjectTypeId;
        
    }
}