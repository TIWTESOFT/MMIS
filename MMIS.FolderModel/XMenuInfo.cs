using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;

namespace MMIS.FolderModel
{
    public class XMenuInfo : XModelBase
    {
        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSpace
        {
            get;
            set;
        }

        /// <summary>
        /// 类名
        /// </summary>
        public string ClassName
        {
            get;
            set;
        }

        /// <summary>
        /// 全名
        /// </summary>
        public string FullAssembleName
        {
            get { return this.NameSpace + "." + this.ClassName; }
        }

        /// <summary>
        /// 是否Dialog方式弹出
        /// </summary>
        /// <returns></returns>
        public bool IsDialogModel
        {
            get;
            set;
        }

        /// <summary>
        /// 菜单名
        /// </summary>
        public string MenuName
        {
            get;
            set;
        }

        /// <summary>
        /// 菜单分组所属ID
        /// </summary>
        public string GroupId
        {
            get;
            set;
        }

        /// <summary>
        /// 菜单分组名称
        /// </summary>
        public string GroupName
        {
            get { return this.MenuGroupInfo.GroupName; }
        }

        /// <summary>
        /// 菜单次序
        /// </summary>
        public int OrderIndex
        {
            get;
            set;
        }

        public int Count
        {
            get;
            set;
        }

        /// <summary>
        /// 菜单所属分组
        /// </summary>
        public XMenuGroupInfo MenuGroupInfo
        {
            get;
            set;
        }
    }
}
