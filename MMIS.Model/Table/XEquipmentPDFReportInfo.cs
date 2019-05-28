using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XEquipmentPDFReportInfo : XModelBase,ICloneable
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
        public string FileId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string AtchName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string AtchDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string AtchType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public double AtchSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string AtchPath
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string AtchShotGifPath
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string AtchImag
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