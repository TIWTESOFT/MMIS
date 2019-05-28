using MMIS.Helper;
using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI
{
    public partial class frmSystemConfig : frmEditBase
    {
        private XSystemConfigTool m_ConfigTool = new XSystemConfigTool();

        public frmSystemConfig()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.SetConfigInfo();
        }

        private void SetConfigInfo()
        {
            XSystemConfigInfo configInfo = m_ConfigTool.GetConfigInfo();

            this.nebWidth.Value = XHelper.GetInt(configInfo.SignWidht);
            this.nebHeight.Value = XHelper.GetInt(configInfo.SignHeight);
            this.nebRefreshMinutes.Value = XHelper.GetInt(configInfo.RefreshMinutes);
        }

        protected override void SaveFunction()
        {
            XSystemConfigInfo configInfo = new XSystemConfigInfo();
            configInfo.SignWidht = XHelper.GetInt(this.nebWidth.Value);
            configInfo.SignHeight = XHelper.GetInt(this.nebHeight.Value);
            configInfo.RefreshMinutes = XHelper.GetInt(this.nebRefreshMinutes.Value);

            if (this.m_ConfigTool.SaveConfigInfo(configInfo))
            {
                XUICommon.SystemConfigInfo = configInfo;
                XMessageBox.ShowRemindMessage("保存成功！");
                this.Close();
            }
        }
    }
}
