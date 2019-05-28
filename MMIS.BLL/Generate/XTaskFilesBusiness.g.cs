﻿using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;
using System.Data;
using MMIS.Model;

namespace MMIS.BLL
{
     /// <summary>
    /// 任务文档
    /// </summary>
    public partial class XTaskFilesBusiness : XBusinessBase
    {
        public XTaskFilesBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetTaskFilesProvider();
        }
    
        /// <summary>
        /// 自定义删除校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XTaskFilesInfo taskfiles = modelInfo as XTaskFilesInfo;
            if (taskfiles == null)
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
            XTaskFilesInfo taskfiles = modelInfo as XTaskFilesInfo;
            if (taskfiles == null)
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
            XTaskFilesInfo taskfiles = modelInfo as XTaskFilesInfo;
            if (taskfiles == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }
    }
}