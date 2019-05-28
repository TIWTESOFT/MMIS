using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MMIS.Helper;
using MMIS.UI.Common;
using MMIS.FolderMenu;
using System.Reflection;
using MMIS.FolderModel;
using MMIS.Model;
using MMIS.BLL;

namespace MMIS.UI.Common
{
    public partial class frmMainBase : frmBase
    {
        protected DataRow currentFolder;

        protected bool m_IsSignOut = false;

        public frmMainBase()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.InitMenuFolder();//初始化系统菜单
            }
            frmBase defaultForm = this.GetDefaultForm();
            if (defaultForm != null)
            {
                this.ShowTabbedMdi(defaultForm);
            }
            this.cmdCloseAll.Click += cmdCloseAll_Click;


            //this.SetFormControlFont(this.pnlMenu);

        }


        void cmdCloseAll_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (XMessageBox.ShowQuestion("确定关闭所有的窗口吗？") == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            foreach (frmBase frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        /// <summary>
        /// 初始化菜单
        /// </summary>
        protected virtual void InitMenuFolder()
        {

            XMenuFolderInfoTool menuFolderInfoTool = this.GetMenuFolderInfoTool();
            string userId = this.GetLoginUserId();
            IList<XModelBase> menuFolderInfos = null;
            if (this.IsAdmin)
            {
                menuFolderInfos = menuFolderInfoTool.GetAllMenuFolderInfos();
            }
            else
            {
                menuFolderInfos = menuFolderInfoTool.GetMenuFolderInfos(userId);
            }
            XMenuTool menuFolderTool = new XMenuTool(this.panelMenu, menuFolderInfos);
            menuFolderTool.MenuClickEvent += new MenuClickHandler(menuFolderTool_MenuClickEvent);
        }

        /// <summary>
        /// 获取默认窗体
        /// </summary>
        /// <returns></returns>
        protected virtual frmBase GetDefaultForm()
        {
            return null;
        }

        protected virtual string GetLoginUserId()
        {
            return string.Empty;
        }

        /// <summary>
        /// 菜单单击事件
        /// </summary>
        /// <param name="menuInfo"></param>
        /// <param name="e"></param>
        protected virtual void menuFolderTool_MenuClickEvent(XMenuInfo menuInfo, EventArgs e)
        {
            try
            {
                frmBase frm = Assembly.Load(menuInfo.NameSpace).CreateInstance(menuInfo.FullAssembleName) as frmBase;
                if (frm == null)
                {
                    XMessageBox.ShowError("该功能未实现或者实现的接口不正确！");
                    return;
                }
                if (menuInfo.IsDialogModel)
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
                else
                {
                    this.ShowTabbedMdi(frm);
                }
            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
            }
        }

        protected void ShowTabbedMdi(frmBase form)
        {
            bool isFound = false;
            foreach (frmBase frm in this.MdiChildren)
            {
                if (frm.Key == form.Key)
                {
                    frm.Activate();
                    this.ActivateMdiChild(frm);
                    isFound = true;
                }
            }
            try
            {
                if (!isFound)
                {
                    form.MdiParent = this;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.m_IsSignOut)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    System.Windows.Forms.DialogResult.Yes)
                {
                    this.Exit();

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Exit()
        {
            try
            {
                XLoginLogBusiness business = new XLoginLogBusiness();
                business.Exit(XCommon.LoginId);
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
            }
            this.Dispose();
            Environment.Exit(0);
        }

        private void cmdExit_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// 获取菜单工具类：此类必须重写
        /// </summary>
        /// <returns></returns>
        public virtual XMenuFolderInfoTool GetMenuFolderInfoTool()
        {
            return new XMenuFolderInfoTool();
        }

        /// <summary>
        /// 是否系统管理员
        /// </summary>
        protected virtual bool IsAdmin
        {
            get { return false; }
        }

        void cmdSignOut_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            m_IsSignOut = true;
            this.SignOut();
        }

        /// <summary>
        /// 注销
        /// </summary>
        protected virtual void SignOut()
        {
            if (XMessageBox.ShowQuestion("您确定要注销吗？") == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            Application.Restart();
        }
    }
}
