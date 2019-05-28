using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XEquipmentDetectInfo : XModelBase,ICloneable
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
        public string EquipmentCheckId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DetectUserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DetectReport
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