using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;

namespace MMIS.UI
{
    public partial class frmFileListList : frmListBase
    {
        public frmFileListList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XFileListBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmFileListEdit(this.m_CurrentList);
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

        protected override bool IsAllowDownLoad
        {
            get
            {
                return true;
            }
        }
    }
}