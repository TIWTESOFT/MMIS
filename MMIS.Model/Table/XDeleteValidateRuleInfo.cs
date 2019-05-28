using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XDeleteValidateRuleInfo : XModelBase,ICloneable
    {

        /// <summary>
        /// 
        /// </summary>
        public string RId
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ValidateTableName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UseTableName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UseTableFieldName
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