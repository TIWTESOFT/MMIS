using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Data;
using MMIS.FolderModel;
using MMIS.Model;

namespace MMIS.FolderMenu
{

    public delegate void MenuClickHandler(XMenuInfo menuInfo, EventArgs e);

    public class XMenuTool
    {

        /// <summary>
        /// 菜单单击事件
        /// </summary>
        public event MenuClickHandler MenuClickEvent;

        private Janus.Windows.UI.Dock.UIPanelGroup m_MenuPanel;

        private IList<XModelBase> m_MenuFolderInfos = null;

        public XMenuTool(Janus.Windows.UI.Dock.UIPanelGroup menuPanel, IList<XModelBase> menuFolderInfos)
        {
            this.m_MenuPanel = menuPanel;
            this.m_MenuFolderInfos = menuFolderInfos;
            this.InitFolders();
        }

        public DataSet GetFolderDataSet()
        {
            DataSet folderSet = new DataSet();

            foreach (XMenuFolderInfo folderInfo in this.m_MenuFolderInfos)
            {
                XMenuFolder menuFolder = this.MenuInfo2MenuFolder(folderInfo);
                folderSet.Tables.Add(menuFolder);
            }

            return folderSet;
        }

        public XMenuFolder MenuInfo2MenuFolder(XMenuFolderInfo folderInfo)
        {
            XMenuFolder menuTable = new XMenuFolder();

            menuTable.FolderName = folderInfo.FolderName;
            menuTable.Image = folderInfo.ImageFile;
            menuTable.LargeImage = folderInfo.LargeImageFile;
            menuTable.Title = folderInfo.Title;

            foreach (XMenuGroupInfo groupInfo in folderInfo.MenuGroupInfos)
            {
                foreach (XMenuInfo menuInfo in groupInfo.Menus)
                {
                    DataRow menuRow = menuTable.NewRow();

                    XMenuInfoTool.MenuInfo2MenuRow(menuInfo, menuRow);

                    menuTable.Rows.Add(menuRow);
                }
            }

            return menuTable;
        }

        protected virtual void OnMenuClick(XMenuInfo menuInfo, EventArgs e)
        {
            if (this.MenuClickEvent != null)
            {
                this.MenuClickEvent(menuInfo, e);
            }
        }


        public void InitFolders()
        {
            DataSet folders = this.GetFolderDataSet();

            foreach (XMenuFolder f in folders.Tables)
            {
                InitFolder(f);
            }
        }


        public void InitFolder(XMenuFolder folder)
        {
            if (folder.Rows.Count > 0)
            {
                Janus.Windows.GridEX.GridEX grid;
                Janus.Windows.UI.Dock.UIPanelInnerContainer container = GetFolderContainer(folder);
                Janus.Windows.UI.Dock.UIPanel panel = GetFolderPanel(folder);
                Janus.Windows.UI.Dock.UIPanelGroup group = GetFolderPanelGroup(folder);
                grid = GetFolderGrid(folder);

                container.Dock = DockStyle.Fill;
                panel.Controls.Add(container);
                panel.DockStyle = Janus.Windows.UI.Dock.PanelDockStyle.Fill;
                group.Panels.Add(panel);
                m_MenuPanel.Panels.Add(group);
                group.Tag = grid;
                grid.Font = new Font("微软雅黑", 10);
                grid.Dock = DockStyle.Fill;
                container.Controls.Add(grid);
                grid.Click += new EventHandler(grid_Click);
            }
        }

        void grid_Click(object sender, EventArgs e)
        {
            Janus.Windows.GridEX.GridEX gridEx = sender as Janus.Windows.GridEX.GridEX;
            if (gridEx != null)
            {
                if (gridEx.CurrentRow != null && gridEx.CurrentRow.RowType == Janus.Windows.GridEX.RowType.Record)
                {
                    DataRow currentRow = ((System.Data.DataRowView)(gridEx.CurrentRow.DataRow)).Row;
                    XMenuInfo menuInfo = XMenuInfoTool.MenuRow2MenuInfo(currentRow);
                    this.OnMenuClick(menuInfo, new EventArgs());

                }
            }
        }

