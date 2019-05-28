using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XTableDictInfo : XModelBase,ICloneable
    {

        /// <summary>
        /// 
        /// </summary>
        public string TableName
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string TableDesc
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