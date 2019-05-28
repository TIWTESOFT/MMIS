using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.Helper;
using MMIS.UI.Common;
using MMIS.BLL;
using System.Runtime.InteropServices;

namespace MMIS.UI
{
    public partial class frmWebResetPassword : frmEditBase
    {
        protected string m_UserIds = string.Empty;

        public frmWebResetPassword()
        {
            InitializeComponent();
        }

        public frmWebResetPassword(string userIds)
        {
            InitializeComponent();
            this.m_UserIds = userIds;
        }

        protected override XBusinessBase InitBusiness()
        {
            return null;
        }

        protected override void SaveFunction()
        {
            if (this.txtPassword.Text.Trim() == string.Empty)
            {
                XMessageBox.ShowError("重置密码不能为空！");
                return;
            }

            string password = XMD5EncodeTool.Encode(this.txtPassword.Text.Trim());

            if (this.ResetOperate(password))
            {
                XMessageBox.ShowRemindMessage("重置密码成功！");
                this.Close();
            }
            else
            {
                XMessageBox.ShowRemindMessage("重置密码失败！");
            }
        }

        protected virtual bool ResetOperate(string password)
        {
            return false;
        }

        
    }
}
