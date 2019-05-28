using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVStandCodeEquipmentInfo : XStandCodeEquipmentInfo
    {
        private string m_EquipStatus = string.Empty;

        /// <summary>
        /// 设备状态
        /// </summary>
        public string EquipStatus
        {
            get { return this.m_EquipStatus; }
            set { this.m_EquipStatus = value; }
        }
    }
}
