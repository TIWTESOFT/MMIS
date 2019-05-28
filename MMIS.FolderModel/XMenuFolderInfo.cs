using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;

namespace MMIS.FolderModel
{
    public class XMenuFolderInfo : XModelBase
    {
        /// <summary>
        /// 菜单组
        /// </summary>
        public IList<XModelBase> MenuGroupInfos
        {
            get;
            set;
        }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// 分类名
        /// </summary>
        public string FolderName
        {
            get;
            set;
        }

        /// <summary>
        /// 图片
        /// </summary>
        public string ImageFile
        {
            get;
            set;
        }

        /// <summary>
        /// 大图片
        /// </summary>
        public string LargeImageFile
        {
            get;
            set;
        }

        /// <summary>
        /// 排序
        /// </summary>
        public int OrderIndex
        {
            get;
            set;
        }

    }
}
