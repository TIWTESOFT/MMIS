using System;
using System.Collections.Generic;
using System.Text;
using MMIS.DAL;

namespace MMIS.DAL.SqlServer
{
    public partial class XSqlServerFactory : XFactory
    {
        public override XCodeCItemProvider GetCodeCItemProvider()
        {
            return new XSqlServerCodeCItemProvider();
        }
        public override XCodeDefProvider GetCodeDefProvider()
        {
            return new XSqlServerCodeDefProvider();
        }
        public override XCodeEquipmentCustTypeProvider GetCodeEquipmentCustTypeProvider()
        {
            return new XSqlServerCodeEquipmentCustTypeProvider();
        }
        public override XCodeEquipmentStateProvider GetCodeEquipmentStateProvider()
        {
            return new XSqlServerCodeEquipmentStateProvider();
        }
        public override XCodeEquipmentTypeProvider GetCodeEquipmentTypeProvider()
        {
            return new XSqlServerCodeEquipmentTypeProvider();
        }
        public override XCodeFileLevelProvider GetCodeFileLevelProvider()
        {
            return new XSqlServerCodeFileLevelProvider();
        }
        public override XCodeFileStateProvider GetCodeFileStateProvider()
        {
            return new XSqlServerCodeFileStateProvider();
        }
        public override XCodeFileTypeProvider GetCodeFileTypeProvider()
        {
            return new XSqlServerCodeFileTypeProvider();
        }
        public override XCodeFolderTypeProvider GetCodeFolderTypeProvider()
        {
            return new XSqlServerCodeFolderTypeProvider();
        }
        public override XCodeProjectTypeProvider GetCodeProjectTypeProvider()
        {
            return new XSqlServerCodeProjectTypeProvider();
        }
        public override XCodeStandStatusProvider GetCodeStandStatusProvider()
        {
            return new XSqlServerCodeStandStatusProvider();
        }
        public override XCodeTaskTypeProvider GetCodeTaskTypeProvider()
        {
            return new XSqlServerCodeTaskTypeProvider();
        }
        public override XCodeTempPssStateProvider GetCodeTempPssStateProvider()
        {
            return new XSqlServerCodeTempPssStateProvider();
        }
        public override XCodeUserStateProvider GetCodeUserStateProvider()
        {
            return new XSqlServerCodeUserStateProvider();
        }
        public override XCodeUserTypeProvider GetCodeUserTypeProvider()
        {
            return new XSqlServerCodeUserTypeProvider();
        }
        public override XDeleteValidateRuleProvider GetDeleteValidateRuleProvider()
        {
            return new XSqlServerDeleteValidateRuleProvider();
        }
        public override XEquipmentCheckProvider GetEquipmentCheckProvider()
        {
            return new XSqlServerEquipmentCheckProvider();
        }
        public override XEquipmentCustProvider GetEquipmentCustProvider()
        {
            return new XSqlServerEquipmentCustProvider();
        }
        public override XEquipmentDetectProvider GetEquipmentDetectProvider()
        {
            return new XSqlServerEquipmentDetectProvider();
        }
        public override XEquipmentPDFReportProvider GetEquipmentPDFReportProvider()
        {
            return new XSqlServerEquipmentPDFReportProvider();
        }
        public override XEquipmentReceiveProvider GetEquipmentReceiveProvider()
        {
            return new XSqlServerEquipmentReceiveProvider();
        }
        public override XFileAttachmentProvider GetFileAttachmentProvider()
        {
            return new XSqlServerFileAttachmentProvider();
        }
        public override XFileListProvider GetFileListProvider()
        {
            return new XSqlServerFileListProvider();
        }
        public override XLoginLogProvider GetLoginLogProvider()
        {
            return new XSqlServerLoginLogProvider();
        }
        public override XMeetingProjectProvider GetMeetingProjectProvider()
        {
            return new XSqlServerMeetingProjectProvider();
        }
        public override XPassWord4FileProvider GetPassWord4FileProvider()
        {
            return new XSqlServerPassWord4FileProvider();
        }
        public override XPassWordTmpProvider GetPassWordTmpProvider()
        {
            return new XSqlServerPassWordTmpProvider();
        }
        public override XRemindConfigProvider GetRemindConfigProvider()
        {
            return new XSqlServerRemindConfigProvider();
        }
        public override XRemindRolesProvider GetRemindRolesProvider()
        {
            return new XSqlServerRemindRolesProvider();
        }
        public override XRemindUsersProvider GetRemindUsersProvider()
        {
            return new XSqlServerRemindUsersProvider();
        }
        public override XRoleProvider GetRoleProvider()
        {
            return new XSqlServerRoleProvider();
        }
        public override XRoleMenusProvider GetRoleMenusProvider()
        {
            return new XSqlServerRoleMenusProvider();
        }
        public override XStaffCertificateProvider GetStaffCertificateProvider()
        {
            return new XSqlServerStaffCertificateProvider();
        }
        public override XStaffCItemProvider GetStaffCItemProvider()
        {
            return new XSqlServerStaffCItemProvider();
        }
        public override XStaffInfoProvider GetStaffInfoProvider()
        {
            return new XSqlServerStaffInfoProvider();
        }
        public override XStandardProvider GetStandardProvider()
        {
            return new XSqlServerStandardProvider();
        }
        public override XStandCheckRecordProvider GetStandCheckRecordProvider()
        {
            return new XSqlServerStandCheckRecordProvider();
        }
        public override XStandCodeEquipmentProvider GetStandCodeEquipmentProvider()
        {
            return new XSqlServerStandCodeEquipmentProvider();
        }
        public override XStandEquipmentProvider GetStandEquipmentProvider()
        {
            return new XSqlServerStandEquipmentProvider();
        }
        public override XStandEquipmentCheckRecordProvider GetStandEquipmentCheckRecordProvider()
        {
            return new XSqlServerStandEquipmentCheckRecordProvider();
        }
        public override XStandFilesProvider GetStandFilesProvider()
        {
            return new XSqlServerStandFilesProvider();
        }
        public override XStandFilesCheckRecordProvider GetStandFilesCheckRecordProvider()
        {
            return new XSqlServerStandFilesCheckRecordProvider();
        }
        public override XTableDictProvider GetTableDictProvider()
        {
            return new XSqlServerTableDictProvider();
        }
        public override XTaskProvider GetTaskProvider()
        {
            return new XSqlServerTaskProvider();
        }
        public override XTaskAttachmentProvider GetTaskAttachmentProvider()
        {
            return new XSqlServerTaskAttachmentProvider();
        }
        public override XTaskFilesProvider GetTaskFilesProvider()
        {
            return new XSqlServerTaskFilesProvider();
        }
        public override XTemplateProvider GetTemplateProvider()
        {
            return new XSqlServerTemplateProvider();
        }
        public override XTemplateBillProvider GetTemplateBillProvider()
        {
            return new XSqlServerTemplateBillProvider();
        }
        public override XTemplateCatalogProvider GetTemplateCatalogProvider()
        {
            return new XSqlServerTemplateCatalogProvider();
        }
        public override XTemplateCatalogItemProvider GetTemplateCatalogItemProvider()
        {
            return new XSqlServerTemplateCatalogItemProvider();
        }
        public override XTemplateItemProvider GetTemplateItemProvider()
        {
            return new XSqlServerTemplateItemProvider();
        }
        public override XUseDeptProvider GetUseDeptProvider()
        {
            return new XSqlServerUseDeptProvider();
        }
        public override XUseDeptFolderProvider GetUseDeptFolderProvider()
        {
            return new XSqlServerUseDeptFolderProvider();
        }
        public override XUseErroLogProvider GetUseErroLogProvider()
        {
            return new XSqlServerUseErroLogProvider();
        }
        public override XUseFileLogProvider GetUseFileLogProvider()
        {
            return new XSqlServerUseFileLogProvider();
        }
        public override XUseOperateLogProvider GetUseOperateLogProvider()
        {
            return new XSqlServerUseOperateLogProvider();
        }
        public override XUsersProvider GetUsersProvider()
        {
            return new XSqlServerUsersProvider();
        }
        public override XUsersRoleProvider GetUsersRoleProvider()
        {
            return new XSqlServerUsersRoleProvider();
        }
        public override XUseUserDeptProvider GetUseUserDeptProvider()
        {
            return new XSqlServerUseUserDeptProvider();
        }
    }
}