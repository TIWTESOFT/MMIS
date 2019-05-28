using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MMIS.Component;
using MMIS.Helper;

namespace MMIS.UI.Common
{
    public class XFormValidateTool
    {
        protected ErrorProvider m_ErrorProvider = new ErrorProvider();

        /// <summary>
        /// 校验控件
        /// </summary>
        /// <param name="parentControl"></param>
        public bool ValidateControls(Control parentControl)
        {
            this.m_ErrorProvider.Clear();

            foreach (Control control in parentControl.Controls)
            {
                if (control.Visible == false)
                {
                    continue;
                }
                if (control.HasChildren)
                {
                    if (!this.ValidateSingleControl(control))
                    {
                        return false;
                    }
                    else
                    {
                        if (!ValidateControls(control))
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (!this.ValidateSingleControl(control))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 校验单个控件
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private bool ValidateSingleControl(Control control)
        {
            if (control.Visible == false)
            {
                return true;
            }

            if (control is XEditBox)
            {
                XEditBox editBox = control as XEditBox;
                if (editBox.Visible == false)
                {
                    return true;
                }
                if (!editBox.IsAllowEmpty && editBox.Text.Trim() == string.Empty)
                {
                    this.m_ErrorProvider.SetError(control, "不能为空！");
                    return false;
                }
            }
            else if (control is XNumberEditBox)
            {
                XNumberEditBox numberEditBox = control as XNumberEditBox;
                if (numberEditBox.Visible == false)
                {
                    return true;
                }
                double value = XHelper.GetDouble(numberEditBox.Value);
                if (!numberEditBox.IsAllowZero && value == 0)
                {
                    this.m_ErrorProvider.SetError(control, "不能为0！");
                    return false;
                }
                else if (!numberEditBox.IsAllowLessThanZero && value < 0)
                {
                    this.m_ErrorProvider.SetError(control, "不能小于0！");
                    return false;
                }
            }
            else if (control is XCombobox)
            {
                XCombobox comboBox = control as XCombobox;
                if (!comboBox.IsAllowEmpty && comboBox.Text.Trim() == string.Empty)
                {
                    this.m_ErrorProvider.SetError(control, "不能为空！");
                    return false;
                }
            }

            return true;
        }
    }
}
