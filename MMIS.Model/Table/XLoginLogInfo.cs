using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XLoginLogInfo : XModelBase,ICloneable
    {

        /// <summary>
        /// 
        /// </summary>
        public string LoginUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string LoginTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ExitTime
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