using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVStandEquipmentInfo : XStandEquipmentInfo
    {
        private string m_EquipmentStatus = string.Empty;

        public string EquipmentStatus
        {
            get { return this.m_EquipmentStatus; }
            set { this.m_EquipmentStatus = value; }
        }

        private string m_StandName = string.Empty;

        /// <summary>
        /// 标准名称
        /// </summary>
        public string StandName
        {
            get { return this.m_StandName; }
            set { this.m_StandName = value; }
        }
    }
}
