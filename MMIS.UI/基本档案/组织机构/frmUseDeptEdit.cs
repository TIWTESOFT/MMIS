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
    public partial class frmUseDeptEdit : frmEditBase
    {
    
       /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XUseDeptBusiness m_UseDeptBusiness = new XUseDeptBusiness();
        
        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmUseDeptEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmUseDeptEdit(XModelBase currentModel)
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
            return new XUseDeptBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XUseDeptInfo();
        }
        
          /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XUseDeptInfo info = this.m_CurrentModel as XUseDeptInfo;

            this.txtParentID.Text = info.ParentID;
            this.txtDeptName.Text = info.DeptName;
            this.nebNameNum.Value = info.NameNum;
            this.txtSpell.Text = info.Spell;
            this.txtSpellHeader.Text = info.SpellHeader;
            this.chkIsUsed.Checked = info.IsUsed;
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
            XUseDeptInfo info = this.m_CurrentModel as XUseDeptInfo;

            info.ParentID = this.txtParentID.Text;
            info.DeptName = this.txtDeptName.Text;
            info.NameNum = XHelper.GetInt(this.nebNameNum.Value);
            info.Spell = this.txtSpell.Text;
            info.SpellHeader = this.txtSpellHeader.Text;
            info.IsUsed = this.chkIsUsed.Checked;
            info.Remark = this.txtRemark.Text;
            
            base.FillModelInfo();
        }
    }
}