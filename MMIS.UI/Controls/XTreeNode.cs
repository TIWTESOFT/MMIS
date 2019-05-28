using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MMIS.Model;

namespace MMIS.UI
{
    public class XTreeNode : TreeNode
    {
        private string m_Code = string.Empty;

        /// <summary>
        /// 编码
        /// </summary>
        public string Code
        {
            get { return this.m_Code; }
            set { this.m_Code = value; }
        }

        private string m_Name = string.Empty;

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return this.m_Name; }
            set { this.m_Name = value; }
        }

        private XModelBase m_Model = null;

        /// <summary>
        /// 选中的模型
        /// </summary>
        public XModelBase Model
        {
            get { return this.m_Model; }
            set { this.m_Model = value; }
        }
    }
}
