using System;
using System.Collections.Generic;
using System.Text;
using MMIS.Model;
using MMIS.DAL;
using MMIS.Helper;
using System.Data;

namespace MMIS.BLL
{
    public partial class XBusinessBase
    {
        protected XProviderBase m_Provider;

        public XBusinessBase()
        {

        }


        /// <summary>
        /// 查询表格
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual DataTable GetTableByWhere(string where)
        {
            return this.m_Provider.GetTableByWhere(where);
        }

        /// <summary>
        /// 获取集合
        /// </summary>
        /// <returns></returns>
        public virtual IList<XModelBase> GetAll()
        {
            return this.m_Provider.GetAll();
        }

        public virtual DataTable GetAllTable()
        {
            return this.m_Provider.GetAllTable();
        }

        /// <summary>
        /// 通过主表Id获取记录
        /// </summary>
        /// <param name="mainId"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> GetByMainId(string mainId, string where)
        {
            return this.m_Provider.GetByMainId(mainId, where);
        }

        /// <summary>
        /// 获取视图模型记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual XModelBase GetViewById(string id)
        {
            return this.m_Provider.GetViewById(id);
        }

        /// <summary>
        /// 通过主表Id获取记录
        /// </summary>
        /// <param name="mainId"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> GetViewByMainId(string mainId, string where)
        {
            return this.m_Provider.GetViewByMainId(mainId, where);
        }

        /// <summary>
        /// 获取集合
        /// </summary>
        /// <returns></returns>
        public virtual IList<XModelBase> GetAllView()
        {
            return this.m_Provider.GetAllView();
        }

        /// <summary>
        /// 获取插入校验信息
        /// </summary>
        /// <returns></returns>
        protected virtual string GetValidateInsert(XModelBase modelInfo)
        {
            string validateCommon = this.GetValidateInsertCommon(modelInfo);
            if (validateCommon != string.Empty)
            {
                return validateCommon;
            }

            string validateCustom = this.GetValidateInsertCustom(modelInfo);
            if (validateCustom != string.Empty)
            {
                return validateCustom;
            }

            return string.Empty;
        }

