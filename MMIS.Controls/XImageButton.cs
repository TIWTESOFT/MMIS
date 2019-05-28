using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace MMIS.Controls
{
    public partial class XImageButton : System.Windows.Forms.PictureBox
    {
        public XImageButton()
        {
            this.Init();
        }

        private void Init()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            this.MouseEnter += new EventHandler(XImageButton_MouseEnter);
            this.MouseLeave += new EventHandler(XImageButton_MouseLeave);
        }

        void XImageButton_MouseLeave(object sender, EventArgs e)
        {
            this.IsFocus = false;
        }

        void XImageButton_MouseEnter(object sender, EventArgs e)
        {
            this.IsFocus = true;
        }

        public XImageButton(IContainer container)
        {
            container.Add(this);
            this.Init();
        }

        private Button m_FocusButton = null;

        /// <summary>
        /// 聚焦按钮
        /// </summary>
        public Button FocusButton
        {
            get { return this.m_FocusButton; }
            set
            {
                this.m_FocusButton = value;
                this.m_FocusButton.GotFocus += new EventHandler(m_FocusButton_GotFocus);
                this.m_FocusButton.LostFocus += new EventHandler(m_FocusButton_LostFocus);
            }
        }

        private bool m_IsFocus = false;

        /// <summary>
        /// 是否获得焦点
        /// </summary>
        public bool IsFocus
        {
            get
            {
                return this.m_IsFocus;
            }
            set
            {
                this.m_IsFocus = value;
                if (value == true)
                {
                    //聚焦
                    this.BackgroundImage = this.m_FocusImage;
                }
                else
                {
                    //非聚焦
                    this.BackgroundImage = this.m_NormalImage;
                }
            }
        }

        private Image m_FocusImage = null;

        /// <summary>
        /// 焦点图片
        /// </summary>
        public Image FocusImage
        {
            get { return this.m_FocusImage; }
            set
            {
                this.m_FocusImage = value;
            }
        }

        private Image m_NormalImage = null;

        /// <summary>
        /// 正常下的图片
        /// </summary>
        public Image NormalImage
        {
            get
            {
                return this.m_NormalImage;
            }
            set
            {
                this.BackgroundImage = value;
                this.m_NormalImage = value;
            }
        }

        /// <summary>
        /// 失去焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_FocusButton_LostFocus(object sender, EventArgs e)
        {
            this.IsFocus = false;
        }

        /// <summary>
        /// 获得焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void m_FocusButton_GotFocus(object sender, EventArgs e)
        {
            this.IsFocus = true;
        }

    }
}
