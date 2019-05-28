using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.UI
{
    public partial class frmFileDownloadList : frmFileListList
    {
        private XPassWordTmpBusiness m_TempBusiness = new XPassWordTmpBusiness();
        private XPassWordTmpInfo m_PasswordTempInfo = null;
        private XPassWord4FileBusiness m_PassWord4FileBusiness = new XPassWord4FileBusiness();

        public frmFileDownloadList()
        {
            InitializeComponent();
        }

        protected override bool IsAllowOperateData
        {
            get
            {
                return false;
            }
        }

        protected override bool IsAllowDownLoad
        {
            get
            {
                return true;
            }
        }

        protected override bool IsAllowAddNew
        {
            get
            {
                return false;
            }
        }

        protected override bool IsAllowEdit
        {
            get
            {
                return false;
            }
        }

        protected override bool ValidateDownLoadCustom()
        {
            bool isAllowDownLoad = false;

            if (XCommon.LoginUsersInfo.IsDownPower)
            {
                isAllowDownLoad = true;
            }
            else
            {
                frmFileDownloadEdit frm = new frmFileDownloadEdit();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.m_PasswordTempInfo = frm.PasswordTempInfo;
                    isAllowDownLoad = true;
                }
            }

            if (!isAllowDownLoad)
            {
                //XMessageBox.ShowError("您没有下载文件的权限！");
                return false;
            }

            return true;
        }

        protected override void DownloadAfter(string fileName, XModelBase model)
        {
            if (!XCommon.LoginUsersInfo.IsDownPower)
            {
                //如果不是超权限下载，则说明是通过密码下载
                XFileListInfo fileInfo = this.m_CurrentModel as XFileListInfo;
                XPassWord4FileInfo passFileInfo = new XPassWord4FileInfo();

                if (this.m_PasswordTempInfo != null)
                {
                    passFileInfo.RID = Guid.NewGuid().ToString();
                    passFileInfo.ID = passFileInfo.RID;
                    passFileInfo.DownLoadUserId = XCommon.LoginUsersInfo.RID;
                    passFileInfo.FileID = fileInfo.RID;
                    passFileInfo.PassWord = this.m_PasswordTempInfo.Password;
                    passFileInfo.PassWordTmpId = this.m_PasswordTempInfo.RID;

                    this.m_PassWord4FileBusiness.Insert(passFileInfo);
                }
            }
        }

        protected override void FormLoadFunction(object sender, System.EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.cmDelete.Visible = Janus.Windows.UI.InheritableBoolean.False;
            this.cmdExport.Visible = Janus.Windows.UI.InheritableBoolean.False;
        }
    }
}
