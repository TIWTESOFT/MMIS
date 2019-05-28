using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XPassWord4FileInfo : XModelBase,ICloneable
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
        public string PassWordTmpId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string PassWord
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DownLoadUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FileID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DownTime
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