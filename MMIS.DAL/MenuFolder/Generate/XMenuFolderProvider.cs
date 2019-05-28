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
    public partial class XMenuFolderProvider : XProviderBase
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "MenuFolder";
            }
        }

        protected override XModelBase InitTableModel()
        {
            return new XMenuFolderInfo();
        }

        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo, DataRow modelRow)
        {
            XMenuFolderInfo info = modelInfo as XMenuFolderInfo;

            info.ID = XHelper.GetString(modelRow["RID"]);//
            info.Title = XHelper.GetString(modelRow["Title"]);//
            info.FolderName = XHelper.GetString(modelRow["FolderName"]);//
            info.ImageFile = XHelper.GetString(modelRow["ImageFile"]);//
            info.LargeImageFile = XHelper.GetString(modelRow["LargeImageFile"]);//
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

            XMenuFolderInfo info = modelInfo as XMenuFolderInfo;
            sql = "Insert Into " + this.TableName + "(ID,Title,FolderName,ImageFile,LargeImageFile,OrderIndex)Values('{0}','{1}','{2}','{3}','{4}',{5})";
            sql = String.Format(sql, info.ID, info.Title, info.FolderName, info.ImageFile, info.LargeImageFile, info.OrderIndex);

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

            XMenuFolderInfo info = modelInfo as XMenuFolderInfo;
            sql = "Update " + this.TableName + " Set Title='{0}',FolderName='{1}',ImageFile='{2}',LargeImageFile='{3}',OrderIndex={4} Where ID='{5}'";
            sql = string.Format(sql, info.Title, info.FolderName, info.ImageFile, info.LargeImageFile, info.OrderIndex);

            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

    }
}