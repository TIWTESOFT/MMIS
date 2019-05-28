﻿using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;
using System.Data;
using MMIS.Model;

namespace MMIS.BLL
{
     /// <summary>
    /// 临时密码下载文档
    /// </summary>
    public partial class XPassWord4FileBusiness : XBusinessBase
    {
        public XPassWord4FileBusiness()
        {
            this.m_Provider = XFactoryManager.CreateFactory().GetPassWord4FileProvider();
        }
    
        /// <summary>
        /// 自定义删除校验
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            string validateInfo = string.Empty;
            XPassWord4FileInfo password4file = modelInfo as XPassWord4FileInfo;
            if (password4file == null)
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
            XPassWord4FileInfo password4file = modelInfo as XPassWord4FileInfo;
            if (password4file == null)
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
            XPassWord4FileInfo password4file = modelInfo as XPassWord4FileInfo;
            if (password4file == null)
            {
                return this.GetNotRightType();
            }
            return string.Empty;
        }
    }
}