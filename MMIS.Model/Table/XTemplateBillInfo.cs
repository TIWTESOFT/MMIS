using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MMIS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class XTemplateBillInfo : XModelBase,ICloneable
    {

        /// <summary>
        /// 
        /// </summary>
        public string RID
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Rno
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Bno
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Unitname
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Linkname
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Linktel
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DevNameDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string DevSpecDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string MnoDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string AttachmentDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string NumDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string PriceDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string TotaleDesc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string WriteTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string GetTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public double Total
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Linkmanw
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Accnamw
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Unitmemo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Memo1
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Memo2
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Memo3
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Memo4
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Memo
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Createtime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Creator
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string ModifyTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Modifeir
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public string Desc_wgjc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 型式评价费
        /// </summary>
        public string Fee_xspjf
        {
            get;
            set;
        }
        
        /// <summary>
        /// 型式评价费
        /// </summary>
        public double Fee_xspjf_num
        {
            get;
            set;
        }
        
        /// <summary>
        /// 监督检验费
        /// </summary>
        public string Fee_jdjyf
        {
            get;
            set;
        }
        
        /// <summary>
        /// 监督检验费
        /// </summary>
        public double Fee_jdjyf_num
        {
            get;
            set;
        }
        
        /// <summary>
        /// 检定费
        /// </summary>
        public string Fee_jdf
        {
            get;
            set;
        }
        
        /// <summary>
        /// 检定费
        /// </summary>
        public double Fee_jdf_num
        {
            get;
            set;
        }
        
        /// <summary>
        /// 校准费
        /// </summary>
        public string Fee_jzf
        {
            get;
            set;
        }
        
        /// <summary>
        /// 校准费
        /// </summary>
        public double Fee_jzf_num
        {
            get;
            set;
        }
        
        /// <summary>
        /// 测试费
        /// </summary>
        public string Fee_csf
        {
            get;
            set;
        }
        
        /// <summary>
        /// 测试费
        /// </summary>
        public double Fee_csf_num
        {
            get;
            set;
        }
        
        /// <summary>
        /// 检测费
        /// </summary>
        public string Fee_jcf
        {
            get;
            set;
        }
        
        /// <summary>
        /// 检测费
        /// </summary>
        public double Fee_jcf_num
        {
            get;
            set;
        }
        
        /// <summary>
        /// 其他收费
        /// </summary>
        public string Fee_qtsf
        {
            get;
            set;
        }
        
        /// <summary>
        /// 其他收费
        /// </summary>
        public double Fee_qtsf_num
        {
            get;
            set;
        }
        
        /// <summary>
        /// 检测人员
        /// </summary>
        public string Person_jc
        {
            get;
            set;
        }
        
        /// <summary>
        /// 送仪器年
        /// </summary>
        public string Time_year
        {
            get;
            set;
        }
        
        /// <summary>
        /// 送仪器月
        /// </summary>
        public string Time_month
        {
            get;
            set;
        }
        
        /// <summary>
        /// 送仪器日
        /// </summary>
        public string Time_day
        {
            get;
            set;
        }
        
        /// <summary>
        /// 备注
        /// </summary>
        public string Memo_bill
        {
            get;
            set;
        }
        
        /// <summary>
        /// 其他需说明
        /// </summary>
        public string Memo_else
        {
            get;
            set;
        }
        
        /// <summary>
        /// 地址
        /// </summary>
        public string Bill_dizhi
        {
            get;
            set;
        }
        
        /// <summary>
        /// 邮编
        /// </summary>
        public string Bill_youbian
        {
            get;
            set;
        }
        
        /// <summary>
        /// 收发室仪器接收人
        /// </summary>
        public string Bill_jieshouren
        {
            get;
            set;
        }
        
        
         /// <summary>
        /// 复制
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}