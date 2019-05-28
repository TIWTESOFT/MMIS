using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XStaffInfoInfo : XModelBase,ICloneable
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
        public string UserName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UserSex
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Nationality
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 UserAge
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Birthday
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string NativePlace
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StartWorkDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ToCompWorkDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string PersonID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Specialty
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string HouseHoldAddr
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string HomeAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string HomeTel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string MobileNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string WorkTel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Education
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Major
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string University
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 MeasureWorkYears
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string MeasureWorkContent
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
        public string Post
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
        public string UserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FileName
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