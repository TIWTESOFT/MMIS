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

namespace MMIS.UI
{
    public partial class frmEditPassword : frmEditBase
    {
        public frmEditPassword()
        {
            InitializeComponent();
            this.txtUserId.Text = UserId;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        protected override XBusinessBase InitBusiness()
        {
            return new XUsersBusiness();
        }

        protected override bool SaveAdd()
        {
            XEncodeAndDecodeBase encodeTool = XEncodeAndDecodeContext.GetEncodeAndDecodeTool(EncodeType.Md5);
            string password = encodeTool.Encode(this.txtPassword.Text);

            XUsersBusiness business = this.m_Business as XUsersBusiness;
            return business.UpdatePassword(this.UserId, password);
        }

        protected override bool ValidataForm()
        {
            if (this.txtPassword.Text.Trim() != this.txtRepass.Text.Trim())
            {
                XMessageBox.ShowError("两次输入的密码不一致！");
                return false;
            }
            return true;
        }
    }
}
