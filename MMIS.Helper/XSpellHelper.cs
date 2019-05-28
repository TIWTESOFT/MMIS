using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.International.Converters.PinYinConverter;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;

namespace MMIS.Helper
{
    public partial class XSpellHelper
    {
        public static string GetFullSpell(string spellValue)
        {
            string value = string.Empty;

            foreach (char c in spellValue)
            {
                if (IsChineseCharacters(c.ToString()))
                {
                    ChineseChar chineseChar = new ChineseChar(c);
                    ReadOnlyCollection<string> readOnlyDinosaurs = chineseChar.Pinyins;
                    if (readOnlyDinosaurs.Count > 0)
                    {
                        value += readOnlyDinosaurs[0].Substring(0, readOnlyDinosaurs[0].Length - 1).ToLower();
                    }
                    else
                    {
                        value += c;
                    }
                }
                else
                {
                    value += c;
                }
            }

            return value;
        }

        public static bool IsChineseCharacters(string chrStr)
        {
            Regex CheckStr = new Regex("[\u4e00-\u9fa5]");
            return CheckStr.IsMatch(chrStr);
        }

        public static string GetSpellHeader(string spellValue)
        {
            string value = string.Empty;

            foreach (char c in spellValue)
            {
                if (IsChineseCharacters(c.ToString()))
                {
                    string spell = GetFullSpell(c.ToString());
                    value += spell.Substring(0, 1);
                }
                else
                {
                    value += c;
                }
            }

            return value;
        }
    }
}
