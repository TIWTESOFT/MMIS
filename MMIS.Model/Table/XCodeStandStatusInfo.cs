using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XCodeStandStatusInfo : XModelBase,ICloneable
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
        public string NameEN
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string NameCN
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string NameBig5
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Code
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 CodeNum
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CodeEN
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
        public Int32 ProirNum
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DeptId
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
        /// 
        /// </summary>
        public string ParentID
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
        /// 复制
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}