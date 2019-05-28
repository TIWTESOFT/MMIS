using MMIS.Component;
using MMIS.Model;
using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XTreeSelectEditBox : XQueryEditBox, IXAllowEmptyAble
    {
        public XTreeSelectEditBox()
        {
            this.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.ButtonClick += new EventHandler(XSelectEditBox_ButtonClick);
            this.ReadOnly = true;
            //this.DoubleClick += new EventHandler(XSelectEditBox_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(XSelectEditBox_KeyDown);
            this.DoubleClick += new EventHandler(XSelectEditBox_DoubleClick);
        }

        void XSelectEditBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Back || e.KeyCode == System.Windows.Forms.Keys.Delete)
            {
                this.m_SelectedModel = null;
                this.Text = string.Empty;
                this.ValueMember = string.Empty;
                this.DisplayMember = string.Empty;
            }
        }


        void XSelectEditBox_DoubleClick(object sender, EventArgs e)
        {
            this.XSelectEditBox_ButtonClick(null, null);
        }

        private string m_DisplayMember = string.Empty;

        public string DisplayMember
        {
            get { return this.m_DisplayMember; }
            set { this.m_DisplayMember = value; }
        }

        private string m_ValueMember = string.Empty;

        public string ValueMember
        {
            get { return this.m_ValueMember; }
            set { this.m_ValueMember = value; }
        }

        private XModelBase m_SelectedModel = null;

        /// <summary>
        /// 选择的模型
        /// </summary>
        public XModelBase SelectedModel
        {
            get { return this.m_SelectedModel; }
            set { this.m_SelectedModel = value; }
        }

        protected virtual void XSelectEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmTreeBase frm = this.GetSelectForm();
            if (frm != null)
            {
                frm.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (frm.SelectedModel != null)
                    {
                        this.m_DisplayMember = this.GetDisplayMember(frm.SelectedModel);
                        this.m_ValueMember = this.GetValueMember(frm.SelectedModel);
                        this.m_SelectedModel = frm.SelectedModel;

                        this.Text = this.GetText();
                    }
                }
            }
        }

        /// <summary>
        /// 获取显示标题
        /// </summary>
        /// <returns></returns>
        protected virtual string GetText()
        {
            if (this.m_SelectedModel != null)
            {
                return this.m_DisplayMember;
            }
            else
            {
                return string.Empty;
            }
            //if (this.m_SelectedModel != null)
            //{
            //    return this.m_ValueMember + "-" + this.m_DisplayMember;
            //}
            //else
            //{
            //    return string.Empty;
            //}
        }

        protected virtual frmTreeBase GetSelectForm()
        {
            return null;
        }

        protected virtual string GetDisplayMember(XModelBase selectedModel)
        {
            return string.Empty;
        }

        protected virtual string GetValueMember(XModelBase selectedModel)
        {
            return string.Empty;
        }

        public override string QueryValue
        {
            get
            {
                return this.m_ValueMember;
            }
        }
    }
}
