using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Model
{
    public class XImportResultInfo
    {
        private int m_Count = 0;

        /// <summary>
        /// 总数量
        /// </summary>
        public int Count
        {
            get { return this.m_Count; }
            set { this.m_Count = value; }
        }


        public int m_SuccessCount = 0;

        /// <summary>
        /// 成功数
        /// </summary>
        public int SuccessCount
        {
            get { return this.m_SuccessCount; }
            set { this.m_SuccessCount = value; }
        }


        private int m_FailureCount = 0;

        /// <summary>
        /// 失败数
        /// </summary>
        public int FailureCount
        {
            get { return this.m_FailureCount; }
            set { this.m_FailureCount = value; }
        }

        private IList<XOperateSingleResultInfo> m_Result = new List<XOperateSingleResultInfo>();

        /// <summary>
        /// 导入结果
        /// </summary>
        public IList<XOperateSingleResultInfo> Results
        {
            get { return this.m_Result; }
            set { this.m_Result = value; }
        }
    }
}
