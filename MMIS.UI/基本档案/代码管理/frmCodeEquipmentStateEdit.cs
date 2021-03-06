﻿using System;
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
    public partial class frmCodeEquipmentStateEdit : frmEditBase
    {

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XCodeEquipmentStateBusiness m_CodeEquipmentStateBusiness = new XCodeEquipmentStateBusiness();

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmCodeEquipmentStateEdit(IList<XModelBase> modelList)
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
        public frmCodeEquipmentStateEdit(XModelBase currentModel)
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
            return new XCodeEquipmentStateBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XCodeEquipmentStateInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XCodeEquipmentStateInfo info = this.m_CurrentModel as XCodeEquipmentStateInfo;

            this.txtNameEN.Text = info.NameEN;
            this.txtNameCN.Text = info.NameCN;
            this.txtNameBig5.Text = info.NameBig5;
            this.txtCode.Text = info.Code;
            this.nebCodeNum.Value = info.CodeNum;
            this.txtCodeEN.Text = info.CodeEN;
            this.txtSpell.Text = info.Spell;
            this.txtSpellHeader.Text = info.SpellHeader;
            //this.txtColorRGB.Text = info.ColorRGB;
            this.nebProirNum.Value = info.ProirNum;
            this.txtDeptId.Text = info.DeptId;
            this.chkIsUsed.Checked = info.IsUsed;
            this.txtParentID.Text = info.ParentID;
            this.txtUserID.Text = info.UserID;
            this.txtRemark.Text = info.Remark;

            string colorArgb = info.ColorRGB;
            string[] rgbs = colorArgb.Split(',');
            if (rgbs.Length == 3)
            {
                int r = XHelper.GetInt(rgbs[0]);
                int g = XHelper.GetInt(rgbs[1]);
                int b = XHelper.GetInt(rgbs[2]);
                Color color = Color.FromArgb(r, g, b);
                this.btnColor.SelectedColor = color;
            }

        }


        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            //Color color = this.btnColor.SelectedColor;
            //if (color.R + color.G + color.B == 0)
            //{
            //    XMessageBox.ShowError("颜色不能为空或者为黑色！");
            //    return false;
            //}

            return true;
        }

        /// <summary>
        /// 填充实体信息
        /// </summary>
        protected override void FillModelInfo()
        {
            XCodeEquipmentStateInfo info = this.m_CurrentModel as XCodeEquipmentStateInfo;

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
            //info.ColorRGB = this.txtColorRGB.Text;
            info.ProirNum = XHelper.GetInt(this.nebProirNum.Value);
            info.DeptId = this.txtDeptId.Text;
            info.IsUsed = this.chkIsUsed.Checked;
            info.ParentID = this.txtParentID.Text;
            info.UserID = this.txtUserID.Text;
            info.Remark = this.txtRemark.Text;

            Color selectedColor = this.btnColor.SelectedColor;
            info.ColorRGB = selectedColor.R.ToString() + "," +
                selectedColor.G.ToString() + "," + selectedColor.B.ToString();

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