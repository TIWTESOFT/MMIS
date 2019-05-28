using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XEquipmentCustInfo : XModelBase,ICloneable
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
        public string CustTypeId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CustName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CustNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CustAddress
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string LinkPeople
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
        public string Email
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string WebSite
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CustDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string InvoiceTitle
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string TaxNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string BankName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string BankAccountNo
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