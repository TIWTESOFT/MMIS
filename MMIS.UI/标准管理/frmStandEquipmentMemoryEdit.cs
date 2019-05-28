using MMIS.Model;
using MMIS.UI.Common;
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
    public partial class frmStandEquipmentMemoryEdit : frmStandEquipmentEdit
    {
        public frmStandEquipmentMemoryEdit()
        {
            InitializeComponent();
        }

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmStandEquipmentMemoryEdit(IList<XModelBase> modelList)
            : base(modelList)
        {
            InitializeComponent();
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmStandEquipmentMemoryEdit(XModelBase currentModel)
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
    }
}
