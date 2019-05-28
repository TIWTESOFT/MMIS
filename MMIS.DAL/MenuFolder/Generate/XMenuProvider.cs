using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;
using MMIS.FolderModel;

namespace MMIS.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public partial class XMenuProvider : XProviderBase
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "Menu";
            }
        }

        protected override XModelBase InitTableModel()
        {
            return new XMenuInfo();
        }

        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo, DataRow modelRow)
        {
            XMenuInfo info = modelInfo as XMenuInfo;

            info.ID = XHelper.GetString(modelRow["RID"]);//
            info.GroupId = XHelper.GetString(modelRow["GroupId"]);//
            info.MenuName = XHelper.GetString(modelRow["MenuName"]);//
            info.NameSpace = XHelper.GetString(modelRow["AssembleName"]);//
            info.ClassName = XHelper.GetString(modelRow["ClassName"]);//
            info.OrderIndex = XHelper.GetInt(modelRow["OrderIndex"]);//
            info.IsDialogModel = Convert.ToBoolean(modelRow["IsDialogModel"]);//

        }

        /// <summary>
        /// 添加操作
        /// </summary>
        /// <param name="modelInfo">信息</param>
        /// <returns></returns>
        public override bool Insert(XModelBase modelInfo)
        {
            string sql = String.Empty;

            XMenuInfo info = modelInfo as XMenuInfo;
            sql = "Insert Into " + this.TableName + "(ID,GroupId,MenuName,NameSpace,ClassName,OrderIndex)Values('{0}','{1}','{2}','{3}','{4}',{5})";
            sql = String.Format(sql, info.ID, info.GroupId, info.MenuName, info.NameSpace, info.ClassName, info.OrderIndex);

            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        /// <summary>
        /// 更新操作
        /// </summary>
        /// <param name="modelInfo">信息</param>
        /// <returns></returns>
        public override bool Update(XModelBase modelInfo)
        {
            string sql = String.Empty;

            XMenuInfo info = modelInfo as XMenuInfo;
            sql = "Update " + this.TableName + " Set GroupId='{0}',MenuName='{1}',NameSpace='{2}',ClassName='{3}',OrderIndex={4} Where ID='{5}'";
            sql = string.Format(sql, info.GroupId, info.MenuName, info.NameSpace, info.ClassName, info.OrderIndex);

            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

    }
}