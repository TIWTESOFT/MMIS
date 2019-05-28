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
    public partial class frmRemindConfigEdit : frmEditBase
    {
    
       /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XRemindConfigBusiness m_RemindConfigBusiness = new XRemindConfigBusiness();
        
        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmRemindConfigEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmRemindConfigEdit(XModelBase currentModel)
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
            return new XRemindConfigBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XRemindConfigInfo();
        }
        
          /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XRemindConfigInfo info = this.m_CurrentModel as XRemindConfigInfo;

            this.txtConfigType.Text = info.ConfigType;
            this.nebRemindDays.Value = info.RemindDays;
            this.txtRemindInfoTemplate.Text = info.RemindInfoTemplate;
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
            XRemindConfigInfo info = this.m_CurrentModel as XRemindConfigInfo;

             if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue)
            {
                info.RID = this.GetNewId();
            }
            
            info.ConfigType = this.txtConfigType.Text;
            info.RemindDays = XHelper.GetInt(this.nebRemindDays.Value);
            info.RemindInfoTemplate = this.txtRemindInfoTemplate.Text;
            info.Remark = this.txtRemark.Text;
            
            base.FillModelInfo();
        }
    }
}