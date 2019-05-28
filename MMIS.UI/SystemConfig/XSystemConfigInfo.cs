using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.UI
{
    public partial class XSystemConfigInfo
    {
        private int m_SignWidth = 60;

        /// <summary>
        /// 点在签章宽度
        /// </summary>
        public int SignWidht
        {
            get { return this.m_SignWidth; }
            set { this.m_SignWidth = value; }
        }

        private int m_SignHeight = 20;

        /// <summary>
        /// 电子签章高度
        /// </summary>
        public int SignHeight
        {
            get { return this.m_SignHeight; }
            set { this.m_SignHeight = value; }
        }

        private int m_RefreshMinutes = 1;

        /// <summary>
        /// 定时刷新时间
        /// </summary>
        public int RefreshMinutes
        {
            get { return this.m_RefreshMinutes; }
            set { this.m_RefreshMinutes = value; }
        }
    }
}
