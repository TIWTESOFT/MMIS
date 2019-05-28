using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MMIS.BLL;
using MMIS.UI.Common;
using MMIS.Model;
using MMIS.Helper;
using MMIS.Component;
using System.IO;

namespace MMIS.UI
{
    public partial class frmStaffInfoEdit : frmDetailEditBase
    {
        private XFileAttachmentBusiness m_FileAttachBusiness = new XFileAttachmentBusiness();

        protected bool m_IsFormLoad = false;

        private string m_OldUserId = string.Empty;

        /// <summary>
        /// 业务逻辑操作对象
        /// </summary>
        private XStaffInfoBusiness m_StaffInfoBusiness = new XStaffInfoBusiness();
        private XCodeCItemBusiness m_ItemBusiness = new XCodeCItemBusiness();

        #region 构造函数

        /// 添加构造函数
        /// </summary>
        /// <param name="gridTable">要添加的对象集合</param>
        public frmStaffInfoEdit(IList<XModelBase> modelList)
        {
            InitializeComponent();
            this.m_ModelList = modelList;
            this.m_EditStatus = XEditStatus.AddNew;
        }

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="currentRow">要编辑的记录</param>
        public frmStaffInfoEdit(XModelBase currentModel)
        {
            InitializeComponent();
            this.m_CurrentModel = currentModel;
            this.m_EditStatus = XEditStatus.Edit;
            this.SetDefaultValue();
        }


        #endregion


        /// <summary>
        /// 获取业务操作对象
        /// </summary>
        /// <returns></returns>
        protected override XBusinessBase InitBusiness()
        {
            return new XStaffInfoBusiness();
        }

        /// <summary>
        /// 初始化创建对象
        /// </summary>
        /// <returns></returns>
        protected override XModelBase InitNewModel()
        {
            return new XVStaffInfoInfo();
        }

        /// <summary>
        /// 设置修改时的默认值
        /// </summary>
        protected override void SetDefaultValue()
        {
            XVStaffInfoInfo info = this.m_CurrentModel as XVStaffInfoInfo;


            this.txtUserName.Text = info.UserName;
            this.txtUserSex.Text = info.UserSex;
            this.txtNationality.Text = info.Nationality;
            this.nebUserAge.Value = info.UserAge;
            this.dtBirthday.Value = XHelper.GetDateTime(info.Birthday);
            this.txtNativePlace.Text = info.NativePlace;
            this.dtStartWorkDate.Value = XHelper.GetDateTime(info.StartWorkDate);
            this.dtToCompWorkDate.Value = XHelper.GetDateTime(info.ToCompWorkDate);
            this.txtPersonID.Text = info.PersonID;
            this.txtSpecialty.Text = info.Specialty;
            this.txtHouseHoldAddr.Text = info.HouseHoldAddr;
            this.txtHomeAddress.Text = info.HomeAddress;
            this.txtHomeTel.Text = info.HomeTel;
            this.txtMobileNo.Text = info.MobileNo;
            this.txtWorkTel.Text = info.WorkTel;
            this.txtEducation.Text = info.Education;
            this.txtMajor.Text = info.Major;
            this.txtUniversity.Text = info.University;
            this.nebMeasureWorkYears.Value = info.MeasureWorkYears;
            this.txtMeasureWorkContent.Text = info.MeasureWorkContent;

            if (info.DeptId != string.Empty)
            {
                this.txtDeptId.Text = info.DeptName;
                this.txtDeptId.ValueMember = info.DeptId;
                this.txtDeptId.DisplayMember = info.DeptName;
            }

            this.txtPost.Text = info.Post;
            this.txtRoleId.Text = info.RoleId;

            if (info.UserId != string.Empty)
            {
                this.txtUserId.Text = info.LoginUserName;
                this.txtUserId.ValueMember = info.UserId;
                this.txtUserId.DisplayMember = info.LoginUserName;

                this.m_OldUserId = info.UserId;
            }

            this.txtRemark.Text = info.Remark;
        }


