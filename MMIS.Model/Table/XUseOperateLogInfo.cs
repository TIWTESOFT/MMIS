using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XUseOperateLogInfo : XModelBase,ICloneable
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
        public string LogName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string LogDescription
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
        /// 
        /// </summary>
        public string UserName
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