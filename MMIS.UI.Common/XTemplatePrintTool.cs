using MMIS.Helper;
using MMIS.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Word = Microsoft.Office.Interop.Word;

namespace MMIS.UI.Common
{
    public class XTemplatePrintTool
    {
        public static bool Print(string fileName, XModelBase model)
        {
            Word.Application app = new Word.Application();
            Word.Document dct = app.Documents.Open(fileName);

            Word.Bookmarks bookMarks = dct.Bookmarks;
            foreach (Word.Bookmark bookMark in bookMarks)
            {
                string bookMarkValue = GetBookMarkValue(bookMark.Name, model);
                bookMark.Range.Text = bookMarkValue;
            }
            app.Visible = true;
            return true;
        }

        private static string GetBookMarkValue(string bookMarkName, XModelBase model)
        {
            Type type = model.GetType();

            string[] bookMarkNames = bookMarkName.Split('_');
            if (bookMarkNames.Length > 0)
            {
                bookMarkName = bookMarkNames[0];
            }

            PropertyInfo pi = type.GetProperty(bookMarkName);
            if (pi != null)
            {
                return pi.GetValue(model, null).ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
