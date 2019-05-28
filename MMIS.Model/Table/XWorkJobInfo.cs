using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XWorkJobInfo : XModelBase,ICloneable
    {

        /// <summary>
        /// 
        /// </summary>
        public string JobCode
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string JobName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string JobDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 OrderIndex
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