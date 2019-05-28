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
using MMIS.BLL;
using MMIS.Component;

namespace MMIS.UI
{
    public partial class frmCoPrintList : frmListBase
    {
        public frmCoPrintList()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.dtBegin.Value = this.dtEnd.Value.AddMonths(-1);
            base.FormLoadFunction(sender, e);
            //2016-11-30,mxj,del
            //this.cmDelete.Visible = Janus.Windows.UI.InheritableBoolean.False;
            //this.grdData.RootTable.Columns["GetTime"].DataTypeCode = TypeCode.DateTime;
            this.grdData.RootTable.Columns["GetTime"].FormatString = "yyyy-MM-dd";
        }

        protected override BLL.XBusinessBase InitBusiness()
        {
            return new XTemplateBillBusiness();
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

        /// <summary>
        /// 2016-11-30,mxj,modify
        /// </summary>
        protected override bool IsAllowDelete
        {
            get
            {
                return true;
            }
        }
        /// <summary>
        /// 2016-11-30,mxj,add
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateDeleteCustom()
        {
            if (this.grdData.CurrentRow.IsChecked)
            {
                XTemplateBillInfo curr = this.grdData.CurrentRow.DataRow as XTemplateBillInfo;

                DataTable dt = new DataTable();
                string sql = "select Rno, Bno from TemplateBill where Rno='" + curr.Rno + "' and Bno='" + curr.Bno + "'";
                dt = SQLHelper.GetDataSet(sql);

                if (dt != null)
                {
                    //XMessageBox.ShowRemindMessage("数据提取异常！");
                    if (dt.Rows.Count <= 1)
                    {
                        if (XMessageBox.ShowQuestion("不存在重复项，是否继续删除！", "提示") == System.Windows.Forms.DialogResult.Yes)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                return false;
            }

                return true;

        }


        protected override bool IsAllowDoubleEdit
        {
            get
            {
                return false;
            }
        }

        protected override bool IsQueryDataFromView
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 选中行
        /// </summary>
        /// <returns></returns>
        private string  GetSelectRow()
        {
            string selectid = "";
            foreach (Janus.Windows.GridEX.GridEXRow gridRow in this.grdData.GetRows())
            {
                if (gridRow.IsChecked)
                {
                    XModelBase currentModel = gridRow.DataRow as XModelBase;          
                    string id = currentModel.ID;
                    selectid += "'" + id + "',";
                }
            }
            selectid = selectid.TrimEnd(',');

            return selectid;
        }

        private bool IsCheck(string selectrid)
        {
            if (selectrid == "")
            {
                return false;
            }
            return true;
        }

    }
}
