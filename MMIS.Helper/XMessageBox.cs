using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MMIS.Helper
{
    /// <summary>
    /// XMessageBox 类
    /// 名称: 
    /// 功能: 
    /// 时间: 6/30/2011 2:05:00 PM
    /// 作者: Lizard
    /// </summary>
    public class XMessageBox
    {
        #region 构造和析构

        /// <summary>
        /// 构造
        /// </summary>
        public XMessageBox()
        {
        }

        #endregion // 构造和析构

        #region 公有方法

        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="text">要显示的信息</param>
        /// <param name="caption">标题</param>
        /// <returns></returns>
        public static DialogResult ShowRemindMessage(string text, string caption = "")
        {
            caption = GetMessageCaption(caption);
            return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 显示错误信息
        /// </summary>
        /// <param name="text">要显示的信息</param>
        /// <param name="caption">标题</param>
        /// <returns></returns>
        public static DialogResult ShowError(string text, string caption = "")
        {
            caption = GetMessageCaption(caption);
            return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowExclamation(string text, string caption = "")
        {
            caption = GetMessageCaption(caption);
            return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// 显示提示信息
        /// </summary>
        /// <param name="text">要显示的信息</param>
        /// <param name="caption">标题</param>
        /// <returns></returns>
        public static DialogResult ShowQuestion(string text, string caption = "", bool isHaveCancel = false)
        {
            caption = GetMessageCaption(caption);
            if (isHaveCancel)
            {
                return MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else
            {
                return MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            }
        }

        #endregion // 公有方法

        #region 保护方法
        #endregion // 保护方法

        #region 私有方法

        /// <summary>
        /// 获得消息框标题
        /// </summary>
        /// <param name="caption"></param>
        /// <returns></returns>
        private static string GetMessageCaption(string caption)
        {
            if (caption.Trim() != string.Empty)
            {
                return caption;
            }
            else
            {
                return "提示";
            }
        }

        #endregion // 私有方法

        #region 属性及其私有变量
        #endregion // 属性及其私有变量

    }
}