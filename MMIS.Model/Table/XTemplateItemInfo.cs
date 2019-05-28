using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XTemplateItemInfo : XModelBase,ICloneable
    {

        /// <summary>
        /// 
        /// </summary>
        public string TemplateID
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string TemplateItemID
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
        public double X
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public double Y
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public double Width
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public double Height
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public double FontSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FontName
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