using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.UI.Common;
using MMIS.Helper;
using MMIS.Component;

namespace MMIS.UI
{
    public partial class frmBillPrint : Form
    {
        public frmBillPrint()
        {
            InitializeComponent();
        }
        string EditFlag = "";
        string SelectRowId = "";
        DataTable OutTable = new DataTable();
        //EquipmentName
        //Model
        //FactoryNo
        //
        //Quanlity

        public frmBillPrint(string _editFlag,string _selectRowId,DataTable _outTb)
        {
            InitializeComponent();

            try
            {
                EditFlag = _editFlag;
                SelectRowId = _selectRowId;
                OutTable = _outTb;

                btndevlp.Visible = false;

                if (EditFlag == "A")
                {
                    this.txtRno.Text = System.DateTime.Now.ToString("yyyyMMddHHmmssffff");

                    string EquipmentName = "";
                    string Model = "";
                    string FactoryNo = "";
                    string Quanlity = "";

                    string cust = "";
                    string custid = "";
                    string equipmentType = "";

                    for (int i = 0; i < _outTb.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            cust = _outTb.Rows[i]["CustName"] + "";
                            custid = _outTb.Rows[i]["EquipmentCustId"] + "";
                            this.txt_sjxyqdrq.Text = _outTb.Rows[i]["LastCheckDate"] + "";
                        }
                        EquipmentName = EquipmentName + _outTb.Rows[i]["EquipmentName"] + "" + Environment.NewLine + Environment.NewLine;
                        Model = Model + _outTb.Rows[i]["Model"] + "" + Environment.NewLine + Environment.NewLine;
                        FactoryNo = FactoryNo + _outTb.Rows[i]["FactoryNo"] + "" + Environment.NewLine + Environment.NewLine;
                        Quanlity = Quanlity + _outTb.Rows[i]["Quanlity"] + "" + Environment.NewLine + Environment.NewLine;
                        //2016-11-25,mxj,add
                        equipmentType = equipmentType + _outTb.Rows[i]["EquipmentTypeName"] + "" + "  ";
                    }

                    this.txt_sjdwmc.Text = cust;
                    this.txt_jlqjmc.Text = EquipmentName;
                    this.txt_xhgg.Text = Model;
                    this.txt_ccbh.Text = FactoryNo;
                    this.txt_sl.Text = Quanlity;
                    this.txteqtype.Text =GetNewDevType( equipmentType);

                    if (custid != "")
                    {
                        string sqlget = "select * from V_EquipmentCust where rid='" + custid + "'";
                        DataTable dt = new DataTable();
                        dt = SQLHelper.GetDataSet(sqlget);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                this.txt_xxdz.Text = dt.Rows[0]["CustAddress"] + "";//地址
                                this.txt_sjr.Text = dt.Rows[0]["LinkPeople"] + "";//联系人
                                this.txt_lxdh.Text = dt.Rows[0]["MobileNo"] + "";  //电话
                                this.txt_memo.Text = dt.Rows[0]["Remark"] + "";  //备注
                            }
                        }

                    }

