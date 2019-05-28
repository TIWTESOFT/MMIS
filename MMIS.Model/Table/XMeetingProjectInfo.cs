using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XMeetingProjectInfo : XModelBase,ICloneable
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
        public string ProjectName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ProjectDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StartTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string EndTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Purveyor
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Linkman
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Tel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ProjectTypeId
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
        /// 复制
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}