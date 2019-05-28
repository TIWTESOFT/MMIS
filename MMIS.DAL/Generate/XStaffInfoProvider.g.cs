using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 人员信息
    /// </summary>
    public partial class XStaffInfoProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "StaffInfo";
            }
        }
        
         /// <summary>
        /// 主键
        /// </summary>
        public override string PrimaryKey
        {
            get
            {
                return "RID";
            }
        }
        
        
        protected override XModelBase InitTableModel()
        {
            return new XStaffInfoInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XStaffInfoInfo info = modelInfo as XStaffInfoInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//主键
            info.UserName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserName"));//姓名
            info.UserSex=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserSex"));//性别
            info.Nationality=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Nationality"));//民族
            info.UserAge=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "UserAge"));//年龄
            info.Birthday=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Birthday"));//出生日期
            info.NativePlace=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NativePlace"));//籍贯
            info.StartWorkDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "StartWorkDate"));//参加工作时间
            info.ToCompWorkDate=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ToCompWorkDate"));//到本单位工作时间
            info.PersonID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PersonID"));//身份证号
            info.Specialty=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Specialty"));//特长
            info.HouseHoldAddr=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "HouseHoldAddr"));//户口所在地
            info.HomeAddress=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "HomeAddress"));//家庭地址
            info.HomeTel=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "HomeTel"));//家庭电话
            info.MobileNo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "MobileNo"));//手机号
            info.WorkTel=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "WorkTel"));//工作电话
            info.Education=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Education"));//文化程度
            info.Major=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Major"));//所学专业
            info.University=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "University"));//毕业院校
            info.MeasureWorkYears=XHelper.GetInt(XDataRowHelper.GetFieldValue(modelRow, "MeasureWorkYears"));//计量工作年限
            info.MeasureWorkContent=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "MeasureWorkContent"));//负责计量工作内容
            info.DeptId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DeptId"));//部门
            info.Post=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Post"));//职务
            info.RoleId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RoleId"));//角色
            info.UserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UserId"));//关联用户
            info.Remark=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Remark"));//备注
            info.InputUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputUserId"));//录入人
            info.InputTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "InputTime"));//录入时间
            info.UpdateUserId=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateUserId"));//修改人
            info.UpdateTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "UpdateTime"));//修改时间
            info.FileName=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "FileName"));//
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XStaffInfoInfo info = modelInfo as XStaffInfoInfo;
            string sql="Insert Into " + this.TableName + "(RID,UserName,UserSex,Nationality,UserAge,Birthday,NativePlace,StartWorkDate,ToCompWorkDate,PersonID,Specialty,HouseHoldAddr,HomeAddress,HomeTel,MobileNo,WorkTel,Education,Major,University,MeasureWorkYears,MeasureWorkContent,DeptId,Post,RoleId,UserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,FileName)Values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}',{19},'{20}','{21}','{22}','{23}','{24}','{25}','{26}',{27},'{28}',{29},'{30}')";
            sql=String.Format(sql,info.RID,info.UserName,info.UserSex,info.Nationality,info.UserAge,info.Birthday,info.NativePlace,info.StartWorkDate,info.ToCompWorkDate,info.PersonID,info.Specialty,info.HouseHoldAddr,info.HomeAddress,info.HomeTel,info.MobileNo,info.WorkTel,info.Education,info.Major,info.University,info.MeasureWorkYears,info.MeasureWorkContent,info.DeptId,info.Post,info.RoleId,info.UserId,info.Remark,info.InputUserId,this.GetServerTimeFuncion(),info.UpdateUserId,this.GetServerTimeFuncion(),info.FileName);
            return sql;
        }

        
        /// <summary>
        /// 获取更新Sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetUpdateSql(XModelBase modelInfo)
        {
            string sql = String.Empty;
            
            XStaffInfoInfo info = modelInfo as XStaffInfoInfo;
            sql="Update " + this.TableName + " Set UserName='{0}',UserSex='{1}',Nationality='{2}',UserAge={3},Birthday='{4}',NativePlace='{5}',StartWorkDate='{6}',ToCompWorkDate='{7}',PersonID='{8}',Specialty='{9}',HouseHoldAddr='{10}',HomeAddress='{11}',HomeTel='{12}',MobileNo='{13}',WorkTel='{14}',Education='{15}',Major='{16}',University='{17}',MeasureWorkYears={18},MeasureWorkContent='{19}',DeptId='{20}',Post='{21}',RoleId='{22}',UserId='{23}',Remark='{24}',UpdateUserId='{25}',UpdateTime={26},FileName='{27}' Where RID='{28}'";
            sql=string.Format(sql,info.UserName,info.UserSex,info.Nationality,info.UserAge,info.Birthday,info.NativePlace,info.StartWorkDate,info.ToCompWorkDate,info.PersonID,info.Specialty,info.HouseHoldAddr,info.HomeAddress,info.HomeTel,info.MobileNo,info.WorkTel,info.Education,info.Major,info.University,info.MeasureWorkYears,info.MeasureWorkContent,info.DeptId,info.Post,info.RoleId,info.UserId,info.Remark,info.UpdateUserId,this.GetServerTimeFuncion(),info.FileName,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XStaffInfoInfo info = modelInfo as XStaffInfoInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,UserName,UserSex,Nationality,UserAge,Birthday,NativePlace,StartWorkDate,ToCompWorkDate,PersonID,Specialty,HouseHoldAddr,HomeAddress,HomeTel,MobileNo,WorkTel,Education,Major,University,MeasureWorkYears,MeasureWorkContent,DeptId,Post,RoleId,UserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,FileName,OperateUserId,Operate,OperateTime,NewID) SELECT RID,UserName,UserSex,Nationality,UserAge,Birthday,NativePlace,StartWorkDate,ToCompWorkDate,PersonID,Specialty,HouseHoldAddr,HomeAddress,HomeTel,MobileNo,WorkTel,Education,Major,University,MeasureWorkYears,MeasureWorkContent,DeptId,Post,RoleId,UserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,FileName,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }
        
        /// <summary>
        /// 获取删除时插入日志表sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        protected override string GetInsertDeleteHistory(XModelBase modelInfo, string userId)
        {
            XStaffInfoInfo info = modelInfo as XStaffInfoInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,UserName,UserSex,Nationality,UserAge,Birthday,NativePlace,StartWorkDate,ToCompWorkDate,PersonID,Specialty,HouseHoldAddr,HomeAddress,HomeTel,MobileNo,WorkTel,Education,Major,University,MeasureWorkYears,MeasureWorkContent,DeptId,Post,RoleId,UserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,FileName,OperateUserId,Operate,OperateTime,NewID) SELECT RID,UserName,UserSex,Nationality,UserAge,Birthday,NativePlace,StartWorkDate,ToCompWorkDate,PersonID,Specialty,HouseHoldAddr,HomeAddress,HomeTel,MobileNo,WorkTel,Education,Major,University,MeasureWorkYears,MeasureWorkContent,DeptId,Post,RoleId,UserId,Remark,InputUserId,InputTime,UpdateUserId,UpdateTime,FileName,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}