using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.DAL
{
    public partial class XFactory
    {
        public virtual XCodeCItemProvider GetCodeCItemProvider()
        {
            return new XCodeCItemProvider();
        }
        public virtual XCodeDefProvider GetCodeDefProvider()
        {
            return new XCodeDefProvider();
        }
        public virtual XCodeEquipmentCustTypeProvider GetCodeEquipmentCustTypeProvider()
        {
            return new XCodeEquipmentCustTypeProvider();
        }
        public virtual XCodeEquipmentStateProvider GetCodeEquipmentStateProvider()
        {
            return new XCodeEquipmentStateProvider();
        }
        public virtual XCodeEquipmentTypeProvider GetCodeEquipmentTypeProvider()
        {
            return new XCodeEquipmentTypeProvider();
        }
        public virtual XCodeFileLevelProvider GetCodeFileLevelProvider()
        {
            return new XCodeFileLevelProvider();
        }
        public virtual XCodeFileStateProvider GetCodeFileStateProvider()
        {
            return new XCodeFileStateProvider();
        }
        public virtual XCodeFileTypeProvider GetCodeFileTypeProvider()
        {
            return new XCodeFileTypeProvider();
        }
        public virtual XCodeFolderTypeProvider GetCodeFolderTypeProvider()
        {
            return new XCodeFolderTypeProvider();
        }
        public virtual XCodeProjectTypeProvider GetCodeProjectTypeProvider()
        {
            return new XCodeProjectTypeProvider();
        }
        public virtual XCodeStandStatusProvider GetCodeStandStatusProvider()
        {
            return new XCodeStandStatusProvider();
        }
        public virtual XCodeTaskTypeProvider GetCodeTaskTypeProvider()
        {
            return new XCodeTaskTypeProvider();
        }
        public virtual XCodeTempPssStateProvider GetCodeTempPssStateProvider()
        {
            return new XCodeTempPssStateProvider();
        }
        public virtual XCodeUserStateProvider GetCodeUserStateProvider()
        {
            return new XCodeUserStateProvider();
        }
        public virtual XCodeUserTypeProvider GetCodeUserTypeProvider()
        {
            return new XCodeUserTypeProvider();
        }
        public virtual XDeleteValidateRuleProvider GetDeleteValidateRuleProvider()
        {
            return new XDeleteValidateRuleProvider();
        }
        public virtual XEquipmentCheckProvider GetEquipmentCheckProvider()
        {
            return new XEquipmentCheckProvider();
        }
        public virtual XEquipmentCustProvider GetEquipmentCustProvider()
        {
            return new XEquipmentCustProvider();
        }
        public virtual XEquipmentDetectProvider GetEquipmentDetectProvider()
        {
            return new XEquipmentDetectProvider();
        }
        public virtual XEquipmentPDFReportProvider GetEquipmentPDFReportProvider()
        {
            return new XEquipmentPDFReportProvider();
        }
        public virtual XEquipmentReceiveProvider GetEquipmentReceiveProvider()
        {
            return new XEquipmentReceiveProvider();
        }
        public virtual XFileAttachmentProvider GetFileAttachmentProvider()
        {
            return new XFileAttachmentProvider();
        }
        public virtual XFileListProvider GetFileListProvider()
        {
            return new XFileListProvider();
        }
        public virtual XLoginLogProvider GetLoginLogProvider()
        {
            return new XLoginLogProvider();
        }
        public virtual XMeetingProjectProvider GetMeetingProjectProvider()
        {
            return new XMeetingProjectProvider();
        }
        public virtual XPassWord4FileProvider GetPassWord4FileProvider()
        {
            return new XPassWord4FileProvider();
        }
        public virtual XPassWordTmpProvider GetPassWordTmpProvider()
        {
            return new XPassWordTmpProvider();
        }
        public virtual XRemindConfigProvider GetRemindConfigProvider()
        {
            return new XRemindConfigProvider();
        }
        public virtual XRemindRolesProvider GetRemindRolesProvider()
        {
            return new XRemindRolesProvider();
        }
        public virtual XRemindUsersProvider GetRemindUsersProvider()
        {
            return new XRemindUsersProvider();
        }
        public virtual XRoleProvider GetRoleProvider()
        {
            return new XRoleProvider();
        }
        public virtual XRoleMenusProvider GetRoleMenusProvider()
        {
            return new XRoleMenusProvider();
        }
        public virtual XStaffCertificateProvider GetStaffCertificateProvider()
        {
            return new XStaffCertificateProvider();
        }
        public virtual XStaffCItemProvider GetStaffCItemProvider()
        {
            return new XStaffCItemProvider();
        }
        public virtual XStaffInfoProvider GetStaffInfoProvider()
        {
            return new XStaffInfoProvider();
        }
        public virtual XStandardProvider GetStandardProvider()
        {
            return new XStandardProvider();
        }
        public virtual XStandCheckRecordProvider GetStandCheckRecordProvider()
        {
            return new XStandCheckRecordProvider();
        }
        public virtual XStandCodeEquipmentProvider GetStandCodeEquipmentProvider()
        {
            return new XStandCodeEquipmentProvider();
        }
        public virtual XStandEquipmentProvider GetStandEquipmentProvider()
        {
            return new XStandEquipmentProvider();
        }
        public virtual XStandEquipmentCheckRecordProvider GetStandEquipmentCheckRecordProvider()
        {
            return new XStandEquipmentCheckRecordProvider();
        }
        public virtual XStandFilesProvider GetStandFilesProvider()
        {
            return new XStandFilesProvider();
        }
        public virtual XStandFilesCheckRecordProvider GetStandFilesCheckRecordProvider()
        {
            return new XStandFilesCheckRecordProvider();
        }
        public virtual XTableDictProvider GetTableDictProvider()
        {
            return new XTableDictProvider();
        }
        public virtual XTaskProvider GetTaskProvider()
        {
            return new XTaskProvider();
        }
        public virtual XTaskAttachmentProvider GetTaskAttachmentProvider()
        {
            return new XTaskAttachmentProvider();
        }
        public virtual XTaskFilesProvider GetTaskFilesProvider()
        {
            return new XTaskFilesProvider();
        }
        public virtual XTemplateProvider GetTemplateProvider()
        {
            return new XTemplateProvider();
        }
        public virtual XTemplateBillProvider GetTemplateBillProvider()
        {
            return new XTemplateBillProvider();
        }
        public virtual XTemplateCatalogProvider GetTemplateCatalogProvider()
        {
            return new XTemplateCatalogProvider();
        }
        public virtual XTemplateCatalogItemProvider GetTemplateCatalogItemProvider()
        {
            return new XTemplateCatalogItemProvider();
        }
        public virtual XTemplateItemProvider GetTemplateItemProvider()
        {
            return new XTemplateItemProvider();
        }
        public virtual XUseDeptProvider GetUseDeptProvider()
        {
            return new XUseDeptProvider();
        }
        public virtual XUseDeptFolderProvider GetUseDeptFolderProvider()
        {
            return new XUseDeptFolderProvider();
        }
        public virtual XUseErroLogProvider GetUseErroLogProvider()
        {
            return new XUseErroLogProvider();
        }
        public virtual XUseFileLogProvider GetUseFileLogProvider()
        {
            return new XUseFileLogProvider();
        }
        public virtual XUseOperateLogProvider GetUseOperateLogProvider()
        {
            return new XUseOperateLogProvider();
        }
        public virtual XUsersProvider GetUsersProvider()
        {
            return new XUsersProvider();
        }
        public virtual XUsersRoleProvider GetUsersRoleProvider()
        {
            return new XUsersRoleProvider();
        }
        public virtual XUseUserDeptProvider GetUseUserDeptProvider()
        {
            return new XUseUserDeptProvider();
        }
    }
}