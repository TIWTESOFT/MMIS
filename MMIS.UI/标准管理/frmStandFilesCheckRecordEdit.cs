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
    public partial class frmStandFilesCheckRecordEdit : frmEditBase
    {
    
       /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XStandFilesCheckRecordBusiness m_StandFilesCheckRecordBusiness = new XStandFilesCheckRecordBusiness();
        
        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmStandFilesCheckRecordEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmStandFilesCheckRecordEdit(XModelBase currentModel)
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
            return new XStandFilesCheckRecordBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVStandFilesCheckRecordInfo();
        }
        
          /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVStandFilesCheckRecordInfo info = this.m_CurrentModel as XVStandFilesCheckRecordInfo;

            if (info.StandFileId != string.Empty)
            {
                this.txtStandFileId.ValueMember = info.StandFileId;
                this.txtStandFileId.Text = info.FileName;
                this.txtStandFileId.DisplayMember = info.FileName;
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
            XVStandFilesCheckRecordInfo info = this.m_CurrentModel as XVStandFilesCheckRecordInfo;

             if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue)
            {
                info.RID = this.GetNewId();
            }
            
            info.StandFileId = this.txtStandFileId.ValueMember;
            info.FileName = this.txtStandFileId.DisplayMember;
            if (this.txtStandFileId.SelectedModel != null)
            {
                XVStandFilesInfo fileInfos = this.txtStandFileId.SelectedModel as XVStandFilesInfo;

                info.StandName = fileInfos.StandName;
                info.StandId = fileInfos.MainId;
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