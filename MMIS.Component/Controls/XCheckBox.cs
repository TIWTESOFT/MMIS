using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.Component
{
    public partial class XCheckBox : Janus.Windows.EditControls.UICheckBox
    {
        public XCheckBox()
        {
            this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(XCheckBox_KeyDown);
        }

        void XCheckBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                XHelper.SendTab();
            }
        }

        private XModelBase m_Model = null;

        /// <summary>
        /// 实体
        /// </summary>
        public XModelBase Model
        {
            get { return this.m_Model; }
            set { this.m_Model = value; }
        }
    }
}