        /// <summary>
        /// 获取插入校验的公共信息
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetValidateInsertCommon(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取插入校验的自定义信息
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetValidateInsertCustom(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取更新校验信息
        /// </summary>
        /// <returns></returns>
        protected virtual string GetValidateUpdate(XModelBase modelInfo)
        {
            string validateCommon = this.GetValidateUpdateCommon(modelInfo);
            if (validateCommon != string.Empty)
            {
                return validateCommon;
            }

            string validateCustom = this.GetValidateUpdateCustom(modelInfo);
            if (validateCustom != string.Empty)
            {
                return validateCustom;
            }

            return string.Empty;
        }

        /// <summary>
        /// 获取更新校验的公共信息
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetValidateUpdateCommon(XModelBase modelInfo)
        {
            //DateTime timpStamp = this.m_Provider.GetTimeStamp(modelInfo);
            //if (timpStamp != XHelper.GetDateTime(modelInfo.TimeStamp))
            //{
            //    return "数据已更新，请刷新后重试！";
            //}

            return string.Empty;
        }

        /// <summary>
        /// 获取更新校验的自定义信息
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetValidateUpdateCustom(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 类型不匹配校验
        /// </summary>
        /// <returns></returns>
        protected virtual string GetNotRightType()
        {
            return "实体类型不匹配！";
        }

        /// <summary>
        /// 获得删除校验信息
        /// </summary>
        /// <returns></returns>
        protected virtual string GetValidateDelete(XModelBase modelInfo)
        {
            string validateCommon = this.GetValidateDeleteCommon(modelInfo);
            if (validateCommon != string.Empty)
            {
                return validateCommon;
            }

            string validateCustom = this.GetValidateDeleteCustom(modelInfo);
            if (validateCustom != string.Empty)
            {
                return validateCustom;
            }

            return string.Empty;
        }

        /// <summary>
        /// 获取删除校验的公共信息
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetValidateDeleteCommon(XModelBase modelInfo)
        {
            bool isUsed = this.IsUsed(modelInfo);

            string errorInfo = string.Empty;

            if (isUsed)
            {
                errorInfo += "该记录已被使用，不能删除！";
            }

            return errorInfo;
        }

        /// <summary>
        /// 获取删除校验的自定义信息
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetValidateDeleteCustom(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 通过查询条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> QueryByWhere(string where)
        {
            return this.m_Provider.QueryByWhere(where);
        }

        public virtual IList<XModelBase> QueryTop100ByWhere(string where)
        {
            return this.m_Provider.QueryTop100ByWhere(where);
        }

        public virtual IList<XModelBase> QueryTop100ViewByWhere(string where)
        {
            return this.m_Provider.QueryTop100ViewByWhere(where);
        }

        /// <summary>
        /// 根据查询条件获取视图记录
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> QueryViewByWhere(string where)
        {
            return this.m_Provider.QueryViewByWhere(where);
        }

        /// <summary>
        /// 根据主键获取记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual XModelBase GetById(string id)
        {
            return this.m_Provider.GetById(id);
        }

        /// <summary>
        /// 添加操作
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual bool Insert(XModelBase modelInfo)
        {
            string validateResult = this.GetValidateInsert(modelInfo);

            if (validateResult == string.Empty)
            {
                return this.m_Provider.Insert(modelInfo);
            }
            else
            {
                XMessageBox.ShowError(validateResult);
                return false;
            }
        }

        /// <summary>
        /// 更新操作
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual bool Update(XModelBase modelInfo)
        {
            string validateResult = this.GetValidateUpdate(modelInfo);

            if (validateResult == string.Empty)
            {
                return this.m_Provider.Update(modelInfo);
            }
            else
            {
                XMessageBox.ShowError(validateResult);
                return false;
            }
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual bool Delete(XModelBase modelInfo, string userId)
        {
            string validateResult = this.GetValidateDelete(modelInfo);
            if (validateResult == string.Empty)
            {
                return this.m_Provider.Delete(modelInfo, userId);
            }
            else
            {
                XMessageBox.ShowError(validateResult);
                return false;
            }
        }

        /// <summary>
        /// 删除多条记录
        /// </summary>
        /// <param name="modelInfos"></param>
        /// <returns></returns>
        public virtual bool Delete(IList<XModelBase> modelInfos, string userId)
        {
            string validateInfos = string.Empty;

            foreach (XModelBase modelInfo in modelInfos)
            {
                validateInfos += this.GetValidateDelete(modelInfo) + "\r\n";
            }

            if (validateInfos.Replace("\r\n", "") == string.Empty)
            {
                return this.m_Provider.Delete(modelInfos, userId);
            }
            else
            {
                XMessageBox.ShowError(validateInfos);
                return false;
            }
        }

        public bool DeleteWithDetails(IList<XModelBase> modelInfos)
        {
            return this.m_Provider.DeleteWithDetails(modelInfos);
        }

        /// <summary>
        /// 获取根节点集合
        /// </summary>
        /// <returns></returns>
        public IList<Model.XModelBase> GetRootModelList()
        {
            return this.m_Provider.GetRootModelList();
        }

        /// <summary>
        /// 获取根节点的集合
        /// </summary>
        /// <returns></returns>
        public virtual IList<Model.XModelBase> GetRootViewModelList(string where)
        {
            return this.m_Provider.GetRootViewModelList(where);
        }

        /// <summary>
        /// 获取子节点集合
        /// </summary>
        /// <returns></returns>
        public virtual IList<Model.XModelBase> GetChildModelLists(XModelBase model)
        {
            return this.m_Provider.GetChildModelLists(model);
        }

        /// <summary>
        /// 获取子节点
        /// </summary>
        /// <returns></returns>
        public virtual IList<Model.XModelBase> GetChildViewModelLists(XModelBase model, string where = "")
        {
            return this.m_Provider.GetChildViewModelLists(model, where);
        }

        /// <summary>
        /// 是否末级节点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsEndNode(XModelBase model)
        {
            return this.m_Provider.IsEndNode(model);
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DateTime GetTimeStamp(string id)
        {
            return this.m_Provider.GetTimeStamp(id);
        }

        /// <summary>
        /// 是否已使用
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsUsed(XModelBase model)
        {
            return this.m_Provider.IsUsed(model);
        }

        /// <summary>
        /// 插入明细
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="detailInfos"></param>
        /// <returns></returns>
        public virtual bool Insert(XModelBase modelInfo, IList<XModelBase> detailInfos)
        {
            return this.m_Provider.Insert(modelInfo, detailInfos);
        }

        /// <summary>
        /// 更新明细
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="detailInfos"></param>
        /// <returns></returns>
        public virtual bool Update(XModelBase modelInfo, IList<XModelBase> detailInfos)
        {
            return this.m_Provider.Update(modelInfo, detailInfos);
        }

        /// <summary>
        /// 带明细删除
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual bool DeleteWithDetail(XModelBase modelInfo)
        {
            return this.m_Provider.DeleteWithDetail(modelInfo);
        }

        /// <summary>
        /// 是否已发布
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public bool IsSend(XModelBase modelInfo)
        {
            return this.m_Provider.IsSend(modelInfo);
        }

        /// <summary>
        /// 发布
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public bool Send(XModelBase modelInfo, XSendMessageInfo sendMessageInfo)
        {
            return this.m_Provider.Send(modelInfo, sendMessageInfo);
        }

        /// <summary>
        /// 反馈
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="sendMessageInfo"></param>
        /// <returns></returns>
        public bool Feedback(XModelBase modelInfo, XSendMessageInfo sendMessageInfo, string feedbackUserId)
        {
            return this.m_Provider.Feedback(modelInfo, sendMessageInfo, feedbackUserId);
        }

        public bool InsertFile(string id, string mainID, string fileName, string userId)
        {
            return this.m_Provider.InsertFile(id, mainID, fileName, userId);
        }

        public bool Download(string id, string filePath)
        {
            return this.m_Provider.Download(id, filePath);
        }

        /// <summary>
        /// 获取附件数
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        public virtual int GetFileCount(string mainId)
        {
            return this.m_Provider.GetFileCount(mainId);
        }

        /// <summary>
        /// 获取附件信息
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetFileInfoes(string mainId, string where)
        {
            return this.m_Provider.GetFileInfoes(mainId, where);
        }

        public bool DeleteFile(string id)
        {
            return this.m_Provider.DeleteFile(id);
        }

        /// <summary>
        /// 删除实体集合
        /// </summary>
        /// <param name="modelInfos"></param>
        /// <returns></returns>
        public bool DeleteFiles(IList<XModelBase> modelInfos, string userId)
        {
            return this.m_Provider.DeleteFiles(modelInfos, userId);
        }


        /// <summary>
        /// 是否已提交
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool IsCommit(XModelBase model)
        {
            return this.m_Provider.IsCommit(model);
        }

        /// <summary>
        /// 是否已审核
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool IsCheck(XModelBase model)
        {
            return this.m_Provider.IsCheck(model);
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Commit(XModelBase model)
        {
            return this.m_Provider.Commit(model);
        }

        /// <summary>
        /// 收回
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Rollback(XModelBase model)
        {
            return this.m_Provider.Rollback(model);
        }

        /// <summary>
        /// 是否定义了工作流
        /// </summary>
        /// <param name="voucherTypeCode"></param>
        /// <returns></returns>
        public bool IsHaveWorkFlow(string voucherTypeCode)
        {
            return this.m_Provider.IsHaveWorkFlow(voucherTypeCode);
        }

        /// <summary>
        /// 获取要审核的记录
        /// </summary>
        /// <param name="jobCode"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<XModelBase> GetToCheckViewList(string jobCode, string where)
        {
            return this.m_Provider.GetToCheckViewList(jobCode, where);
        }

        /// <summary>
        /// 获取当前应审核信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public XModelBase GetToCheckInfo(XModelBase model)
        {
            return this.m_Provider.GetToCheckInfo(model);
        }

        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="model"></param>
        /// <param name="checkLevelInfo"></param>
        /// <returns></returns>
        public bool Check(XModelBase model, XCheckLevelInfo checkLevelInfo)
        {
            return this.m_Provider.Check(model, checkLevelInfo);
        }

        /// <summary>
        /// 获取当前应弃审信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public XModelBase GetBackToCheckInfo(XModelBase model)
        {
            return this.m_Provider.GetBackToCheckInfo(model);
        }

        /// <summary>
        /// 获取已审核的记录
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<XModelBase> GetCheckedViewList(string userId, string where)
        {
            return this.m_Provider.GetCheckedViewList(userId, where);
        }

        /// <summary>
        /// 弃审
        /// </summary>
        /// <param name="model"></param>
        /// <param name="backCheckLevelInfo"></param>
        /// <returns></returns>
        public bool BackCheck(XModelBase model, XCheckLevelInfo backCheckLevelInfo)
        {
            return this.m_Provider.BackCheck(model, backCheckLevelInfo);
        }

        /// <summary>
        /// 是否定义了发布信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsHaveSendMessageDef(string voucherTypeCode)
        {
            return this.m_Provider.IsHaveSendMessageDef(voucherTypeCode);
        }

        /// <summary>
        /// 消息是否已被阅读
        /// </summary>
        /// <param name="voucherTypeCode"></param>
        /// <param name="voucherId"></param>
        /// <returns></returns>
        public bool IsSendMessageReaded(string voucherId)
        {
            return this.m_Provider.IsSendMessageReaded(voucherId);
        }

        /// <summary>
        /// 撤销发布
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public bool BackSend(XModelBase modelInfo, string userId)
        {
            return this.m_Provider.BackSend(modelInfo, userId);
        }

        /// <summary>
        /// 是否已终审
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsLastCheck(XModelBase model)
        {
            return this.m_Provider.IsLastCheck(model);
        }

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsExist(string value)
        {
            return this.m_Provider.IsExist(value);
        }

        /// <summary>
        /// 查询表格
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual DataTable GetViewByWhere(string where)
        {
            return this.m_Provider.GetViewByWhere(where);
        }

        /// <summary>
        /// 模型是否已存在
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool IsModelExist(XModelBase model)
        {
            return this.m_Provider.IsModelExist(model);
        }

        /// <summary>
        /// 查看审批流程
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        public virtual DataTable ViewWorkFlow(string mainId)
        {
            return this.m_Provider.ViewWorkFlow(mainId);
        }

        /// <summary>
        /// 根据名称获得编码
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public virtual string GetCodeByName(string name)
        {
            return this.m_Provider.GetCodeByName(name);
        }

        /// <summary>
        /// 获取流水号
        /// </summary>
        /// <returns></returns>
        public virtual string GetSeqNo(string start)
        {
            return this.m_Provider.GetSeqNo(start);
        }

        /// <summary>
        /// 获取按照日期来生成的流水号
        /// </summary>
        /// <returns></returns>
        public virtual string GetDateSeqNo()
        {
            return this.m_Provider.GetDateSeqNo();
        }

        /// <summary>
        /// 数据复制
        /// </summary>
        /// <param name="sourceMonth"></param>
        /// <param name="destMonth"></param>
        /// <returns></returns>
        public virtual bool MonthDataCopy(string sourceMonth, string destMonth, string userId)
        {
            return this.m_Provider.MonthDataCopy(sourceMonth, destMonth, userId);
        }

        /// <summary>
        /// 获取月份行数
        /// </summary>
        /// <param name="sourceMonth"></param>
        /// <returns></returns>
        public virtual int GetMonthDataCopyCount(string sourceMonth)
        {
            return this.m_Provider.GetMonthDataCopyCount(sourceMonth);
        }

        public bool IsEndModel(XModelBase model, string where = "")
        {
            return this.m_Provider.IsEndModel(model, where);
        }

        public bool Check(XModelBase model, string userId)
        {
            return this.m_Provider.Check(model, userId);
        }

        public bool BackCheck(XModelBase model, string userId)
        {
            return this.m_Provider.BackCheck(model, userId);
        }

        public IList<XModelBase> GetToCheckTableList(string where)
        {
            return this.m_Provider.GetToCheckTableList(where);
        }

        public IList<XModelBase> GetCheckedTableList(string where)
        {
            return this.m_Provider.GetCheckedTableList(where);
        }

        public virtual bool Insert(XModelBase modelInfo, IDictionary<string, IList<XModelBase>> detailDict)
        {
            return this.m_Provider.Insert(modelInfo, detailDict);
        }

        /// <summary>
        /// Tab页的更新
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="detailDict"></param>
        /// <param name="deleteDict"></param>
        public virtual bool Update(XModelBase modelInfo, IDictionary<string, IList<XModelBase>> detailDict,
           IDictionary<string, IList<XModelBase>> deleteDict)
        {
            return this.m_Provider.Update(modelInfo, detailDict, deleteDict);
        }

        protected virtual bool DeleteWithDict(IList<XModelBase> modelInfos,
                    IDictionary<string, IList<XModelBase>> detailDict)
        {
            return this.m_Provider.DeleteWithDict(modelInfos, detailDict);
        }

        /// <summary>
        /// 获取子表记录数
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        public virtual int GetCountByMainId(string mainId)
        {
            return this.m_Provider.GetCountByMainId(mainId);
        }

        public bool IsUsed(string id)
        {
            return this.m_Provider.IsUsed(id);
        }
    }
}
