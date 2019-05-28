using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XUseErroLogInfo : XModelBase,ICloneable
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
        public string TargetSite
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Url
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Source
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StackTrace
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string HelpLink
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Message
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
        public string LogTime
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