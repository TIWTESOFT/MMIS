using MMIS.BLL;
using MMIS.Model;
using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI
{
    public partial class frmMain : frmMainBase
    {
        private TaskbarNotifier m_TaskbarNotifier;

        public frmMain()
        {
            InitializeComponent();

           
        }

        protected override string GetLoginUserId()
        {
            return XCommon.LoginUsersInfo.ID;
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.cmdEditPass.Click += cmdEditPass_Click;
            this.ShowRemind();
            this.InitVersion();
            this.cmdSystemConfig.Click += cmdSystemConfig_Click;

            this.Text = ConfigurationManager.AppSettings["SystemName"];

            XSystemConfigTool tool = new XSystemConfigTool();
            XUICommon.SystemConfigInfo = tool.GetConfigInfo();
        }

        void cmdSystemConfig_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            frmSystemConfig frm = new frmSystemConfig();
            frm.ShowDialog();
        }

        private void InitVersion()
        {
            this.lblLoginUser.Text = "登陆人：" + XCommon.LoginUsersInfo.RealName;
            this.lblVersion.Text = "版本： V1.0.0";
            this.lblVersionTime.Text = "版本时间：2014-10-19 09:00:00";// +versionTime;
        }

        private void ShowRemind()
        {
            XVoucherRemindBusiness m_VoucherRemindBusiness = new XVoucherRemindBusiness();
            DataTable remindInfoTable = m_VoucherRemindBusiness.GetVoucherRemind(XCommon.LoginUsersInfo.RID);

            XTaskBusiness taskBusiness = new XTaskBusiness();
            DataTable taskToDoTable = taskBusiness.GetTaskToDo(XCommon.LoginUsersInfo.RID);

            if (remindInfoTable.Rows.Count > 0 || taskToDoTable.Rows.Count > 0)
            {
                frmRemindList frm = new frmRemindList(remindInfoTable, taskToDoTable);
                this.ShowTabbedMdi(frm);
            }
        }

        void cmdEditPass_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
        {
            frmEditPassword frm = new frmEditPassword();
            frm.ShowDialog();
        }

        protected override bool IsAdmin
        {
            get
            {
                return XCommon.LoginUsersInfo.IsAdmin;
            }
        }

        [DllImport("kernel32.dll", EntryPoint = "SetProcessWorkingSetSize")]
        public static extern int SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);

        /// <summary> 
        /// 释放内存 
        /// </summary> 
        public static void ClearMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(System.Diagnostics.Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        private void tmDispose_Tick(object sender, EventArgs e)
        {
            ClearMemory();
        }


        private void InitNotifier()
        {
            Image skinBmp = Bitmap.FromFile("images/skin.bmp");
            Image closeBmp = Bitmap.FromFile("images/close.bmp");

            this.m_TaskbarNotifier = new TaskbarNotifier();
            m_TaskbarNotifier.SetBackgroundBitmap(skinBmp, Color.FromArgb(255, 0, 255));
            m_TaskbarNotifier.SetCloseBitmap(closeBmp, Color.FromArgb(255, 0, 255), new Point(127, 8));
            m_TaskbarNotifier.TitleRectangle = new Rectangle(40, 9, 70, 25);
            m_TaskbarNotifier.ContentRectangle = new Rectangle(8, 41, 133, 68);
            m_TaskbarNotifier.KeepVisibleOnMousOver = true;
            m_TaskbarNotifier.ContentClick += m_TaskbarNotifier_ContentClick;
        }

        void m_TaskbarNotifier_ContentClick(object sender, EventArgs e)
        {
            frmTreeTaskFileList frm = new frmTreeTaskFileList();
            this.ShowTabbedMdi(frm);
        }

        private void tmTask_Tick(object sender, EventArgs e)
        {
            string userId = XCommon.LoginUsersInfo.RID;
            XTaskBusiness taskBusiness = new XTaskBusiness();
            bool isHaveTask = taskBusiness.IsHaveTaskToDo(userId);
            if (isHaveTask)
            {
                this.m_TaskbarNotifier.Show("提示", "您有任务需要提交！", 500, 3000, 500);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

    }
}