        protected Janus.Windows.UI.Dock.UIPanelInnerContainer GetFolderContainer(XMenuFolder folder)
        {
            Janus.Windows.UI.Dock.UIPanelInnerContainer inner = new Janus.Windows.UI.Dock.UIPanelInnerContainer();
            inner.Location = new System.Drawing.Point(1, 1);
            inner.Name = folder.FolderName + "Container";
            inner.Dock = DockStyle.Fill;
            inner.TabIndex = 0;

            return inner;
        }


        protected Janus.Windows.UI.Dock.UIPanel GetFolderPanel(XMenuFolder folder)
        {
            Janus.Windows.UI.Dock.UIPanel panel = new Janus.Windows.UI.Dock.UIPanel();
            panel.ActiveCaptionMode = Janus.Windows.UI.Dock.ActiveCaptionMode.Never;
            panel.CaptionFormatStyle.FontSize = 10;
            panel.CaptionStyle = Janus.Windows.UI.Dock.PanelCaptionStyle.Light;
            panel.CaptionVisible = Janus.Windows.UI.InheritableBoolean.False;
            panel.ImageIndex = 7;
            panel.Location = new System.Drawing.Point(0, 27);
            panel.Name = folder.FolderName + "Panel";
            panel.Size = new System.Drawing.Size(230, 249);
            panel.Id = Guid.NewGuid();
            return panel;
        }

        protected Janus.Windows.UI.Dock.UIPanelGroup GetFolderPanelGroup(XMenuFolder folder)
        {
            Janus.Windows.UI.Dock.UIPanelGroup group = new Janus.Windows.UI.Dock.UIPanelGroup();

            group.ActiveCaptionMode = Janus.Windows.UI.Dock.ActiveCaptionMode.Never;
            group.CaptionFormatStyle.FontBold = Janus.Windows.UI.TriState.True;
            group.CaptionFormatStyle.FontSize = 12;
            if (ValidateImage(folder.Image))
            {
                group.Image = Image.FromFile(folder.Image);
            }
            if (ValidateImage(folder.LargeImage))
            {
                group.Image = Image.FromFile(folder.LargeImage);
            }

            group.Location = new System.Drawing.Point(0, 0);
            group.Name = folder.FolderName;
            group.Size = new System.Drawing.Size(230, 276);
            group.Text = folder.Title;
            group.StaticGroup = true;
            group.Id = Guid.NewGuid();
            group.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;

            return group;
        }

        protected Janus.Windows.GridEX.GridEX GetFolderGrid(XMenuFolder folder)
        {
            Janus.Windows.GridEX.GridEX grid = new Janus.Windows.GridEX.GridEX();
            grid.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
            grid.ColumnAutoResize = true;
            grid.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            grid.Dock = DockStyle.Fill;
            grid.Font = new Font("微软雅黑", 10);
            grid.GridLines = Janus.Windows.GridEX.GridLines.None;
            grid.GroupByBoxFormatStyle.BackColor = Color.White;
            grid.GroupByBoxVisible = false;
            grid.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            grid.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Black;
            grid.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.UseRowStyle;
            grid.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;

            grid.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            grid.Location = new System.Drawing.Point(0, 0);
            grid.Name = folder.FolderName;
            grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;

            grid.RootTable = new Janus.Windows.GridEX.GridEXTable();

            grid.RootTable.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.True;

            AddGridColumns(grid);

            grid.RootTable.Groups.Add("FolderGroup");
            grid.RootTable.Groups[0].GroupPrefix = "";

            grid.DataSource = folder;

            return grid;
        }

        private void AddGridColumns(Janus.Windows.GridEX.GridEX grid)
        {
            AddGridColumn(grid, "FolderGroup", true, 300);
            AddGridColumn(grid, "FolderName", true, 300);
            AddGridColumn(grid, "FolderOrder", false, 300);
        }

        private void AddGridColumn(Janus.Windows.GridEX.GridEX grid, string dataMember, bool visible, int width = 200)
        {
            Janus.Windows.GridEX.GridEXColumn c1 = new Janus.Windows.GridEX.GridEXColumn();
            c1.DataMember = dataMember;
            grid.RootTable.Columns.Add(c1);
            c1.Visible = visible;
            c1.Width = width;
            c1.Key = dataMember;
            c1.Selectable = false;
        }

        private bool ValidateImage(string image)
        {
            if (image == string.Empty || !File.Exists(image))
            {
                return false;
            }
            return true;
        }



    }
}
