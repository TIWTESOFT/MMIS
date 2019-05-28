using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XRemindConfigInfo : XModelBase,ICloneable
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
        public string ConfigType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 RemindDays
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string RemindInfoTemplate
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