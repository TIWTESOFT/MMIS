namespace MMIS.UI.Common
{
    /// <summary>
    /// frmBase ����
    /// ����: frmBase ���� �ֲ���
    /// ʱ��: 2011/8/30 21:47:48
    /// ����: lmm_wss
    /// </summary>
    partial class frmBase
    {
        #region Windows ������������ɵĴ���

        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

           
            base.Dispose(disposing);
        }

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBase));
            this.SuspendLayout();
            // 
            // frmBase
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(272, 233);
            this.Font = new System.Drawing.Font("΢���ź�", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBase_FormClosing);
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.ResumeLayout(false);

        }

        #endregion



    }
}
