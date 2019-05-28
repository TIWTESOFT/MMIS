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
    public partial class frmSelectCodeEquipmentType : frmCodeEquipmentTypeList
    {
        public frmSelectCodeEquipmentType()
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
                return "选择设备类型";
            }
        }

        private void BindCol()
        {
            Janus.Windows.GridEX.GridEXColumn bcol = new Janus.Windows.GridEX.GridEXColumn("Remark");
            bcol.HasValueList = true;

            string sqlget = "select * from codedef where NameEN='EquipmentType'";
            DataTable dt = new DataTable();
            dt = SQLHelper.GetDataSet(sqlget);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {

                }
            }

            Janus.Windows.GridEX.GridEXValueListItemCollection vcol = new Janus.Windows.GridEX.GridEXValueListItemCollection();
            vcol.PopulateValueList(dt.DefaultView, "NameCN", "NameCN");

            bcol.EditType = Janus.Windows.GridEX.EditType.DropDownList;
            bcol.CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text;
            bcol.DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text;



        }

        private void frmSelectCodeEquipmentType_Load(object sender, EventArgs e)
        {
            //BindCol();
        }

    }
}