        /// <summary>
        /// 自定义UI校验
        /// </summary>
        /// <returns></returns>
        protected override bool ValidateCustom()
        {
            bool isValidateExist = false;

            string userId = this.txtUserId.ValueMember;

            if (userId != string.Empty)
            {
                if (this.m_EditStatus == XEditStatus.AddNew)
                {
                    isValidateExist = true;
                }
                else if (this.m_EditStatus == XEditStatus.Edit)
                {
                    if (this.m_OldUserId != this.txtUserId.ValueMember)
                    {
                        isValidateExist = true;
                    }
                }

                if (isValidateExist)
                {
                    XStaffInfoBusiness business = this.m_Business as XStaffInfoBusiness;
                    if (business.IsUserIdHaveStaff(userId))
                    {
                        XMessageBox.ShowError("该关联用户已经关联其他人员信息！");
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 填充实体信息
        /// </summary>
        protected override void FillModelInfo()
        {
            XVStaffInfoInfo info = this.m_CurrentModel as XVStaffInfoInfo;

            if (this.m_EditStatus == XEditStatus.AddNew)
            {
                info.RID = this.GetNewId();
            }

            info.UserName = this.txtUserName.Text;
            info.UserSex = this.txtUserSex.Text;
            info.Nationality = this.txtNationality.Text;
            info.UserAge = XHelper.GetInt(this.nebUserAge.Value);
            info.Birthday = XHelper.GetFormatedDate(this.dtBirthday.Value);
            info.NativePlace = this.txtNativePlace.Text;
            info.StartWorkDate = XHelper.GetFormatedDate(this.dtStartWorkDate.Value);
            info.ToCompWorkDate = XHelper.GetFormatedDate(this.dtToCompWorkDate.Value);
            info.PersonID = this.txtPersonID.Text;
            info.Specialty = this.txtSpecialty.Text;
            info.HouseHoldAddr = this.txtHouseHoldAddr.Text;
            info.HomeAddress = this.txtHomeAddress.Text;
            info.HomeTel = this.txtHomeTel.Text;
            info.MobileNo = this.txtMobileNo.Text;
            info.WorkTel = this.txtWorkTel.Text;
            info.Education = this.txtEducation.Text;
            info.Major = this.txtMajor.Text;
            info.University = this.txtUniversity.Text;
            info.MeasureWorkYears = XHelper.GetInt(this.nebMeasureWorkYears.Value);
            info.MeasureWorkContent = this.txtMeasureWorkContent.Text;
            info.DeptId = this.txtDeptId.ValueMember;
            info.DeptName = this.txtDeptId.DisplayMember;
            info.Post = this.txtPost.Text;
            info.RoleId = this.txtRoleId.Text;
            info.UserId = this.txtUserId.ValueMember;
            info.LoginUserName = this.txtUserId.DisplayMember;
            info.Remark = this.txtRemark.Text;

            if (this.txtFilePath.Text.Trim() != string.Empty)
            {
                info.FileName = this.txtFilePath.Text.Trim();
            }

            base.FillModelInfo();
        }

        /// <summary>
        /// 初始化审批的文件CheckBox
        /// </summary>
        protected virtual void InitItemCheckBoxes()
        {
            IList<XModelBase> documents = this.m_ItemBusiness.GetAll();

            int xStart = 30;//x开始距离
            int yStart = 10;//y开始距离
            int xDistance = 240;//横向距离
            int yDistance = 30;//纵向距离
            int perRowCount = 3;//每行的数量

            int loopNo = 0;

            foreach (XModelBase model in documents)
            {
                XCodeCItemInfo itemInfo = model as XCodeCItemInfo;

                XCheckBox checkBox = new XCheckBox();
                checkBox.Text = itemInfo.NameCN;
                checkBox.Model = itemInfo;
                checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);

                int x = xStart + (loopNo % perRowCount) * xDistance;
                int y = yStart + (loopNo / perRowCount) * yDistance;

                checkBox.Location = new Point(x, y);
                checkBox.AutoSize = true;
                this.pnlItems.Controls.Add(checkBox);

                if (this.IsHaveItem(itemInfo))
                {
                    checkBox.Checked = true;
                }

                loopNo += 1;
            }

            this.pnlItems.BringToFront();
        }

        /// <summary>
        /// 是否有这个证件
        /// </summary>
        /// <param name="itemInfo"></param>
        /// <returns></returns>
        private bool IsHaveItem(XCodeCItemInfo itemInfo)
        {
            if (this.m_DetailLists == null)
            {
                return false;
            }
            foreach (XModelBase model in this.m_DetailLists)
            {
                XStaffCItemInfo staffItemInfo = model as XStaffCItemInfo;
                if (staffItemInfo.CItemId == itemInfo.RID)
                {
                    return true;
                }
            }
            return false;
        }

        void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!m_IsFormLoad)
            {
                //在不是窗体加载的情况下
                this.m_DetailLists.Clear();
                foreach (Control c in this.pnlItems.Controls)
                {
                    if (c is XCheckBox)
                    {
                        XCheckBox checkBox = c as XCheckBox;
                        if (checkBox.Checked)
                        {
                            XVStaffCItemInfo staffItemInfo = new XVStaffCItemInfo();
                            staffItemInfo.RID = Guid.NewGuid().ToString();
                            staffItemInfo.UserId = this.m_PrimaryKeyId;
                            staffItemInfo.InputUserId = XCommon.LoginUsersInfo.RID;
                            staffItemInfo.NameCN = checkBox.Text;
                            XCodeCItemInfo itemInfo = checkBox.Model as XCodeCItemInfo;
                            staffItemInfo.CItemId = itemInfo.RID;
                            this.m_DetailLists.Add(staffItemInfo);
                        }
                    }
                }
            }
        }

        protected override XBusinessBase InitDetailBusiness()
        {
            return new XStaffCItemBusiness();
        }

        protected override void FormLoadFunction(object sender, EventArgs e)
        {
            base.FormLoadFunction(sender, e);
            this.m_IsFormLoad = true;
            this.InitItemCheckBoxes();
            this.m_IsFormLoad = false;
        }

        private void txtFilePath_ButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "电子签章文件(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtFilePath.Text = ofd.FileName;
            }
        }

        private void txtFilePath_DoubleClick(object sender, EventArgs e)
        {
            txtFilePath_ButtonClick(null, null);
        }

        protected override void SavedAfterOperate()
        {
            string filePath = this.txtFilePath.Text.Trim();

            if (filePath != string.Empty)
            {
                if (File.Exists(filePath))
                {
                    XStaffInfoInfo fileInfo = this.m_CurrentModel as XStaffInfoInfo;

                    if (!this.m_FileAttachBusiness.InsertFile(Guid.NewGuid().ToString(),
                        fileInfo.RID, filePath, XCommon.LoginUsersInfo.RID))
                    {
                        XMessageBox.ShowError("上传附件失败，请点击修改重新上传附件！");
                    }
                }
            }
        }

    }
}