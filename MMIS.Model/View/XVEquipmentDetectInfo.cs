using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVEquipmentDetectInfo : XEquipmentDetectInfo
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

        private double m_Quanlity = 0;

        /// <summary>
        /// 数量
        /// </summary>
        public double Quanlity
        {
            get { return m_Quanlity; }
            set { this.m_Quanlity = value; }
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

        private string m_DetectUserName = string.Empty;

        /// <summary>
        /// 核验人
        /// </summary>
        public string DetectUserName
        {
            get { return this.m_DetectUserName; }
            set { this.m_DetectUserName = value; }
        }
    }
}
