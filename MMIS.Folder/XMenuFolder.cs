using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Data;

namespace MMIS.FolderMenu
{
    public partial class XMenuFolder : DataTable
    {
        public XMenuFolder()
        {
            this.InitColumns();
        }

        private void InitColumns()
        {
            this.Columns.Add(new DataColumn("FolderName", typeof(string)));//分类项名
            this.Columns.Add(new DataColumn("Subject", typeof(string)));//分类主题
            this.Columns.Add(new DataColumn("FolderGroup", typeof(string)));//分类项组名
            this.Columns.Add(new DataColumn("FolderOrder", typeof(int)));//分类项顺序
            this.Columns.Add(new DataColumn("Count", typeof(int)));//个数
            this.Columns.Add(new DataColumn("NameSpace", typeof(string)));//命名空间
            this.Columns.Add(new DataColumn("ClassName", typeof(string)));//类名
            this.Columns.Add(new DataColumn("FullAssembleName", typeof(string)));//全名
            this.Columns.Add(new DataColumn("IsDialogModel", typeof(bool)));//全名
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
        public string Image
        {
            get;
            set;
        }

        /// <summary>
        /// 大图片
        /// </summary>
        public string LargeImage
        {
            get;
            set;
        }

    }
}
