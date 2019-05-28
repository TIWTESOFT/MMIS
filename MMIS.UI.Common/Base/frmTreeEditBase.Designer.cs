namespace MMIS.UI.Common
{
    partial class frmTreeEditBase
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
            this.chkIsRootNode = new MMIS.Component.XCheckBox();
            this.SuspendLayout();
            // 
            // chkIsRootNode
            // 
            this.chkIsRootNode.Location = new System.Drawing.Point(12, 12);
            this.chkIsRootNode.Name = "chkIsRootNode";
            this.chkIsRootNode.Size = new System.Drawing.Size(104, 23);
            this.chkIsRootNode.TabIndex = 101;
            this.chkIsRootNode.Text = "根节点";
            this.chkIsRootNode.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // frmTreeEditBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 181);
            this.Controls.Add(this.chkIsRootNode);
            this.Name = "frmTreeEditBase";
            this.Text = "frmTreeEditBase";
            this.Controls.SetChildIndex(this.chkIsRootNode, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.ResumeLayout(false);

        }

        #endregion

        protected Component.XCheckBox chkIsRootNode;

    }
}