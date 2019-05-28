namespace MMIS.UI
{
    partial class frmTreeTaskFileList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.GridEX.GridEXLayout grdFiles_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTreeTaskFileList));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode(" ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("44444444444", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            MMIS.Model.XVTaskInfo xvTaskInfo1 = new MMIS.Model.XVTaskInfo();
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("55");
            MMIS.Model.XVTaskInfo xvTaskInfo2 = new MMIS.Model.XVTaskInfo();
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("22");
            MMIS.Model.XVTaskInfo xvTaskInfo3 = new MMIS.Model.XVTaskInfo();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode(" ");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("8888888", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            MMIS.Model.XVTaskInfo xvTaskInfo4 = new MMIS.Model.XVTaskInfo();
            Janus.Windows.GridEX.GridEXLayout grdTaskAttach_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.cmTaskFiles = new Janus.Windows.UI.CommandBars.UIContextMenu();
            this.cmdNewFiles1 = new Janus.Windows.UI.CommandBars.UICommand("cmdNewFiles");
            this.cmdEditFile1 = new Janus.Windows.UI.CommandBars.UICommand("cmdEditFile");
            this.cmdDeleteFile1 = new Janus.Windows.UI.CommandBars.UICommand("cmdDeleteFile");
            this.cmdNewFiles = new Janus.Windows.UI.CommandBars.UICommand("cmdNewFiles");
            this.cmdEditFile = new Janus.Windows.UI.CommandBars.UICommand("cmdEditFile");
            this.cmdDeleteFile = new Janus.Windows.UI.CommandBars.UICommand("cmdDeleteFile");
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmTaskMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmTaskFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // xCommandManager1
            // 
            this.xCommandManager1.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdNewFiles,
            this.cmdEditFile,
            this.cmdDeleteFile});
            this.xCommandManager1.ContextMenus.AddRange(new Janus.Windows.UI.CommandBars.UIContextMenu[] {
            this.cmTaskFiles});
            // 
            // grdFiles
            // 
            grdFiles_DesignTimeLayout.LayoutString = resources.GetString("grdFiles_DesignTimeLayout.LayoutString");
            this.grdFiles.DesignTimeLayout = grdFiles_DesignTimeLayout;
            this.grdFiles.Size = new System.Drawing.Size(738, 23);
            // 
            // tvTask
            // 
            this.tvTask.LineColor = System.Drawing.Color.Black;
            treeNode1.Name = "";
            treeNode1.Text = " ";
            treeNode2.Name = "";
            xvTaskInfo1.AssignPeople = "222";
            xvTaskInfo1.AssignPeopleName = "";
            xvTaskInfo1.Content = "222";
            xvTaskInfo1.DispatchDate = "2014-10-08";
            xvTaskInfo1.ID = "201410081255555883463";
            xvTaskInfo1.InputTime = "2014-10-08 12:55:55";
            xvTaskInfo1.InputUserId = "Admin";
            xvTaskInfo1.IsDeleted = false;
            xvTaskInfo1.ModelStatus = MMIS.Model.XModelStatus.None;
            xvTaskInfo1.ParentId = "";
            xvTaskInfo1.ParentPreEndDate = "";
            xvTaskInfo1.ParentStartDate = "";
            xvTaskInfo1.ParentTaskName = "";
            xvTaskInfo1.ParentTaskNo = "";
            xvTaskInfo1.PreEndDate = "2014-10-08";
            xvTaskInfo1.Remark = "222";
            xvTaskInfo1.Require = "22";
            xvTaskInfo1.RID = "201410081255555883463";
            xvTaskInfo1.ShortDesc = "22";
            xvTaskInfo1.StartDate = "2014-10-08";
            xvTaskInfo1.StartPeople = "22";
            xvTaskInfo1.TaskName = "44444444444";
            xvTaskInfo1.TaskNo = "2";
            xvTaskInfo1.TaskStatus = "结束";
            xvTaskInfo1.TaskType = "";
            xvTaskInfo1.TaskTypeId = "22";
            xvTaskInfo1.TimeStamp = null;
            xvTaskInfo1.UpdateTime = "2014-10-08 12:55:55";
            xvTaskInfo1.UpdateUserId = "Admin";
            treeNode2.Tag = xvTaskInfo1;
            treeNode2.Text = "44444444444";
            treeNode2.ToolTipText = "44444444444";
            treeNode3.Name = "";
            xvTaskInfo2.AssignPeople = "555";
            xvTaskInfo2.AssignPeopleName = "";
            xvTaskInfo2.Content = "55";
            xvTaskInfo2.DispatchDate = "2014-10-08";
            xvTaskInfo2.ID = "201410081300598734494";
            xvTaskInfo2.InputTime = "2014-10-08 13:00:59";
            xvTaskInfo2.InputUserId = "Admin";
            xvTaskInfo2.IsDeleted = false;
            xvTaskInfo2.ModelStatus = MMIS.Model.XModelStatus.None;
            xvTaskInfo2.ParentId = "";
            xvTaskInfo2.ParentPreEndDate = "";
            xvTaskInfo2.ParentStartDate = "";
            xvTaskInfo2.ParentTaskName = "";
            xvTaskInfo2.ParentTaskNo = "";
            xvTaskInfo2.PreEndDate = "2014-10-08";
            xvTaskInfo2.Remark = "55555";
            xvTaskInfo2.Require = "55";
            xvTaskInfo2.RID = "201410081300598734494";
            xvTaskInfo2.ShortDesc = "555";
            xvTaskInfo2.StartDate = "2014-10-08";
            xvTaskInfo2.StartPeople = "555";
            xvTaskInfo2.TaskName = "55";
            xvTaskInfo2.TaskNo = "55";
            xvTaskInfo2.TaskStatus = "";
            xvTaskInfo2.TaskType = "";
            xvTaskInfo2.TaskTypeId = "55";
            xvTaskInfo2.TimeStamp = null;
            xvTaskInfo2.UpdateTime = "2014-10-08 13:00:59";
            xvTaskInfo2.UpdateUserId = "Admin";
            treeNode3.Tag = xvTaskInfo2;
            treeNode3.Text = "55";
            treeNode3.ToolTipText = "55";
            treeNode4.Name = "";
            xvTaskInfo3.AssignPeople = "201409272256169545942";
            xvTaskInfo3.AssignPeopleName = "张三";
            xvTaskInfo3.Content = "2";
            xvTaskInfo3.DispatchDate = "2014-11-20";
            xvTaskInfo3.ID = "4ed6d4c7-541f-4da3-a13f-4dacef477f6e";
            xvTaskInfo3.InputTime = "2014-11-20 22:03:06";
            xvTaskInfo3.InputUserId = "Admin";
            xvTaskInfo3.IsDeleted = false;
            xvTaskInfo3.ModelStatus = MMIS.Model.XModelStatus.None;
            xvTaskInfo3.ParentId = "";
            xvTaskInfo3.ParentPreEndDate = "";
            xvTaskInfo3.ParentStartDate = "";
            xvTaskInfo3.ParentTaskName = "";
            xvTaskInfo3.ParentTaskNo = "";
            xvTaskInfo3.PreEndDate = "2014-11-20";
            xvTaskInfo3.Remark = "222";
            xvTaskInfo3.Require = "2";
            xvTaskInfo3.RID = "4ed6d4c7-541f-4da3-a13f-4dacef477f6e";
            xvTaskInfo3.ShortDesc = "2";
            xvTaskInfo3.StartDate = "2014-11-20";
            xvTaskInfo3.StartPeople = "22";
            xvTaskInfo3.TaskName = "22";
            xvTaskInfo3.TaskNo = "222";
            xvTaskInfo3.TaskStatus = "开始";
            xvTaskInfo3.TaskType = "任务类型001";
            xvTaskInfo3.TaskTypeId = "201410072157196588595";
            xvTaskInfo3.TimeStamp = null;
            xvTaskInfo3.UpdateTime = "2014-11-20 22:28:07";
            xvTaskInfo3.UpdateUserId = "Admin";
            treeNode4.Tag = xvTaskInfo3;
            treeNode4.Text = "22";
            treeNode4.ToolTipText = "22";
            treeNode5.Name = "";
            treeNode5.Text = " ";
            treeNode6.Name = "";
            xvTaskInfo4.AssignPeople = "Admin";
            xvTaskInfo4.AssignPeopleName = "系统管理员";
            xvTaskInfo4.Content = "";
            xvTaskInfo4.DispatchDate = "2014-11-08";
            xvTaskInfo4.ID = "feea4f4d-f2e8-4bdc-94aa-b1d0ab2c072a";
            xvTaskInfo4.InputTime = "2014-11-08 22:56:38";
            xvTaskInfo4.InputUserId = "Admin";
            xvTaskInfo4.IsDeleted = false;
            xvTaskInfo4.ModelStatus = MMIS.Model.XModelStatus.None;
            xvTaskInfo4.ParentId = "";
            xvTaskInfo4.ParentPreEndDate = "";
            xvTaskInfo4.ParentStartDate = "";
            xvTaskInfo4.ParentTaskName = "";
            xvTaskInfo4.ParentTaskNo = "";
            xvTaskInfo4.PreEndDate = "2014-11-08";
            xvTaskInfo4.Remark = "";
            xvTaskInfo4.Require = "";
            xvTaskInfo4.RID = "feea4f4d-f2e8-4bdc-94aa-b1d0ab2c072a";
            xvTaskInfo4.ShortDesc = "";
            xvTaskInfo4.StartDate = "2014-11-08";
            xvTaskInfo4.StartPeople = "88";
            xvTaskInfo4.TaskName = "8888888";
            xvTaskInfo4.TaskNo = "88";
            xvTaskInfo4.TaskStatus = "开始";
            xvTaskInfo4.TaskType = "任务类型001";
            xvTaskInfo4.TaskTypeId = "201410072157196588595";
            xvTaskInfo4.TimeStamp = null;
            xvTaskInfo4.UpdateTime = "2014-11-08 22:56:38";
            xvTaskInfo4.UpdateUserId = "Admin";
            treeNode6.Tag = xvTaskInfo4;
            treeNode6.Text = "8888888";
            treeNode6.ToolTipText = "8888888";
            this.tvTask.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode6});
            this.tvTask.Size = new System.Drawing.Size(389, 408);
            // 
            // xQueryCombobox1
            // 
            this.xQueryCombobox1.SelectedIndex = 1;
            this.xQueryCombobox1.Text = "开始";
            // 
            // grdTaskAttach
            // 
            grdTaskAttach_DesignTimeLayout.LayoutString = resources.GetString("grdTaskAttach_DesignTimeLayout.LayoutString");
            this.grdTaskAttach.DesignTimeLayout = grdTaskAttach_DesignTimeLayout;
            // 
            // cmTaskFiles
            // 
            this.cmTaskFiles.CommandManager = this.xCommandManager1;
            this.cmTaskFiles.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.cmdNewFiles1,
            this.cmdEditFile1,
            this.cmdDeleteFile1});
            this.cmTaskFiles.Key = "cmTaskFiles";
            // 
            // cmdNewFiles1
            // 
            this.cmdNewFiles1.Key = "cmdNewFiles";
            this.cmdNewFiles1.Name = "cmdNewFiles1";
            // 
            // cmdEditFile1
            // 
            this.cmdEditFile1.Key = "cmdEditFile";
            this.cmdEditFile1.Name = "cmdEditFile1";
            // 
            // cmdDeleteFile1
            // 
            this.cmdDeleteFile1.Key = "cmdDeleteFile";
            this.cmdDeleteFile1.Name = "cmdDeleteFile1";
            // 
            // cmdNewFiles
            // 
            this.cmdNewFiles.Key = "cmdNewFiles";
            this.cmdNewFiles.Name = "cmdNewFiles";
            this.cmdNewFiles.Text = "提交文档";
            // 
            // cmdEditFile
            // 
            this.cmdEditFile.Key = "cmdEditFile";
            this.cmdEditFile.Name = "cmdEditFile";
            this.cmdEditFile.Text = "修改文档";
            // 
            // cmdDeleteFile
            // 
            this.cmdDeleteFile.Key = "cmdDeleteFile";
            this.cmdDeleteFile.Name = "cmdDeleteFile";
            this.cmdDeleteFile.Text = "删除文档";
            // 
            // frmTreeTaskFileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 445);
            this.Name = "frmTreeTaskFileList";
            this.Text = "任务填报";
            ((System.ComponentModel.ISupportInitialize)(this.xCommandManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmTaskMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTaskAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmTaskFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.CommandBars.UICommand cmdNewFiles;
        private Janus.Windows.UI.CommandBars.UICommand cmdEditFile;
        private Janus.Windows.UI.CommandBars.UICommand cmdDeleteFile;
        private Janus.Windows.UI.CommandBars.UIContextMenu cmTaskFiles;
        private Janus.Windows.UI.CommandBars.UICommand cmdNewFiles1;
        private Janus.Windows.UI.CommandBars.UICommand cmdEditFile1;
        private Janus.Windows.UI.CommandBars.UICommand cmdDeleteFile1;
    }
}