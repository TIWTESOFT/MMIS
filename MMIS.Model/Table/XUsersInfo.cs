using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XUsersInfo : XModelBase,ICloneable
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
        public string UserType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string RealName
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
        public string PassWord
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UserState
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IsAdmin
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
        public string AuditTel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IsDownPower
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