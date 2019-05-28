using MMIS.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MMIS.Model;
using MMIS.BLL;
using Word = Microsoft.Office.Interop.Word;
using MMIS.Helper;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace MMIS.UI
{
    public partial class frmPrintPreview : frmBase
    {
        private XVEquipmentReceiveInfo m_EquipmentReceiveInfo = null;
        private string m_FileName = string.Empty;
        private XFileAttachmentBusiness m_FileAttachmentBusiness = new XFileAttachmentBusiness();

        private bool m_IsAllowPrint = false;

        public frmPrintPreview(XVEquipmentReceiveInfo receiveInfo, bool isAllowPrint)
        {
            InitializeComponent();
            this.m_EquipmentReceiveInfo = receiveInfo;
            this.Init();
            if (!isAllowPrint)
            {
                this.btnPrint.Enabled = false;
            }
        }

        /// <summary>
        /// 注册控件
        /// </summary>
        /// <returns></returns>
        public bool RegControl()
        {
            try
            {
                string sPath = Application.StartupPath + @"/dsoframer.ocx";
                ProcessStartInfo psi = new ProcessStartInfo("regsvr32", "/s " + sPath);
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }


        private void Init()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string path = XCommon.TempPath;
                this.m_FileName = Guid.NewGuid().ToString();

                m_FileName = this.m_FileAttachmentBusiness.DownLoadFile(m_EquipmentReceiveInfo.ID,
                    path, m_FileName);

                if (m_FileName != string.Empty)
                {
                    XEquipmentReceiveWordTool.FillWordValue(m_FileName, m_EquipmentReceiveInfo);
                    this.fcWord.Open(m_FileName, true, null, null, null);

                    Word.Document dct = this.fcWord.ActiveDocument as Word.Document;

                    if (dct.ProtectionType == Word.WdProtectionType.wdAllowOnlyComments)
                    {
                        dct.Unprotect();
                    }

                    if (dct.ProtectionType == Word.WdProtectionType.wdNoProtection)
                    {
                        dct.Protect(Word.WdProtectionType.wdAllowOnlyComments);
                    }
                }
                else
                {
                    XMessageBox.ShowError("未找到要打印的报告文档！");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            Word.Document dct = this.fcWord.ActiveDocument as Word.Document;
            if (dct != null)
            {
                dct.PrintOut();
                XEquipmentReceiveBusiness business =new XEquipmentReceiveBusiness();//this.m_Business as
                business.PrintBill(m_EquipmentReceiveInfo);
            }
        }

        private void frmPrintPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Word.Document dct = this.fcWord.ActiveDocument as Word.Document;
                if (dct != null)
                {
                    dct.Close();
                    dct.Application.Quit();
                    this.fcWord.Close();
                    if (File.Exists(m_FileName))
                    {
                        File.Delete(m_FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                XErrorLogTool.WriteLog(ex.ToString());
            }
        }
// Background 如果为 true，则可以让自定义项代码在打印文档时继续工作。
//Append 如果为 true，则会将文档追加到 OutputFileName 参数指定的文件；如果为 false，则会改写 OutputFileName 的内容。
//Range 页面范围。可以是任何 WdPrintOutRange 值。
//OutputFileName 如果 PrintToFile 为 true，则此参数指定输出文件的路径和文件名。
//From 当 Range 设置为 wdPrintFromTo 时的起始页码。
//To 当 Range 设置为 wdPrintFromTo 时的结束页码。
//Item 要打印的项。可以是任何 WdPrintOutItem 值。
//Copies 要打印的份数。
//Pages 要打印的页码和页码范围，由逗号分隔。例如，“2, 6-8”意为打印第 2 和第 6、7、8页。
//PageType 要打印的页面的类型。可以是任何 WdPrintOutPages 值。
//PrintToFile 如果为 true，则将打印机指令发送到文件。请确保使用 OutputFileName 指定一个文件名。
//Collate 在打印多份文档时，如果为 true，则先打印该文档的所有页，然后再打印下一份。
//ActivePrinterMacGX 此参数仅在 Microsoft Office Macintosh Edition 中可用。
//ManualDuplexPrint 如果为 true，则在没有双面打印装置的打印机上打印双面文档。如果此参数为 true，则忽略 PrintBackground 和 PrintReverse 属性。
//PrintZoomColumn 希望 Word 在一页上水平布置的页数。可以为 1、2、3 或 4。PrintZoomRow 希望 Word 在一页上垂直布置的页数。可以为 1、2 或 4。PrintZoomPaperWidth 希望 Word 将打印页缩放到的宽度（以缇表示，20 缇 = 1 磅）。
//PrintZoomPaperHeight 希望 Word 将打印页缩放到的高度（以缇表示）

        private void btnprintview_Click(object sender, EventArgs e)
        {
            Word.Document dct = this.fcWord.ActiveDocument as Word.Document;

          
            
            if (dct != null)
            {
                //dct.PrintOut(true);
                //跳出打印对话框，提供打印参数可视化设置，如选择哪个打印机打印此文档等
                PrintDialog pd = new PrintDialog();
                //pd.Document = (System.Drawing.Printing.PrintDocument)this.fcWord.;

                //pd.PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages;
                pd.AllowSomePages = true;
                pd.AllowCurrentPage = true;
                pd.AllowSelection = false;
                pd.PrinterSettings.PrintFileName = dct.Name;
                //pd.PrinterSettings.PrintRange=  System.Drawing.Printing.PrintRange.

                //dct.PrintOut(false);
                //return;

                if (DialogResult.OK == pd.ShowDialog()) //如果确认，将会覆盖所有的打印参数设置
                {
                    ////页面设置对话框（可以不使用，其实PrintDialog对话框已提供页面设置）
                    //PageSetupDialog psd = new PageSetupDialog();
                    //psd.Document = (System.Drawing.Printing.PrintDocument)dct.;
                    //if (DialogResult.OK == psd.ShowDialog())
                    //{
                    //    //打印预览
                    //    PrintPreviewDialog ppd = new PrintPreviewDialog();
                    //    ppd.Document = (System.Drawing.Printing.PrintDocument)dct;
                    //    if (DialogResult.OK == ppd.ShowDialog())
                    //        ((System.Drawing.Printing.PrintDocument)dct).Print(); //打印
                    //}

                    //Random r = new Random();
                    
                    object Background = true;

                    object Range = Word.WdPrintOutRange.wdPrintAllDocument;
                    object from = "0";
                    object to = "0";
                    if (pd.PrinterSettings.PrintRange == System.Drawing.Printing.PrintRange.AllPages)
                    {
                        Range = Word.WdPrintOutRange.wdPrintAllDocument;
                    }
                    else if (pd.PrinterSettings.PrintRange == System.Drawing.Printing.PrintRange.CurrentPage)
                    {
                        Range = Word.WdPrintOutRange.wdPrintCurrentPage;
                    }
                    else if (pd.PrinterSettings.PrintRange == System.Drawing.Printing.PrintRange.SomePages)
                    {
                        Range = Word.WdPrintOutRange.wdPrintFromTo;
                        from = pd.PrinterSettings.FromPage.ToString();
                        to = pd.PrinterSettings.ToPage.ToString();
                    }
                    else if (pd.PrinterSettings.PrintRange == System.Drawing.Printing.PrintRange.Selection)
                    {
                        Range = Word.WdPrintOutRange.wdPrintSelection;
                    }

                    object Copies = pd.PrinterSettings.Copies;

                    object PageType = Word.WdPrintOutPages.wdPrintAllPages;
                    if (rbtnall.Checked)
                    {
                        PageType = Word.WdPrintOutPages.wdPrintAllPages;
                    }
                    else if(rbtnj.Checked)
                    {
                        PageType = Word.WdPrintOutPages.wdPrintOddPagesOnly;
                    }
                    else if (rbtno.Checked)
                    {
                        PageType = Word.WdPrintOutPages.wdPrintEvenPagesOnly;
                    }
                    object PrintToFile = false;
                    object Collate = false;

                    object missing = Type.Missing;
                    object ActivePrinterMacGX = missing;
                    object ManualDuplexPrint = chkp.Checked;

                    if (rbtnj.Checked || rbtno.Checked)
                    {
                        ManualDuplexPrint = false;
                    }
                    else if (rbtnall.Checked && chkp.Checked)
                    {
                        ManualDuplexPrint = true;
                    }

                    object PrintZoomColumn = 1;
                    object PrintZoomRow = 1;

                    XMessageBox.ShowError(from + "|" + to);

                    dct.PrintOut(ref Background, ref missing, ref Range, ref missing, ref from, ref to, ref missing, ref Copies, ref missing, ref PageType, ref PrintToFile, ref Collate, ref missing, ref ManualDuplexPrint, ref PrintZoomColumn, ref PrintZoomRow, ref missing, ref missing);      


                    //axFramerControl1.PrintOut(false, printDialog1.PrinterSettings.PrinterName, printDialog1.PrinterSettings.Copies, printDialog1.PrinterSettings.FromPage, printDialog1.PrinterSettings.ToPage, printDialog1.PrinterSettings.PrintFileName);
                    //Object Nothing = System.Reflection.Missing.Value;
                    //object m_true = true;
                    //object m_false = false;
                    //object m_p = true;
                    //m_p = chkp.Checked;
                    //object m_miss = Type.Missing;
                    //dct.PrintOut(m_true, m_true, pd.PrinterSettings.PrintRange, pd.PrinterSettings.PrintFileName, pd.PrinterSettings.FromPage, pd.PrinterSettings.ToPage, m_miss, pd.PrinterSettings.Copies, m_miss, m_miss, pd.PrinterSettings.PrintToFile, pd.PrinterSettings.Collate, m_miss, pd.PrinterSettings.CanDuplex,m_miss, m_miss, m_miss, m_miss);
                    //dct.PrintOut(m_true, m_false, m_miss, m_miss, m_miss, m_miss, m_miss, m_miss, m_miss, m_miss, m_miss, m_true, m_miss, m_true, m_miss, m_miss, m_miss, m_miss);
                    //dct.PrintOut(m_true, m_false, pd.PrinterSettings.PrintRange, pd.PrinterSettings.PrintFileName, pd.PrinterSettings.FromPage, pd.PrinterSettings.ToPage, m_miss, m_miss, m_miss, m_miss, m_miss, m_miss, m_miss, pd.PrinterSettings.CanDuplex, m_miss, m_miss, m_miss, m_miss);

                    //dct.
                    //dct.PrintOut(true);

                }


            }
        }
    }
}
