using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;
using System.Data;
using MMIS.Model;

namespace MMIS.BLL
{
     /// <summary>
    /// 设备接收
    /// </summary>
    public partial class XEquipmentReceiveBusiness : XBusinessBase
    {
        public XEquipmentReceiveBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetEquipmentReceiveProvider();
        }
    
        /// <summary>
        /// 自定义删除校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XEquipmentReceiveInfo equipmentreceive = modelInfo as XEquipmentReceiveInfo;
            if (equipmentreceive == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }

        /// <summary>
        /// 自定义新增校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateInsertCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XEquipmentReceiveInfo equipmentreceive = modelInfo as XEquipmentReceiveInfo;
            if (equipmentreceive == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }

        /// <summary>
        /// 自定义修改校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateUpdateCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XEquipmentReceiveInfo equipmentreceive = modelInfo as XEquipmentReceiveInfo;
            if (equipmentreceive == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }
    }
}