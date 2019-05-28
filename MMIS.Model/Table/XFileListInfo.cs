using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XFileListInfo : XModelBase,ICloneable
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
        public string FileNo
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
        public string FileDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FolderTypeId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FileTypeId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FileLevelId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string FileStateId
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public Int32 PageNum
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