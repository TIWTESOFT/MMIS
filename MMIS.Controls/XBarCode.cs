using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Cobainsoft.Windows.Forms;

namespace MMIS.Controls
{
    public partial class XBarCode : UserControl
    {
        public XBarCode()
        {
            InitializeComponent();
        }

        //private void panelContaioner_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;
        //    Rectangle rc = new Rectangle(0 + 2, 0 + 2, this.Width - 5, this.Height - 5);
        //    SolidBrush brush = new SolidBrush(Color.Black);
        //    Pen pen = new Pen(brush, 1);
        //    g.DrawPath(pen, this.GetGraphicsPath(rc, 20));
        //}

        private GraphicsPath GetGraphicsPath(Rectangle rc, int r)
        {
            int x = rc.X, y = rc.Y, w = rc.Width, h = rc.Height;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(x, y, r, r, 180, 90);                //
            path.AddArc(x + w - r, y, r, r, 270, 90);            //
            path.AddArc(x + w - r, y + h - r, r, r, 0, 90);        //
            path.AddArc(x, y + h - r, r, r, 90, 90);            //
            path.CloseFigure();
            return path;
        }

        private void panelContaioner_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rc = new Rectangle(0, 0, this.Width, this.Height);
            SolidBrush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush, 1);
            pen.DashStyle = DashStyle.Dot;
            g.DrawPath(pen, this.GetGraphicsPath(rc, 0));
        }

        public BarcodeType BarCodeType
        {
            set
            {
                this.ctlBarcode.BarcodeType = value;
            }
        }

        public BarcodeControl BarCodeControl
        {
            get
            {
                return this.ctlBarcode;
            }
        }

        public string TextData
        {
            set
            {
                this.ctlBarcode.Data = value;
                //Invalidate();
            }
        }

        public string Price
        {
            set
            {
                this.lblPrice.Text = value;
            }
        }

        public string Title
        {
            set
            {
                this.lblName.Text = value;
            }
        }

        public string CopyRight
        {
            set
            {
                this.ctlBarcode.CopyRight = value;
            }
        }

        public int BarCodeWidth
        {
            get
            {
                return this.ctlBarcode.Size.Width;
            }
            set
            {
                this.ctlBarcode.Size = new Size(value, BarCodeHeight);
            }
        }

        public int BarCodeHeight
        {
            get
            {
                return this.ctlBarcode.Size.Height;
            }
            set
            {
                this.ctlBarcode.Size = new Size(BarCodeWidth, value);
            }
        }

        public Bitmap GetBitmap(int X, int Y, out Rectangle rect)
        {
            Bitmap formBitmap = new Bitmap(this.Width, this.Height);
            rect = new Rectangle(X, Y, this.Width, this.Height);
            this.DrawToBitmap(formBitmap, rect);

            return formBitmap;
        }

        public void DrawImage(Graphics g, int X, int Y)
        {
            Bitmap formBitmap = new Bitmap(this.Width, this.Height);
            Rectangle rect = new Rectangle(X, Y, this.Width, this.Height);
            this.DrawToBitmap(formBitmap, rect);

            g.DrawImage(formBitmap, rect);
        }
    }
}
