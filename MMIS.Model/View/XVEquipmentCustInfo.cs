using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMIS.Model
{
    public partial class XVEquipmentCustInfo : XEquipmentCustInfo
    {
        private string m_CustTypeNameCN = string.Empty;

        public string CustTypeNameCN
        {
            get { return this.m_CustTypeNameCN; }
            set { this.m_CustTypeNameCN = value; }
        }
    }
}
