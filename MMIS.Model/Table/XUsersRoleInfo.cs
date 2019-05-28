using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XUsersRoleInfo : XModelBase,ICloneable
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
        public string UserID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string RoleID
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