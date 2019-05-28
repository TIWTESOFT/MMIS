using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;
using MMIS.Model;

namespace MMIS.BLL
{
    public partial class XTaskFilesBusiness
    {
        public bool InsertCustom(XModelBase model)
        {
            XTaskFilesProvider provider = this.m_Provider as XTaskFilesProvider;
            return provider.InsertCustom(model);
        }

        public bool UpdateCustom(XModelBase model)
        {
            XTaskFilesProvider provider = this.m_Provider as XTaskFilesProvider;
            return provider.UpdateCustom(model);
        }

        /// <summary>
        /// 根据根级任务获取文件
        /// </summary>
        /// <param name="rootTaskId"></param>
        /// <returns></returns>
        public IList<XModelBase> GetViewListByRootTaskId(string rootTaskId)
        {
            XTaskFilesProvider provider = this.m_Provider as XTaskFilesProvider;
            return provider.GetViewListByRootTaskId(rootTaskId);
        }
    }
}
