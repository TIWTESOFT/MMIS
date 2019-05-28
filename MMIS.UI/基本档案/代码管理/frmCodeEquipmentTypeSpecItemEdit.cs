using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.UI
{
    public partial class frmCodeEquipmentTypeSpecItemEdit : frmEditBase
    {
    
       /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XCodeEquipmentTypeBusiness m_CodeEquipmentTypeBusiness = new XCodeEquipmentTypeBusiness();
        
        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmCodeEquipmentTypeSpecItemEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        private string cName = "";
        private string cRid = "";
        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmCodeEquipmentTypeSpecItemEdit(XModelBase currentModel, string Flag,string name,string rid)
        {
            InitializeComponent();
            this.m_CurrentModel = currentModel;
            this.cName = name;
            this.cRid = rid;

           this.SetDefaultValue();
            if (Flag.ToUpper() == "A")
            {
                this.m_EditStatus = XEditStatus.AddNew ;
            }
            else
            {
                this.m_EditStatus = XEditStatus.Edit;
                lbxx.Visible = true;
                cbodevselect.Visible = true;
                BandComb();
            }
 
        }


        #endregion
        
        
         /// <summary>
        /// 获取业务操作对象
        /// </summary>
        /// <returns></returns>
        protected override XBusinessBase InitBusiness()
        {
            return new XCodeEquipmentTypeBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XCodeEquipmentTypeInfo();
        }
        
          /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            //XCodeEquipmentTypeInfo info = this.m_CurrentModel as XCodeEquipmentTypeInfo;
            
            this.txtNameCN.Text = this.cName;
            //this.txtNameEN.Text = info.NameEN;
            this.txtrid.Text = this.cRid;
        }
        
        
        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            return true;
        }

        /// <summary>
        /// 填充实体信息
        /// </summary>
        protected override void FillModelInfo()
        {
            //XCodeEquipmentTypeInfo info = this.m_CurrentModel as XCodeEquipmentTypeInfo;

            // if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue)
            //{
            //    info.RID = this.GetNewId();
            //}
            
            ////info.NameEN = this.txtNameEN.Text;
            //info.NameCN = this.txtNameCN.Text;

            
            //base.FillModelInfo();
        }

        /// <summary>
        /// 绑定设备选项
        /// </summary>
        private void BandComb()
        {
            string sqlget = "select * from codedef where NameEN='EquipmentTypeSpec' and ParentID='" + txtrid.Text + "'";
            DataTable dt = new DataTable();
            dt = SQLHelper.GetDataSet(sqlget);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (cbodevselect.Items != null)
                    {
                        for (int i = 0; i < cbodevselect.Items.Count; i++)
                        {
                            cbodevselect.Items.RemoveAt(0);
                        }
                    }

                    cbodevselect.DataSource = dt;
                    cbodevselect.DisplayMember = "NameCN";
                    cbodevselect.ValueMember = "RID";

                }
            }
        }

        private void cbodevselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                return;
            }
            txtNameEN.Text = cbodevselect.Text;

        }

        protected override bool SaveAdd()
        {
            int i = 0;
            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                string sqlget = "insert into codedef (RID, NameEN, NameCN, ParentID) VALUES('" + System.DateTime.Now.ToString("yyyyMMddHHmmssffff") + "','EquipmentTypeSpec','" + txtNameEN.Text + "','" + txtrid.Text + "')";
                i= SQLHelper.ExecuteCommand(sqlget);
            }
            else
            {

            }
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override bool SaveEdit()
        {
            int i = 0;
            if (this.m_EditStatus == XEditStatus.AddNew)
            {

            }
            else
            {
                string sqlget = "update codedef set NameCN='" + txtNameEN.Text + "' where rid='" + cbodevselect.SelectedValue.ToString() + "'";
                i = SQLHelper.ExecuteCommand(sqlget);
            }
            if (i > 0)
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