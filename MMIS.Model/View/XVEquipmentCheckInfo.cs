using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVEquipmentCheckInfo : XEquipmentCheckInfo
    {
        private string m_CustName = string.Empty;

        /// <summary>
        /// 送检单位
        /// </summary>
        public string CustName
        {
            get { return this.m_CustName; }
            set { this.m_CustName = value; }
        }

        private string m_EquipmentState = string.Empty;

        /// <summary>
        /// 设备状态
        /// </summary>
        public string EquipmentState
        {
            get { return this.m_EquipmentState; }
            set { this.m_EquipmentState = value; }
        }

        private string m_ColorRGB = string.Empty;

        /// <summary>
        /// 状态颜色
        /// </summary>
        public string ColorRGB
        {
            get { return this.m_ColorRGB; }
            set { this.m_ColorRGB = value; }
        }

        private string m_CustAddress = string.Empty;

        public string CustAddress
        {
            get { return this.m_CustAddress; }
            set { this.m_CustAddress = value; }
        }

        private string m_LinkPeople = string.Empty;

        public string LinkPeople
        {
            get { return this.m_LinkPeople; }
            set { this.m_LinkPeople = value; }
        }

        private string m_MobileNo = string.Empty;

        public string MobileNo
        {
            get { return this.m_MobileNo; }
            set { this.m_MobileNo = value; }
        }

        private string m_WorkTel = string.Empty;

        public string WorkTel
        {
            get { return this.m_WorkTel; }
            set { this.m_WorkTel = value; }
        }

        private string m_WebSite = string.Empty;

        public string WebSite
        {
            get { return this.m_WebSite; }
            set { this.m_WebSite = value; }
        }

        private string m_CustEmail = string.Empty;

        public string CustEmail
        {
            get { return this.m_CustEmail; }
            set { this.m_CustEmail = value; }
        }

        private string m_CustDesc = string.Empty;

        public string CustDesc
        {
            get { return this.m_CustDesc; }
            set { this.m_CustDesc = value; }
        }

        private string m_InvoiceTitle = string.Empty;

        public string InvoiceTitle
        {
            get { return this.m_InvoiceTitle; }
            set { this.m_InvoiceTitle = value; }
        }

        private string m_TaxNo = string.Empty;

        public string TaxNo
        {
            get { return this.m_TaxNo; }
            set { this.m_TaxNo = value; }
        }

        private string m_BankName = string.Empty;

        public string BankName
        {
            get { return this.m_BankName; }
            set { this.m_BankName = value; }
        }

        private string m_BankAccountNo = string.Empty;

        public string BankAccountNo
        {
            get { return this.m_BankAccountNo; }
            set { this.m_BankAccountNo = value; }
        }

        private string m_EquipmentTypeName = string.Empty;

        public string EquipmentTypeName
        {
            get { return this.m_EquipmentTypeName; }
            set { this.m_EquipmentTypeName = value; }
        }

        private string m_UserName = string.Empty;

        public string UserName
        {
            get { return this.m_UserName; }
            set { this.m_UserName = value; }
        }

    }
}
