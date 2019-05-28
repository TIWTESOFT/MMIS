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
    public partial class frmRoleEdit : frmEditBase
    {
    
       /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XRoleBusiness m_RoleBusiness = new XRoleBusiness();
        
        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmRoleEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmRoleEdit(XModelBase currentModel)
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
            return new XRoleBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XRoleInfo();
        }
        
          /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XRoleInfo info = this.m_CurrentModel as XRoleInfo;

            

            this.txtRoleName.Text = info.RoleName;
            this.nebNameNum.Value = info.NameNum;
            this.txtSpell.Text = info.Spell;
            this.txtSpellHeader.Text = info.SpellHeader;
            this.nebOrderIndex.Value = info.OrderIndex;
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
            XRoleInfo info = this.m_CurrentModel as XRoleInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
            }

            info.RoleName = this.txtRoleName.Text;
            info.NameNum = XHelper.GetInt(this.nebNameNum.Value);
            info.Spell = this.txtSpell.Text;
            info.SpellHeader = this.txtSpellHeader.Text;
            info.OrderIndex = XHelper.GetInt(this.nebOrderIndex.Value);
            info.IsUsed = this.chkIsUsed.Checked;
            info.Remark = this.txtRemark.Text;
            
            base.FillModelInfo();
        }

        private void txtRoleName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRoleName_Leave(object sender, EventArgs e)
        {
            if (this.txtSpell.Text.Trim() == string.Empty)
            {
                this.txtSpell.Text = XSpellHelper.GetFullSpell(this.txtRoleName.Text.Trim());
            }
            if (this.txtSpellHeader.Text.Trim() == string.Empty)
            {
                this.txtSpellHeader.Text = XSpellHelper.GetSpellHeader(this.txtRoleName.Text.Trim());
            }
        }
    }
}