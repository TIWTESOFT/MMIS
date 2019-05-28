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
    public partial class frmCodeEquipmentTypeEdit : frmEditBase
    {
    
       /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XCodeEquipmentTypeBusiness m_CodeEquipmentTypeBusiness = new XCodeEquipmentTypeBusiness();
        
        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmCodeEquipmentTypeEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmCodeEquipmentTypeEdit(XModelBase currentModel)
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
            XCodeEquipmentTypeInfo info = this.m_CurrentModel as XCodeEquipmentTypeInfo;

            this.txtNameEN.Text = info.NameEN;
            this.txtNameCN.Text = info.NameCN;
            this.txtRuleCode.Text = info.RuleCode;
            this.txtNameBig5.Text = info.NameBig5;
            this.txtCode.Text = info.Code;
            this.nebCodeNum.Value = info.CodeNum;
            //this.txtCodeEN.Text = info.CodeEN;
            //this.txtSpell.Text = info.Spell;
            //this.txtSpellHeader.Text = info.SpellHeader;
            if (info.Spell != string.Empty)
            {
                this.txtStandId.Text = info.SpellHeader;
                this.txtStandId.ValueMember = info.Spell;
                this.txtStandId.DisplayMember = info.SpellHeader;
            }

            this.nebProirNum.Value = info.ProirNum;
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
            XCodeEquipmentTypeInfo info = this.m_CurrentModel as XCodeEquipmentTypeInfo;

             if (this.m_EditStatus == XEditStatus.AddNew || this.m_EditStatus == XEditStatus.AddContinue)
            {
                info.RID = this.GetNewId();
            }
            
            info.NameEN = this.txtNameEN.Text;
            info.NameCN = this.txtNameCN.Text;
            info.RuleCode = this.txtRuleCode.Text;
            info.NameBig5 = this.txtNameBig5.Text;
            info.Code = this.txtCode.Text;
            info.CodeNum = XHelper.GetInt(this.nebCodeNum.Value);
            //info.CodeEN = this.txtCodeEN.Text;
            //info.Spell = this.txtSpell.Text;
            //info.SpellHeader = this.txtSpellHeader.Text;
            info.Spell = this.txtStandId.ValueMember;
            info.SpellHeader = this.txtStandId.DisplayMember;

            info.ProirNum = XHelper.GetInt(this.nebProirNum.Value);
            
            base.FillModelInfo();
        }

        private void btnNewitem_Click(object sender, EventArgs e)
        {
            frmCodeEquipmentTypeItemEdit frm = new frmCodeEquipmentTypeItemEdit(this.m_CurrentModel,"A");
            frm.ShowDialog();
        }

        private void btnmodifyitem_Click(object sender, EventArgs e)
        {
            frmCodeEquipmentTypeItemEdit frm = new frmCodeEquipmentTypeItemEdit(this.m_CurrentModel, "M");
            frm.ShowDialog();
        }
    }
}