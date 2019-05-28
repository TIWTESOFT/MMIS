using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MMIS.Helper;
using MMIS.Model;

namespace MMIS.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public partial class XTemplateBillProvider : XProviderBase
    {
    
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName
        {
            get
            {
                return "TemplateBill";
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
            return new XTemplateBillInfo();
        }

        
        /// <summary>
        /// 将数据行转换为实体
        /// </summary>
        /// <param name="modelRow">数据行记录</param>
        /// <returns>实体信息</returns>
        protected override void DataRow2ModelBase(XModelBase modelInfo,DataRow modelRow)
        {
            XTemplateBillInfo info = modelInfo as XTemplateBillInfo;
            
            info.ID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.RID=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "RID"));//
            info.Rno=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Rno"));//
            info.Bno=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Bno"));//
            info.Unitname=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Unitname"));//
            info.Linkname=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Linkname"));//
            info.Linktel=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Linktel"));//
            info.DevNameDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DevNameDesc"));//
            info.DevSpecDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "DevSpecDesc"));//
            info.MnoDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "MnoDesc"));//
            info.AttachmentDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "AttachmentDesc"));//
            info.NumDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "NumDesc"));//
            info.PriceDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "PriceDesc"));//
            info.TotaleDesc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "TotaleDesc"));//
            info.WriteTime = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "WriteTime"));//
            info.GetTime = XHelper.GetDateTime(XDataRowHelper.GetFieldValue(modelRow, "GetTime")).ToString("yyyy-MM-dd");//2015-11-12,mxj,modify
            //info.GetTime = XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "GetTime"));//2015-11-12,mxj,modify
            info.Total=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Total"));//
            info.Linkmanw=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Linkmanw"));//
            info.Accnamw=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Accnamw"));//
            info.Unitmemo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Unitmemo"));//
            info.Memo1=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo1"));//
            info.Memo2=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo2"));//
            info.Memo3=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo3"));//
            info.Memo4=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo4"));//
            info.Memo=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo"));//
            info.Createtime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Createtime"));//
            info.Creator=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Creator"));//
            info.ModifyTime=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "ModifyTime"));//
            info.Modifeir=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Modifeir"));//
            info.Desc_wgjc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Desc_wgjc"));//
            info.Fee_xspjf=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Fee_xspjf"));//型式评价费
            info.Fee_xspjf_num=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Fee_xspjf_num"));//型式评价费
            info.Fee_jdjyf=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Fee_jdjyf"));//监督检验费
            info.Fee_jdjyf_num=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Fee_jdjyf_num"));//监督检验费
            info.Fee_jdf=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Fee_jdf"));//检定费
            info.Fee_jdf_num=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Fee_jdf_num"));//检定费
            info.Fee_jzf=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Fee_jzf"));//校准费
            info.Fee_jzf_num=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Fee_jzf_num"));//校准费
            info.Fee_csf=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Fee_csf"));//测试费
            info.Fee_csf_num=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Fee_csf_num"));//测试费
            info.Fee_jcf=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Fee_jcf"));//检测费
            info.Fee_jcf_num=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Fee_jcf_num"));//检测费
            info.Fee_qtsf=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Fee_qtsf"));//其他收费
            info.Fee_qtsf_num=XHelper.GetDouble(XDataRowHelper.GetFieldValue(modelRow, "Fee_qtsf_num"));//其他收费
            info.Person_jc=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Person_jc"));//检测人员
            info.Time_year=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Time_year"));//送仪器年
            info.Time_month=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Time_month"));//送仪器月
            info.Time_day=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Time_day"));//送仪器日
            info.Memo_bill=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo_bill"));//备注
            info.Memo_else=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Memo_else"));//其他需说明
            info.Bill_dizhi=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Bill_dizhi"));//地址
            info.Bill_youbian=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Bill_youbian"));//邮编
            info.Bill_jieshouren=XHelper.GetString(XDataRowHelper.GetFieldValue(modelRow, "Bill_jieshouren"));//收发室仪器接收人
            
        }

        
        /// <summary>
        /// 获取插入sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        public override string GetInsertSql(XModelBase modelInfo)
        {
            XTemplateBillInfo info = modelInfo as XTemplateBillInfo;
            string sql="Insert Into " + this.TableName + "(RID,Rno,Bno,Unitname,Linkname,Linktel,DevNameDesc,DevSpecDesc,MnoDesc,AttachmentDesc,NumDesc,PriceDesc,TotaleDesc,WriteTime,GetTime,Total,Linkmanw,Accnamw,Unitmemo,Memo1,Memo2,Memo3,Memo4,Memo,Createtime,Creator,ModifyTime,Modifeir,Desc_wgjc,Fee_xspjf,Fee_xspjf_num,Fee_jdjyf,Fee_jdjyf_num,Fee_jdf,Fee_jdf_num,Fee_jzf,Fee_jzf_num,Fee_csf,Fee_csf_num,Fee_jcf,Fee_jcf_num,Fee_qtsf,Fee_qtsf_num,Person_jc,Time_year,Time_month,Time_day,Memo_bill,Memo_else,Bill_dizhi,Bill_youbian,Bill_jieshouren)Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}',{15},'{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}',{30},'{31}',{32},'{33}',{34},'{35}',{36},'{37}',{38},'{39}',{40},'{41}',{42},'{43}','{44}','{45}','{46}','{47}','{48}','{49}','{50}','{51}')";
            sql=String.Format(sql,info.RID,info.Rno,info.Bno,info.Unitname,info.Linkname,info.Linktel,info.DevNameDesc,info.DevSpecDesc,info.MnoDesc,info.AttachmentDesc,info.NumDesc,info.PriceDesc,info.TotaleDesc,info.WriteTime,info.GetTime,info.Total,info.Linkmanw,info.Accnamw,info.Unitmemo,info.Memo1,info.Memo2,info.Memo3,info.Memo4,info.Memo,info.Createtime,info.Creator,info.ModifyTime,info.Modifeir,info.Desc_wgjc,info.Fee_xspjf,info.Fee_xspjf_num,info.Fee_jdjyf,info.Fee_jdjyf_num,info.Fee_jdf,info.Fee_jdf_num,info.Fee_jzf,info.Fee_jzf_num,info.Fee_csf,info.Fee_csf_num,info.Fee_jcf,info.Fee_jcf_num,info.Fee_qtsf,info.Fee_qtsf_num,info.Person_jc,info.Time_year,info.Time_month,info.Time_day,info.Memo_bill,info.Memo_else,info.Bill_dizhi,info.Bill_youbian,info.Bill_jieshouren);
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
            
            XTemplateBillInfo info = modelInfo as XTemplateBillInfo;
            sql="Update " + this.TableName + " Set Rno='{0}',Bno='{1}',Unitname='{2}',Linkname='{3}',Linktel='{4}',DevNameDesc='{5}',DevSpecDesc='{6}',MnoDesc='{7}',AttachmentDesc='{8}',NumDesc='{9}',PriceDesc='{10}',TotaleDesc='{11}',WriteTime='{12}',GetTime='{13}',Total={14},Linkmanw='{15}',Accnamw='{16}',Unitmemo='{17}',Memo1='{18}',Memo2='{19}',Memo3='{20}',Memo4='{21}',Memo='{22}',Createtime='{23}',Creator='{24}',ModifyTime='{25}',Modifeir='{26}',Desc_wgjc='{27}',Fee_xspjf='{28}',Fee_xspjf_num={29},Fee_jdjyf='{30}',Fee_jdjyf_num={31},Fee_jdf='{32}',Fee_jdf_num={33},Fee_jzf='{34}',Fee_jzf_num={35},Fee_csf='{36}',Fee_csf_num={37},Fee_jcf='{38}',Fee_jcf_num={39},Fee_qtsf='{40}',Fee_qtsf_num={41},Person_jc='{42}',Time_year='{43}',Time_month='{44}',Time_day='{45}',Memo_bill='{46}',Memo_else='{47}',Bill_dizhi='{48}',Bill_youbian='{49}',Bill_jieshouren='{50}' Where RID='{51}'";
            sql=string.Format(sql,info.Rno,info.Bno,info.Unitname,info.Linkname,info.Linktel,info.DevNameDesc,info.DevSpecDesc,info.MnoDesc,info.AttachmentDesc,info.NumDesc,info.PriceDesc,info.TotaleDesc,info.WriteTime,info.GetTime,info.Total,info.Linkmanw,info.Accnamw,info.Unitmemo,info.Memo1,info.Memo2,info.Memo3,info.Memo4,info.Memo,info.Createtime,info.Creator,info.ModifyTime,info.Modifeir,info.Desc_wgjc,info.Fee_xspjf,info.Fee_xspjf_num,info.Fee_jdjyf,info.Fee_jdjyf_num,info.Fee_jdf,info.Fee_jdf_num,info.Fee_jzf,info.Fee_jzf_num,info.Fee_csf,info.Fee_csf_num,info.Fee_jcf,info.Fee_jcf_num,info.Fee_qtsf,info.Fee_qtsf_num,info.Person_jc,info.Time_year,info.Time_month,info.Time_day,info.Memo_bill,info.Memo_else,info.Bill_dizhi,info.Bill_youbian,info.Bill_jieshouren,info.RID);
            
            return sql;
        }
        
        /// <summary>
        /// 获取修改时插入历史表的sql
        /// </summary>
        /// <param name="modelInfo"></param>
        /// <returns></returns>
        protected override string GetInsertUpdateHistorySql(XModelBase modelInfo)
        {
            XTemplateBillInfo info = modelInfo as XTemplateBillInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,Rno,Bno,Unitname,Linkname,Linktel,DevNameDesc,DevSpecDesc,MnoDesc,AttachmentDesc,NumDesc,PriceDesc,TotaleDesc,WriteTime,GetTime,Total,Linkmanw,Accnamw,Unitmemo,Memo1,Memo2,Memo3,Memo4,Memo,Createtime,Creator,ModifyTime,Modifeir,Desc_wgjc,Fee_xspjf,Fee_xspjf_num,Fee_jdjyf,Fee_jdjyf_num,Fee_jdf,Fee_jdf_num,Fee_jzf,Fee_jzf_num,Fee_csf,Fee_csf_num,Fee_jcf,Fee_jcf_num,Fee_qtsf,Fee_qtsf_num,Person_jc,Time_year,Time_month,Time_day,Memo_bill,Memo_else,Bill_dizhi,Bill_youbian,Bill_jieshouren,OperateUserId,Operate,OperateTime,NewID) SELECT RID,Rno,Bno,Unitname,Linkname,Linktel,DevNameDesc,DevSpecDesc,MnoDesc,AttachmentDesc,NumDesc,PriceDesc,TotaleDesc,WriteTime,GetTime,Total,Linkmanw,Accnamw,Unitmemo,Memo1,Memo2,Memo3,Memo4,Memo,Createtime,Creator,ModifyTime,Modifeir,Desc_wgjc,Fee_xspjf,Fee_xspjf_num,Fee_jdjyf,Fee_jdjyf_num,Fee_jdf,Fee_jdf_num,Fee_jzf,Fee_jzf_num,Fee_csf,Fee_csf_num,Fee_jcf,Fee_jcf_num,Fee_qtsf,Fee_qtsf_num,Person_jc,Time_year,Time_month,Time_day,Memo_bill,Memo_else,Bill_dizhi,Bill_youbian,Bill_jieshouren,'" + info.UpdateUserId + "','修改',getdate(),newid() FROM "+this.TableName  + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
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
            XTemplateBillInfo info = modelInfo as XTemplateBillInfo;
            string sql="Insert Into " + this.HistoryTableName + "(RID,Rno,Bno,Unitname,Linkname,Linktel,DevNameDesc,DevSpecDesc,MnoDesc,AttachmentDesc,NumDesc,PriceDesc,TotaleDesc,WriteTime,GetTime,Total,Linkmanw,Accnamw,Unitmemo,Memo1,Memo2,Memo3,Memo4,Memo,Createtime,Creator,ModifyTime,Modifeir,Desc_wgjc,Fee_xspjf,Fee_xspjf_num,Fee_jdjyf,Fee_jdjyf_num,Fee_jdf,Fee_jdf_num,Fee_jzf,Fee_jzf_num,Fee_csf,Fee_csf_num,Fee_jcf,Fee_jcf_num,Fee_qtsf,Fee_qtsf_num,Person_jc,Time_year,Time_month,Time_day,Memo_bill,Memo_else,Bill_dizhi,Bill_youbian,Bill_jieshouren,OperateUserId,Operate,OperateTime,NewID) SELECT RID,Rno,Bno,Unitname,Linkname,Linktel,DevNameDesc,DevSpecDesc,MnoDesc,AttachmentDesc,NumDesc,PriceDesc,TotaleDesc,WriteTime,GetTime,Total,Linkmanw,Accnamw,Unitmemo,Memo1,Memo2,Memo3,Memo4,Memo,Createtime,Creator,ModifyTime,Modifeir,Desc_wgjc,Fee_xspjf,Fee_xspjf_num,Fee_jdjyf,Fee_jdjyf_num,Fee_jdf,Fee_jdf_num,Fee_jzf,Fee_jzf_num,Fee_csf,Fee_csf_num,Fee_jcf,Fee_jcf_num,Fee_qtsf,Fee_qtsf_num,Person_jc,Time_year,Time_month,Time_day,Memo_bill,Memo_else,Bill_dizhi,Bill_youbian,Bill_jieshouren,'" + userId + "','删除',getdate(),newid() FROM "+this.TableName + " WHERE " + this.PrimaryKey + "='" + info.RID+"'";
            return sql;
        }

    }
}