using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using MMIS.Helper;
using MMIS.Model;
using System.IO;

namespace MMIS.DAL
{
    public class XProviderBase
    {
        public XProviderBase()
        {
            this.m_DataAccess = this.GetDataAccess();
            this.m_DetailProvider = this.InitDetailProvider();
        }

        protected XDataAccessBase m_DataAccess;

        protected XProviderBase m_DetailProvider = null;

        protected virtual XProviderBase InitDetailProvider()
        {
            return null;
        }

        /// <summary>
        /// 主键
        /// </summary>
        public virtual string PrimaryKey
        {
            get { return "RID"; }
        }

        /// <summary>
        /// 表名
        /// </summary>
        public virtual string TableName
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// 获取历史表
        /// </summary>
        protected virtual string HistoryTableName
        {
            get { return this.TableName + "History"; }
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        protected virtual string TimeStampFieldName
        {
            get { return "TimeStamp"; }
        }


        public virtual XDataAccessBase GetDataAccess()
        {
            return null;
        }


        /// 获取系统时间函数
        /// </summary>
        /// <returns></returns>
        public virtual string GetServerTimeFuncion()
        {
            return XFactoryManager.CreateFactory().GetServerTimeFuncion();
        }

        /// <summary>
        /// 获取所有记录
        /// </summary>
        /// <returns></returns>
        public virtual IList<XModelBase> GetAll()
        {
            string sql = "SELECT * FROM " + this.TableName + " ";
            sql += " WHERE " + this.PrimaryKey + "<>'' ";
            if (this.IsGetAllOrderBy())
            {
                sql += this.GetGetAllOrderByString();
            }
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return this.DataTable2ModelList(queryTable);
        }

        public virtual DataTable GetAllTable()
        {
            string sql = "SELECT * FROM " + this.TableName + " ";
            sql += " WHERE " + this.PrimaryKey + "<>'' ";
            if (this.IsGetAllOrderBy())
            {
                sql += this.GetGetAllOrderByString();
            }
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return queryTable;
        }

        /// <summary>
        /// 查询表格
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual DataTable GetTableByWhere(string where)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE 1=1 ";
            sql += " and " + this.PrimaryKey + "<>'' ";
            sql += where;
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return queryTable;
        }

        /// <summary>
        /// 查询表格
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual DataTable GetViewByWhere(string where)
        {
            string sql = "SELECT * FROM " + this.ViewName + " WHERE 1=1 ";
            sql += " and " + this.PrimaryKey + "<>'' ";
            sql += where;
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return queryTable;
        }

        /// <summary>
        /// 主表主键字段
        /// </summary>
        protected virtual string MainIdFieldName
        {
            get { return "MainId"; }
        }

        /// <summary>
        /// 通过主表Id获取记录
        /// </summary>
        /// <param name="mainId"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> GetByMainId(string mainId, string where)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE " + this.MainIdFieldName + "='" + mainId + "'";
            sql += where;
            return this.GetListBySql(sql);
        }

        /// <summary>
        /// 通过主表Id获取记录
        /// </summary>
        /// <param name="mainId"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> GetViewByMainId(string mainId, string where)
        {
            string sql = "SELECT * FROM " + this.ViewName + " WHERE " + this.MainIdFieldName + "='" + mainId + "'";
            sql += where;
            return this.GetViewListBySql(sql);
        }

        /// <summary>
        /// 获取所有记录
        /// </summary>
        /// <returns></returns>
        public virtual IList<XModelBase> GetAllView()
        {
            string sql = "SELECT * FROM " + this.ViewName + " ";
            if (this.IsGetAllOrderBy())
            {
                sql += this.GetGetAllOrderByString();
            }
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return this.DataView2ModelList(queryTable);
        }

        /// <summary>
        /// GetAll方法是否排序
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsGetAllOrderBy()
        {
            return false;
        }

        /// <summary>
        /// 获取GetAll的排序语句
        /// </summary>
        /// <returns></returns>
        protected virtual string GetGetAllOrderByString()
        {
            return " Order By OrderIndex asc ";
        }

        /// <summary>
        /// 表格转换为模型集合
        /// </summary>
        /// <returns></returns>
        protected virtual IList<XModelBase> DataTable2ModelList(DataTable queryTable)
        {
            IList<XModelBase> modelBases = new List<XModelBase>();

            foreach (DataRow queryRow in queryTable.Rows)
            {
                XModelBase modelInfo = this.InitTableModel();
                this.DataRow2ModelBase(modelInfo, queryRow);
                modelBases.Add(modelInfo);
            }

            return modelBases;
        }


        /// <summary>
        /// 表格转换为模型集合
        /// </summary>
        /// <returns></returns>
        protected virtual IList<XModelBase> DataView2ModelList(DataTable queryTable)
        {
            IList<XModelBase> modelBases = new List<XModelBase>();

            if (queryTable != null)
            {
                foreach (DataRow queryRow in queryTable.Rows)
                {
                    modelBases.Add(this.DataViewRow2ModelBase(queryRow));
                }
            }

            return modelBases;
        }

        /// <summary>
        /// 根据查询条件获取记录
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> QueryTop100ByWhere(string where)
        {
            string sql = "SELECT TOP 100 * FROM " + this.TableName + " WHERE 1=1 ";
            sql += " and " + this.PrimaryKey + "<>'' ";
            sql += where;
            if (IsQueryByWhereOrderBy())
            {
                sql += this.GetQueryByWhereOrderByString();
            }
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return this.DataTable2ModelList(queryTable);
        }

