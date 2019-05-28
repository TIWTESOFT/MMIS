using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MMIS.Helper
{
    /// <summary>
    /// XMessageBox ��
    /// ����: 
    /// ����: 
    /// ʱ��: 6/30/2011 2:05:00 PM
    /// ����: Lizard
    /// </summary>
    public class XMessageBox
    {
        #region ���������

        /// <summary>
        /// ����
        /// </summary>
        public XMessageBox()
        {
        }

        #endregion // ���������

        #region ���з���

        /// <summary>
        /// ��ʾ��ʾ��Ϣ
        /// </summary>
        /// <param name="text">Ҫ��ʾ����Ϣ</param>
        /// <param name="caption">����</param>
        /// <returns></returns>
        public static DialogResult ShowRemindMessage(string text, string caption = "")
        {
            caption = GetMessageCaption(caption);
            return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// ��ʾ������Ϣ
        /// </summary>
        /// <param name="text">Ҫ��ʾ����Ϣ</param>
        /// <param name="caption">����</param>
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
        /// ��ʾ��ʾ��Ϣ
        /// </summary>
        /// <param name="text">Ҫ��ʾ����Ϣ</param>
        /// <param name="caption">����</param>
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

        #endregion // ���з���

        #region ��������
        #endregion // ��������

        #region ˽�з���

        /// <summary>
        /// �����Ϣ�����
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
                return "��ʾ";
            }
        }

        #endregion // ˽�з���

        #region ���Լ���˽�б���
        #endregion // ���Լ���˽�б���

    }
}