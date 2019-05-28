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
using MMIS.Model;

namespace MMIS.UI
{
    public partial class frmFileTreeListList : frmTreeListBase
    {
     

        public frmFileTreeListList()
        {
            InitializeComponent();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);

            this.grpQuery.Width = this.grpQuery.Parent.Width - 10;

            this.btnQuery.Location = new Point(this.grpQuery.Width - this.btnQuery.Width - 10, this.btnQuery.Location.Y);
            this.btnDownload.Location = new Point(this.btnQuery.Location.X - this.btnDownload.Width - 10, this.btnQuery.Location.Y);
        }

        protected override BLL.XBusinessBase InitTreeBusiness()
        {
            return new XCodeFolderTypeBusiness();
        }

        protected override frmTreeEditBase GetAddNewForm()
        {
            return new frmCodeFolderTypeTreeEdit(this.treeView);
        }

        protected override frmTreeEditBase GetTreeEditForm()
        {
            return new frmCodeFolderTypeTreeEdit(this.treeView.SelectedNode);
        }

        protected override string GetModelText(Model.XModelBase model)
        {
            XCodeFolderTypeInfo folderTypeInfo = model as XCodeFolderTypeInfo;
            return folderTypeInfo.NameCN;
        }

        protected override bool IsEndModel(XModelBase model)
        {
            return this.m_TreeBusiness.IsEndModel(model);
        }


        protected override XBusinessBase InitListBusiness()
        {
            return new XFileListBusiness();
        }

        protected override string ListTreeFieldName
        {
            get
            {
                return "FolderTypeId";
            }
        }

        protected override frmEditBase GetAddForm(XModelBase selectedTreeModel)
        {
            return new frmFileListEdit(this.m_CurrentList, selectedTreeModel);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmFileListEdit(this.m_CurrentModel);
        }

        protected override bool IsQueryDataFromView
        {
            get
            {
                return true;
            }
        }

        protected override bool IsAllowDownload
        {
            get
            {
                return true;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            this.Download();
        }

    }
}
