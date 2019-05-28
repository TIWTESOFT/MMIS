using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XTemplateInfo : XModelBase,ICloneable
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
        public string TemplateID
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string TemplateName
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string PageSize
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
        public double Width
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
        public double FontSize
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string TemplateBlob
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string TemplateType
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Spell
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
        public string IsUsed
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
        /// 
        /// </summary>
        public string StampTime
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