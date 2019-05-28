namespace MMIS.UI
{
    partial class frmWebResetPassword
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
            this.txtPassword = new MMIS.Component.XEditBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(194, 55);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(281, 55);
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(12, 19);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(68, 17);
            this.xLabel1.TabIndex = 101;
            this.xLabel1.Text = "重置密码：";
            // 
            // txtPassword
            // 
            this.txtPassword.IsAllowEmpty = false;
            this.txtPassword.Location = new System.Drawing.Point(84, 17);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(272, 23);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // frmWebResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 94);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.xLabel1);
            this.Name = "frmWebResetPassword";
            this.Text = "密码重置";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Component.XLabel xLabel1;
        private Component.XEditBox txtPassword;
    }
}