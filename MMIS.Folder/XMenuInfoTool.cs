using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.FolderModel;

namespace MMIS.FolderMenu
{
    public class XMenuInfoTool
    {

        /// <summary>
        /// 将菜单数据行转换为菜单信息
        /// </summary>
        /// <param name="menuRow"></param>
        /// <returns></returns>
        public static XMenuInfo MenuRow2MenuInfo(DataRow menuRow)
        {
            XMenuInfo menuInfo = new XMenuInfo();

            //menuInfo.FolderName = XHelper.GetString(menuRow["FolderName"]);
            //menuInfo.FolderGroup = XHelper.GetString(menuRow["FolderGroup"]);
            menuInfo.Count = XHelper.GetInt(menuRow["Count"]);
            menuInfo.OrderIndex = XHelper.GetInt(menuRow["FolderOrder"]);
            menuInfo.MenuName = XHelper.GetString(menuRow["FolderName"]);
            menuInfo.NameSpace = XHelper.GetString(menuRow["NameSpace"]);
            menuInfo.ClassName = XHelper.GetString(menuRow["ClassName"]);
            menuInfo.IsDialogModel = Convert.ToBoolean(menuRow["IsDialogModel"]);

            return menuInfo;
        }

        /// <summary>
        /// 将菜单信息类转换为菜单数据行
        /// </summary>
        /// <param name="menuInfo"></param>
        /// <returns></returns>
        public static void MenuInfo2MenuRow(XMenuInfo menuInfo, DataRow menuRow)
        {
            menuRow["FolderName"] = menuInfo.MenuName;
            menuRow["FolderGroup"] = menuInfo.GroupName;
            menuRow["Count"] = menuInfo.Count;
            menuRow["FolderOrder"] = menuInfo.OrderIndex;
            menuRow["NameSpace"] = menuInfo.NameSpace;
            menuRow["ClassName"] = menuInfo.ClassName;
            menuRow["FullAssembleName"] = menuInfo.FullAssembleName;
            menuRow["IsDialogModel"] = menuInfo.IsDialogModel;
        }
    }
}
