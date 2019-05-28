using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XRoleMenusInfo : XModelBase,ICloneable
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
        public string RoleId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string MenuId
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