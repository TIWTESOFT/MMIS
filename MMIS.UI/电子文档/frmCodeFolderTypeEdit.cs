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
    public partial class frmCodeFolderTypeEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XCodeFolderTypeBusiness m_CodeFolderTypeBusiness = new XCodeFolderTypeBusiness();

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmCodeFolderTypeEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmCodeFolderTypeEdit(XModelBase currentModel)
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
            return new XCodeFolderTypeBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XCodeFolderTypeInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XCodeFolderTypeInfo info = this.m_CurrentModel as XCodeFolderTypeInfo;

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
            XCodeFolderTypeInfo info = this.m_CurrentModel as XCodeFolderTypeInfo;

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
    }
}