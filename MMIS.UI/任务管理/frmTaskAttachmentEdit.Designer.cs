namespace MMIS.UI
{
    public partial class frmTaskAttachmentEdit
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
            this.lblMainId = new MMIS.Component.XLabel();
            this.lblFileName = new MMIS.Component.XLabel();
            this.lblFileDesc = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtMainId = new MMIS.Component.XEditBox();
            this.txtFileName = new MMIS.Component.XEditBox();
            this.txtFileDesc = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.txtFilePath = new MMIS.Component.XEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(354, 210);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(441, 210);
            // 
            // lblMainId
            // 
            this.lblMainId.AutoSize = true;
            this.lblMainId.ForeColor = System.Drawing.Color.Black;
            this.lblMainId.Location = new System.Drawing.Point(33, 353);
            this.lblMainId.Name = "lblMainId";
            this.lblMainId.Size = new System.Drawing.Size(56, 17);
            this.lblMainId.TabIndex = 1;
            this.lblMainId.Text = "任务主键";
            this.lblMainId.Visible = false;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(12, 44);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(56, 17);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "文件名称";
            // 
            // lblFileDesc
            // 
            this.lblFileDesc.AutoSize = true;
            this.lblFileDesc.ForeColor = System.Drawing.Color.Black;
            this.lblFileDesc.Location = new System.Drawing.Point(12, 73);
            this.lblFileDesc.Name = "lblFileDesc";
            this.lblFileDesc.Size = new System.Drawing.Size(56, 17);
            this.lblFileDesc.TabIndex = 3;
            this.lblFileDesc.Text = "文件描述";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(12, 137);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(32, 17);
            this.lblRemark.TabIndex = 4;
            this.lblRemark.Text = "备注";
            // 
            // txtMainId
            // 
            this.txtMainId.IsAllowEmpty = false;
            this.txtMainId.Location = new System.Drawing.Point(95, 350);
            this.txtMainId.Name = "txtMainId";
            this.txtMainId.Size = new System.Drawing.Size(185, 23);
            this.txtMainId.TabIndex = 1;
            this.txtMainId.Visible = false;
            this.txtMainId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileName
            // 
            this.txtFileName.IsAllowEmpty = false;
            this.txtFileName.Location = new System.Drawing.Point(74, 41);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(442, 23);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFileDesc
            // 
            this.txtFileDesc.IsAllowEmpty = true;
            this.txtFileDesc.Location = new System.Drawing.Point(74, 70);
            this.txtFileDesc.Multiline = true;
            this.txtFileDesc.Name = "txtFileDesc";
            this.txtFileDesc.Size = new System.Drawing.Size(442, 58);
            this.txtFileDesc.TabIndex = 3;
            this.txtFileDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(74, 134);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(442, 67);
            this.txtRemark.TabIndex = 4;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtFilePath
            // 
            this.txtFilePath.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtFilePath.IsAllowEmpty = true;
            this.txtFilePath.Location = new System.Drawing.Point(74, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(442, 23);
            this.txtFilePath.TabIndex = 0;
            this.txtFilePath.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtFilePath.ButtonClick += new System.EventHandler(this.txtFilePath_ButtonClick);
            this.txtFilePath.TextChanged += new System.EventHandler(this.txtFilePath_TextChanged);
            this.txtFilePath.DoubleClick += new System.EventHandler(this.txtFilePath_DoubleClick);
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(12, 15);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 106;
            this.xLabel1.Text = "文件附件";
            // 
            // frmTaskAttachmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(528, 249);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtMainId);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.txtFileDesc);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblMainId);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblFileDesc);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmTaskAttachmentEdit";
            this.Text = "任务附件";
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.lblFileDesc, 0);
            this.Controls.SetChildIndex(this.lblFileName, 0);
            this.Controls.SetChildIndex(this.lblMainId, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtFileDesc, 0);
            this.Controls.SetChildIndex(this.txtFileName, 0);
            this.Controls.SetChildIndex(this.txtMainId, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtFilePath, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblMainId;
        private MMIS.Component.XLabel lblFileName;
        private MMIS.Component.XLabel lblFileDesc;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtMainId;
        private MMIS.Component.XEditBox txtFileName;
        private MMIS.Component.XEditBox txtFileDesc;
        private MMIS.Component.XEditBox txtRemark;
        protected Component.XEditBox txtFilePath;
        protected Component.XLabel xLabel1;
        
    }
}