                    if (this.txt_sjxyqdrq.Text.Trim() == "")
                    {
                        this.txt_sjxyqdrq.Text = System.DateTime.Now.ToString("yyyy-MM-dd");
                    }

                }
                else if (EditFlag == "M")
                {
                    btndevlp.Visible = true;

                    string rno = "";
                    for (int i = 0; i < _outTb.Rows.Count; i++)
                    {
                        if (i == 0)
                        {
                            rno = _outTb.Rows[i]["InvoiceNo"] + "";
                       }                 
                    }

                    string sqlget = "select * from TemplateBill where Rno='" + rno + "'";
                    DataTable dt = new DataTable();
                    dt = SQLHelper.GetDataSet(sqlget);

                    if (dt == null)
                    {
                        XMessageBox.ShowRemindMessage("获取接收单信息异常");
                        this.Close();
                    }
                    if (dt.Rows.Count <= 0)
                    {
                        XMessageBox.ShowRemindMessage("获取接收单信息异常");
                        this.Close();
                    }
                    DataRow dr = dt.Rows[0];
                    this.txtRno.Text = dr["Rno"] + "";
                    this.txtno.Text = dr["Bno"] + "";
                    this.txt_sjdwmc.Text = dr["Unitname"] + "";
                    this.txt_sjr.Text = dr["Linkname"] + "";
                    this.txt_lxdh.Text = dr["Linktel"] + "";
                    
                    this.txt_jlqjmc.Text = dr["DevNameDesc"] + "";
                    this.txt_xhgg.Text = dr["DevSpecDesc"] + "";
                    this.txt_ccbh.Text = dr["MnoDesc"] + "";
                    this.txt_sdfj.Text = dr["AttachmentDesc"] + "";
                    this.txt_sl.Text = dr["NumDesc"] + "";
                    this.txt_wgjc.Text = dr["PriceDesc"] + "";
                    this.txt_xspjf.Text = dr["TotaleDesc"] + "";

                    this.txteqtype.Text = dr["Memo3"] + "";

                    if(dr["Total"]!=null)
                    {
                        this.txt_sfzj.Text =decimal.Parse( dr["Total"].ToString()).ToString("0.00");
                    }
                    this.txt_sjrqz.Text = dr["Linkmanw"] + "";
                    this.txt_yqjsrqz.Text = dr["Accnamw"] + "";

                    //if (dr["WriteTime"] != null)
                    //{
                    //    this.txt_sjxyqdrq.Text = System.DateTime.Parse(dr["WriteTime"].ToString()).ToString("yyyy-MM-dd");
                    //}
                    //if (dr["GetTime"] != null)
                    //{
                    //    this.txt_tqzsjyqrq.Text = System.DateTime.Parse(dr["GetTime"].ToString()).ToString("yyyy-MM-dd");
                    //}

                    if (dr["GetTime"] != null)
                    {
                        this.txt_sjxyqdrq.Text = System.DateTime.Parse(dr["GetTime"].ToString()).ToString("yyyy-MM-dd");
                    }

                   txt_xxdz.Text = dr["Bill_dizhi"] + "";
                   txt_yzbm.Text = dr["Bill_youbian"] + "";
                   txt_yqjsrqz.Text = dr["Bill_jieshouren"] + "";

                   txt_wgjc.Text = dr["Desc_wgjc"] + "";
                   txt_xspjf.Text = dr["Fee_xspjf"] + "";
                   if (dr["Fee_xspjf_num"] != null)
                   {
                       this.txt_xspjf_num.Text = dr["Fee_xspjf_num"].ToString();
                   }
                   txt_jdjyf.Text = dr["Fee_jdjyf"] + "";
                   if (dr["Fee_jdjyf_num"] != null)
                   {
                       this.txt_jdjyf_num.Text = dr["Fee_jdjyf_num"].ToString();
                   }
                   txt_jdf.Text = dr["Fee_jdf"] + "";
                   if (dr["Fee_jdf_num"] != null)
                   {
                       this.txt_jdf_num.Text = dr["Fee_jdf_num"].ToString();
                   }
                   txt_jzf.Text = dr["Fee_jzf"] + "";
                   if (dr["Fee_jzf_num"] != null)
                   {
                       this.txt_jzf_num.Text = dr["Fee_jzf_num"].ToString();
                   }
                   txt_csf.Text = dr["Fee_csf"] + "";
                   if (dr["Fee_csf_num"] != null)
                   {
                       this.txt_csf_num.Text = dr["Fee_csf_num"].ToString();
                   }
                   txt_jcf.Text = dr["Fee_jcf"] + "";
                   if (dr["Fee_jcf_num"] != null)
                   {
                       this.txt_jcf_num.Text = dr["Fee_jcf_num"].ToString();
                   }
                   txt_qtsf.Text = dr["Fee_qtsf"] + "";
                   if (dr["Fee_qtsf_num"] != null)
                   {
                       this.txt_qtsf_num.Text = dr["Fee_qtsf_num"].ToString();
                   }
                   txt_jcry.Text = dr["Person_jc"] + "";
                   txt_syqn.Text = dr["Time_year"] + "";
                   txt_syqy.Text = dr["Time_month"] + "";
                   txt_syqr.Text = dr["Time_day"] + "";
                   txt_memo.Text = dr["Memo_bill"] + "";
                   txt_memoelse.Text = dr["Memo_else"] + "";


                }
                //XMessageBox.ShowRemindMessage(SelectRowId);
            }
            catch (Exception ex)
            {
                XMessageBox.ShowRemindMessage(ex.Message);
            }
        }
        DataTable templateItems = new DataTable();
        string catalogName = "委托报检协议书";

        private void Print(string printType)
        {
            string tt = "";
            Template t;


            //需要赋值
            templateItems = GetTemplateItems(catalogName);
            Control2DocContent(this);

            DocContent2TemplateItems(docContent);

            t = new Template(templateItems);
            t.ShowPSDialog = true;

            if (printType == "P")
            {
                t.Print();
            }
            else
            {
                t.Preview();
            }

            GC.Collect();
        }

        #region "填充"
        public DataTable GetTemplateItems(string templateName)
        {
            DataTable table = null;
            string templateID = "";
            DataTable tm = new DataTable();
            tm = SQLHelper.GetDataSet("select * from Template where Templatename='" + templateName + "'");

            if (tm == null)
            {
                return null;
            }
            if (tm.Rows.Count <= 0)
            {
                return null;
            }

            //table = GetDataTableFromXML("TemplateItem", Application.StartupPath + "\\Files\\TemplateItem.xml");
            table = SQLHelper.GetDataSet("select * from TemplateItem where TemplateID='" + tm.Rows[0]["TemplateID"] + "" + "'");
            DataRow[] row = null;
            row = table.Select("TemplateID='" + tm.Rows[0]["TemplateID"] + "" + "'");
            DataTable tmpTable = new DataTable();
            tmpTable = table.Clone();
            DataRow rowT = null;
            for (int i = 0; i <= row.Length - 1; i++)
            {
                rowT = tmpTable.NewRow();
                for (int j = 0; j <= tmpTable.Columns.Count - 1; j++)
                {
                    rowT[j] = row[i][j];
                }
                tmpTable.Rows.Add(rowT);
            }

            return tmpTable;
        }

        //此方法必须在继承类中实现
        private void SetItemValue(string itemMean, string value)
        {
            //根据项目的含义设定值
            string itemID = null;

            itemID = GetTemplateItemIDByMean(itemMean);
            for (int i = 0; i <= this.templateItems.Rows.Count - 1; i++)
            {
                if (itemID.IndexOf(this.templateItems.Rows[i]["ItemID"] + "") >= 0)
                {
                    this.templateItems.Rows[i]["TemplateID"] = value;
                }
            }
        }
        private string GetTemplateItemIDByMean(string mean)
        {
            string s = "";

            DataTable TBCatalog = new DataTable();
            TBCatalog = SQLHelper.GetDataSet("select * from TemplateCatalog where CatalogDesc='" + this.catalogName + "'");
            DataTable TBCatalogItem = new DataTable();
            
            for (int i = 0; i <= TBCatalog.Rows.Count - 1; i++)
            {
                if (TBCatalog.Rows[i]["CatalogDesc"] + "" == this.catalogName)
                {
                    TBCatalogItem = SQLHelper.GetDataSet("select * from TemplateCatalogItem where CatalogID='" + TBCatalog.Rows[i]["CatalogID"] + "" + "'");
                    for (int j = 0; j <= TBCatalogItem.Rows.Count - 1; j++)
                    {
                        if (TBCatalogItem.Rows[j]["ItemMean"] + "" == mean)
                        {
                            s = s + "," + TBCatalogItem.Rows[j]["ItemID"] + "";
                        }
                    }
                    break; // TODO: might not be correct. Was : Exit For
                }
            }
            return s;
        }

        #endregion 

        #region "生成文件内容结构及数据 序列化"
        private void DocContent2TemplateItems(Hashtable hash)
        {
            //由于TemplateItems的数据已在UCBTemplate的SelectedIndexChanged事件中处理 不再处理

            foreach (string key in hash.Keys)
            {
                SetItemValue(key, hash[key].ToString());
            }
        }

        private Hashtable docContent = new Hashtable();
        private void Control2DocContent(Control control)
        {
            this.docContent.Clear();
            this.DoControl2DocContent(this);

        }
        private void DoControl2DocContent(Control control)
        {
            //填充docContent的内容
            string tag = null;

            foreach (Control c in control.Controls)
            {
                tag = c.Tag + "";
                if (c.GetType().ToString() == typeof(System.Windows.Forms.TextBox).ToString())
                {
                    if (!string.IsNullOrEmpty(tag))
                    {
                        if (!docContent.Contains(tag))
                        {
                            docContent.Add(tag, c.Text);
                        }
                    }
                }
                else
                {
                    if (c.Controls.Count > 0)
                    {
                        DoControl2DocContent(c);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(tag))
                        {
                            if (!docContent.Contains(tag))
                            {
                                docContent.Add(tag, c.Text);
                            }
                        }
                    }

                }
            }


        }


        #endregion 

        #region "保存"

        /// <summary>
        /// 2016-11-24,mxj,add
        /// </summary>
        /// <returns></returns>
        private string GetNewDevName()
        {
            string devname = this.txt_jlqjmc.Text;
            //string split=Environment.NewLine + Environment.NewLine;
            string[] dev = devname.Split((Environment.NewLine + Environment.NewLine).ToCharArray());
            string devnamenew = devname;
            if (dev.Length > 1)
            {
                devnamenew = dev[0] + Environment.NewLine + Environment.NewLine;
                foreach (string n in dev)
                {
                    if (!(devnamenew.Contains(n + Environment.NewLine + Environment.NewLine)))
                    {
                        devnamenew = devnamenew + n + Environment.NewLine + Environment.NewLine;
                    }
                }
            }

            return devnamenew;
        }

        /// <summary>
        /// 新增
        /// </summary>
        private void Insert()
        {
            try
            {
                string sql = "insert into TemplateBill(RID,Rno,Bno,Unitname,Linkname,Linktel,DevNameDesc,DevSpecDesc,MnoDesc,AttachmentDesc,NumDesc,PriceDesc,TotaleDesc,WriteTime,GetTime,Total,Createtime,Creator,";
                sql += "Desc_wgjc,Fee_xspjf,Fee_xspjf_num,Fee_jdjyf,Fee_jdjyf_num,Fee_jdf,Fee_jdf_num,Fee_jzf,Fee_jzf_num,Fee_csf,Fee_csf_num, Fee_jcf,Fee_jcf_num,Fee_qtsf,Fee_qtsf_num,Person_jc,Time_year,Time_month,Time_day,Memo_bill,Memo_else,Bill_dizhi,Bill_youbian,Bill_jieshouren,memo4,memo3)";

                sql = sql + " values('" + System.Guid.NewGuid() + "','" + txtRno.Text + "','" + this.txtno.Text.Trim() + "','" + this.txt_sjdwmc.Text.Trim() + "','" + this.txt_sjr.Text.Trim() + "','" + this.txt_lxdh.Text.Trim() + "', ";
                sql = sql + " '" + this.txt_jlqjmc.Text + "','" + this.txt_xhgg.Text + "','" + this.txt_ccbh.Text + "','" + this.txt_sdfj.Text + "','" + this.txt_sl.Text + "','" + this.txt_wgjc.Text + "','" + this.txt_xspjf.Text + "', ";
                sql = sql + " '" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + System.DateTime.Parse(this.txt_sjxyqdrq.Text).ToString("yyyy-MM-dd HH:mm:ss") + "',";
                sql = sql + " " + decimal.Parse(this.txt_sfzj.Text.Trim()).ToString() + ",'" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + XCommon.LoginUsersInfo.RealName + "',";

                sql = sql + " '" + txt_wgjc.Text + "','" + txt_xspjf.Text + "'," + GetValue(txt_xspjf_num.Text) + ",'" + txt_jdjyf.Text + "'," + GetValue(txt_jdjyf_num.Text) + ",'" + txt_jdf.Text + "'," + GetValue(txt_jdf_num.Text) + ",";
                sql = sql + " '" + txt_jzf.Text + "'," + GetValue(txt_jzf_num.Text) + ",'" + txt_csf.Text + "'," + GetValue(txt_csf_num.Text) + ",'" + txt_jcf.Text + "'," + GetValue(txt_jcf_num.Text) + ",";
                sql = sql + " '" + txt_qtsf.Text + "'," + GetValue(txt_qtsf_num.Text) + ",'" + txt_jcry.Text + "','" + txt_syqn.Text + "','" + txt_syqy.Text + "','" + txt_syqr.Text + "','" + txt_memo.Text + "','" + txt_memoelse.Text + "',";
                sql = sql + " '" + txt_xxdz.Text + "','" + txt_yzbm.Text + "','" + txt_yqjsrqz.Text + "','" + GetNewDevName() + "','" + this.txteqtype.Text + "'";


                sql = sql + " )";

                if (SQLHelper.ExecuteCommand(sql) > 0)
                {
                    string updatemainsql = "update   EquipmentReceive set InvoiceNo='" + txtRno.Text + "' where RID in (" + SelectRowId + ")";
                    SQLHelper.ExecuteCommand(updatemainsql);
                    XMessageBox.ShowRemindMessage("保存成功！");
                }
            }
            catch (Exception ex)
            {
                XMessageBox.ShowRemindMessage("保存异常！" + Environment.NewLine + ex.Message);
            }

        }

        private void Update()
        {
            try
            {

                //(RID,Rno,Bno,Unitname,Linkname,Linktel,DevNameDesc,DevSpecDesc,MnoDesc,AttachmentDesc,NumDesc,PriceDesc,TotaleDesc,WriteTime,GetTime,Total,Createtime,Creator)
                string sql = "update TemplateBill ";
                sql = sql + " set Bno='" + this.txtno.Text.Trim() + "',Unitname='" + this.txt_sjdwmc.Text.Trim() + "',Linkname='" + this.txt_sjr.Text.Trim() + "',Linktel='" + this.txt_lxdh.Text.Trim() + "', ";
                sql = sql + " DevNameDesc='" + this.txt_jlqjmc.Text + "',DevSpecDesc='" + this.txt_xhgg.Text + "',MnoDesc='" + this.txt_ccbh.Text + "',AttachmentDesc='" + this.txt_sdfj.Text + "',NumDesc='" + this.txt_sl.Text + "',PriceDesc='" + this.txt_wgjc.Text + "',TotaleDesc='" + this.txt_xspjf.Text + "', ";
                sql = sql + " WriteTime='" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',GetTime='" + System.DateTime.Parse(this.txt_sjxyqdrq.Text).ToString("yyyy-MM-dd HH:mm:ss") + "',";
                sql = sql + " Total=" + decimal.Parse(this.txt_sfzj.Text.Trim()).ToString() + ",";

                // "Desc_wgjc,Fee_xspjf,Fee_xspjf_num,Fee_jdjyf,Fee_jdjyf_num,Fee_jdf,Fee_jdf_num,Fee_jzf,Fee_jzf_num,Fee_csf,Fee_csf_num, Fee_jcf,Fee_jcf_num,Fee_qtsf,Fee_qtsf_num,Person_jc,Time_year,Time_month,Time_day,Memo_bill,Memo_else)"
                sql = sql + " Desc_wgjc='" + txt_wgjc.Text + "',Fee_xspjf='" + txt_xspjf.Text + "',Fee_xspjf_num=" + GetValue(txt_xspjf_num.Text) + ",Fee_jdjyf='" + txt_jdjyf.Text + "',Fee_jdjyf_num=" + GetValue(txt_jdjyf_num.Text) + ",Fee_jdf='" + txt_jdf.Text + "',Fee_jdf_num=" + GetValue(txt_jdf_num.Text) + ",";
                sql = sql + " Fee_jzf='" + txt_jzf.Text + "',Fee_jzf_num=" + GetValue(txt_jzf_num.Text) + ",Fee_csf='" + txt_csf.Text + "',Fee_csf_num=" + GetValue(txt_csf_num.Text) + ",Fee_jcf='" + txt_jcf.Text + "',Fee_jcf_num=" + GetValue(txt_jcf_num.Text) + ",";
                sql = sql + " Fee_qtsf='" + txt_qtsf.Text + "',Fee_qtsf_num=" + GetValue(txt_qtsf_num.Text) + ",Person_jc='" + txt_jcry.Text + "',Time_year='" + txt_syqn.Text + "',Time_month='" + txt_syqy.Text + "',Time_day='" + txt_syqr.Text + "',Memo_bill='" + txt_memo.Text + "',Memo_else='" + txt_memoelse.Text + "',";

                //sql = sql + " '" + txt_xxdz.Text + "','" + txt_yzbm.Text + "','" + txt_yqjsrqz.Text + "'";
                sql = sql + " Bill_dizhi='" + txt_xxdz.Text + "',Bill_youbian='" + txt_yzbm.Text + "',Bill_jieshouren='" + txt_yqjsrqz.Text + "',memo4='" + GetNewDevName() + "',memo3='"+ this.txteqtype.Text +"'";

                sql = sql + " where Rno='" + txtRno.Text + "'";

                if (SQLHelper.ExecuteCommand(sql) > 0)
                {
                    XMessageBox.ShowRemindMessage("保存成功！");
                }
            }
            catch (Exception ex)
            {
                XMessageBox.ShowRemindMessage("保存异常！" + Environment.NewLine + ex.Message);
            }

        }

        #endregion 

        private void ubPreview_Click(object sender, EventArgs e)
        {
            Print("V");            
        }

        private void ubPrint_Click(object sender, EventArgs e)
        {
            Print("P");      
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (EditFlag == "A")
            {
                Insert();
            }
            else if (EditFlag == "M")
            {
                Update();
            }
        }

        private void btnprintandsave_Click(object sender, EventArgs e)
        {
            Print("P"); 
            if (EditFlag == "A")
            {
                Insert();
            }
            else if (EditFlag == "M")
            {
                Update();
            }
        }


        #region text数值计算处理

        /// <summary>
        /// 获得有效数值
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private decimal GetValue(string value)
        {
            decimal num = 0;
            if (Helper.XHelper.IsNumberic(value) == false)
            {
                return 0;
            }

            num = decimal.Parse(value);

            return num;
        }
        /// <summary>
        /// 获得text数据
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        private decimal GetTextValue(System.Windows.Forms.TextBox txt)
        {
            decimal num=0;

            string[] split = txt.Text.Split("\r\n".ToCharArray());//\r\n

            for(int i=0;i<split.Length;i++)
            {
                if ( Helper.XHelper.IsNumberic(split[i])==false)
                {
                    split[i] = "0";
                }
                num += decimal.Parse(split[i]);
            }

            if (txt.Name.ToUpper() == "txt_xspjf".ToUpper())
            {
                txt_xspjf_num.Text = num.ToString();
            }
            else if (txt.Name.ToUpper() == "txt_jdjyf".ToUpper())
            {
                txt_jdjyf_num.Text = num.ToString();
            }
            else if (txt.Name.ToUpper() == "txt_jdf".ToUpper())
            {
                txt_jdf_num.Text = num.ToString();
            }
            else if (txt.Name.ToUpper() == "txt_jzf".ToUpper())
            {
                txt_jzf_num.Text = num.ToString();
            }
            else if (txt.Name.ToUpper() == "txt_csf".ToUpper())
            {
                txt_csf_num.Text = num.ToString();
            }
            else if (txt.Name.ToUpper() == "txt_jcf".ToUpper())
            {
                txt_jcf_num.Text = num.ToString();
            }
            else if (txt.Name.ToUpper() == "txt_qtsf".ToUpper())
            {
                txt_qtsf_num.Text = num.ToString();
            }


            return num;
        }

        private void btntotle_Click(object sender, EventArgs e)
        {
            txt_sfzj.Text =( GetTextValue(txt_xspjf) + GetTextValue(txt_jdjyf) + GetTextValue(txt_jdf) + GetTextValue(txt_jzf) + GetTextValue(txt_csf) + GetTextValue(txt_jcf) + GetTextValue(txt_qtsf)).ToString();

        }

        #endregion

        /// <summary>
        /// 2016-11-21,mxj,add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndevlp_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlget = "select EquipmentCheckId from  EquipmentReceive where InvoiceNo='" + txtRno.Text + "'";
                DataTable dt = new DataTable();
                dt = SQLHelper.GetDataSet(sqlget);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        string where = " ";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (i == dt.Rows.Count - 1)
                            {
                                where += " rid='"+  dt.Rows[i][0].ToString()  +"' ";
                            }
                            else
                            {
                                where += " rid='" + dt.Rows[i][0].ToString() + "' or ";
                            }
                        }

                        string sql = "update EquipmentCheck set LinkMan='" + txt_sjr.Text + "', Tel='" + txt_lxdh.Text + "'  where " + where;

                        if (SQLHelper.ExecuteCommand(sql) > 0)
                        {
                            //XMessageBox.ShowRemindMessage("更新成功！");

                            //同时保存单据
                            if (EditFlag == "M")
                            {
                                Update();
                            }
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                XMessageBox.ShowRemindMessage("更新异常！" + Environment.NewLine + ex.Message);
            }

        }

        /// <summary>
        /// 2016-11-23,mxj,add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            if (txtUserId.Text != "")
            {
                txt_yqjsrqz.Text = txtUserId.Text;
            }
        }



        /// <summary>
        /// 初始化人员CheckBox
        /// </summary>
        protected virtual void InitItemCheckBoxes()
        {
            string sqlget = "select  RID, UserName from  StaffInfo ";
            DataTable dt = new DataTable();
            dt = SQLHelper.GetDataSet(sqlget);

            int xStart = 10;//x开始距离
            int yStart = 10;//y开始距离
            int xDistance = 60;//横向距离
            int yDistance = 6;//纵向距离
            int perRowCount = 10;//每行的数量

            int loopNo = 0;

            foreach (DataRow dr in dt.Rows)
            {
 
                XCheckBox checkBox = new XCheckBox();
                checkBox.Text = dr[1].ToString();
                //checkBox.Model = itemInfo;
                //checkBox.CheckedChanged += new EventHandler(checkBox_CheckedChanged);

                int x = xStart + (loopNo % perRowCount) * xDistance;
                int y = yStart + (loopNo / perRowCount) * yDistance;

                checkBox.Location = new Point(x, y);
                checkBox.AutoSize = true;
                this.pnlItems.Controls.Add(checkBox);

                //if (this.IsHaveItem(itemInfo))
                //{
                //    checkBox.Checked = true;
                //}

                loopNo += 1;
            }

            this.pnlItems.BringToFront();
        }
        /// <summary>
        /// 2016-11-23,mxj,add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnselectp_Click(object sender, EventArgs e)
        {
            try
            {
                string jcr = "";
                foreach (Control c in this.pnlItems.Controls)
                {
                    if (c is XCheckBox)
                    {
                        XCheckBox checkBox = c as XCheckBox;
                        if (checkBox.Checked)
                        {
                            jcr += c.Text + ",";
                        }
                    }
                }

                if (jcr.Length > 0)
                {
                    jcr = jcr.Substring(0, jcr.Length - 1);

                    txt_jcry.Text = jcr;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmBillPrint_Load(object sender, EventArgs e)
        {
            try
            {
                InitItemCheckBoxes();
            }
            catch (Exception ex)
            {

            }
        }


        /// <summary>
        /// 2016-11-24,mxj,add
        /// </summary>
        /// <returns></returns>
        private string GetNewDevNameT(string name)
        {
            string devname = name;
            //string split=Environment.NewLine + Environment.NewLine;
            string[] dev = devname.Split((Environment.NewLine + Environment.NewLine).ToCharArray());
            string devnamenew = devname;
            if (dev.Length > 1)
            {
                devnamenew = dev[0] + Environment.NewLine + Environment.NewLine;
                foreach (string n in dev)
                {
                    if (!(devnamenew.Contains(n + Environment.NewLine + Environment.NewLine)))
                    {
                        devnamenew = devnamenew + n + Environment.NewLine + Environment.NewLine;
                    }
                }
            }

            return devnamenew;
        }
        /// <summary>
        /// 2016-11-24,mxj,add
        /// </summary>
        /// <returns></returns>
        private string GetNewDevType(string type)
        {
            string devname = type;
            //string split=Environment.NewLine + Environment.NewLine;
            string[] dev = devname.Split(("  ").ToCharArray());
            string devnamenew = devname;
            if (dev.Length > 1)
            {
                devnamenew = dev[0] + "  ";
                foreach (string n in dev)
                {
                    if (!(devnamenew.Contains(n + "  ")))
                    {
                        devnamenew = devnamenew + n + "  ";
                    }
                }
            }

            return devnamenew;
        }
        /// <summary>
        /// 同步合同订单的设备名称
        /// 2016-11-24
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label6_Click(object sender, EventArgs e)
        {
            int savenum = 0;
            try
            {
                string sqlget = "select  RID, DevNameDesc,Rno  from  TemplateBill ";
                DataTable dt = new DataTable();
                dt = SQLHelper.GetDataSet(sqlget);

                 string typename = "";
                 string sqltype = "";
                 DataTable dtt = new DataTable();
                 string sql = "";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sqltype = "select EquipmentTypeName  from  V_EquipmentReceive where InvoiceNo='" + dt.Rows[i][2].ToString() + "' ";
                    dtt = new DataTable();
                    dtt = SQLHelper.GetDataSet(sqltype);

                    typename = "";

                    if (dtt != null)
                    {
                        if (dtt.Rows != null)
                        {
                            for (int j = 0; j < dtt.Rows.Count; j++)
                            {
                                typename = typename + dtt.Rows[j][0].ToString() + "  ";
                            }
                        }
                    }

                    sql = "update TemplateBill set memo4='" + GetNewDevNameT(dt.Rows[i][1].ToString()) + "', memo3='" + GetNewDevType(typename) + "' where rid='" + dt.Rows[i][0].ToString() + "'";

                    savenum = savenum+SQLHelper.ExecuteCommand(sql);
                }

                XMessageBox.ShowRemindMessage("更新" + savenum.ToString() + "条信息！", "提示");

            }
            catch (Exception ex)
            {
                XMessageBox.ShowError(ex.Message.ToString(), "提示！");
            }
        }



    }
}
