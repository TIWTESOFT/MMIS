using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XTemplateCatalogItemInfo : XModelBase,ICloneable
    {

        /// <summary>
        /// 
        /// </summary>
        public string CatalogID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ItemID
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ItemName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ItemMean
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Memo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string StampTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string BranchID
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