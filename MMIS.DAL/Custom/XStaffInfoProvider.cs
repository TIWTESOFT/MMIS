using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.DAL
{
    public partial class XStaffInfoProvider
    {
        protected override bool IsGetAllOrderBy()
        {
            return false;
        }

        protected override Model.XModelBase InitViewModel()
        {
            return new XVStaffInfoInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVStaffInfoInfo staffInfo = model as XVStaffInfoInfo;

            staffInfo.LoginUserName = XHelper.GetString(modelRow["LoginUserName"]);
            staffInfo.DeptName = XHelper.GetString(modelRow["DeptName"]);
        }

        protected override XProviderBase InitDetailProvider()
        {
            return new XStaffCItemProvider();
        }

        protected override void FillDetailMainId(XModelBase detailInfo, XModelBase mainInfo)
        {
            XStaffCItemInfo cItemInfo = detailInfo as XStaffCItemInfo;
            XStaffInfoInfo staffInfo = mainInfo as XStaffInfoInfo;

            cItemInfo.UserId = staffInfo.ID;
        }

        protected override string DetailTableName
        {
            get
            {
                return "StaffCItem";
            }
        }

        protected override string DetailTableMainIdFieldName
        {
            get
            {
                return "UserId";
            }
        }

        /// <summary>
        /// 用户是否已关联其他人员信息
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public bool IsUserIdHaveStaff(string userid)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE UserId='" + userid + "'";
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }

        /// <summary>
        /// 根据用户ID获取人员ID
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string GetStaffIdByUserId(string userId)
        {
            string sql = "SELECT RID FROM " + this.TableName + " WHERE UserId='" + userId + "'";
            return XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql));
        }
    }

}
