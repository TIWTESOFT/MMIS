using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.Model;
using MMIS.BLL;

namespace MMIS.UI
{
    public partial class frmSelectEquipmentCheck : frmEquipmentCheckList
    {
        public frmSelectEquipmentCheck()
        {
            InitializeComponent();
        }

        protected override bool IsSelectForm
        {
            get
            {
                return true;
            }
        }

        protected override string SelectFormTitle
        {
            get
            {
                return "选择设备";
            }
        }

        protected override void grdData_Click(object sender, EventArgs e)
        {
            if (this.grdData.CurrentRow != null)
            {
                XEquipmentCheckInfo checkInfo = this.grdData.CurrentRow.DataRow as XEquipmentCheckInfo;

                XEquipmentReceiveBusiness business=new XEquipmentReceiveBusiness();

                IList<XModelBase> receiveInfos = business.GetTop5Checked(checkInfo.RID);

                this.grdEquipmentRecieve.DataSource = receiveInfos;
                this.grdEquipmentRecieve.AutoSizeColumns();
            }
        }
    }
}
