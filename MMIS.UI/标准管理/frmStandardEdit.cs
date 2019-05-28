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
using MMIS.Component;

namespace MMIS.UI
{
    public partial class frmStandardEdit : frmTabEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XStandardBusiness m_StandardBusiness = new XStandardBusiness();



        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmStandardEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmStandardEdit(XModelBase currentModel)
        {
            InitializeComponent();
            this.m_CurrentModel = currentModel;
            this.m_EditStatus = XEditStatus.Edit;
            this.SetDefaultValue();
        }


        #endregion


        /// <summary>
        /// 获取业务操作对象
        /// </summary>
        /// <returns></returns>
        protected override XBusinessBase InitBusiness()
        {
            return new XStandardBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVStandardInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVStandardInfo info = this.m_CurrentModel as XVStandardInfo;

            this.txtStandNo.Text = info.StandNo;
            this.txtStandName.Text = info.StandName;
            this.dtCreateTime.Value = XHelper.GetDateTime(info.CreateTime);
            this.dtNextCheckTime.Value = XHelper.GetDateTime(info.NextCheckTime);
            this.nebCheckTimes.Value = info.CheckTimes;
            this.txtChargeUserId.Text = info.ChargeUserId;
            this.txtRemark.Text = info.Remark;
            //if (info.StandStatus != string.Empty)
            //{
            //    this.txtStatus111.Text = info.StandStatusName;
            //    this.txtStatus111.ValueMember = info.StandStatus;
            //    this.txtStatus111.DisplayMember = info.StandStatusName;
            //}

            this.cboStatus.Text = info.StandStatus;

            this.txtStandDesc.Text = info.StandDesc;

        }


        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            IList<XModelBase> standFiles = this.grdFiles.DataSource as IList<XModelBase>;

            int maxVersionCount = 0;

            if (standFiles.Count > 0)
            {
                foreach (XStandFilesInfo standFile in standFiles)
                {
                    if (standFile.IsMaxVersion)
                    {
                        maxVersionCount += 1;
                    }
                }
            }

            if (maxVersionCount > 1)
            {
                XMessageBox.ShowError("只能有一个文件集是最新版本！");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 填充实体信息
        /// </summary>
        protected override void FillModelInfo()
        {
            XVStandardInfo info = this.m_CurrentModel as XVStandardInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.m_PrimaryKeyId;
            }

            info.StandNo = this.txtStandNo.Text;
            info.StandName = this.txtStandName.Text;
            info.CreateTime = XHelper.GetFormatedDate(this.dtCreateTime.Value);
            info.NextCheckTime = XHelper.GetFormatedDate(this.dtNextCheckTime.Value);
            info.CheckTimes = XHelper.GetInt(this.nebCheckTimes.Value);
            info.ChargeUserId = this.txtChargeUserId.Text;
            info.Remark = this.txtRemark.Text;

            info.StandDesc = this.txtStandDesc.Text.Trim();
            //info.StandStatus = this.txtStatus111.ValueMember;
            //info.StandStatusName = this.txtStatus111.DisplayMember;

            info.StandStatus = this.cboStatus.Text.Trim();

            base.FillModelInfo();
        }

        protected override void InitDetailBusiness()
        {
            foreach (Janus.Windows.UI.Tab.UITabPage tabPage in this.tabDetail.TabPages)
            {
                XBusinessBase business = null;
                switch (tabPage.Name)
                {
                    case "pageFiles":
                        business = new XStandFilesBusiness();
                        break;
                    case "pageEquipments":
                        business = new XStandEquipmentBusiness();
                        break;
                }
                tabPage.Tag = business;
            }
        }

        protected override IList<XModelBase> GetTabPageDetailList(XBusinessBase tabPageBusiness, string mainId)
        {
            return tabPageBusiness.GetViewByMainId(mainId, "");
        }

        protected override frmEditBase GetAddNewDetailForm(IList<XModelBase> gridList, object sender)
        {
            XButton btnAddNew = sender as XButton;

            switch (btnAddNew.Name)
            {
                case "btnAddNewFile":
                    return new frmStandFilesMemoryEdit(gridList);
                case "btnAddNewEquipment":
                    return new frmStandEquipmentMemoryEdit(gridList);
                default:
                    return null;
            }
        }

        protected override frmEditBase GetEditDetailForm(object sender, XModelBase currentModel)
        {
            XButton btnAddNew = sender as XButton;

            switch (btnAddNew.Name)
            {
                case "btnEditFile":
                    return new frmStandFilesMemoryEdit(currentModel);
                case "btnEditEquipment":
                    return new frmStandEquipmentMemoryEdit(currentModel);
                default:
                    return null;
            }
        }

        protected override bool SaveAdd()
        {
            return this.m_Business.Insert(this.m_CurrentModel, this.m_DetailDict);
        }

        protected override bool SaveEdit()
        {
            return this.m_Business.Update(this.m_CurrentModel, m_DetailDict, m_DeleteDict);
        }
    }
}