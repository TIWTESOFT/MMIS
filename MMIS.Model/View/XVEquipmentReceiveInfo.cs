using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVEquipmentReceiveInfo : XEquipmentReceiveInfo
    {
        private string m_EquipmentType = string.Empty;

        /// <summary>
        /// 设备类别
        /// </summary>
        public string EquipmentType
        {
            get { return this.m_EquipmentType; }
            set { this.m_EquipmentType = value; }
        }

        private string m_EquipmentCustId = string.Empty;

        /// <summary>
        /// 送检单位ID
        /// </summary>
        public string EquipmentCustId
        {
            get { return this.m_EquipmentCustId; }
            set { this.m_EquipmentCustId = value; }
        }

        private string m_CustName = string.Empty;

        /// <summary>
        /// 送检单位
        /// </summary>
        public string CustName
        {
            get { return this.m_CustName; }
            set { this.m_CustName = value; }
        }

        private string m_EquipmentName = string.Empty;

        /// <summary>
        /// 设备名称
        /// </summary>
        public string EquipmentName
        {
            get { return this.m_EquipmentName; }
            set { this.m_EquipmentName = value; }
        }

        private string m_FactoryNo = string.Empty;

        /// <summary>
        /// 出厂编号
        /// </summary>
        public string FactoryNo
        {
            get { return this.m_FactoryNo; }
            set { this.m_FactoryNo = value; }
        }

        private string m_Spec = string.Empty;

        /// <summary>
        /// 规格
        /// </summary>
        public string Spec
        {
            get { return this.m_Spec; }
            set { this.m_Spec = value; }
        }

        private string m_Model = string.Empty;

        /// <summary>
        /// 型号
        /// </summary>
        public string Model
        {
            get { return this.m_Model; }
            set { this.m_Model = value; }
        }

        private string m_FactoryName = string.Empty;

        /// <summary>
        /// 制造单位
        /// </summary>
        public string FactoryName
        {
            get { return this.m_FactoryName; }
            set { this.m_FactoryName = value; }
        }

        private string m_SourceTime = string.Empty;

        /// <summary>
        /// 溯源时间
        /// </summary>
        public string SourceTime
        {
            get { return this.m_SourceTime; }
            set { this.m_SourceTime = value; }
        }

        private string m_UseTime = string.Empty;

        /// <summary>
        /// 使用时间
        /// </summary>
        public string UseTime
        {
            get { return this.m_UseTime; }
            set { this.m_UseTime = value; }
        }

        private string m_SourceCustId = string.Empty;

        /// <summary>
        /// 溯源单位
        /// </summary>
        public string SourceCustId
        {
            get { return this.m_SourceCustId; }
            set { this.m_SourceCustId = value; }
        }

        private string m_SourceTypeId = string.Empty;

        /// <summary>
        /// 溯源方式
        /// </summary>
        public string SourceTypeId
        {
            get { return this.m_SourceTypeId; }
            set { this.m_SourceTypeId = value; }
        }

        private string m_EquipmentStatusId = string.Empty;

        /// <summary>
        /// 设备状态
        /// </summary>
        public string EquipmentStatusId
        {
            get { return this.m_EquipmentStatusId; }
            set { this.m_EquipmentStatusId = value; }
        }

        private string m_EquipmentNo = string.Empty;

        /// <summary>
        /// 设备编号
        /// </summary>
        public string EquipmentNo
        {
            get { return this.m_EquipmentNo; }
            set { this.m_EquipmentNo = value; }
        }

        private string m_LastCheckDate = string.Empty;

        /// <summary>
        /// 最后检定日期
        /// </summary>
        public string LastCheckDate
        {
            get { return this.m_LastCheckDate; }
            set { this.m_LastCheckDate = value; }
        }

        private string m_EquipmentDesc = string.Empty;

        /// <summary>
        /// 设备描述
        /// </summary>
        public string EquipmentDesc
        {
            get { return this.m_EquipmentDesc; }
            set { this.m_EquipmentDesc = value; }
        }

        private string m_CheckUserName = string.Empty;

        /// <summary>
        /// 检定人
        /// </summary>
        public string CheckUserName
        {
            get { return this.m_CheckUserName; }
            set { this.m_CheckUserName = value; }
        }

        private string m_ReceiveUserName = string.Empty;

        /// <summary>
        /// 接收人
        /// </summary>
        public string ReceiveUserName
        {
            get { return this.m_ReceiveUserName; }
            set { this.m_ReceiveUserName = value; }
        }

        private string m_ReportFileFullName = string.Empty;

        /// <summary>
        /// 检定报告全路径
        /// </summary>
        public string ReportFileFullName
        {
            get { return this.m_ReportFileFullName; }
            set { this.m_ReportFileFullName = value; }
        }

        private string m_PdfReportFileFullName = string.Empty;

        /// <summary>
        /// 检定报告全路径
        /// </summary>
        public string PdfReportFileFullName
        {
            get { return this.m_PdfReportFileFullName; }
            set { this.m_PdfReportFileFullName = value; }
        }

        private string m_VefirfyUserName = string.Empty;

        /// <summary>
        /// 核验员
        /// </summary>
        public string VerifyUserName
        {
            get { return this.m_VefirfyUserName; }
            set { this.m_VefirfyUserName = value; }
        }

        private string m_SignUserName = string.Empty;

        /// <summary>
        /// 指定收发员
        /// </summary>
        public string SignUserName
        {
            get { return this.m_SignUserName; }
            set { this.m_SignUserName = value; }
        }

        public string m_VerifyedUserName = string.Empty;

        /// <summary>
        /// 核验员
        /// </summary>
        public string VerifyedUserName
        {
            get { return this.m_VerifyedUserName; }
            set { this.m_VerifyedUserName = value; }
        }

        private string m_CheckedUserName = string.Empty;

        /// <summary>
        /// 检定人
        /// </summary>
        public string CheckedUserName
        {
            get { return this.m_CheckedUserName; }
            set { this.m_CheckedUserName = value; }
        }

        private string m_DispatchUserName = string.Empty;

        /// <summary>
        /// 指定收发员
        /// </summary>
        public string DispatchUserName
        {
            get { return this.m_DispatchUserName; }
            set { this.m_DispatchUserName = value; }
        }

        private string m_SignedUserName = string.Empty;

        /// <summary>
        /// 签发人
        /// </summary>
        public string SignedUserName
        {
            get { return this.m_SignedUserName; }
            set { this.m_SignedUserName = value; }
        }

        private string m_BackUserName = string.Empty;

        /// <summary>
        /// 退回人
        /// </summary>
        public string BackUserName
        {
            get { return this.m_BackUserName; }
            set { this.m_BackUserName = value; }
        }

        private string m_StandName = string.Empty;

        /// <summary>
        /// 检定标准
        /// </summary>
        public string StandName
        {
            get { return this.m_StandName; }
            set { this.m_StandName = value; }
        }

        private string m_CheckAccord = string.Empty;

        /// <summary>
        /// 检定依据
        /// </summary>
        public string CheckAccord
        {
            get { return this.m_CheckAccord; }
            set { this.m_CheckAccord = value; }
        }

        private string m_EquipmentTypeName = string.Empty;

        /// <summary>
        /// 设备类型
        /// </summary>
        public string EquipmentTypeName
        {
            get { return this.m_EquipmentTypeName; }
            set { this.m_EquipmentTypeName = value; }
        }

        //2014-12-19,mxj,add
        private string m_InvoiceNo = string.Empty;
        public string InvoiceNo
        {
            get { return this.m_InvoiceNo; }
            set { this.m_InvoiceNo = value; }
        }
        private string m_InvoiceFlag = string.Empty;
        public string InvoiceFlag

        {
            get { return this.m_InvoiceFlag; }
            set { this.m_InvoiceFlag = value; }
        }


    }
}
