using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using MMIS.Helper;

namespace MMIS.Component
{
    public partial class XNumberEditBox : Janus.Windows.GridEX.EditControls.NumericEditBox, IXAllowEmptyAble,
        IXNumberValidateInterface
    {
        public XNumberEditBox()
        {
            this.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.FormatString = "0.00";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(XNumberEditBox_KeyDown);
        }

        void XNumberEditBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                bool isSendTab = false;

                double value = XHelper.GetDouble(this.Value);
                if (value == 0)
                {
                    if (this.m_IsAllowZero)
                    {
                        isSendTab = true;
                    }
                }
                else if (value < 0)
                {
                    if (this.m_IsAllowLessThanZero)
                    {
                        isSendTab = true;
                    }
                }
                else
                {
                    isSendTab = true;
                }

                if (isSendTab)
                {
                    XHelper.SendTab();
                }
            }
        }

        #region 扩展属性

        /// <summary>
        /// 是否允许为空
        /// </summary>
        private bool m_IsAllowEmpty = false;

        /// <summary>
        /// 是否允许为空
        /// </summary>
        public bool IsAllowEmpty
        {
            get
            {
                return this.m_IsAllowEmpty;
            }
            set
            {
                this.m_IsAllowEmpty = value;
            }
        }

        private bool m_IsAllowZero = false;

        /// <summary>
        /// 是否允许为0
        /// </summary>
        public bool IsAllowZero
        {
            get
            {
                return this.m_IsAllowZero;
            }
            set
            {
                this.m_IsAllowZero = value;
            }
        }

        private bool m_IsAllowLessThanZero = false;

        /// <summary>
        /// 是否允许小于0
        /// </summary>
        public bool IsAllowLessThanZero
        {
            get
            {
                return this.m_IsAllowLessThanZero;
            }
            set
            {
                this.m_IsAllowLessThanZero = value;
            }
        }

        #endregion

     
    }
}
