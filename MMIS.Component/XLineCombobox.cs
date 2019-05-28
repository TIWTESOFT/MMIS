using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MMIS.Component
{
    public partial class XLineCombobox : Janus.Windows.EditControls.UIComboBox
    {
        public XLineCombobox()
        {
            InitializeComponent();
            this.Width = 200;
            this.Text = "";
            this.BorderStyle = Janus.Windows.UI.BorderStyle.None;
            this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.BackColor = Color.FromArgb(216, 228, 248);
        }

        private Color _linecolor = Color.Black;
        /// <summary>
        /// 线条颜色
        /// </summary>
        public Color LineColor
        {
            get
            {
                return this._linecolor;
            }
            set
            {
                this._linecolor = value;
                this.Invalidate();
            }
        }
        private const int WM_PAINT = 0xF;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                DrawLine();
            }
        }
        private void DrawLine()
        {
            Graphics g = this.CreateGraphics();
            using (Pen p = new Pen(this._linecolor))
            {
                g.DrawLine(p, 0, this.Height - 1, this.Width, this.Height - 1);
            }
        }

    }
}
