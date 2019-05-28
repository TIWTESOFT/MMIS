using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Model
{
    /// <summary>
    /// 实体基类
    /// </summary>
    public class XModelBase : ICloneable
    {
        private XModelStatus m_ModelStatus = XModelStatus.None;

        /// <summary>
        /// 实体状态
        /// </summary>
        public XModelStatus ModelStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 主键
        /// </summary>
        public string ID
        {
            get;
            set;
        }

        /// <summary>
        /// 录入人Id
        /// </summary>
        public string InputUserId
        {
            get;
            set;
        }

        /// <summary>
        /// 录入时间
        /// </summary>
        public string InputTime
        {
            get;
            set;
        }

        /// <summary>
        /// 更新人Id
        /// </summary>
        public string UpdateUserId
        {
            get;
            set;
        }

        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDeleted
        {
            get;
            set;
        }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Remark
        {
            get;
            set;
        }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string TimeStamp
        {
            get;
            set;
        }




        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
