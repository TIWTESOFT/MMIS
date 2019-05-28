using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.Model;
using MMIS.Helper;
using System.Data.Common;
using System.Data;
using System.IO;
namespace MMIS.DAL
{
    public partial class XEquipmentCheckProvider
    {
        protected override XModelBase InitViewModel()
        {
            return new XVEquipmentCheckInfo();
        }

        protected override void FillRowViewInfos(XModelBase model, System.Data.DataRow modelRow)
        {
            XVEquipmentCheckInfo info = model as XVEquipmentCheckInfo;

            info.CustName = XHelper.GetString(modelRow["CustName"]);
            info.EquipmentState = XHelper.GetString(modelRow["EquipmentState"]);
            info.ColorRGB = XHelper.GetString(modelRow["ColorRGB"]);

            info.CustAddress = XHelper.GetString(modelRow["CustAddress"]);
            info.LinkPeople = XHelper.GetString(modelRow["LinkPeople"]);
            info.MobileNo = XHelper.GetString(modelRow["MobileNo"]);
            info.WorkTel = XHelper.GetString(modelRow["WorkTel"]);
            info.CustEmail = XHelper.GetString(modelRow["CustEmail"]);
            info.Email = XHelper.GetString(modelRow["Email"]);
            info.WebSite = XHelper.GetString(modelRow["WebSite"]);
            info.CustDesc = XHelper.GetString(modelRow["CustDesc"]);
            info.InvoiceTitle = XHelper.GetString(modelRow["InvoiceTitle"]);
            info.TaxNo = XHelper.GetString(modelRow["TaxNo"]);
            info.BankName = XHelper.GetString(modelRow["BankName"]);
            info.BankAccountNo = XHelper.GetString(modelRow["BankAccountNo"]);
            info.EquipmentTypeName = XHelper.GetString(modelRow["EquipmentTypeName"]);
            //2015-10-14,mxj,add
            info.UserName = XHelper.GetString(modelRow["UserName"]);
        }

        /// <summary>
        /// 获取设备编号
        /// </summary>
        /// <param name="ruleCode"></param>
        /// <returns></returns>
        public string GetEquipmentNo(string ruleCode)
        {
            int length = ruleCode.Trim().Length;

            string sql = "SELECT MAX(substring(EquipmentNo," + (length + 1) + ",5)) FROM EquipmentCheck " +
                "WHERE len(EquipmentNo)=" + (ruleCode.Length + 5) + " AND substring(EquipmentNo,1," +
                length + ")='" + ruleCode + "'";
            string result = XHelper.GetString(this.m_DataAccess.ExecuteScalar(sql));

            int maxNo = XHelper.GetInt(result.TrimStart('0'));

            return ruleCode + (maxNo + 1).ToString().PadLeft(5, '0');
        }

        public bool IsEquipmentNoExist(string equipmentNo)
        {
            string sql = "SELECT COUNT(*) FROM " + this.TableName + " WHERE EquipmentNo='" + equipmentNo + "'";
            return XHelper.GetInt(this.m_DataAccess.ExecuteScalar(sql)) > 0;
        }



        #region 20151019mxjadd
        /// <summary>
        /// 自动填充设备接收信息
        /// </summary>
        /// <param name="check"></param>
        /// <returns></returns>
        public  XVEquipmentReceiveInfo FillEquipmentReceiveInfo4Add(XVEquipmentCheckInfo check, string userId)
        {
            XVEquipmentReceiveInfo rev = new XVEquipmentReceiveInfo();

            rev.EquipmentCheckId = check.RID;
            rev.EquipmentName = check.EquipmentName;
            rev.CheckUserId = check.SourceCustId;
            rev.CheckUserName = check.CheckResult;//字段临时借用:指定检定人名称
            rev.Remark = "自动接收";

            rev.RID = Guid.NewGuid().ToString();
            rev.ID = check.RID;

            rev.EquipmentType = check.EquipmentTypeName;
            rev.EquipmentNo = check.EquipmentNo;
            rev.CustName = check.CustName;
            rev.Spec = check.Spec;
            rev.Model = check.Model;
            rev.Quanlity = check.Quanlity;
            rev.LastCheckDate = check.LastCheckDate;
            rev.SourceTypeId = check.SourceTypeId;
            rev.SourceCustId = check.SourceCustId;
            rev.SourceTime = check.SourceTime;

            rev.ReceiveDate = check.UseTime;
            rev.ReceiveDesc = check.EquipmentDesc;

            rev.ReceiveUserId = userId;
            //info.ReceiveUserName = XCommon.LoginUsersInfo.UserName;

            rev.CurrentStatus = "接收";
            rev.FlowUserId = rev.CheckUserId;
            rev.FlowStatus = "检定";

            rev.InputUserId = userId;
            rev.InputTime = XHelper.GetFormatedTime(DateTime.Now);
            rev.UpdateUserId = userId;
            rev.UpdateTime = XHelper.GetFormatedTime(DateTime.Now);
            rev.ModelStatus = XModelStatus.Add;


            return rev;
        }

