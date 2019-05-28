using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XStandFilesInfo : XModelBase,ICloneable
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
        public string MainId
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
        /// 
        /// </summary>
        public string FileNo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FileDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IsMaxVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string NextCheckDate
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public bool IsNeedCheck
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