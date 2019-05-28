using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI.Common
{
    public partial class frmSingleDetailEditBase : frmEditBase
    {
        public frmSingleDetailEditBase()
        {
            InitializeComponent();
        }

        protected XModelBase m_MainModel = null;

        public frmSingleDetailEditBase(XModelBase mainModel, IList<XModelBase> modelList)
            : base(modelList)
        {
            InitializeComponent();
            this.m_MainModel = mainModel;
        }

        public frmSingleDetailEditBase(XModelBase currentModel)
            : base(currentModel)
        {
            InitializeComponent();
        }
    }
}
