using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.Component;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.UI
{
    public partial class frmCodeFolderTypeTreeEdit : frmTreeEditBase
    {
        public frmCodeFolderTypeTreeEdit()
            : base()
        {
            InitializeComponent();
        }

        public frmCodeFolderTypeTreeEdit(XTreeView treeView)
            : base(treeView)
        {
            InitializeComponent();
        }

        public frmCodeFolderTypeTreeEdit(TreeNode treeNode)
            : base(treeNode)
        {
            InitializeComponent();
            this.SetDefaultValue();
        }

        protected override BLL.XBusinessBase InitBusiness()
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
            //this.txtUserID.Text = info.UserID;
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

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
                info.ID = info.RID;
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
            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                //如果是新增的情况下，才需要给父节点赋值
                //info.ParentID = this.txtParentID.Text;
                TreeNode selectedNode = this.m_TreeView.SelectedNode;
                if (selectedNode != null && !this.chkIsRootNode.Checked)
                {
                    XCodeFolderTypeInfo folderTypeInfo = selectedNode.Tag as XCodeFolderTypeInfo;
                    info.ParentID = folderTypeInfo.RID;
                }
            }
            //info.UserID = this.txtUserID.Text;
            info.Remark = this.txtRemark.Text;

            base.FillModelInfo();
        }

        protected override string GetTreeNodeText(XModelBase model)
        {
            XCodeFolderTypeInfo info = model as XCodeFolderTypeInfo;
            return info.NameCN;
        }
    }
}
