using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;
using MMIS.Model;

namespace MMIS.BLL
{
    public partial class XEquipmentCheckBusiness
    {
        /// <summary>
        /// 获取设备编号
        /// </summary>
        /// <param name="ruleCode"></param>
        /// <returns></returns>
        public string GetEquipmentNo(string ruleCode)
        {
            XEquipmentCheckProvider provider = this.m_Provider as XEquipmentCheckProvider;
            return provider.GetEquipmentNo(ruleCode);
        }

        public bool IsEquipmentNoExist(string equipmentNo)
        {
            XEquipmentCheckProvider provider = this.m_Provider as XEquipmentCheckProvider;
            return provider.IsEquipmentNoExist(equipmentNo);
        }

        public bool Checked(XModelBase model, string userId)
        {
            XEquipmentCheckProvider provider = this.m_Provider as XEquipmentCheckProvider;
            return provider.Checked(model, userId);
        }

    }
}
