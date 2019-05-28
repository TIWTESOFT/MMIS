using System;
using System.Collections.Generic;
using System.Text;

namespace MMIS.Helper
{
    public class XNumberHelper
    {
        /// <summary>
        /// 是否数字
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumber(object value)
        {
            try
            {
                Convert.ToDouble(value.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
