namespace MMIS.UI.Common
{
    partial class frmTabEditBase
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
            this.tabDetail = new MMIS.Component.XTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(634, 451);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(721, 451);
            // 
            // tabDetail
            // 
            this.tabDetail.Location = new System.Drawing.Point(12, 235);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Size = new System.Drawing.Size(781, 205);
            this.tabDetail.TabIndex = 101;
            this.tabDetail.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007;
            this.tabDetail.SelectedTabChanged += new Janus.Windows.UI.Tab.TabEventHandler(this.tabDetail_SelectedTabChanged);
            this.tabDetail.TabIndexChanged += new System.EventHandler(this.tabDetail_TabIndexChanged);
            // 
            // frmTabEditBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 490);
            this.Controls.Add(this.tabDetail);
            this.Name = "frmTabEditBase";
            this.Text = "frmTabEditBase";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.tabDetail, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tabDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected Component.XTabControl tabDetail;

    }
}