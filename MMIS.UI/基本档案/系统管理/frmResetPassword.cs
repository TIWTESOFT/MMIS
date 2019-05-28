using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;

namespace MMIS.UI
{
    public partial class frmResetPassword : frmWebResetPassword
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        public frmResetPassword(string userIds)
            : base(userIds)
        {
            InitializeComponent();
        }

        protected override XBusinessBase InitBusiness()
        {
            return new XUsersBusiness();
        }

        protected override bool ResetOperate(string password)
        {
            XUsersBusiness usersBusiness = this.m_Business as XUsersBusiness;
            return usersBusiness.UpdatePasswordMulti(this.m_UserIds, password);
        }
    }
}
