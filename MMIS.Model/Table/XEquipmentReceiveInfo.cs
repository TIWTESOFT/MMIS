using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XEquipmentReceiveInfo : XModelBase,ICloneable
    {

        /// <summary>
        /// 
        /// </summary>
        public string RID
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentCheckId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ReceiveUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ReceiveDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ReceiveDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CurrentStatus
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FlowStatus
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FlowUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckedUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckedDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckedDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string VerifyUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckedReport
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string VerifyedUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string VerifyedDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string VerifyedDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SignUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SignedUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SignedDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SignedDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DispatchUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IsBack
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string BackDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string BackReason
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string BackStatus
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string BackUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 Quanlity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StandId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string PdfReportFileName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceNo
        {
            get;
            set;
        }
        
        
         /// <summary>
        /// 复制
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}