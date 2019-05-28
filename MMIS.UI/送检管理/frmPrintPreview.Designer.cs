namespace MMIS.UI
{
    partial class frmPrintPreview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintPreview));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.chkp = new MMIS.Component.XCheckBox();
            this.btnprintview = new MMIS.Component.XButton();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPrint = new MMIS.Component.XButton();
            this.fcWord = new AxDSOFramer.AxFramerControl();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.rbtnall = new MMIS.Component.XRadioButton();
            this.rbtnj = new MMIS.Component.XRadioButton();
            this.rbtno = new MMIS.Component.XRadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcWord)).BeginInit();
            this.pnlFill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Controls.Add(this.btnprintview);
            this.pnlTop.Controls.Add(this.btnPrint);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(871, 39);
            this.pnlTop.TabIndex = 0;
            // 
            // chkp
            // 
            this.chkp.BackColor = System.Drawing.Color.Transparent;
            this.chkp.Checked = true;
            this.chkp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkp.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkp.Location = new System.Drawing.Point(10, 10);
            this.chkp.Model = null;
            this.chkp.Name = "chkp";
            this.chkp.Size = new System.Drawing.Size(76, 20);
            this.chkp.TabIndex = 2;
            this.chkp.Text = "双面";
            this.chkp.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // btnprintview
            // 
            this.btnprintview.ImageIndex = 76;
            this.btnprintview.ImageList = this.ImageList1;
            this.btnprintview.Location = new System.Drawing.Point(112, 6);
            this.btnprintview.Name = "btnprintview";
            this.btnprintview.Size = new System.Drawing.Size(114, 27);
            this.btnprintview.TabIndex = 1;
            this.btnprintview.Text = "按属性打印";
            this.btnprintview.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnprintview.Click += new System.EventHandler(this.btnprintview_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            this.ImageList1.Images.SetKeyName(3, "");
            this.ImageList1.Images.SetKeyName(4, "");
            this.ImageList1.Images.SetKeyName(5, "");
            this.ImageList1.Images.SetKeyName(6, "");
            this.ImageList1.Images.SetKeyName(7, "");
            this.ImageList1.Images.SetKeyName(8, "");
            this.ImageList1.Images.SetKeyName(9, "");
            this.ImageList1.Images.SetKeyName(10, "");
            this.ImageList1.Images.SetKeyName(11, "");
            this.ImageList1.Images.SetKeyName(12, "");
            this.ImageList1.Images.SetKeyName(13, "");
            this.ImageList1.Images.SetKeyName(14, "");
            this.ImageList1.Images.SetKeyName(15, "");
            this.ImageList1.Images.SetKeyName(16, "");
            this.ImageList1.Images.SetKeyName(17, "");
            this.ImageList1.Images.SetKeyName(18, "");
            this.ImageList1.Images.SetKeyName(19, "");
            this.ImageList1.Images.SetKeyName(20, "");
            this.ImageList1.Images.SetKeyName(21, "");
            this.ImageList1.Images.SetKeyName(22, "");
            this.ImageList1.Images.SetKeyName(23, "");
            this.ImageList1.Images.SetKeyName(24, "");
            this.ImageList1.Images.SetKeyName(25, "");
            this.ImageList1.Images.SetKeyName(26, "");
            this.ImageList1.Images.SetKeyName(27, "");
            this.ImageList1.Images.SetKeyName(28, "");
            this.ImageList1.Images.SetKeyName(29, "");
            this.ImageList1.Images.SetKeyName(30, "");
            this.ImageList1.Images.SetKeyName(31, "");
            this.ImageList1.Images.SetKeyName(32, "");
            this.ImageList1.Images.SetKeyName(33, "");
            this.ImageList1.Images.SetKeyName(34, "");
            this.ImageList1.Images.SetKeyName(35, "");
            this.ImageList1.Images.SetKeyName(36, "");
            this.ImageList1.Images.SetKeyName(37, "");
            this.ImageList1.Images.SetKeyName(38, "");
            this.ImageList1.Images.SetKeyName(39, "");
            this.ImageList1.Images.SetKeyName(40, "");
            this.ImageList1.Images.SetKeyName(41, "");
            this.ImageList1.Images.SetKeyName(42, "");
            this.ImageList1.Images.SetKeyName(43, "");
            this.ImageList1.Images.SetKeyName(44, "");
            this.ImageList1.Images.SetKeyName(45, "");
            this.ImageList1.Images.SetKeyName(46, "");
            this.ImageList1.Images.SetKeyName(47, "");
            this.ImageList1.Images.SetKeyName(48, "");
            this.ImageList1.Images.SetKeyName(49, "");
            this.ImageList1.Images.SetKeyName(50, "");
            this.ImageList1.Images.SetKeyName(51, "");
            this.ImageList1.Images.SetKeyName(52, "");
            this.ImageList1.Images.SetKeyName(53, "");
            this.ImageList1.Images.SetKeyName(54, "");
            this.ImageList1.Images.SetKeyName(55, "");
            this.ImageList1.Images.SetKeyName(56, "");
            this.ImageList1.Images.SetKeyName(57, "");
            this.ImageList1.Images.SetKeyName(58, "");
            this.ImageList1.Images.SetKeyName(59, "");
            this.ImageList1.Images.SetKeyName(60, "");
            this.ImageList1.Images.SetKeyName(61, "");
            this.ImageList1.Images.SetKeyName(62, "");
            this.ImageList1.Images.SetKeyName(63, "");
            this.ImageList1.Images.SetKeyName(64, "");
            this.ImageList1.Images.SetKeyName(65, "");
            this.ImageList1.Images.SetKeyName(66, "");
            this.ImageList1.Images.SetKeyName(67, "");
            this.ImageList1.Images.SetKeyName(68, "");
            this.ImageList1.Images.SetKeyName(69, "");
            this.ImageList1.Images.SetKeyName(70, "");
            this.ImageList1.Images.SetKeyName(71, "");
            this.ImageList1.Images.SetKeyName(72, "");
            this.ImageList1.Images.SetKeyName(73, "");
            this.ImageList1.Images.SetKeyName(74, "");
            this.ImageList1.Images.SetKeyName(75, "");
            this.ImageList1.Images.SetKeyName(76, "");
            this.ImageList1.Images.SetKeyName(77, "");
            this.ImageList1.Images.SetKeyName(78, "");
            this.ImageList1.Images.SetKeyName(79, "");
            this.ImageList1.Images.SetKeyName(80, "");
            this.ImageList1.Images.SetKeyName(81, "");
            this.ImageList1.Images.SetKeyName(82, "");
            this.ImageList1.Images.SetKeyName(83, "");
            this.ImageList1.Images.SetKeyName(84, "");
            this.ImageList1.Images.SetKeyName(85, "");
            this.ImageList1.Images.SetKeyName(86, "");
            this.ImageList1.Images.SetKeyName(87, "");
            this.ImageList1.Images.SetKeyName(88, "");
            this.ImageList1.Images.SetKeyName(89, "");
            this.ImageList1.Images.SetKeyName(90, "");
            this.ImageList1.Images.SetKeyName(91, "");
            this.ImageList1.Images.SetKeyName(92, "");
            this.ImageList1.Images.SetKeyName(93, "");
            this.ImageList1.Images.SetKeyName(94, "");
            this.ImageList1.Images.SetKeyName(95, "");
            this.ImageList1.Images.SetKeyName(96, "");
            this.ImageList1.Images.SetKeyName(97, "");
            this.ImageList1.Images.SetKeyName(98, "");
            this.ImageList1.Images.SetKeyName(99, "");
            this.ImageList1.Images.SetKeyName(100, "");
            this.ImageList1.Images.SetKeyName(101, "");
            this.ImageList1.Images.SetKeyName(102, "");
            this.ImageList1.Images.SetKeyName(103, "");
            this.ImageList1.Images.SetKeyName(104, "");
            this.ImageList1.Images.SetKeyName(105, "");
            this.ImageList1.Images.SetKeyName(106, "");
            this.ImageList1.Images.SetKeyName(107, "");
            this.ImageList1.Images.SetKeyName(108, "");
            this.ImageList1.Images.SetKeyName(109, "");
            this.ImageList1.Images.SetKeyName(110, "");
            this.ImageList1.Images.SetKeyName(111, "");
            this.ImageList1.Images.SetKeyName(112, "");
            this.ImageList1.Images.SetKeyName(113, "");
            this.ImageList1.Images.SetKeyName(114, "");
            this.ImageList1.Images.SetKeyName(115, "");
            this.ImageList1.Images.SetKeyName(116, "");
            this.ImageList1.Images.SetKeyName(117, "");
            this.ImageList1.Images.SetKeyName(118, "");
            this.ImageList1.Images.SetKeyName(119, "");
            this.ImageList1.Images.SetKeyName(120, "");
            this.ImageList1.Images.SetKeyName(121, "");
            this.ImageList1.Images.SetKeyName(122, "");
            this.ImageList1.Images.SetKeyName(123, "");
            // 
            // btnPrint
            // 
            this.btnPrint.ImageIndex = 84;
            this.btnPrint.ImageList = this.ImageList1;
            this.btnPrint.Location = new System.Drawing.Point(5, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(101, 27);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "直接打印";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // fcWord
            // 
            this.fcWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fcWord.Enabled = true;
            this.fcWord.Location = new System.Drawing.Point(0, 0);
            this.fcWord.Name = "fcWord";
            this.fcWord.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fcWord.OcxState")));
            this.fcWord.Size = new System.Drawing.Size(871, 411);
            this.fcWord.TabIndex = 1;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.fcWord);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(0, 39);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(871, 411);
            this.pnlFill.TabIndex = 1;
            // 
            // rbtnall
            // 
            this.rbtnall.Checked = true;
            this.rbtnall.Location = new System.Drawing.Point(67, 8);
            this.rbtnall.Name = "rbtnall";
            this.rbtnall.Size = new System.Drawing.Size(99, 23);
            this.rbtnall.TabIndex = 3;
            this.rbtnall.TabStop = true;
            this.rbtnall.Text = "全部打印";
            this.rbtnall.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // rbtnj
            // 
            this.rbtnj.Location = new System.Drawing.Point(152, 8);
            this.rbtnj.Name = "rbtnj";
            this.rbtnj.Size = new System.Drawing.Size(103, 23);
            this.rbtnj.TabIndex = 4;
            this.rbtnj.Text = "奇数页打印";
            this.rbtnj.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // rbtno
            // 
            this.rbtno.Location = new System.Drawing.Point(252, 8);
            this.rbtno.Name = "rbtno";
            this.rbtno.Size = new System.Drawing.Size(107, 23);
            this.rbtno.TabIndex = 5;
            this.rbtno.Text = "偶数页打印";
            this.rbtno.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtno);
            this.panel1.Controls.Add(this.rbtnj);
            this.panel1.Controls.Add(this.rbtnall);
            this.panel1.Controls.Add(this.chkp);
            this.panel1.Location = new System.Drawing.Point(227, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 39);
            this.panel1.TabIndex = 6;
            // 
            // frmPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrintPreview";
            this.Text = "打印报告";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrintPreview_FormClosing);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcWord)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private AxDSOFramer.AxFramerControl fcWord;
        private System.Windows.Forms.Panel pnlFill;
        private Component.XButton btnPrint;
        internal System.Windows.Forms.ImageList ImageList1;
        private Component.XButton btnprintview;
        private Component.XCheckBox chkp;
        private Component.XRadioButton rbtno;
        private Component.XRadioButton rbtnj;
        private Component.XRadioButton rbtnall;
        private System.Windows.Forms.Panel panel1;
    }
}