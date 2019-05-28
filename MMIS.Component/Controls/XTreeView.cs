using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace MMIS.Component
{
    public partial class XTreeView : System.Windows.Forms.TreeView
    {
        private bool m_IsHaveTitleRootNode = true;

        /// <summary>
        /// 是否有标题根节点
        /// </summary>
        public bool IsHaveTitleRootNode
        {
            get { return this.m_IsHaveTitleRootNode; }
            set { this.m_IsHaveTitleRootNode = value; }
        }

        private string m_RootTitle = string.Empty;

        /// <summary>
        /// 树根节点标题
        /// </summary>
        public string RootTitle
        {
            get { return this.m_RootTitle; }
            set { this.m_RootTitle = value; }
        }
    }
}
