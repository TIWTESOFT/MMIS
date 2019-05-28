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
    public partial class frmPrintList : frmListBase
    {
        public frmPrintList()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            this.dtBegin.Value = this.dtEnd.Value.AddMonths(-1);
            base.FormLoadFunction(sender, e);
            this.cmDelete.Visible = Janus.Windows.UI.InheritableBoolean.False;
        }

        protected override BLL.XBusinessBase InitBusiness()
        {
            return new XEquipmentReceiveBusiness();
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

        protected override bool IsAllowDelete
        {
            get
            {
                return false;
            }
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
                return true;
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
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string selectrid = GetSelectRow();
            if (!(IsCheck(selectrid)))
            {
                XMessageBox.ShowRemindMessage("请选择记录信息！");
                return;
            }
            DataTable dt = new DataTable();
            string sql = "select * from V_EquipmentReceive where rid in(" + selectrid + ") order by EquipmentName";
            dt = SQLHelper.GetDataSet(sql);

            if (dt == null)
            {
                XMessageBox.ShowRemindMessage("数据提取异常！");
                return;
            }
            if (dt.Rows.Count <= 0)
            {
                XMessageBox.ShowRemindMessage("数据提取异常！");
                return;
            }

            string cust = "";
            string invoiceno = "";

            if (dt.Rows.Count > 0)
            {
                cust = dt.Rows[0]["CustName"] + "";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (cust != dt.Rows[i]["CustName"] + "")
                    {
                        XMessageBox.ShowRemindMessage("所选数据中单位不一致！");
                        return;
                    }
                    invoiceno = dt.Rows[i]["InvoiceNo"] + "";
                    if (invoiceno != "")
                    {
                        XMessageBox.ShowRemindMessage("所选数据中存在已打印数据！");
                        return;
                    }
                }
            }

            frmBillPrint frm = new frmBillPrint("A", selectrid, dt);
            frm.ShowDialog();

            this.Query();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            string selectrid = GetSelectRow();
            if (!(IsCheck(selectrid)))
            {
                XMessageBox.ShowRemindMessage("请选择记录信息！");
                return;
            }

            DataTable dt = new DataTable();
            string sql = "select * from V_EquipmentReceive where rid in(" + selectrid + ")";
            dt = SQLHelper.GetDataSet(sql);

            if (dt == null)
            {
                XMessageBox.ShowRemindMessage("数据提取异常！");
                return;
            }
            if (dt.Rows.Count<=0)
            {
                XMessageBox.ShowRemindMessage("数据提取异常！");
                return;
            }

            string cust = "";
            string invoiceno = "";
            if (dt.Rows.Count > 0)
            {
                cust = dt.Rows[0]["CustName"] + "";
                invoiceno = dt.Rows[0]["InvoiceNo"] + "";

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    if (dt.Rows[i]["InvoiceNo"] + "" == "")
                    {
                        XMessageBox.ShowRemindMessage("所选数据中存在接收单代码为空的！");
                        return;
                    }
                    if (cust != dt.Rows[i]["CustName"] + "")
                    {
                        XMessageBox.ShowRemindMessage("所选数据中单位不一致！");
                        return;
                    }
                    if (invoiceno != dt.Rows[i]["InvoiceNo"] + "")
                    {
                        XMessageBox.ShowRemindMessage("所选数据中接收单代码不一致！");
                        return;
                    }
                }
            }

            frmBillPrint frm = new frmBillPrint("M", selectrid, dt);
            frm.ShowDialog();

            this.Query();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            string selectrid = GetSelectRow();
            if (!(IsCheck(selectrid)))
            {
                XMessageBox.ShowRemindMessage("请选择记录信息！");
                return;
            }
            DataTable dt = new DataTable();
            string sql = "select * from V_EquipmentReceive where rid in(" + selectrid + ")";
            dt = SQLHelper.GetDataSet(sql);

            if (dt == null)
            {
                XMessageBox.ShowRemindMessage("数据提取异常！");
                return;
            }
            if (dt.Rows.Count <= 0)
            {
                XMessageBox.ShowRemindMessage("数据提取异常！");
                return;
            }
            if (dt.Rows.Count > 1)
            {
                XMessageBox.ShowRemindMessage("请选择一条数据！");
                return;
            }
            string invoiceno = dt.Rows[0]["InvoiceNo"] + "";
            if (invoiceno == "")
            {
                XMessageBox.ShowRemindMessage("所选数据未打印接收单！");
                return;
            }

            if (MessageBox.Show("是否删除接收单号为：" + invoiceno + "的接收单信息？", "提醒！", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                string sqldel = "delete from TemplateBill where Rno='" + invoiceno + "'";
                string sqlupdate = "update EquipmentReceive set InvoiceNo='' where InvoiceNo='" + invoiceno + "'";

                if (SQLHelper.ExecuteCommand(sqldel) > 0)
                {
                    if (SQLHelper.ExecuteCommand(sqlupdate)>0)
                    {
                        XMessageBox.ShowRemindMessage("执行成功！");
                    }
                }

            }


            
            this.Query();
        }
    }
}
