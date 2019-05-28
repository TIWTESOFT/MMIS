using MMIS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI
{
    public partial class frmStandFilesMemoryEdit : frmStandFilesEdit
    {
        public frmStandFilesMemoryEdit()
        {
            InitializeComponent();
        }

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmStandFilesMemoryEdit(IList<XModelBase> modelList)
            : base(modelList)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmStandFilesMemoryEdit(XModelBase currentModel)
            : base(currentModel)
        {
            InitializeComponent();
            this.SetDefaultValue();
        }

        protected override bool SaveAdd()
        {
            return true;
        }

        protected override bool SaveEdit()
        {
            return true;
        }

        protected override bool GetIsShowSaveMessage()
        {
            return false;
        }

        protected override void SavedAfterOperate()
        {

        }
    }
}
