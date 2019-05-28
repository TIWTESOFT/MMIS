using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XRoleInfo : XModelBase,ICloneable
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
        public string RoleName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 NameNum
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Spell
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SpellHeader
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
        /// 
        /// </summary>
        public bool IsUsed
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