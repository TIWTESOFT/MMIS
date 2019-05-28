using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;
using System.Data;
using MMIS.Model;

namespace MMIS.BLL
{
     /// <summary>
    /// 单位类型
    /// </summary>
    public partial class XCodeEquipmentStateBusiness : XBusinessBase
    {
        public XCodeEquipmentStateBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetCodeEquipmentStateProvider();
        }
    
        /// <summary>
        /// 自定义删除校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XCodeEquipmentStateInfo codeequipmentstate = modelInfo as XCodeEquipmentStateInfo;
            if (codeequipmentstate == null)
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
            XCodeEquipmentStateInfo codeequipmentstate = modelInfo as XCodeEquipmentStateInfo;
            if (codeequipmentstate == null)
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
            XCodeEquipmentStateInfo codeequipmentstate = modelInfo as XCodeEquipmentStateInfo;
            if (codeequipmentstate == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }
    }
}