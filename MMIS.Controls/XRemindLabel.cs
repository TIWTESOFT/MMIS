using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace MMIS.Controls
{
    public partial class XRemindLabel : XControlBase
    {
        public XRemindLabel()
        {
            InitializeComponent();
        }

        public string RemindText
        {
            get { return this.lblRemindText.Text; }
            set { this.lblRemindText.Text = value; }
        }

        public Font RemindTextFont
        {
            get { return this.lblRemindText.Font; }
            set { this.lblRemindText.Font = value; }
        }

        public Image RemindImage
        {
            get { return this.pcRemind.BackgroundImage; }
            set { this.pcRemind.BackgroundImage = value; }
        }
    }
}
