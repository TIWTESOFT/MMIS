using System;
using System.Collections.Generic;
using System.Text;
using MMIS.FolderMenu;
using MMIS.FolderModel;
using MMIS.Model;
using MMIS.BLL;

namespace MMIS.UI.Common
{
    public delegate void XMenuFolderLoadHandler(object sender, XMenuFolderLoadEventArgs e);

    public class XMenuFolderInfoTool
    {
        public event XMenuFolderLoadHandler MenuFolderLoadEvent;

        private XMenuBusiness m_MenuBusiness = new XMenuBusiness();
        private XMenuGroupBusiness m_MenuGroupBusiness = new XMenuGroupBusiness();
        private XMenuFolderBusiness m_MenuFolderBusiness = new XMenuFolderBusiness();

        /// <summary>
        /// 此类为获取菜单信息类，通过此类读取数据库将数据转换为菜单项
        /// </summary>
        /// <returns></returns>
        public virtual IList<XModelBase> GetAllMenuFolderInfos()
        {
            IList<XModelBase> folderInfos = m_MenuFolderBusiness.GetAll() as IList<XModelBase>;

            foreach (XMenuFolderInfo folderInfo in folderInfos)
            {
                //获取菜单组集合
                IList<XModelBase> groupInfos = this.m_MenuGroupBusiness.GetGroupInfos(folderInfo);
                folderInfo.MenuGroupInfos = groupInfos;

                //事件
                this.OnFolderLoad(this, new XMenuFolderLoadEventArgs(folderInfo));

                int loopNo = 0;

                foreach (XMenuGroupInfo groupInfo in groupInfos)
                {
                    loopNo += 1;

                    groupInfo.FolderInfo = folderInfo;
                    groupInfo.GroupName = loopNo.ToString() + "." + groupInfo.GroupName;

                    IList<XModelBase> menuInfos = this.m_MenuBusiness.GetMenuInfos(groupInfo);
                    groupInfo.Menus = menuInfos;

                    foreach (XMenuInfo menuInfo in menuInfos)
                    {
                        menuInfo.MenuGroupInfo = groupInfo;
                    }
                }
            }

            return folderInfos;
        }

        /// <summary>
        /// 此类为获取菜单信息类，通过此类读取数据库将数据转换为菜单项
        /// </summary>
        /// <returns></returns>
        public virtual IList<XModelBase> GetMenuFolderInfos(string userId)
        {
            //IList<XModelBase> folderInfos = m_MenuFolderBusiness.GetAll() as IList<XModelBase>;
            IList<XModelBase> folderInfos = m_MenuFolderBusiness.GetUserMenuFolders(userId) as IList<XModelBase>;

            foreach (XMenuFolderInfo folderInfo in folderInfos)
            {
                //获取菜单组集合
                //IList<XModelBase> groupInfos = this.m_MenuGroupBusiness.GetGroupInfos(folderInfo);
                IList<XModelBase> groupInfos = this.m_MenuGroupBusiness.GetUserMenuGroups(userId, folderInfo.ID);
                folderInfo.MenuGroupInfos = groupInfos;

                //事件
                this.OnFolderLoad(this, new XMenuFolderLoadEventArgs(folderInfo));

                int loopNo = 0;

                foreach (XMenuGroupInfo groupInfo in groupInfos)
                {
                    loopNo += 1;

                    groupInfo.FolderInfo = folderInfo;
                    groupInfo.GroupName = loopNo.ToString() + "." + groupInfo.GroupName;

                    //IList<XModelBase> menuInfos = this.m_MenuBusiness.GetMenuInfos(groupInfo);
                    IList<XModelBase> menuInfos = this.m_MenuBusiness.GetUserMenus(userId, groupInfo.ID);
                    groupInfo.Menus = menuInfos;

                    foreach (XMenuInfo menuInfo in menuInfos)
                    {
                        menuInfo.MenuGroupInfo = groupInfo;
                    }
                }
            }

            return folderInfos;
        }

        /// <summary>
        /// 菜单Folder加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void OnFolderLoad(object sender, XMenuFolderLoadEventArgs e)
        {
            if (MenuFolderLoadEvent != null)
            {
                this.MenuFolderLoadEvent(sender, e);
            }
        }
    }
}
