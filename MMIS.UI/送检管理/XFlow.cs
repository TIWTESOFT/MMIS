using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Model;
using MMIS.Helper;

namespace MMIS.UI
{
   public  class XFlow
    {
       ///// <summary>
       ///// 自动填充设备接收信息
       ///// </summary>
       ///// <param name="check"></param>
       ///// <returns></returns>
       //public static XVEquipmentReceiveInfo FillEquipmentReceiveInfo4Add(XVEquipmentCheckInfo check)
       //{
       //    XVEquipmentReceiveInfo rev = new XVEquipmentReceiveInfo();

       //    rev.EquipmentCheckId = check.RID;
       //    rev.EquipmentName = check.EquipmentName;
       //    rev.CheckUserId = check.SourceCustId;
       //    //2015-10-19,mxj,add============================
       //    if (check.SourceCustId != string.Empty)
       //    {
       //        string sqlget = "select * from StaffInfo where rid='" + check.SourceCustId + "'";
       //        DataTable dt = new DataTable();
       //        dt = SQLHelper.GetDataSet(sqlget);
       //        bool ishad = false;
       //        if (dt != null)
       //        {
       //            if (dt.Rows.Count > 0)
       //            {
       //                ishad = true;
       //            }
       //        }
       //        if (ishad)
       //        {
       //            string disname = "";
       //            disname = dt.Rows[0]["UserName"] + "";

       //            rev.CheckUserName = disname;
       //        }
       //    }
       //    else//没有指定检定员，直接跳出
       //    {
       //        return null;
       //    }

       //    rev.Remark = "自动接收";

       //    rev.RID = Guid.NewGuid().ToString();
       //    rev.ID = check.RID;

       //    rev.EquipmentType = check.EquipmentTypeName;
       //    rev.EquipmentNo = check.EquipmentNo;
       //    rev.CustName = check.CustName;
       //    rev.Spec = check.Spec;
       //    rev.Model = check.Model;
       //    rev.Quanlity = check.Quanlity;
       //    rev.LastCheckDate = check.LastCheckDate;
       //    rev.SourceTypeId = check.SourceTypeId;
       //    rev.SourceCustId = check.SourceCustId;
       //    rev.SourceTime = check.SourceTime;

       //    rev.ReceiveDate = check.UseTime;
       //    rev.ReceiveDesc = check.EquipmentDesc;

       //    rev.ReceiveUserId = XCommon.LoginUsersInfo.RID;
       //    //info.ReceiveUserName = XCommon.LoginUsersInfo.UserName;

       //    rev.CurrentStatus = "接收";
       //    rev.FlowUserId = rev.CheckUserId;
       //    rev.FlowStatus = "检定";

       //    rev.InputUserId = XCommon.LoginUsersInfo.RID;
       //    rev.InputTime = XHelper.GetFormatedTime(DateTime.Now);
       //    rev.UpdateUserId = XCommon.LoginUsersInfo.RID;
       //    rev.UpdateTime = XHelper.GetFormatedTime(DateTime.Now);
       //    rev.ModelStatus = XModelStatus.Add;


       //    return rev;
       //}



    }
}
