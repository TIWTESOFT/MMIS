using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVStandEquipmentCheckRecordInfo : XStandEquipmentCheckRecordInfo
    {
        private string m_StandName = string.Empty;

        public string StandName
        {
            get { return this.m_StandName; }
            set { this.m_StandName = value; }
        }

        private string m_StandId = string.Empty;

        public string StandId
        {
            get { return this.m_StandId; }
            set { this.m_StandId = value; }
        }

        private string m_EquipmentName = string.Empty;

        public string EquipmentName
        {
            get { return this.m_EquipmentName; }
            set { this.m_EquipmentName = value; }
        }
    }
}
