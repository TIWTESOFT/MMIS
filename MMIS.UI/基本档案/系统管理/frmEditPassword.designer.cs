namespace MMIS.UI
{
    partial class frmEditPassword
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
            this.xLabel1 = new MMIS.Component.XLabel();
            this.txtUserId = new MMIS.Component.XEditBox();
            this.txtPassword = new MMIS.Component.XEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtRepass = new MMIS.Component.XEditBox();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(230, 74);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(317, 74);
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(13, 140);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(45, 17);
            this.xLabel1.TabIndex = 101;
            this.xLabel1.Text = "用户ID";
            this.xLabel1.Visible = false;
            // 
            // txtUserId
            // 
            this.txtUserId.IsAllowEmpty = false;
            this.txtUserId.Location = new System.Drawing.Point(64, 140);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(326, 23);
            this.txtUserId.TabIndex = 0;
            this.txtUserId.Visible = false;
            this.txtUserId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPassword
            // 
            this.txtPassword.IsAllowEmpty = false;
            this.txtPassword.Location = new System.Drawing.Point(67, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(326, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(10, 14);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(56, 17);
            this.xLabel2.TabIndex = 103;
            this.xLabel2.Text = "用户密码";
            // 
            // txtRepass
            // 
            this.txtRepass.IsAllowEmpty = false;
            this.txtRepass.Location = new System.Drawing.Point(67, 41);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.PasswordChar = '*';
            this.txtRepass.Size = new System.Drawing.Size(326, 23);
            this.txtRepass.TabIndex = 2;
            this.txtRepass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(10, 43);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(56, 17);
            this.xLabel3.TabIndex = 105;
            this.xLabel3.Text = "重复密码";
            // 
            // frmEditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 113);
            this.Controls.Add(this.txtRepass);
            this.Controls.Add(this.xLabel3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.xLabel1);
            this.Name = "frmEditPassword";
            this.Text = "修改密码";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtUserId, 0);
            this.Controls.SetChildIndex(this.xLabel2, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.xLabel3, 0);
            this.Controls.SetChildIndex(this.txtRepass, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Component.XLabel xLabel1;
        private Component.XEditBox txtUserId;
        private Component.XEditBox txtPassword;
        private Component.XLabel xLabel2;
        private Component.XEditBox txtRepass;
        private Component.XLabel xLabel3;
    }
}