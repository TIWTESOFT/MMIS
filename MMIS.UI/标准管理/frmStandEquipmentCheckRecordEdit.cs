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
    public partial class frmStandEquipmentCheckRecordEdit : frmEditBase
    {
    
       /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XStandEquipmentCheckRecordBusiness m_StandEquipmentCheckRecordBusiness = 
            new XStandEquipmentCheckRecordBusiness();
        
        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmStandEquipmentCheckRecordEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmStandEquipmentCheckRecordEdit(XModelBase currentModel)
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
            return new XStandEquipmentCheckRecordBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVStandEquipmentCheckRecordInfo();
        }
        
          /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVStandEquipmentCheckRecordInfo info = this.m_CurrentModel as XVStandEquipmentCheckRecordInfo;

            if (info.StandEqupimentId != string.Empty)
            {
                this.txtStandEqupimentId.Text = info.EquipmentName;
                this.txtStandEqupimentId.ValueMember = info.StandEqupimentId;
                this.txtStandEqupimentId.DisplayMember = info.EquipmentName;
            }
            this.txtCheckUserName.Text = info.CheckUserName;
            this.txtCheckDesc.Text = info.CheckDesc;
            this.dtCheckDate.Value = XHelper.GetDateTime(info.CheckDate);
            this.dtNextCheckDate.Value = XHelper.GetDateTime(info.NextCheckDate);
            this.txtRemark.Text = info.Remark;
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
            XVStandEquipmentCheckRecordInfo info = this.m_CurrentModel as XVStandEquipmentCheckRecordInfo;

             if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue)
            {
                info.RID = this.GetNewId();
            }
            
            info.StandEqupimentId = this.txtStandEqupimentId.ValueMember;
            info.EquipmentName = this.txtStandEqupimentId.DisplayMember;
            if (this.txtStandEqupimentId.SelectedModel != null)
            {
                XVStandEquipmentInfo equipmentInfo = this.txtStandEqupimentId.SelectedModel as XVStandEquipmentInfo;
                info.StandId = equipmentInfo.MainId;
                info.StandName = equipmentInfo.StandName;
            }
            info.CheckUserName = this.txtCheckUserName.Text;
            info.CheckDesc = this.txtCheckDesc.Text;
            info.CheckDate = XHelper.GetFormatedDate(this.dtCheckDate.Value);
            info.NextCheckDate = XHelper.GetFormatedDate(this.dtNextCheckDate.Value);
            info.Remark = this.txtRemark.Text;
            
            base.FillModelInfo();
        }
    }
}