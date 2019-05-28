using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;
using System.Data;
using MMIS.Model;

namespace MMIS.BLL
{
     /// <summary>
    /// 用户状态
    /// </summary>
    public partial class XCodeUserStateBusiness : XBusinessBase
    {
        public XCodeUserStateBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetCodeUserStateProvider();
        }
    
        /// <summary>
        /// 自定义删除校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XCodeUserStateInfo codeuserstate = modelInfo as XCodeUserStateInfo;
            if (codeuserstate == null)
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
            XCodeUserStateInfo codeuserstate = modelInfo as XCodeUserStateInfo;
            if (codeuserstate == null)
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
            XCodeUserStateInfo codeuserstate = modelInfo as XCodeUserStateInfo;
            if (codeuserstate == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }
    }
}