        public string GetInsertSql4rev(XModelBase modelInfo)
        {
            XEquipmentReceiveInfo info = modelInfo as XEquipmentReceiveInfo;
            string sql = "Insert Into EquipmentReceive(RID,EquipmentCheckId,CheckUserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,ReceiveUserId,ReceiveDate,ReceiveDesc,CurrentStatus,FlowStatus,FlowUserId,CheckedUserId,CheckedDate,CheckedDesc,VerifyUserId,CheckedReport,VerifyedUserId,VerifyedDate,VerifyedDesc,SignUserId,SignedUserId,SignedDate,SignedDesc,DispatchUserId,IsBack,BackDate,BackReason,BackStatus,BackUserId,Quanlity,StandId,PdfReportFileName)Values('{0}','{1}','{2}','{3}','{4}',{5},'{6}',{7},'{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}','{31}',{32},'{33}','{34}')";
            sql = String.Format(sql, info.RID, info.EquipmentCheckId, info.CheckUserId, info.Remark, info.InputUserId, this.GetServerTimeFuncion(), info.UpdateUserId, this.GetServerTimeFuncion(), info.ReceiveUserId, info.ReceiveDate, info.ReceiveDesc, info.CurrentStatus, info.FlowStatus, info.FlowUserId, info.CheckedUserId, info.CheckedDate, info.CheckedDesc, info.VerifyUserId, info.CheckedReport, info.VerifyedUserId, info.VerifyedDate, info.VerifyedDesc, info.SignUserId, info.SignedUserId, info.SignedDate, info.SignedDesc, info.DispatchUserId, info.IsBack == true ? "1" : "0", info.BackDate, info.BackReason, info.BackStatus, info.BackUserId, info.Quanlity, info.StandId, info.PdfReportFileName);
            return sql;
        }

        public bool Checked(XModelBase model,string userId)
        {
            DbConnection sqlConn = this.m_DataAccess.Connection;
            DbTransaction trans = null;
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                trans = sqlConn.BeginTransaction();

                string sql = string.Empty;

                XEquipmentCheckInfo info = model as XEquipmentCheckInfo;
                sql = "Insert Into " + this.TableName + "(RID,EquipmentType,EquipmentCustId,EquipmentName,FactoryNo,Spec,Model,FactoryName,SourceTime,UseTime,SourceCustId,SourceTypeId,EquipmentStatusId,SignStatus,Quanlity,LinkMan,Tel,Email,CheckAccord,LastCheckDate,CheckResult,ValidDate,CertNo,EquipmentDesc,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,EquipmentNo,BillNo)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',{14},'{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}',{26},'{27}',{28},'{29}','{30}')";
                sql = String.Format(sql, info.RID, info.EquipmentType, info.EquipmentCustId, info.EquipmentName, info.FactoryNo, info.Spec, info.Model, info.FactoryName, info.SourceTime, info.UseTime, info.SourceCustId, info.SourceTypeId, info.EquipmentStatusId, info.SignStatus, info.Quanlity, info.LinkMan, info.Tel, info.Email, info.CheckAccord, info.LastCheckDate, info.CheckResult, info.ValidDate, info.CertNo, info.EquipmentDesc, info.Remark, info.InputUserId, this.GetServerTimeFuncion(), info.UpdateUserId, this.GetServerTimeFuncion(), info.EquipmentNo, info.BillNo);


                //if (receiveInfo.ReportFileFullName != string.Empty)
                //{
                //    //上传附件
                //    DbCommand fileCommand = this.GetFileCommand(receiveInfo);
                //    fileCommand.Connection = sqlConn;
                //    fileCommand.Transaction = trans;
                //    DbDataReader reader = fileCommand.ExecuteReader();
                //    reader.Close();
                //}

                sql += ";";

                 //XEquipmentReceiveInfo inforev = modelrev as XEquipmentReceiveInfo;
                XVEquipmentReceiveInfo inforev = FillEquipmentReceiveInfo4Add(model as XVEquipmentCheckInfo, userId);
                string sql2 = GetInsertSql4rev(inforev);

                sql = sql + sql2;


                DbCommand cmd = this.m_DataAccess.GetDbCommand();
                cmd.Connection = sqlConn;
                cmd.CommandText = sql;
                cmd.Transaction = trans;
                bool isSuccess = cmd.ExecuteNonQuery() > 0;
                trans.Commit();

                return isSuccess;

            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message);
                XErrorLogTool.WriteLog(ex.ToString());
                trans.Rollback();
            }
            finally
            {
                if (sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return false;
        }

        #endregion

    }
}
