using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XStandCodeEquipmentInfo : XModelBase,ICloneable
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
        public string EquipmentType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentCustId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FactoryNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Spec
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Model
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FactoryName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SourceTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string UseTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SourceCustId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SourceTypeId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentStatusId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string SignStatus
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 Quanlity
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string LinkMan
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
        public string Email
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckAccord
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string LastCheckDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CheckResult
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ValidDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CertNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string EquipmentNo
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