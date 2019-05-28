using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;

namespace MMIS.UI.Common
{
    public partial class XListControlBase : XControlBase
    {
        public XListControlBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化业务对象
        /// </summary>
        /// <returns></returns>
        protected virtual XBusinessBase InitBusiness()
        {
            return new XBusinessBase();
        }
    }
}
