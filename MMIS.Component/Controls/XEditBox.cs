using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using MMIS.Helper;

namespace MMIS.Component
{
    public partial class XEditBox : Janus.Windows.GridEX.EditControls.EditBox, IXAllowEmptyAble
    {
        private bool m_IsAllowEmpty = false;

        public XEditBox()
        {
            this.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            //this.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(XEditBox_KeyDown);
        }

        /// <summary>
        /// 当按回车时发送Tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void XEditBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                bool isAllowSendTab = false;//是否允许发送Tab

                if (this.Text.Trim() == string.Empty)
                {
                    if (this.m_IsAllowEmpty)
                    {
                        //如果允许为空，则允许发送Tab
                        isAllowSendTab = true;
                    }
                }
                else
                {
                    isAllowSendTab = true;
                }
                if (isAllowSendTab)
                {
                    XHelper.SendTab();
                }
            }
        }

        #region 扩展属性

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

        #endregion

      
    }
}
