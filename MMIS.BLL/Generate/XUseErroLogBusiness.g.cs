using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;
using System.Data;
using MMIS.Model;

namespace MMIS.BLL
{
     /// <summary>
    /// 
    /// </summary>
    public partial class XUseErroLogBusiness : XBusinessBase
    {
        public XUseErroLogBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetUseErroLogProvider();
        }
    
        /// <summary>
        /// 自定义删除校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XUseErroLogInfo useerrolog = modelInfo as XUseErroLogInfo;
            if (useerrolog == null)
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
            XUseErroLogInfo useerrolog = modelInfo as XUseErroLogInfo;
            if (useerrolog == null)
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
            XUseErroLogInfo useerrolog = modelInfo as XUseErroLogInfo;
            if (useerrolog == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }
    }
}