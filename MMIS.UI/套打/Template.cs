using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Collections;
using System.Data;
using System.Diagnostics;

namespace MMIS.UI 
{
   public   class Template
    {

       private PrintCommon cMm = new PrintCommon();
        //<Summary>
        //定义输出对象
        //<Summary>
        //=============================
        //
        //=============================
        //保存数据字典
        public  DataTable templateItems;


        public GoldPrinter.MisGoldPrinter printerObject;

        public bool ShowPSDialog = false;

        public GoldPrinter.ImportExcelDelegate m_PrinterExcel;
        //系统调整X值
        public double SysX = 0;
        //系统调整Y值
        public double SysY = 0;
        public static event PrintClickedEventHandler PrintClicked;
        public  delegate void PrintClickedEventHandler();
        private struct ItemInfo
        {
            public float x;
            public float y;
            public float height;
            public float width;
            public string font;
            public int fontSize;
            public string text;
        }
        public void Dispose()
        {
            this.printerObject.Dispose();
            this.templateItems.Dispose();
        }
        private void OnPrintClicked(object sender, EventArgs e)
        {
            if (PrintClicked != null)
            {
                PrintClicked();
            }
        }
        public Template(DataTable items, string _text = "")
        {
            //<summary>
            //测试
            //<summary>
            templateItems = items;

            printerObject = new GoldPrinter.MisGoldPrinter();

            printerObject.GridBorder = GoldPrinter.GridBorderFlag.None;

            printerObject.DocumentName = "打印预览_" + _text;
            printerObject.PrintClicked += OnPrintClicked;


            //DataTable vTable = GetDataTableFromXML("BillPageJudge", Application.StartupPath + "\\Files\\BillPageJudge.xml");
            ////DBClass.GetDataTableAll("BillPageJudge")
            //if ((vTable != null) & vTable.Rows.Count > 0)
            //{
            //    SysX = GetDBInt(vTable.Rows[0]["SYS_X"] + "");
            //    SysY = GetDBInt(vTable.Rows[0]["SYS_Y"] + "");
            //}


            if ((templateItems != null))
            {
                DrawTemplate();
            }

        }
        public  void Preview()
        {
            printerObject.Preview();
        }
        public  void PrintDT(DataTable d)
        {
            printerObject.DataSource = d;
            printerObject.Preview();
        }

        public  void Print()
        {
            printerObject.Print(ShowPSDialog);
        }
        private GoldPrinter.TextItem NewItem(DataRow ti)
        {
            GoldPrinter.TextItem item = new GoldPrinter.TextItem();

            if ((ti != null))
            {
                item.X =(int) cMm.Cm2Pix((float)cMm.GetDBInt(ti["X"])); //- SysX
                item.Y = (int)cMm.Cm2Pix((float)cMm.GetDBInt(ti["Y"]));// - SysY
                item.Width = (int)cMm.Cm2Pix((float)cMm.GetDBInt(ti["Width"]));
                item.Height = (int)cMm.Cm2Pix((float)cMm.GetDBInt(ti["Height"]));
                if (cMm.GetDBInt(ti["FontSize"]) <= 0)
                {
                    ti["FontSize"] = 11;
                }
                item.Font = new Font(Convert.ToString(ti["FontName"] + ""), cMm.GetDBInt(ti["FontSize"]));
                item.Text = ti["TemplateID"] + "";
            }
            else
            {
                item = null;
            }


            return item;
        }

        private void DrawTemplate()
        {
            int i = 0;
            GoldPrinter.TextItem item = default(GoldPrinter.TextItem);
            DataRow row = null;

            for (i = 0; i <= this.templateItems.Rows.Count - 1; i++)
            {
                row = this.templateItems.Rows[i];
                item = NewItem(row);
                if ((item != null))
                {
                    printerObject.AddTextItem(item);
                }
            }
        }


    }
}
