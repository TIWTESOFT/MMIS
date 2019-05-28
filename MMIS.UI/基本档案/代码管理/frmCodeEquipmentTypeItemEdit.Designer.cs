namespace MMIS.UI
{
    public partial class frmCodeEquipmentTypeItemEdit
    {
         /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNameEN = new MMIS.Component.XEditBox();
            this.txtNameCN = new MMIS.Component.XEditBox();
            this.nebCodeNum = new MMIS.Component.XNumberEditBox();
            this.txtSpell = new MMIS.Component.XEditBox();
            this.txtSpellHeader = new MMIS.Component.XEditBox();
            this.nebProirNum = new MMIS.Component.XNumberEditBox();
            this.lblNameEN = new MMIS.Component.XLabel();
            this.lblNameCN = new MMIS.Component.XLabel();
            this.lblCodeNum = new MMIS.Component.XLabel();
            this.lblCodeEN = new MMIS.Component.XLabel();
            this.lblSpell = new MMIS.Component.XLabel();
            this.lblSpellHeader = new MMIS.Component.XLabel();
            this.lblProirNum = new MMIS.Component.XLabel();
            this.txtrid = new MMIS.Component.XEditBox();
            this.cbodevselect = new MMIS.Component.XCombobox();
            this.lbxx = new MMIS.Component.XLabel();
            this.btnmodifyitem = new MMIS.Component.XButton();
            this.btnNewitem = new MMIS.Component.XButton();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(359, 73);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(446, 73);
            // 
            // txtNameEN
            // 
            this.txtNameEN.IsAllowEmpty = true;
            this.txtNameEN.Location = new System.Drawing.Point(336, 12);
            this.txtNameEN.Name = "txtNameEN";
            this.txtNameEN.Size = new System.Drawing.Size(185, 23);
            this.txtNameEN.TabIndex = 1;
            this.txtNameEN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtNameCN
            // 
            this.txtNameCN.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
            this.txtNameCN.Enabled = false;
            this.txtNameCN.IsAllowEmpty = false;
            this.txtNameCN.Location = new System.Drawing.Point(76, 12);
            this.txtNameCN.Name = "txtNameCN";
            this.txtNameCN.ReadOnly = true;
            this.txtNameCN.Size = new System.Drawing.Size(185, 21);
            this.txtNameCN.TabIndex = 0;
            this.txtNameCN.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebCodeNum
            // 
            this.nebCodeNum.FormatString = "0";
            this.nebCodeNum.IsAllowEmpty = false;
            this.nebCodeNum.IsAllowLessThanZero = false;
            this.nebCodeNum.IsAllowZero = true;
            this.nebCodeNum.Location = new System.Drawing.Point(95, 392);
            this.nebCodeNum.Name = "nebCodeNum";
            this.nebCodeNum.Size = new System.Drawing.Size(105, 23);
            this.nebCodeNum.TabIndex = 159;
            this.nebCodeNum.Text = "0";
            this.nebCodeNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebCodeNum.Visible = false;
            this.nebCodeNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpell
            // 
            this.txtSpell.IsAllowEmpty = false;
            this.txtSpell.Location = new System.Drawing.Point(95, 423);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(185, 23);
            this.txtSpell.TabIndex = 162;
            this.txtSpell.Visible = false;
            this.txtSpell.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtSpellHeader
            // 
            this.txtSpellHeader.IsAllowEmpty = false;
            this.txtSpellHeader.Location = new System.Drawing.Point(355, 423);
            this.txtSpellHeader.Name = "txtSpellHeader";
            this.txtSpellHeader.Size = new System.Drawing.Size(185, 23);
            this.txtSpellHeader.TabIndex = 163;
            this.txtSpellHeader.Visible = false;
            this.txtSpellHeader.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // nebProirNum
            // 
            this.nebProirNum.FormatString = "0";
            this.nebProirNum.IsAllowEmpty = false;
            this.nebProirNum.IsAllowLessThanZero = false;
            this.nebProirNum.IsAllowZero = true;
            this.nebProirNum.Location = new System.Drawing.Point(465, 392);
            this.nebProirNum.Name = "nebProirNum";
            this.nebProirNum.Size = new System.Drawing.Size(75, 23);
            this.nebProirNum.TabIndex = 161;
            this.nebProirNum.Text = "0";
            this.nebProirNum.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nebProirNum.Visible = false;
            this.nebProirNum.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblNameEN
            // 
            this.lblNameEN.AutoSize = true;
            this.lblNameEN.ForeColor = System.Drawing.Color.Black;
            this.lblNameEN.Location = new System.Drawing.Point(274, 15);
            this.lblNameEN.Name = "lblNameEN";
            this.lblNameEN.Size = new System.Drawing.Size(56, 17);
            this.lblNameEN.TabIndex = 165;
            this.lblNameEN.Text = "选项名称";
            // 
            // lblNameCN
            // 
            this.lblNameCN.AutoSize = true;
            this.lblNameCN.ForeColor = System.Drawing.Color.Black;
            this.lblNameCN.Location = new System.Drawing.Point(14, 15);
            this.lblNameCN.Name = "lblNameCN";
            this.lblNameCN.Size = new System.Drawing.Size(56, 17);
            this.lblNameCN.TabIndex = 166;
            this.lblNameCN.Text = "设备类型";
            // 
            // lblCodeNum
            // 
            this.lblCodeNum.AutoSize = true;
            this.lblCodeNum.ForeColor = System.Drawing.Color.Black;
            this.lblCodeNum.Location = new System.Drawing.Point(33, 395);
            this.lblCodeNum.Name = "lblCodeNum";
            this.lblCodeNum.Size = new System.Drawing.Size(56, 17);
            this.lblCodeNum.TabIndex = 169;
            this.lblCodeNum.Text = "数字代码";
            this.lblCodeNum.Visible = false;
            // 
            // lblCodeEN
            // 
            this.lblCodeEN.AutoSize = true;
            this.lblCodeEN.ForeColor = System.Drawing.Color.Black;
            this.lblCodeEN.Location = new System.Drawing.Point(215, 395);
            this.lblCodeEN.Name = "lblCodeEN";
            this.lblCodeEN.Size = new System.Drawing.Size(56, 17);
            this.lblCodeEN.TabIndex = 170;
            this.lblCodeEN.Text = "字母代码";
            this.lblCodeEN.Visible = false;
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.ForeColor = System.Drawing.Color.Black;
            this.lblSpell.Location = new System.Drawing.Point(33, 426);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(32, 17);
            this.lblSpell.TabIndex = 171;
            this.lblSpell.Text = "拼音";
            this.lblSpell.Visible = false;
            // 
            // lblSpellHeader
            // 
            this.lblSpellHeader.AutoSize = true;
            this.lblSpellHeader.ForeColor = System.Drawing.Color.Black;
            this.lblSpellHeader.Location = new System.Drawing.Point(293, 426);
            this.lblSpellHeader.Name = "lblSpellHeader";
            this.lblSpellHeader.Size = new System.Drawing.Size(56, 17);
            this.lblSpellHeader.TabIndex = 172;
            this.lblSpellHeader.Text = "拼音缩写";
            this.lblSpellHeader.Visible = false;
            // 
            // lblProirNum
            // 
            this.lblProirNum.AutoSize = true;
            this.lblProirNum.ForeColor = System.Drawing.Color.Black;
            this.lblProirNum.Location = new System.Drawing.Point(403, 395);
            this.lblProirNum.Name = "lblProirNum";
            this.lblProirNum.Size = new System.Drawing.Size(44, 17);
            this.lblProirNum.TabIndex = 173;
            this.lblProirNum.Text = "顺序号";
            this.lblProirNum.Visible = false;
            // 
            // txtrid
            // 
            this.txtrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
            this.txtrid.Enabled = false;
            this.txtrid.IsAllowEmpty = false;
            this.txtrid.Location = new System.Drawing.Point(76, -6);
            this.txtrid.Name = "txtrid";
            this.txtrid.ReadOnly = true;
            this.txtrid.Size = new System.Drawing.Size(185, 21);
            this.txtrid.TabIndex = 174;
            this.txtrid.Visible = false;
            this.txtrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cbodevselect
            // 
            this.cbodevselect.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.cbodevselect.IsAllowEmpty = false;
            this.cbodevselect.Location = new System.Drawing.Point(76, 39);
            this.cbodevselect.Name = "cbodevselect";
            this.cbodevselect.Size = new System.Drawing.Size(185, 23);
            this.cbodevselect.TabIndex = 175;
            this.cbodevselect.Visible = false;
            this.cbodevselect.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cbodevselect.SelectedIndexChanged += new System.EventHandler(this.cbodevselect_SelectedIndexChanged);
            // 
            // lbxx
            // 
            this.lbxx.AutoSize = true;
            this.lbxx.ForeColor = System.Drawing.Color.Black;
            this.lbxx.Location = new System.Drawing.Point(14, 45);
            this.lbxx.Name = "lbxx";
            this.lbxx.Size = new System.Drawing.Size(56, 17);
            this.lbxx.TabIndex = 176;
            this.lbxx.Text = "选择选项";
            this.lbxx.Visible = false;
            // 
            // btnmodifyitem
            // 
            this.btnmodifyitem.Location = new System.Drawing.Point(194, 77);
            this.btnmodifyitem.Name = "btnmodifyitem";
            this.btnmodifyitem.Size = new System.Drawing.Size(96, 23);
            this.btnmodifyitem.TabIndex = 179;
            this.btnmodifyitem.Text = "修改设备规格";
            this.btnmodifyitem.Visible = false;
            this.btnmodifyitem.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnmodifyitem.Click += new System.EventHandler(this.btnmodifyitem_Click);
            // 
            // btnNewitem
            // 
            this.btnNewitem.Location = new System.Drawing.Point(76, 77);
            this.btnNewitem.Name = "btnNewitem";
            this.btnNewitem.Size = new System.Drawing.Size(96, 23);
            this.btnNewitem.TabIndex = 178;
            this.btnNewitem.Text = "新增设备规格";
            this.btnNewitem.Visible = false;
            this.btnNewitem.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnNewitem.Click += new System.EventHandler(this.btnNewitem_Click);
            // 
            // frmCodeEquipmentTypeItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(534, 111);
            this.Controls.Add(this.btnmodifyitem);
            this.Controls.Add(this.btnNewitem);
            this.Controls.Add(this.lbxx);
            this.Controls.Add(this.cbodevselect);
            this.Controls.Add(this.txtrid);
            this.Controls.Add(this.txtNameEN);
            this.Controls.Add(this.txtNameCN);
            this.Controls.Add(this.nebCodeNum);
            this.Controls.Add(this.txtSpell);
            this.Controls.Add(this.txtSpellHeader);
            this.Controls.Add(this.nebProirNum);
            this.Controls.Add(this.lblNameEN);
            this.Controls.Add(this.lblNameCN);
            this.Controls.Add(this.lblCodeNum);
            this.Controls.Add(this.lblCodeEN);
            this.Controls.Add(this.lblSpell);
            this.Controls.Add(this.lblSpellHeader);
            this.Controls.Add(this.lblProirNum);
            this.Name = "frmCodeEquipmentTypeItemEdit";
            this.Text = "设备选项";
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblProirNum, 0);
            this.Controls.SetChildIndex(this.lblSpellHeader, 0);
            this.Controls.SetChildIndex(this.lblSpell, 0);
            this.Controls.SetChildIndex(this.lblCodeEN, 0);
            this.Controls.SetChildIndex(this.lblCodeNum, 0);
            this.Controls.SetChildIndex(this.lblNameCN, 0);
            this.Controls.SetChildIndex(this.lblNameEN, 0);
            this.Controls.SetChildIndex(this.nebProirNum, 0);
            this.Controls.SetChildIndex(this.txtSpellHeader, 0);
            this.Controls.SetChildIndex(this.txtSpell, 0);
            this.Controls.SetChildIndex(this.nebCodeNum, 0);
            this.Controls.SetChildIndex(this.txtNameCN, 0);
            this.Controls.SetChildIndex(this.txtNameEN, 0);
            this.Controls.SetChildIndex(this.txtrid, 0);
            this.Controls.SetChildIndex(this.cbodevselect, 0);
            this.Controls.SetChildIndex(this.lbxx, 0);
            this.Controls.SetChildIndex(this.btnNewitem, 0);
            this.Controls.SetChildIndex(this.btnmodifyitem, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Component.XEditBox txtNameEN;
        private Component.XEditBox txtNameCN;
        private Component.XNumberEditBox nebCodeNum;
        private Component.XEditBox txtSpell;
        private Component.XEditBox txtSpellHeader;
        private Component.XNumberEditBox nebProirNum;
        private Component.XLabel lblNameEN;
        private Component.XLabel lblNameCN;
        private Component.XLabel lblCodeNum;
        private Component.XLabel lblCodeEN;
        private Component.XLabel lblSpell;
        private Component.XLabel lblSpellHeader;
        private Component.XLabel lblProirNum;
        private Component.XEditBox txtrid;
        private Component.XCombobox cbodevselect;
        private Component.XLabel lbxx;
        private Component.XButton btnmodifyitem;
        private Component.XButton btnNewitem;
        
    }
}