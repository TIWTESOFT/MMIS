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
    public partial class frmStandFilesList : frmListBase
    {
        public frmStandFilesList()
        {
            InitializeComponent();
        }
        
        protected override XBusinessBase InitBusiness()
        {
            return new XStandFilesBusiness();
        }

        protected override frmEditBase GetAddForm()
        {
            return new frmStandFilesEdit(this.m_CurrentList);
        }

        protected override frmEditBase GetEditForm()
        {
            return new frmStandFilesEdit(this.m_CurrentModel);
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

        protected override bool IsAllowPreview
        {
            get
            {
                return true;
            }
        }
    }
}