        /// <summary>
        /// 根据查询条件获取记录
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> QueryByWhere(string where)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE 1=1 ";
            sql += " and " + this.PrimaryKey + "<>'' ";
            sql += where;
            if (IsQueryByWhereOrderBy())
            {
                sql += this.GetQueryByWhereOrderByString();
            }
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return this.DataTable2ModelList(queryTable);
        }

        /// <summary>
        /// 根据查询条件获取视图记录
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> QueryViewByWhere(string where)
        {
            string sql = "SELECT * FROM " + this.ViewName + " WHERE 1=1 ";
            sql += " and " + this.PrimaryKey + "<>'' ";
            sql += where;
             if (IsQueryByWhereOrderBy())
            {
                sql += this.GetQueryByWhereOrderByString();
            }
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return this.DataView2ModelList(queryTable);
        }

        public virtual IList<XModelBase> QueryTop100ViewByWhere(string where)
        {
            string sql = "SELECT TOP 100 * FROM " + this.ViewName + " WHERE 1=1 ";
            sql += " and " + this.PrimaryKey + "<>'' ";
            sql += where;
            if (IsQueryByWhereOrderBy())
            {
                sql += this.GetQueryByWhereOrderByString();
            }
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return this.DataView2ModelList(queryTable);
        }

        /// <summary>
        /// 根据Where条件是否OrderBy
        /// </summary>
        /// <returns></returns>
        protected virtual bool IsQueryByWhereOrderBy()
        {
            return this.IsGetAllOrderBy();
        }

        /// <summary>
        /// 获取QueryByWhere排序语句
        /// </summary>
        /// <returns></returns>
        protected virtual string GetQueryByWhereOrderByString()
        {
            return this.GetGetAllOrderByString();
        }

        /// <summary>
        /// 根据主键获得实体记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual XModelBase GetById(string id)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE " + this.PrimaryKey + "='{0}'";
            sql = string.Format(sql, id);
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            if (queryTable.Rows.Count > 0)
            {
                DataRow queryRow = queryTable.Rows[0];
                XModelBase modelInfo = this.InitTableModel();
                this.DataRow2ModelBase(modelInfo, queryRow);
                return modelInfo;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取视图模型记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual XModelBase GetViewById(string id)
        {
            string sql = "SELECT * FROM " + this.ViewName + " WHERE " + this.PrimaryKey + "='{0}'";
            sql = string.Format(sql, id);
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            if (queryTable.Rows.Count > 0)
            {
                DataRow queryRow = queryTable.Rows[0];
                XModelBase modelInfo = DataViewRow2ModelBase(queryRow);
                return modelInfo;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 将视图数据行转为模型记录
        /// </summary>
        /// <param name="modelRow"></param>
        /// <returns></returns>
        protected virtual XModelBase DataViewRow2ModelBase(DataRow modelRow)
        {
            XModelBase modelInfo = this.InitViewModel();
            this.DataRow2ModelBase(modelInfo, modelRow);
            this.FillRowViewInfos(modelInfo, modelRow);
            return modelInfo;
        }

        /// <summary>
        /// 初始化表模型
        /// </summary>
        /// <returns></returns>
        protected virtual XModelBase InitTableModel()
        {
            return null;
        }

        protected virtual XModelBase InitViewModel()
        {
            return null;
        }

        /// <summary>
        /// 填充视图信息
        /// </summary>
        /// <param name="model"></param>
        /// <param name="modelRow"></param>
        protected virtual void FillRowViewInfos(XModelBase model, DataRow modelRow)
        {

        }

        /// <summary>
        /// 将数据行转为模型记录
        /// </summary>
        /// <param name="modelRow"></param>
        /// <returns></returns>
        protected virtual void DataRow2ModelBase(XModelBase modelInfo, DataRow modelRow)
        {

        }

        /// <summary>
        /// 插入明细
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="detailInfos"></param>
        /// <returns></returns>
        public virtual bool Insert(XModelBase modelInfo, IList<XModelBase> detailInfos)
        {
            string sql = string.Empty;

            //插入语句
            sql += this.GetInsertSql(modelInfo) + ";";

            foreach (XModelBase detailInfo in detailInfos)
            {
                this.FillDetailMainId(detailInfo, modelInfo);
                string sqlDetail = this.GetInsertDetailSql(modelInfo, detailInfo);
                if (sqlDetail != string.Empty)
                {
                    sql += sqlDetail + ";";
                }
            }

            //插入语句后执行
            sql += this.GetInsertAfterSql(modelInfo);

            return this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
        }

        /// <summary>
        /// 获取插入明细sql
        /// </summary>
        /// <param name="mainInfo"></param>
        /// <param name="detailInfo"></param>
        /// <returns></returns>
        protected virtual string GetInsertDetailSql(XModelBase mainInfo, XModelBase detailInfo)
        {
            if (this.m_DetailProvider != null)
            {
                return this.m_DetailProvider.GetInsertSql(detailInfo);
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 填充明细表的主表主键
        /// </summary>
        /// <param name="detailInfo"></param>
        /// <param name="mainId"></param>
        protected virtual void FillDetailMainId(XModelBase detailInfo, XModelBase mainInfo)
        {

        }

        /// <summary>
        /// 更新明细
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="detailInfos"></param>
        /// <returns></returns>
        public virtual bool Update(XModelBase modelInfo, IList<XModelBase> detailInfos)
        {
            string sql = string.Empty;

            //插入语句
            sql += this.GetUpdateSql(modelInfo) + ";";

            //删除明细
            sql += "DELETE FROM " + this.DetailTableName + " WHERE " + this.DetailTableMainIdFieldName
                + "='" + this.GetPrimaryKeyValue(modelInfo) + "';";

            foreach (XModelBase detailInfo in detailInfos)
            {
                this.FillDetailMainId(detailInfo, modelInfo);
                string sqlDetail = this.GetInsertDetailSql(modelInfo, detailInfo);
                if (sqlDetail != string.Empty)
                {
                    sql += sqlDetail + ";";
                }
            }

            return this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
        }

        /// <summary>
        /// 获取主键值
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetPrimaryKeyValue(XModelBase modelInfo)
        {
            return modelInfo.ID;
        }

        /// <summary>
        /// 带明细删除
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual bool DeleteWithDetail(XModelBase modelInfo)
        {
            string sqlDelete = this.GetDeleteSql(modelInfo) + ";";

            sqlDelete += "DELETE FROM " + this.DetailTableName + " WHERE " +
                this.DetailTableMainIdFieldName + "'" + this.GetPrimaryKeyValue(modelInfo) + "';";

            return this.m_DataAccess.ExecuteNonQueryByTrans(sqlDelete) > 0;
        }

        /// <summary>
        /// 明细表
        /// </summary>
        protected virtual string DetailTableName
        {
            get { return this.TableName + "s"; }
        }

        /// <summary>
        /// 明细表中主表主键字段名
        /// </summary>
        protected virtual string DetailTableMainIdFieldName
        {
            get { return "MainId"; }
        }

        /// <summary>
        /// 插入操作
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual bool Insert(XModelBase modelInfo)
        {
            string sql = string.Empty;

            string sqlBefore = this.GetInsertBeforeSql(modelInfo);
            if (sqlBefore != string.Empty)
            {
                sql += sqlBefore + ";";
            }
            string sqlInsert = this.GetInsertSql(modelInfo);
            sql += sqlInsert;

            string sqlAfter = this.GetInsertAfterSql(modelInfo);
            if (sqlAfter != string.Empty)
            {
                sql += ";" + sqlAfter;
            }

            if (sql != string.Empty)
            {
                return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取执行插入前的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetInsertBeforeSql(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取执行插入后的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetInsertAfterSql(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取插入语句
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual string GetInsertSql(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 是否插入历史表
        /// </summary>
        protected virtual bool IsInsertUpdateHistory
        {
            get { return false; }
        }

        /// <summary>
        /// 更新操作
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual bool Update(XModelBase modelInfo)
        {
            string sql = string.Empty;

            if (IsInsertUpdateHistory)
            {
                //插入历史表
                string sqlHistory = this.GetInsertUpdateHistorySql(modelInfo);
                if (sqlHistory != string.Empty)
                {
                    sql += sqlHistory + ";";
                }
            }
            string sqlBefore = this.GetUpdateBeforeSql(modelInfo);
            if (sqlBefore != string.Empty)
            {
                sql += sqlBefore + ";";
            }

            string sqlUpdate = this.GetUpdateSql(modelInfo);
            sql += sqlUpdate;

            string sqlAfter = this.GetUpdateAfterSql(modelInfo);
            if (sqlAfter != string.Empty)
            {
                sql += ";" + sqlAfter;
            }

            if (sql != string.Empty)
            {
                return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取执行更新前的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetUpdateBeforeSql(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取执行更新后的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetUpdateAfterSql(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取更新Sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual string GetUpdateSql(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 是否插入删除历史表
        /// </summary>
        protected virtual bool IsInsertDeleteHistory
        {
            get { return false; }
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual bool Delete(XModelBase modelInfo, string userId)
        {
            string sql = string.Empty;

            if (IsInsertDeleteHistory)
            {
                string sqlHistory = this.GetInsertDeleteHistory(modelInfo, userId);
                if (sqlHistory != string.Empty)
                {
                    sql += sqlHistory + ";";
                }
            }

            string sqlBefore = this.GetDeleteBeforeSql(modelInfo);
            if (sqlBefore != string.Empty)
            {
                sql += sqlBefore + ";";
            }
            sql += this.GetDeleteSql(modelInfo);
            string sqlAfter = this.GetDeleteAfterSql(modelInfo);
            if (sqlAfter != string.Empty)
            {
                sql += ";" + sqlAfter;
            }

            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        /// <summary>
        /// 获取删除前的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetDeleteBeforeSql(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取删除后的sql 
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetDeleteAfterSql(XModelBase modelInfo)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取插入删除前的历史记录
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected virtual string GetInsertDeleteHistory(XModelBase modelInfo, string userId)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取删除的
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        protected virtual string GetInsertDeleteHistory(IList<XModelBase> modelInfo, string userId)
        {
            string sql = string.Empty;

            foreach (XModelBase model in modelInfo)
            {
                sql += this.GetInsertDeleteHistory(model, userId) + ";";
            }

            return sql;
        }

        /// <summary>
        /// 获取删除sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual string GetDeleteSql(XModelBase modelInfo)
        {
            string sql = "DELETE FROM " + this.TableName + " WHERE " + this.PrimaryKey + "='{0}'";
            sql = string.Format(sql, this.GetPrimaryKeyValue(modelInfo));
            return sql;
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public virtual DateTime GetTimeStamp(XModelBase modelInfo)
        {
            string sql = "SELECT " + this.TimeStampFieldName + " FROM " + this.TableName + " WHERE " + this.PrimaryKey + "='{0}'";
            sql = string.Format(sql, modelInfo.ID);
            return XHelper.GetDateTime(this.m_DataAccess.ExecuteScalar(sql));
        }

        /// <summary>
        /// 根据sql获取列表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> GetListBySql(string sql)
        {
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return this.DataTable2ModelList(queryTable);
        }

        /// <summary>
        /// 根据sql获取列表
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public virtual IList<XModelBase> GetViewListBySql(string sql)
        {
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);
            return this.DataView2ModelList(queryTable);
        }

        public bool DeleteWithDetails(IList<XModelBase> modelInfos)
        {
            string deleteIds = string.Empty;

            foreach (XModelBase model in modelInfos)
            {
                deleteIds += "'" + model.ID + "',";
            }

            deleteIds = deleteIds.TrimEnd(',');

            if (modelInfos.Count == 0)
            {
                return false;
            }

            string deleteSql = string.Empty;

            string deleteDetailSql = "";
            deleteDetailSql += "DELETE FROM " + this.DetailTableName + " WHERE " +
             this.DetailTableMainIdFieldName + " IN (" + deleteIds + ");";
            deleteSql += deleteDetailSql;

            deleteSql += "DELETE FROM " + this.TableName + " where " + this.PrimaryKey + " IN ({0});";
            deleteSql = string.Format(deleteSql, deleteIds);


            string deleteAfterSql = this.GetDeleteAfterSql(modelInfos);
            deleteSql += deleteAfterSql;

            return this.m_DataAccess.ExecuteNonQueryByTrans(deleteSql) > 0;
        }

        /// <summary>
        /// 删除实体集合
        /// </summary>
        /// <param name="modelInfos"></param>
        /// <returns></returns>
        public bool Delete(IList<XModelBase> modelInfos, string userId)
        {
            if (modelInfos.Count == 0)
            {
                return false;
            }

            string sql = string.Empty;

            string deleteIds = this.GetModelIds(modelInfos);

            if (IsInsertDeleteHistory)
            {
                string historySql = this.GetInsertDeleteHistory(modelInfos, userId);
                sql += historySql;
            }

            string deleteSql = "DELETE FROM " + this.TableName + " where " + this.PrimaryKey + " IN ({0});";
            deleteSql = string.Format(deleteSql, deleteIds);
            sql += deleteSql;

            string deleteAfterSql = this.GetDeleteAfterSql(modelInfos);
            sql += deleteAfterSql;

            bool maindel = this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
            ////联合删除
            //if (maindel)
            //{
            //    if (this.TableName.ToUpper() == "EquipmentReceive".ToUpper())
            //    {
            //        maindel = this.m_DataAccess.ExecuteNonQueryByTrans("delete from EquipmentReceive where ") > 0;
            //    }
            //}

            return maindel;
        }

        /// <summary>
        /// 获取删除后执行的sql
        /// </summary>
        /// <param name="deleteIds"></param>
        /// <returns></returns>
        protected virtual string GetDeleteAfterSql(IList<XModelBase> modelInfos)
        {
            return string.Empty;
        }

        protected virtual string GetModelIds(IList<XModelBase> modelInfos)
        {
            string deleteIds = string.Empty;

            foreach (XModelBase model in modelInfos)
            {
                deleteIds += "'" + this.GetPrimaryKeyValue(model) + "',";
            }


            deleteIds = deleteIds.TrimEnd(',');

            return deleteIds;
        }



        /// <summary>
        /// 获取根节点的集合
        /// </summary>
        /// <returns></returns>
        public virtual IList<Model.XModelBase> GetRootModelList()
        {
            string sql = "SELECT " + this.GetRootNodeSelectFieldNames() + " FROM " + this.TableName +
                " WHERE " + ParentIdFieldName + " IS NULL OR " + ParentIdFieldName + "=''";
            if (IsOrderBy)
            {
                sql += OrderBy;
            }
            return this.GetListBySql(sql);
        }

        /// <summary>
        /// 获取根节点的集合
        /// </summary>
        /// <returns></returns>
        public virtual IList<Model.XModelBase> GetRootViewModelList(string where)
        {
            string sql = "SELECT " + this.GetRootNodeSelectFieldNames() + " FROM " + this.ViewName +
                " WHERE " + ParentIdFieldName + " IS NULL OR " + ParentIdFieldName + "=''";
            if (IsOrderBy)
            {
                sql += OrderBy;
            }
            return this.GetViewListBySql(sql);
        }

        /// <summary>
        /// 获取查询根节点时需要的字段
        /// </summary>
        /// <returns></returns>
        protected virtual string GetRootNodeSelectFieldNames()
        {
            return "*";
        }

        /// <summary>
        /// 获取子节点
        /// </summary>
        /// <returns></returns>
        public virtual IList<Model.XModelBase> GetChildModelLists(XModelBase model)
        {
            string sql = "SELECT " + this.GetRootNodeSelectFieldNames() + " FROM " + this.TableName +
                          " WHERE " + ParentIdFieldName + "='" + model.ID + "'";
            if (IsOrderBy)
            {
                sql += OrderBy;
            }
            return this.GetListBySql(sql);
        }

        /// <summary>
        /// 获取子节点
        /// </summary>
        /// <returns></returns>
        public virtual IList<Model.XModelBase> GetChildViewModelLists(XModelBase model, string where = "")
        {
            string sql = "SELECT " + this.GetRootNodeSelectFieldNames() + " FROM " + this.ViewName +
                          " WHERE " + ParentIdFieldName + "='" + model.ID + "'";
            sql += where;
            if (IsOrderBy)
            {
                sql += OrderBy;
            }
            return this.GetViewListBySql(sql);
        }

        /// <summary>
        /// 树形结构的父节点字段名称
        /// </summary>
        protected virtual string ParentIdFieldName
        {
            get { return "ParentId"; }
        }

        /// <summary>
        /// 是否是叶子节点
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsEndNode(XModelBase model)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE " +
                ParentIdFieldName + "='{0}'";
            sql = string.Format(sql, model.ID);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DateTime GetTimeStamp(string id)
        {
            string sql = "SELECT " + TimeStampFieldName + " FROM " + TableName + " WHERE " + PrimaryKey + "='{0}'";
            sql = string.Format(sql, id);
            return XHelper.GetDateTime(this.m_DataAccess.ExecuteScalar(sql));
        }

        /// <summary>
        /// 是否已被使用
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual bool IsUsed(XModelBase model)
        {
            return false;
        }

        /// <summary>
        /// 视图名称
        /// </summary>
        public virtual string ViewName
        {
            get { return "V_" + this.TableName; }
        }

        protected virtual string IsSendFieldName
        {
            get { return "IsSend"; }
        }

        protected virtual string SendTimeFieldName
        {
            get { return "SendTime"; }
        }

        /// <summary>
        /// 是否已发布
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public bool IsSend(XModelBase modelInfo)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE " +
                this.PrimaryKey + "='" + this.GetPrimaryKeyValue(modelInfo) + "' and IsSend=1 ";
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 反馈
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="sendMessageInfo"></param>
        /// <returns></returns>
        public bool Feedback(XModelBase modelInfo, XSendMessageInfo sendMessageInfo, string feedbackUserId)
        {
            //1、更新单据状态
            string sql = "Update " + this.TableName + " SET " + this.FeedbackTimeFieldName +
                "=getdate(),IsFeedback=1," + this.FeedbackUserIdFieldName + "='" + feedbackUserId + "' WHERE " +
                this.PrimaryKey + "='" + this.GetPrimaryKeyValue(modelInfo) + "';";

            sql += "INSERT INTO VoucherMessage(ID,RemindType,VoucherTypeCode,VoucherId,Message,SendUserId,SendTime)" +
                          "values('{0}','{1}','{2}','{3}','{4}','{5}',getdate());";
            sql = string.Format(sql, sendMessageInfo.ID, sendMessageInfo.RemindType, sendMessageInfo.VoucherTypeCode,
               sendMessageInfo.VoucherId, sendMessageInfo.Message, sendMessageInfo.SendUserId);

            //明细表
            sql += "INSERT INTO VoucherMessages(ID,MainID,ReceiveUserId,IsRead,ReadTime) " +
                "SELECT newid(),'" + sendMessageInfo.ID + "',a.UserId,0,NULL FROM Users a WHERE " +
                " a.JobCode IN (SELECT b.JobCode FROM SendMessageDef a " +
                "LEFT JOIN SendMessageDefs b ON a.SendCode=b.MainID WHERE a.VoucherTypeCode='" + sendMessageInfo.VoucherTypeCode + "');";

            return XHelper.GetInt(this.m_DataAccess.ExecuteNonQueryByTrans(sql)) > 0;
        }

        protected virtual string FeedbackUserIdFieldName
        {
            get { return "FeedbackUserId"; }
        }

        protected virtual string FeedbackTimeFieldName
        {
            get { return "FeedbackTime"; }
        }

        /// <summary>
        /// 发送
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public bool Send(XModelBase modelInfo, XSendMessageInfo sendMessageInfo)
        {
            //1、更新单据状态
            string sql = "Update " + this.TableName + " SET " + this.SendTimeFieldName +
                "=getdate(),IsSend=1 WHERE " +
                this.PrimaryKey + "='" + this.GetPrimaryKeyValue(modelInfo) + "';";

            //2、插入发布消息表
            //主表
            sql += "INSERT INTO VoucherMessage(ID,RemindType,VoucherTypeCode,VoucherId,Message,SendUserId,SendTime)" +
                "values('{0}','{1}','{2}','{3}','{4}','{5}',getdate());";
            sql = string.Format(sql, sendMessageInfo.ID, sendMessageInfo.RemindType, sendMessageInfo.VoucherTypeCode,
               sendMessageInfo.VoucherId, sendMessageInfo.Message, sendMessageInfo.SendUserId);
            //明细表
            //sql += "INSERT INTO VoucherMessages(ID,MainID,ReceiveUserId,IsRead,ReadTime) " +
            //    "SELECT newid(),'" + sendMessageInfo.ID + "',a.UserId,0,NULL FROM Employee a WHERE IsUser=1 " +
            //    "AND a.JobCode IN (SELECT b.JobCode FROM SendMessageDef a " +
            //    "LEFT JOIN SendMessageDefs b ON a.SendCode=b.MainID WHERE a.VoucherTypeCode='" + sendMessageInfo.VoucherTypeCode + "');";
            sql += "INSERT INTO VoucherMessages(ID,MainID,ReceiveUserId,IsRead,ReadTime) " +
                "SELECT newid(),'" + sendMessageInfo.ID + "',a.UserId,0,NULL FROM Users a WHERE " +
                " a.JobCode IN (SELECT b.JobCode FROM SendMessageDef a " +
                "LEFT JOIN SendMessageDefs b ON a.SendCode=b.MainID WHERE a.VoucherTypeCode='" + sendMessageInfo.VoucherTypeCode + "');";

            return XHelper.GetInt(this.m_DataAccess.ExecuteNonQueryByTrans(sql)) > 0;
        }

        /// <summary>
        /// 撤销发布
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public bool BackSend(XModelBase modelInfo, string userId)
        {
            string voucherID = this.GetPrimaryKeyValue(modelInfo);

            //1、设置撤销发布标志
            string sql = "Update " + this.TableName + " SET " + this.SendTimeFieldName +
               "=NULL,IsSend=0 WHERE " +
               this.PrimaryKey + "='" + voucherID + "';";

            //2、如果有已经阅读的，则发送已经阅读了消息的人撤回信息

            string backMainId = Guid.NewGuid().ToString();

            sql += "DECLARE @ReadCount INT ";
            sql += "SET @ReadCount=(SELECT COUNT(*) FROM VoucherMessages WHERE MainID IN " +
                "(SELECT ID FROM VoucherMessage WHERE VoucherId='" + voucherID + "' AND RemindType='发布消息' ) AND IsRead=1 ) ";
            sql += "IF @ReadCount>0 ";
            sql += "BEGIN ";
            //插入主表
            sql += "INSERT INTO VoucherMessageBack(ID,RemindType,VoucherTypeCode,VoucherId,Message,SendUserId,SendTime) " +
                "SELECT '" + backMainId + "',RemindType,VoucherTypeCode,VoucherId,Message,'" + userId +
                "',getdate() FROM VoucherMessage WHERE VoucherId='" + voucherID + "' AND RemindType='发布消息' ; ";
            //插入明细表
            sql += "INSERT INTO VoucherMessagesBack(ID,MainID,ReceiveUserId,IsRead,ReadTime) " +
                "SELECT newid(),'" + backMainId + "',ReceiveUserID,0,NULL FROM VoucherMessages WHERE MainID IN " +
                "(SELECT ID FROM VoucherMessage WHERE VoucherId='" + voucherID + "' AND RemindType='发布消息' ) AND IsRead=1 ";
            sql += "END ";

            //3、删除原来发布的消息
            sql += "DELETE FROM VoucherMessages WHERE MainID IN " +
                "(SELECT ID FROM VoucherMessage WHERE VoucherId='" + voucherID + "' AND RemindType='发布消息' )";
            sql += "DELETE FROM VoucherMessage WHERE VoucherID='" + voucherID + "';";

            return XHelper.GetInt(this.m_DataAccess.ExecuteNonQueryByTrans(sql)) > 0;
        }

        /// <summary>
        /// 附件表名
        /// </summary>
        protected virtual string FileTableName
        {
            get { return this.TableName + "Files"; }
        }


        /// <summary>
        /// 上传附件
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mainID"></param>
        /// <param name="fileName"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool InsertFile(string id, string mainID, string fileName, string userId)
        {
            FileInfo fi = new FileInfo(fileName);
            if (fi.Exists == false)
            {
                return false;
                //直接返回失败
            }

            byte[] bData = null;
            using (FileStream fs = fi.OpenRead())
            {
                bData = new byte[fi.Length];
                fs.Read(bData, 0, Convert.ToInt32(fi.Length));
            }

            string sql = "INSERT INTO " + this.FileTableName + "(ID,MainId,FileName,FileBytes,UploadUserId,UploadTime)values(@Id,@MainId,@FileName,@FileBytes,@UserId,getdate())";
            DbConnection conn = this.m_DataAccess.Connection;
            DbCommand cmd = this.m_DataAccess.GetDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            DbParameter parameterId = this.m_DataAccess.GetParameter("@Id", id);
            cmd.Parameters.Add(parameterId);
            DbParameter parameterMainId = this.m_DataAccess.GetParameter("@MainId", mainID);
            cmd.Parameters.Add(parameterMainId);
            DbParameter parameterFileName = this.m_DataAccess.GetParameter("@FileName", fi.Name);
            cmd.Parameters.Add(parameterFileName);
            DbParameter parameterFile = this.m_DataAccess.GetParameter("@FileBytes", bData);
            cmd.Parameters.Add(parameterFile);
            DbParameter parameterUser = this.m_DataAccess.GetParameter("@UserId", userId);
            cmd.Parameters.Add(parameterUser);

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                return false;
            }
            finally
            {
                conn.Close();
            }
        }



        public virtual bool Download(string id, string filePath)
        {
            string sql = "SELECT FileBytes,FileName FROM " + this.FileTableName + " WHERE ID = '" + id + "'";
            DbConnection conn = this.m_DataAccess.Connection;
            DbDataAdapter adp = this.m_DataAccess.GetDbDataAdapter(conn, sql);
            DataTable dt = new DataTable();

            byte[] bData = null;
            string fileName = string.Empty;
            try
            {
                //从服务器获取文件
                adp.Fill(dt);
                DataRow dr = null;
                if (dt.Rows.Count > 0)
                {
                    dr = dt.Rows[0];
                    if (((!object.ReferenceEquals(dr["FileBytes"], DBNull.Value))))
                    {
                        bData = (byte[])dr["FileBytes"];
                    }
                    fileName = XHelper.GetString(dr["FileName"]);
                }
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
                return false;
            }
            finally
            {
                adp.Dispose();
            }

            //存文件
            if (((bData != null)))
            {
                fileName = filePath + "\\" + fileName;
                FileInfo fi = new FileInfo(fileName);
                //不存在
                if (!fi.Exists)
                {
                    using (FileStream fs = fi.Create())
                    {
                        fs.Write(bData, 0, bData.Length);
                    }
                }
                else
                {
                    XMessageBox.ShowError("要下载的文件:[" + fi.Name + "]在目录：\r\n" + filePath + "已存在！");
                    return false;
                }
            }
            return true;

        }

        /// <summary>
        /// 获取附件数
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        public virtual int GetFileCount(string mainId)
        {
            string sql = "SELECT COUNT(*) FROM " + this.FileTableName + " WHERE MainID='{0}'";
            sql = string.Format(sql, mainId);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql));
        }

        /// <summary>
        /// 获取附件信息
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetFileInfoes(string mainId, string where)
        {
            IList<XModelBase> fileInfos = new List<XModelBase>();

            string sql = "SELECT ID,FileName,UploadTime FROM " + this.FileTableName + " WHERE MainID='{0}'";
            sql += where;
            sql = string.Format(sql, mainId);
            DataTable queryTable = this.m_DataAccess.GetDataTable(sql);

            foreach (DataRow fileRow in queryTable.Rows)
            {
                XFileInfo fileInfo = new XFileInfo();
                fileInfo.ID = XHelper.GetString(fileRow["ID"]);
                fileInfo.FileName = XHelper.GetString(fileRow["FileName"]);
                fileInfo.UploadTime = XHelper.GetString(fileRow["UploadTime"]);
                fileInfos.Add(fileInfo);
            }


            return fileInfos;
        }

        public bool DeleteFile(string id)
        {
            string sql = "DELETE FROM " + this.FileTableName + " WHERE Id='{0}'";
            sql = string.Format(sql, id);
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        /// <summary>
        /// 删除实体集合
        /// </summary>
        /// <param name="modelInfos"></param>
        /// <returns></returns>
        public bool DeleteFiles(IList<XModelBase> modelInfos, string userId)
        {
            string deleteIds = string.Empty;

            foreach (XFileInfo fileInfo in modelInfos)
            {
                deleteIds += "'" + fileInfo.ID + "',";
            }

            deleteIds = deleteIds.TrimEnd(',');

            string sql = "DELETE FROM " + this.FileTableName + " WHERE Id IN ({0})";
            sql = string.Format(sql, deleteIds);
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        /// <summary>
        /// 是否已提交
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool IsCommit(XModelBase model)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE " + this.PrimaryKey + "='{0}' AND IsCommit=1 ";
            sql = string.Format(sql, model.ID);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 是否已审核
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool IsCheck(XModelBase model)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE " + this.PrimaryKey + "='{0}' AND IsCheck=1 ";
            sql = string.Format(sql, model.ID);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Commit(XModelBase model)
        {
            string sql = "UPDATE " + this.TableName + " SET IsCommit=1,CommitTime=getdate() WHERE ID='{0}';";
            sql = string.Format(sql, model.ID);

            string voucherTypeCode = this.GetVoucherTypeCode(model);

            //插入审批表
            sql += "INSERT INTO " + this.CheckTableName + "(ID,MainID,JobCode,CheckLevel,IsToCheck) " +
                "SELECT NEWID(),'{0}',JobCode,CheckLevel,0 FROM WorkFlowCheckLevelDef " +
                "WHERE FlowCode IN ( SELECT FlowCode FROM WorkFlowDef WHERE VoucherTypeCode='{1}');";
            sql = string.Format(sql, model.ID, voucherTypeCode);

            //将第一条修改为应审核
            sql += "UPDATE {0} SET IsToCheck=1 WHERE ID=" +
                " (SELECT TOP 1 ID FROM " + this.CheckTableName + " WHERE MainID='{1}' ORDER BY CheckLevel ASC);";
            sql = string.Format(sql, this.CheckTableName, model.ID);

            return XHelper.GetInt(this.m_DataAccess.ExecuteNonQueryByTrans(sql)) > 0;
        }

        /// <summary>
        /// 审批表表名
        /// </summary>
        protected virtual string CheckTableName
        {
            get { return this.TableName + "Check"; }
        }

        /// <summary>
        /// 获取单据类型
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetVoucherTypeCode(XModelBase model)
        {
            return string.Empty;
        }

        /// <summary>
        /// 收回
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Rollback(XModelBase model)
        {
            string sql = "UPDATE " + this.TableName + " SET IsCommit=0,CommitTime=NULL WHERE ID='{0}' AND IsCommit=1;";
            sql = string.Format(sql, model.ID);

            sql += "DELETE FROM " + this.CheckTableName + " WHERE MainId='{0}'";
            sql = string.Format(sql, model.ID);

            return XHelper.GetInt(this.m_DataAccess.ExecuteNonQueryByTrans(sql)) > 0;
        }

        /// <summary>
        /// 是否定义了工作流
        /// </summary>
        /// <param name="voucherTypeCode"></param>
        /// <returns></returns>
        public bool IsHaveWorkFlow(string voucherTypeCode)
        {
            string sql = "SELECT COUNT(*) FROM WorkFlowCheckLevelDef WHERE FlowCode IN (SELECT FlowCode FROM WorkFlowDef WHERE VoucherTypeCode='{0}')";
            sql = string.Format(sql, voucherTypeCode);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 获取要审核的记录
        /// </summary>
        /// <param name="jobCode"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<XModelBase> GetToCheckViewList(string jobCode, string where)
        {
            string sql = "SELECT * FROM " + this.ViewName + " a WHERE ID IN ( " +
                "SELECT TOP 1 MainID FROM " + this.CheckTableName + " b " +
                "WHERE a.ID=b.MainID AND b.IsToCheck=1 AND b.JobCode='{0}')";
            sql = string.Format(sql, jobCode);
            sql += where;
            return this.GetViewListBySql(sql);
        }

        public IList<XModelBase> GetToCheckTableList(string where)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE isnull(IsCheck,0)=0 " + where;
            return this.GetListBySql(sql);
        }

        public IList<XModelBase> GetCheckedTableList(string where)
        {
            string sql = "SELECT * FROM " + this.TableName + " WHERE IsCheck=1 " + where;
            return this.GetListBySql(sql);
        }

        /// <summary>
        /// 获取已审核的记录
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<XModelBase> GetCheckedViewList(string userId, string where)
        {
            string sql = "SELECT * FROM " + this.ViewName + " WHERE ID IN " +
                "(SELECT MainID FROM " + this.CheckTableName + " WHERE CheckUserId='{0}')";
            sql = string.Format(sql, userId);
            sql += where;
            return this.GetViewListBySql(sql);
        }

        /// <summary>
        /// 审批表
        /// </summary>
        protected virtual string CheckViewName
        {
            get { return "V_" + this.CheckTableName; }
        }

        /// <summary>
        /// 获取当前应审核信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public XModelBase GetToCheckInfo(XModelBase model)
        {
            string sql = "SELECT * FROM " + this.CheckViewName + " WHERE IsToCheck=1 and MainId='{0}'";
            sql = string.Format(sql, model.ID);

            XProviderBase checkProvier = this.GetCheckProvider();

            IList<XModelBase> modelBases = checkProvier.GetViewListBySql(sql);
            if (modelBases.Count > 0)
            {
                return modelBases[0];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获取当前应弃审信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public XModelBase GetBackToCheckInfo(XModelBase model)
        {
            string sql = "SELECT * FROM " + this.CheckViewName + " WHERE ID=(SELECT TOP 1 ID FROM " +
                this.CheckTableName + " WHERE MainID='{0}' AND CheckUserId IS NOT NULL ORDER BY CheckLevel DESC )";
            sql = string.Format(sql, model.ID);
            XProviderBase checkProvier = this.GetCheckProvider();

            IList<XModelBase> modelBases = checkProvier.GetViewListBySql(sql);
            if (modelBases.Count > 0)
            {
                return modelBases[0];
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 获取审批表Provider
        /// </summary>
        /// <returns></returns>
        protected virtual XProviderBase GetCheckProvider()
        {
            return null;
        }

        public bool Check(XModelBase model, string userId)
        {
            string sql = "UPDATE " + this.TableName + " SET IsCheck=1," +
                "Auditor='" + userId + "',AuditTime=getdate() WHERE " + PrimaryKey + "='" + model.ID + "'";
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }

        public bool BackCheck(XModelBase model, string userId)
        {
            string sql = "UPDATE " + this.TableName + " SET IsCheck=0," +
                "Auditor='',AuditTime=NULL WHERE " + PrimaryKey + "='" + model.ID + "'";
            return this.m_DataAccess.ExecuteNonQuery(sql) > 0;
        }


        /// <summary>
        /// 审核
        /// </summary>
        /// <param name="model"></param>
        /// <param name="checkLevelInfo"></param>
        /// <returns></returns>
        public bool Check(XModelBase model, XCheckLevelInfo checkLevelInfo)
        {
            string sql = string.Empty;

            //1、首先判断是否是第一次审批，如果是，则修改主表审批标志
            sql += "DECLARE @FirstCheckLevel INT,@LastCheckLevel INT,@NextCheckLevel INT ";
            sql += "SET @FirstCheckLevel=(SELECT TOP 1 CheckLevel FROM " + this.CheckTableName +
                " WHERE MainID='" + model.ID + "' ORDER BY CheckLevel) ";
            sql += "IF  @FirstCheckLevel=" + checkLevelInfo.CheckLevel + " BEGIN UPDATE " + this.TableName +
                " SET IsCheck=1 WHERE ID='" + model.ID + "' END ";

            //2、判断是否是最后一次，如果是最后一次，则修改终审标志
            sql += "SET @LastCheckLevel=(SELECT TOP 1 CheckLevel FROM " + this.CheckTableName + " WHERE MainID='" + model.ID + "' ORDER BY CheckLevel desc) ";
            sql += "IF  @LastCheckLevel=" + checkLevelInfo.CheckLevel + " BEGIN UPDATE " + this.TableName +
                " SET IsLastCheck=1 WHERE ID='" + model.ID + "' END ";

            //3、将级次大于当前级次的审批记录设置为将审核
            sql += "SET @NextCheckLevel=(SELECT TOP 1 CheckLevel FROM " + this.CheckTableName + " WHERE MainID='" + model.ID +
                "' AND CheckLevel>" + checkLevelInfo.CheckLevel + " ORDER BY CheckLevel)";
            sql += "IF @NextCheckLevel IS NOT NULL BEGIN UPDATE " + this.CheckTableName + " SET IsToCheck=1 " +
                "WHERE MainID='" + model.ID + "' AND CheckLevel=@NextCheckLevel END ";

            //4、修改本次审核标志
            sql += "UPDATE " + this.CheckTableName + " SET CheckUserId='" + checkLevelInfo.CheckUserId + "',CheckTime=getdate(),IsToCheck=0 " +
                "WHERE MainID='" + model.ID + "' AND CheckLevel=" + checkLevelInfo.CheckLevel;

            return this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
        }

        /// <summary>
        /// 弃审
        /// </summary>
        /// <param name="model"></param>
        /// <param name="backCheckLevelInfo"></param>
        /// <returns></returns>
        public bool BackCheck(XModelBase model, XCheckLevelInfo backCheckLevelInfo)
        {
            string sql = string.Empty;

            sql += "DECLARE @FirstCheckLevel INT,@LastCheckLevel INT,@NextCheckLevel INT ";

            //1、判断是否是最后一次，如果是最后一次，则修改终审标志
            sql += "SET @LastCheckLevel=(SELECT TOP 1 CheckLevel FROM " + this.CheckTableName + " WHERE MainID='" + model.ID + "' ORDER BY CheckLevel desc) ";
            sql += "IF  @LastCheckLevel=" + backCheckLevelInfo.CheckLevel + " BEGIN UPDATE " + this.TableName +
                " SET IsLastCheck=0 WHERE ID='" + model.ID + "' END ";

            //2、首先判断是否是第一次弃审，如果是，则修改主表审批标志
            sql += "SET @FirstCheckLevel=(SELECT TOP 1 CheckLevel FROM " + this.CheckTableName +
                " WHERE MainID='" + model.ID + "' ORDER BY CheckLevel) ";
            sql += "IF  @FirstCheckLevel=" + backCheckLevelInfo.CheckLevel + " BEGIN UPDATE " + this.TableName +
                " SET IsCheck=0 WHERE ID='" + model.ID + "' END ";

            //3、将级次大于当前级次的审批记录将审核设置为否
            sql += "SET @NextCheckLevel=(SELECT TOP 1 CheckLevel FROM " + this.CheckTableName + " WHERE MainID='" + model.ID +
                "' AND CheckLevel>" + backCheckLevelInfo.CheckLevel + " ORDER BY CheckLevel)";
            sql += "IF @NextCheckLevel IS NOT NULL BEGIN UPDATE " + this.CheckTableName + " SET IsToCheck=0 " +
                "WHERE MainID='" + model.ID + "' AND CheckLevel=@NextCheckLevel END ";

            //4、修改本次审核标志
            sql += "UPDATE " + this.CheckTableName + " SET CheckUserId=NULL,CheckTime=NULL,IsToCheck=1 " +
                "WHERE MainID='" + model.ID + "' AND CheckLevel=" + backCheckLevelInfo.CheckLevel;

            return this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
        }

        /// <summary>
        /// 是否定义了发布信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsHaveSendMessageDef(string voucherTypeCode)
        {
            string sql = "SELECT COUNT(*) FROM SendMessageDefs WHERE MainID=" +
                "(SELECT TOP 1 SendCode FROM SendMessageDef WHERE VoucherTypeCode='{0}')";
            sql = string.Format(sql, voucherTypeCode);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 消息是否已被阅读
        /// </summary>
        /// <param name="voucherTypeCode"></param>
        /// <param name="voucherId"></param>
        /// <returns></returns>
        public bool IsSendMessageReaded(string voucherId)
        {
            string sql = "SELECT COUNT(*) FROM VoucherMessage a LEFT JOIN VoucherMessages b ON a.ID=b.MainID " +
                "WHERE b.IsRead=1 AND a.VoucherId='{0}'";
            sql = string.Format(sql, voucherId);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 是否已终审
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsLastCheck(XModelBase model)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE " + this.PrimaryKey + "='{0}' AND IsLastCheck=1 ";
            sql = string.Format(sql, this.GetPrimaryKeyValue(model));
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 是否存在判断的字段
        /// </summary>
        protected virtual string ExistFieldName
        {
            get { return string.Empty; }
        }

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsExist(string value)
        {
            string queryObjectName = this.TableName;
            if (this.ExistQueryFromView)
            {
                queryObjectName = this.ViewName;
            }
            string sql = "SELECT COUNT(*) FROM " + queryObjectName + " WHERE " + ExistFieldName + "='{0}'";
            sql = string.Format(sql, value);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 是否存在查询从视图查询
        /// </summary>
        protected virtual bool ExistQueryFromView
        {
            get { return false; }
        }


        /// <summary>
        /// 模型是否已存在
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public virtual bool IsModelExist(XModelBase model)
        {
            string sql = this.GetModelExistSql(model);
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 模型是否已存在判断sql
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected virtual string GetModelExistSql(XModelBase model)
        {
            return string.Empty;
        }

        /// <summary>
        /// 查看审批流程
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        public virtual DataTable ViewWorkFlow(string mainId)
        {
            string sql = "SELECT * FROM " + this.CheckViewName + " WHERE MainId='{0}' Order By CheckLevel asc ";
            sql = string.Format(sql, mainId);
            return this.m_DataAccess.GetDataTable(sql);
        }

        /// <summary>
        /// 根据名称获得编码
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public virtual string GetCodeByName(string name)
        {
            string sql = "SELECT " + this.CodeFieldName + " FROM " + this.TableName + " WHERE " + this.NameFieldName + "='{0}'";
            sql = string.Format(sql, name);
            return XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql));
        }

        /// <summary>
        /// 代码字段
        /// </summary>
        protected virtual string CodeFieldName
        {
            get { return this.PrimaryKey; }
        }

        /// <summary>
        /// 名称字段
        /// </summary>
        protected virtual string NameFieldName
        {
            get { return "TypeName"; }
        }

        /// <summary>
        /// 获取流水号
        /// </summary>
        /// <returns></returns>
        public virtual string GetSeqNo(string start)
        {
            string sql = "DECLARE @RowCount INT,@SeqNo INT ";
            sql += "SELECT @RowCount=COUNT(*) FROM " + TableName + " WHERE substring(" + DateSeqNoFieldName + ",1,len('" + start + "'))='" + start + "' AND len(" + DateSeqNoFieldName + ")=len('" + start + "')+" + DateSeqNoLength + " ";
            sql += "IF @RowCount>0 BEGIN ";
            sql += "SELECT substring(" + DateSeqNoFieldName + ",len('" + start + "')+1," + DateSeqNoLength + ") FROM " + this.TableName + " WHERE substring(" + DateSeqNoFieldName + ",1,len('" + start + "'))='" + start + "' AND len(" + DateSeqNoFieldName + ")=len('" + start + "')+" + DateSeqNoLength + " ";
            sql += "END ELSE BEGIN SELECT '" + this.GetFirstSeqNo() + "' END ";

            string seqNo = XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql));

            int seq = XHelper.GetInt(seqNo.TrimStart('0')) + 1;

            seqNo = seq.ToString().PadLeft(DateSeqNoLength, '0');

            sql = "SELECT '" + start + "'+" + "'" + seqNo + "'";

            return XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql)); ;
        }

        /// <summary>
        /// 获取按照日期来生成的流水号
        /// </summary>
        /// <returns></returns>
        public virtual string GetDateSeqNo()
        {
            string sql = "DECLARE @RowCount INT,@SeqNo INT ";
            sql += "SELECT @RowCount=COUNT(*) FROM " + TableName + " WHERE substring(" + DateSeqNoFieldName + ",1,8)=convert(VARCHAR(8),getdate(),112) AND len(" + DateSeqNoFieldName + ")=8+" + DateSeqNoLength + " ";
            sql += "IF @RowCount>0 BEGIN ";
            sql += "SELECT substring(" + DateSeqNoFieldName + ",9," + DateSeqNoLength + ") FROM " + this.TableName + " WHERE substring(" + DateSeqNoFieldName + ",1,8)=convert(VARCHAR(8),getdate(),112) AND len(" + DateSeqNoFieldName + ")=8+" + DateSeqNoLength + " ";
            sql += "END ELSE BEGIN SELECT '" + this.GetFirstSeqNo() + "' END ";

            string seqNo = XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql));

            int seq = XHelper.GetInt(seqNo.TrimStart('0')) + 1;

            seqNo = seq.ToString().PadLeft(DateSeqNoLength, '0');

            sql = "SELECT convert(VARCHAR(8),getdate(),112)+" + "'" + seqNo + "'";

            return XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql)); ;
        }

        /// <summary>
        /// 流水字段名
        /// </summary>
        protected virtual string DateSeqNoFieldName
        {
            get { return ""; }
        }

        /// <summary>
        /// 流水长度
        /// </summary>
        protected virtual int DateSeqNoLength
        {
            get { return 5; }
        }

        /// <summary>
        /// 获取第一个流水号
        /// </summary>
        /// <returns></returns>
        protected virtual string GetFirstSeqNo()
        {
            string seqNo = string.Empty;

            for (int i = 1; i <= DateSeqNoLength - 1; i++)
            {
                seqNo += "0";
            }

            return seqNo + "0";
        }

        /// <summary>
        /// 数据复制
        /// </summary>
        /// <param name="sourceMonth"></param>
        /// <param name="destMonth"></param>
        /// <returns></returns>
        public virtual bool MonthDataCopy(string sourceMonth, string destMonth, string userId)
        {
            string sql = this.GetMonthDataCopySql(sourceMonth, destMonth, userId);
            return this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
        }

        /// <summary>
        /// 获取月份行数
        /// </summary>
        /// <param name="sourceMonth"></param>
        /// <returns></returns>
        public virtual int GetMonthDataCopyCount(string sourceMonth)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE " +
                this.YearMonthFieldName + "='" + sourceMonth + "'";
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql));
        }

        protected virtual string YearMonthFieldName
        {
            get { return "PayYearMonth"; }
        }

        /// <summary>
        /// 获取数据复制sql
        /// </summary>
        /// <param name="sourceMonth"></param>
        /// <param name="destMonth"></param>
        /// <returns></returns>
        protected virtual string GetMonthDataCopySql(string sourceMonth, string destMonth, string userId)
        {
            return string.Empty;
        }

        public bool IsEndModel(XModelBase model, string where = "")
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE " + ParentIdFieldName + "='" + model.ID + "'";
            sql += where;
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) == 0;
        }

        public virtual bool Insert(XModelBase modelInfo, IDictionary<string, IList<XModelBase>> detailDict)
        {
            string sql = string.Empty;

            //插入语句
            sql += this.GetInsertSql(modelInfo) + ";";

            foreach (KeyValuePair<string, IList<XModelBase>> keyValue in detailDict)
            {
                string key = keyValue.Key;
                IList<XModelBase> detailModels = keyValue.Value;

                foreach (XModelBase detailInfo in detailModels)
                {
                    this.FillDetailMainId(key, detailInfo, modelInfo);
                    sql += this.GetDetailInsertSql(key, detailInfo);
                }
            }

            //插入语句后执行
            sql += this.GetInsertAfterSql(modelInfo);

            return this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
        }

        public virtual string GetDetailInsertSql(string key, XModelBase detailModel)
        {
            return string.Empty;
        }

        /// <summary>
        /// 填充明细的主表主键值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="detailInfo"></param>
        /// <param name="mainInfo"></param>
        public virtual void FillDetailMainId(string key, XModelBase detailInfo, XModelBase mainInfo)
        {

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
            string sql = string.Empty;

            //插入语句
            sql += this.GetUpdateSql(modelInfo) + ";";

            //获取删除语句
            foreach (KeyValuePair<string, IList<XModelBase>> keyValue in deleteDict)
            {
                string key = keyValue.Key;
                IList<XModelBase> detailModels = keyValue.Value;
                foreach (XModelBase detailInfo in detailModels)
                {
                    sql += this.GetDetailDeleteSql(key, detailInfo);
                }
            }

            //获取新增和修改明细
            foreach (KeyValuePair<string, IList<XModelBase>> keyValue in detailDict)
            {
                string key = keyValue.Key;
                IList<XModelBase> detailModels = keyValue.Value;
                foreach (XModelBase detailInfo in detailModels)
                {
                    if (detailInfo.ID == string.Empty)
                    {
                        //新增
                        this.FillDetailMainId(key, detailInfo, modelInfo);
                        sql += this.GetDetailInsertSql(key, detailInfo);
                    }
                    else
                    {
                        //修改
                        sql += this.GetDetailUpdateSql(key, detailInfo);
                    }
                }
            }

            return this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
        }

        public virtual string GetDetailUpdateSql(string key, XModelBase detailModel)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取删除明细sql
        /// </summary>
        /// <param name="key"></param>
        /// <param name="detailInfo"></param>
        /// <returns></returns>
        protected virtual string GetDetailDeleteSql(string key, XModelBase detailInfo)
        {
            return string.Empty;
        }

        public virtual bool DeleteWithDict(IList<XModelBase> modelInfos,
            IDictionary<string, IList<XModelBase>> detailDict)
        {
            string deleteIds = string.Empty;

            foreach (XModelBase model in modelInfos)
            {
                deleteIds += "'" + model.ID + "',";
            }

            deleteIds = deleteIds.TrimEnd(',');

            if (modelInfos.Count == 0)
            {
                return false;
            }

            string sql = string.Empty;

            sql += "DELETE FROM " + this.TableName + " where " + this.PrimaryKey + " IN ({0});";
            sql = string.Format(sql, deleteIds);

            foreach (KeyValuePair<string, IList<XModelBase>> keyValue in detailDict)
            {
                string key = keyValue.Key;
                sql += this.GetDeleteDetailSql(key, deleteIds);
            }

            return this.m_DataAccess.ExecuteNonQueryByTrans(sql) > 0;
        }

        /// <summary>
        /// 获取删除明细sql
        /// </summary>
        /// <param name="key"></param>
        /// <param name="deleteMainIds"></param>
        /// <returns></returns>
        protected virtual string GetDeleteDetailSql(string key, string deleteMainIds)
        {
            return string.Empty;
        }

        /// <summary>
        /// 获取子表记录数
        /// </summary>
        /// <param name="mainId"></param>
        /// <returns></returns>
        public virtual int GetCountByMainId(string mainId)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE " +
                MainIdFieldName + "='" + mainId + "'";
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql));
        }

        public bool IsUsed(string id)
        {
            string sql = "SELECT * FROM V_DeleteValidateRule WHERE ValidateTableName='" + this.TableName + "'";
            DataTable table = this.m_DataAccess.GetDataTable(sql);

            foreach (DataRow row in table.Rows)
            {
                string useTableName = XHelper.GetString(row["UseTableName"]);
                string useTableId = XHelper.GetString(row["UseTableFieldName"]);
                string tableDesc = XHelper.GetString(row["UseTableDesc"]);

                string sqlValidate = "SELECT COUNT(*) FROM " + useTableName + " WHERE " + useTableId + "='" + id + "'";
                int rowCount = XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sqlValidate));
                if (rowCount > 0)
                {
                    XMessageBox.ShowError("要删除的记录中存在已被：[" + tableDesc + "]引用的记录，不能删除！");
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 是否排序
        /// </summary>
        protected virtual bool IsOrderBy
        {
            get { return false; }
        }

        /// <summary>
        /// 排序
        /// </summary>
        protected virtual string OrderBy
        {
            get { return string.Empty; }
        }
    }
}
