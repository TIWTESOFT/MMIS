using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;

namespace MMIS.FolderModel
{
    public class XMenuGroupInfo : XModelBase
    {
        public string FolderId
        {
            get;
            set;
        }

        public string GroupName
        {
            get;
            set;
        }

        /// <summary>
        /// 分组顺序
        /// </summary>
        public int OrderIndex
        {
            get;
            set;
        }

        /// <summary>
        /// 分组下的菜单
        /// </summary>
        public IList<XModelBase> Menus
        {
            get;
            set;
        }

        public XMenuFolderInfo FolderInfo
        {
            get;
            set;
        }
    }
}
