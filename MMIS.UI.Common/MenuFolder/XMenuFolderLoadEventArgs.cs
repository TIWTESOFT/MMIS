using System;
using System.Collections.Generic;
using System.Text;
using MMIS.FolderModel;

namespace MMIS.UI.Common
{
    /// <summary>
    /// 菜单Folder加载事件参数
    /// </summary>
    public class XMenuFolderLoadEventArgs
    {
        public XMenuFolderInfo m_MenuFolderInfo = null;

        /// <summary>
        /// 菜单Folder信息
        /// </summary>
        public XMenuFolderInfo MenuFolderInfo
        {
            get { return this.m_MenuFolderInfo; }
        }

        public XMenuFolderLoadEventArgs(XMenuFolderInfo menuFolderInfo)
        {
            this.m_MenuFolderInfo = menuFolderInfo;
        }
    }
}
