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
    public partial class XMenuGroupProvider : XProviderBase
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "MenuGroup";
            }
        }

        protected override XModelBase InitTableModel()
        {
            return new XMenuGroupInfo();
        }

        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo, DataRow modelRow)
        {
            XMenuGroupInfo info = modelInfo as XMenuGroupInfo;

            info.ID = XHelper.GetString(modelRow["RID"]);//
            info.FolderId = XHelper.GetString(modelRow["FolderId"]);//
            info.GroupName = XHelper.GetString(modelRow["GroupName"]);//
            info.OrderIndex = XHelper.GetInt(modelRow["OrderIndex"]);//
        }

        /// <summary>
        /// 添加操作
        /// </summary>
        /// <param name="modelInfo">信息</param>
        /// <returns></returns>
        public override bool Insert(XModelBase modelInfo)
        {
            string sql = String.Empty;

            XMenuGroupInfo info = modelInfo as XMenuGroupInfo;
            sql = "Insert Into " + this.TableName + "(ID,FolderId,GroupName,OrderIndex)Values('{0}','{1}','{2}',{3})";
            sql = String.Format(sql, info.ID, info.FolderId, info.GroupName, info.OrderIndex);

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

            XMenuGroupInfo info = modelInfo as XMenuGroupInfo;
            sql = "Update " + this.TableName + " Set FolderId='{0}',GroupName='{1}',OrderIndex={2} Where ID='{3}'";
            sql = string.Format(sql, info.FolderId, info.GroupName, info.OrderIndex);

            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

    }
}