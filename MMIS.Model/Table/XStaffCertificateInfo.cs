using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XStaffCertificateInfo : XModelBase,ICloneable
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
        public string UserId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CertName
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
        public string CertGetTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string CertItem
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string RegisterDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string NextRegisterDate
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