using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XStandFilesCheckRecordInfo : XModelBase,ICloneable
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
        public string StandFileId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckUserName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string NextCheckDate
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