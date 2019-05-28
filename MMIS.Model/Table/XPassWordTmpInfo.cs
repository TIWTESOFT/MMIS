using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XPassWordTmpInfo : XModelBase,ICloneable
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
        public string PassDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string PassStateId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UseIP
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UseStartTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UseEndTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 UseLimit
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IsTelAudit
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IsCheck
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Auditor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string AuditTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Password
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