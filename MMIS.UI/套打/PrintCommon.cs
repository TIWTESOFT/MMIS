using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;

namespace MMIS.UI 
{
   public  class PrintCommon
    {
       public System.Drawing.Printing.PaperSize GetPaperSize(float width, float height)
        {
            //返回特定的纸张大小
            //width, height 都是厘米
            return new System.Drawing.Printing.PaperSize("", (int)Cm2Pix(width), (int)Cm2Pix(height));
        }
        public double Cm2Pix(float cm)
        {
            //厘米到像素的转换
            return System.Drawing.Printing.PrinterUnitConvert.Convert((double)cm * 100, System.Drawing.Printing.PrinterUnit.TenthsOfAMillimeter, System.Drawing.Printing.PrinterUnit.Display);
        }
        public double Pix2Cm(float cm)
        {
            //像素到厘米的转换
            return System.Drawing.Printing.PrinterUnitConvert.Convert((double)cm, System.Drawing.Printing.PrinterUnit.Display, System.Drawing.Printing.PrinterUnit.TenthsOfAMillimeter) / 100;
        }

        public float GetDBInt(object dbCol)
        {
            float num = 0;
            try
            {
                if ((object.ReferenceEquals(dbCol, DBNull.Value) || dbCol == null))
                {
                    return 0;
                }
                num = Convert.ToSingle(dbCol);
            }
            catch (Exception ex)
            {
                return 0;
            }

            return num;
        }
        public string GetDBString(object dbCol)
        {
            string text = null;
            try
            {
                if ((object.ReferenceEquals(dbCol, DBNull.Value) || dbCol == null))
                {
                    return "";
                }
                text = dbCol.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
            return text;
        }


    }
}
