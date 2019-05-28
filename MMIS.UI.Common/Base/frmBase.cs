using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI.Common
{
    /// <summary>
    /// frmBase 窗口
    /// 名称: 
    /// 功能: 
    /// 时间: 2011/8/30 21:47:48
    /// 作者: lmm_wss
    /// </summary>
    public partial class frmBase : Form
    {
        #region 构造和析构

        public frmBase()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();
        }

        #endregion // 构造和析构

        private void frmBase_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.FormLoadFunction(sender, e);

                SetFormControlFont(this);
            }
        }

        #region 公有方法
        #endregion // 公有方法

        #region 保护方法

        protected virtual void SetFormControlFont(Control cr)
        {
            foreach (Control c in cr.Controls)
            {
                if (c.Font.Size < XCommon.gFontSize)
                {
                    c.Font = new Font("宋体", XCommon.gFontSize);
                }
                
                if (c.HasChildren)
                {
                    SetFormControlFont(c);
                }
            }
        }

        /// <summary>
        /// 通过授权设置控件
        /// </summary>
        protected virtual void SetFormControlByAuthon()
        {
            foreach (Control c in this.Controls)
            {
                this.SetControlStatus(c);
            }
        }

        /// <summary>
        /// 设置控件状态
        /// </summary>
        /// <param name="c"></param>
        protected virtual void SetControlStatus(Control c)
        {
            if (!this.GetControlEnableFromAuthon(c))
            {
                if (c is DataGridView)
                {
                    //如果是网格
                    DataGridView gridView = c as DataGridView;
                    gridView.DataSource = null;
                    gridView.Refresh();
                    gridView.Enabled = false;
                }
                else
                {
                    c.Enabled = false;
                }
                if (c.HasChildren)
                {
                    foreach (Control childControl in c.Controls)
                    {
                        this.SetControlStatus(childControl);
                    }
                }
            }
        }


        /// <summary>
        /// 通过授权递归获得控件是否可用
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        protected virtual bool GetControlEnableFromAuthon(Control c)
        {
            return true;
        }

        protected virtual void FormLoadFunction(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.SetFormControlByAuthon();
        }

        #endregion // 保护方法

        #region 私有方法
        #endregion // 私有方法

        #region 属性及其私有变量

        /// <summary>
        /// 错误信息
        /// </summary>
        protected string m_ErrorInfo = "";

        /// <summary>
        /// 关键字：用来打开窗体时不会重复打开
        /// </summary>
        public virtual string Key
        {
            get { return this.ToString(); }
        }

        #endregion // 属性及其私有变量

        private void frmBase_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// 用户Id
        /// </summary>
        protected virtual string UserId
        {
            get { return XCommon.LoginUsersInfo.RID; }
        }

        /// <summary>
        /// 获取工作岗位
        /// </summary>
        protected virtual string JobCode
        {
            get { return string.Empty; }
        }
    }
}

