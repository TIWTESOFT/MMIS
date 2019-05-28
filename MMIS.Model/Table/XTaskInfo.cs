using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XTaskInfo : XModelBase,ICloneable
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
        public string TaskTypeId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string TaskName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string TaskNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StartPeople
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DispatchDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string AssignPeople
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StartDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string PreEndDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ShortDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Require
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Content
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ParentId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string TaskStatus
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