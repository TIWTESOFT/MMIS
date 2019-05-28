namespace MMIS.UI
{
    partial class frmStandEquipmentMemoryEdit
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
            this.SuspendLayout();
            // 
            // lblEquipmentType
            // 
            this.lblEquipmentType.Location = new System.Drawing.Point(12, 14);
            // 
            // lblEquipmentNo
            // 
            this.lblEquipmentNo.Location = new System.Drawing.Point(272, 14);
            // 
            // txtEquipmentNo
            // 
            this.txtEquipmentNo.Location = new System.Drawing.Point(334, 11);
            this.txtEquipmentNo.Size = new System.Drawing.Size(451, 23);
            // 
            // dtSourceTime
            // 
            // 
            // 
            // 
            this.dtSourceTime.DropDownCalendar.Name = "";
            this.dtSourceTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // dtUseTime
            // 
            // 
            // 
            // 
            this.dtUseTime.DropDownCalendar.Name = "";
            this.dtUseTime.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // cboEquipmentType
            // 
            this.cboEquipmentType.Location = new System.Drawing.Point(74, 11);
            // 
            // txtMainId
            // 
            this.txtMainId.Location = new System.Drawing.Point(74, 349);
            this.txtMainId.Visible = false;
            // 
            // xLabel1
            // 
            this.xLabel1.Location = new System.Drawing.Point(11, 355);
            this.xLabel1.Visible = false;
            // 
            // dtNextCheckDate
            // 
            // 
            // 
            // 
            this.dtNextCheckDate.DropDownCalendar.Name = "";
            this.dtNextCheckDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(623, 297);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(710, 297);
            // 
            // frmStandEquipmentMemoryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 336);
            this.Name = "frmStandEquipmentMemoryEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}