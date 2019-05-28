using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MMIS.UI.Common
{
    /// <summary>
    /// frmBase ����
    /// ����: 
    /// ����: 
    /// ʱ��: 2011/8/30 21:47:48
    /// ����: lmm_wss
    /// </summary>
    public partial class frmBase : Form
    {
        #region ���������

        public frmBase()
        {
            //
            // Windows ���������֧���������
            //
            InitializeComponent();
        }

        #endregion // ���������

        private void frmBase_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                this.FormLoadFunction(sender, e);

                SetFormControlFont(this);
            }
        }

        #region ���з���
        #endregion // ���з���

        #region ��������

        protected virtual void SetFormControlFont(Control cr)
        {
            foreach (Control c in cr.Controls)
            {
                if (c.Font.Size < XCommon.gFontSize)
                {
                    c.Font = new Font("����", XCommon.gFontSize);
                }
                
                if (c.HasChildren)
                {
                    SetFormControlFont(c);
                }
            }
        }

        /// <summary>
        /// ͨ����Ȩ���ÿؼ�
        /// </summary>
        protected virtual void SetFormControlByAuthon()
        {
            foreach (Control c in this.Controls)
            {
                this.SetControlStatus(c);
            }
        }

        /// <summary>
        /// ���ÿؼ�״̬
        /// </summary>
        /// <param name="c"></param>
        protected virtual void SetControlStatus(Control c)
        {
            if (!this.GetControlEnableFromAuthon(c))
            {
                if (c is DataGridView)
                {
                    //���������
                    DataGridView gridView = c as DataGridView;
                    gridView.DataSource = null;
                    gridView.Refresh();
                    gridView.Enabled = false;
                }
                else
                {
                    c.Enabled = false;
                }
                if (c.HasChildren)
                {
                    foreach (Control childControl in c.Controls)
                    {
                        this.SetControlStatus(childControl);
                    }
                }
            }
        }


        /// <summary>
        /// ͨ����Ȩ�ݹ��ÿؼ��Ƿ����
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        protected virtual bool GetControlEnableFromAuthon(Control c)
        {
            return true;
        }

        protected virtual void FormLoadFunction(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.SetFormControlByAuthon();
        }

        #endregion // ��������

        #region ˽�з���
        #endregion // ˽�з���

        #region ���Լ���˽�б���

        /// <summary>
        /// ������Ϣ
        /// </summary>
        protected string m_ErrorInfo = "";

        /// <summary>
        /// �ؼ��֣������򿪴���ʱ�����ظ���
        /// </summary>
        public virtual string Key
        {
            get { return this.ToString(); }
        }

        #endregion // ���Լ���˽�б���

        private void frmBase_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        /// <summary>
        /// �û�Id
        /// </summary>
        protected virtual string UserId
        {
            get { return XCommon.LoginUsersInfo.RID; }
        }

        /// <summary>
        /// ��ȡ������λ
        /// </summary>
        protected virtual string JobCode
        {
            get { return string.Empty; }
        }
    }
}

