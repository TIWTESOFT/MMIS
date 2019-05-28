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
    public partial class frmCodeTempPssStateEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XCodeTempPssStateBusiness m_CodeTempPssStateBusiness = new XCodeTempPssStateBusiness();

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmCodeTempPssStateEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;

            this.txtUserID.Text = XCommon.LoginUsersInfo.RID;

        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmCodeTempPssStateEdit(XModelBase currentModel)
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
            return new XCodeTempPssStateBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XCodeTempPssStateInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XCodeTempPssStateInfo info = this.m_CurrentModel as XCodeTempPssStateInfo;

            this.txtNameEN.Text = info.NameEN;
            this.txtNameCN.Text = info.NameCN;
            this.txtNameBig5.Text = info.NameBig5;
            this.txtCode.Text = info.Code;
            this.nebCodeNum.Value = info.CodeNum;
            this.txtCodeEN.Text = info.CodeEN;
            this.txtSpell.Text = info.Spell;
            this.txtSpellHeader.Text = info.SpellHeader;
            this.nebProirNum.Value = info.ProirNum;
            this.txtDeptId.Text = info.DeptId;
            this.chkIsUsed.Checked = info.IsUsed;
            this.txtParentID.Text = info.ParentID;
            this.txtUserID.Text = info.UserID;
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
            XCodeTempPssStateInfo info = this.m_CurrentModel as XCodeTempPssStateInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
            }


            info.NameEN = this.txtNameEN.Text;
            info.NameCN = this.txtNameCN.Text;
            info.NameBig5 = this.txtNameBig5.Text;
            info.Code = this.txtCode.Text;
            info.CodeNum = XHelper.GetInt(this.nebCodeNum.Value);
            info.CodeEN = this.txtCodeEN.Text;
            info.Spell = this.txtSpell.Text;
            info.SpellHeader = this.txtSpellHeader.Text;
            info.ProirNum = XHelper.GetInt(this.nebProirNum.Value);
            info.DeptId = this.txtDeptId.Text;
            info.IsUsed = this.chkIsUsed.Checked;
            info.ParentID = this.txtParentID.Text;
            info.UserID = this.txtUserID.Text;
            info.Remark = this.txtRemark.Text;

            base.FillModelInfo();
        }

        private void txtNameCN_Leave(object sender, EventArgs e)
        {
            if (this.txtSpell.Text.Trim() == string.Empty)
            {
                this.txtSpell.Text = XSpellHelper.GetFullSpell(this.txtNameCN.Text.Trim());
            }
            if (this.txtSpellHeader.Text.Trim() == string.Empty)
            {
                this.txtSpellHeader.Text = XSpellHelper.GetSpellHeader(this.txtNameCN.Text.Trim());
            }
        }
    }
}