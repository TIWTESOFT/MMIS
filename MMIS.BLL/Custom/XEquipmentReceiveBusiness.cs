using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;
using MMIS.Model;

namespace MMIS.BLL
{
    public partial class XEquipmentReceiveBusiness
    {
        /// <summary>
        /// 获取当前状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetStatus(string id)
        {
            XEquipmentReceiveProvider provider = this.m_Provider as XEquipmentReceiveProvider;
            return provider.GetStatus(id);
        }
        public string GetScalar(string id,string col)
        {
            XEquipmentReceiveProvider provider = this.m_Provider as XEquipmentReceiveProvider;
            return provider.GetScalar(id,col);
        }
        /// <summary>
        /// 检定
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Checked(XModelBase model, string userId)
        {
            XEquipmentReceiveProvider provider = this.m_Provider as XEquipmentReceiveProvider;
            return provider.Checked(model, userId);
        }

        /// <summary>
        /// 核验
        /// </summary>
        /// <param name="model"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Verify(XModelBase model, string userId)
        {
            XEquipmentReceiveProvider provider = this.m_Provider as XEquipmentReceiveProvider;
            return provider.Verify(model, userId);
        }

        /// <summary>
        /// 签发
        /// </summary>
        /// <param name="model"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool Sign(XModelBase model, string userId)
        {
            XEquipmentReceiveProvider provider = this.m_Provider as XEquipmentReceiveProvider;
            return provider.Sign(model, userId);
        }

        /// <summary>
        /// 退回重新检定
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Back(XModelBase model)
        {
            XEquipmentReceiveProvider provider = this.m_Provider as XEquipmentReceiveProvider;
            return provider.Back(model);
        }
        /// <summary>
        /// 制证
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool PrintBill(XModelBase model)
        {
            XEquipmentReceiveProvider provider = this.m_Provider as XEquipmentReceiveProvider;
            return provider.PrintBill(model);
        }
        /// <summary>
        /// 获取提醒信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetRemind(string userId)
        {
            XEquipmentReceiveProvider provider = this.m_Provider as XEquipmentReceiveProvider;
            return provider.GetRemind(userId);
        }

         /// <summary>
        /// 获取5次溯源时间
        /// </summary>
        /// <param name="equipmentCheckId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetTop5Checked(string equipmentCheckId)
        {
            XEquipmentReceiveProvider provider = this.m_Provider as XEquipmentReceiveProvider;
            return provider.GetTop5Checked(equipmentCheckId);
        }
    }
}
