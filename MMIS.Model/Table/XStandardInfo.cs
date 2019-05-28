using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XStandardInfo : XModelBase,ICloneable
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
        public string StandNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StandName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CreateTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string NextCheckTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 CheckTimes
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ChargeUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StandStatus
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StandDesc
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