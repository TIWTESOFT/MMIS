using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MMIS.DAL;
using System.Data;
using MMIS.Model;

namespace MMIS.BLL
{
    public partial class XTaskBusiness
    {
        /// <summary>
        /// 更新任务状态
        /// </summary>
        /// <param name="status"></param>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public bool UpdateTaskStatus(string status, string taskId)
        {
            XTaskProvider provider = this.m_Provider as XTaskProvider;
            return provider.UpdateTaskStatus(status, taskId);
        }

        /// <summary>
        /// 获取任务状态
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public string GetTaskStatus(string taskId)
        {
            XTaskProvider provider = this.m_Provider as XTaskProvider;
            return provider.GetTaskStatus(taskId);
        }

        /// <summary>
        /// 是否已有提交的文件
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsHaveFile(string id)
        {
            XTaskProvider provider = this.m_Provider as XTaskProvider;
            return provider.IsHaveFile(id);
        }

        /// <summary>
        /// 是否有待办任务
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool IsHaveTaskToDo(string userId)
        {
            XTaskProvider provider = this.m_Provider as XTaskProvider;
            return provider.IsHaveTaskToDo(userId);
        }

        /// <summary>
        /// 获取待办任务
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public DataTable GetTaskToDo(string userId)
        {
            XTaskProvider provider = this.m_Provider as XTaskProvider;
            return provider.GetTaskToDo(userId);
        }

        /// <summary>
        /// 获取要填报任务的根任务列表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public IList<XModelBase> GetTaskFileRootViewModelList(string where)
        {
            XTaskProvider provider = this.m_Provider as XTaskProvider;
            return provider.GetTaskFileRootViewModelList(where);
        }
    }
}
