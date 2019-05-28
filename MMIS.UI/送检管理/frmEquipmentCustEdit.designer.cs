namespace MMIS.UI
{
    public partial class frmEquipmentCustEdit
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
            this.lblCustTypeId = new MMIS.Component.XLabel();
            this.lblCustName = new MMIS.Component.XLabel();
            this.lblCustNo = new MMIS.Component.XLabel();
            this.lblCustAddress = new MMIS.Component.XLabel();
            this.lblLinkPeople = new MMIS.Component.XLabel();
            this.lblMobileNo = new MMIS.Component.XLabel();
            this.lblWorkTel = new MMIS.Component.XLabel();
            this.lblEmail = new MMIS.Component.XLabel();
            this.lblWebSite = new MMIS.Component.XLabel();
            this.lblCustDesc = new MMIS.Component.XLabel();
            this.lblRemark = new MMIS.Component.XLabel();
            this.txtCustName = new MMIS.Component.XEditBox();
            this.txtCustNo = new MMIS.Component.XEditBox();
            this.txtCustAddress = new MMIS.Component.XEditBox();
            this.txtLinkPeople = new MMIS.Component.XEditBox();
            this.txtMobileNo = new MMIS.Component.XEditBox();
            this.txtWorkTel = new MMIS.Component.XEditBox();
            this.txtEmail = new MMIS.Component.XEditBox();
            this.txtWebSite = new MMIS.Component.XEditBox();
            this.txtCustDesc = new MMIS.Component.XEditBox();
            this.txtRemark = new MMIS.Component.XEditBox();
            this.txtCustTypeId = new MMIS.UI.XSelectCodeEquipmentCustTypeEditBox();
            this.xLabel1 = new MMIS.Component.XLabel();
            this.txtInvoiceTitle = new MMIS.Component.XEditBox();
            this.xLabel2 = new MMIS.Component.XLabel();
            this.txtTaxNo = new MMIS.Component.XEditBox();
            this.txtBank = new MMIS.Component.XEditBox();
            this.xLabel3 = new MMIS.Component.XLabel();
            this.xLabel4 = new MMIS.Component.XLabel();
            this.txtAccountNo = new MMIS.Component.XEditBox();
            this.xLabel5 = new MMIS.Component.XLabel();
            this.chkcopy = new MMIS.Component.XCheckBox();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(616, 345);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(703, 345);
            // 
            // lblCustTypeId
            // 
            this.lblCustTypeId.AutoSize = true;
            this.lblCustTypeId.ForeColor = System.Drawing.Color.Black;
            this.lblCustTypeId.Location = new System.Drawing.Point(42, 352);
            this.lblCustTypeId.Name = "lblCustTypeId";
            this.lblCustTypeId.Size = new System.Drawing.Size(56, 17);
            this.lblCustTypeId.TabIndex = 1;
            this.lblCustTypeId.Text = "单位类型";
            this.lblCustTypeId.Visible = false;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.ForeColor = System.Drawing.Color.Black;
            this.lblCustName.Location = new System.Drawing.Point(14, 14);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(56, 17);
            this.lblCustName.TabIndex = 2;
            this.lblCustName.Text = "单位名称";
            // 
            // lblCustNo
            // 
            this.lblCustNo.AutoSize = true;
            this.lblCustNo.ForeColor = System.Drawing.Color.Black;
            this.lblCustNo.Location = new System.Drawing.Point(14, 46);
            this.lblCustNo.Name = "lblCustNo";
            this.lblCustNo.Size = new System.Drawing.Size(56, 17);
            this.lblCustNo.TabIndex = 3;
            this.lblCustNo.Text = "单位编号";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.ForeColor = System.Drawing.Color.Black;
            this.lblCustAddress.Location = new System.Drawing.Point(14, 77);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(56, 17);
            this.lblCustAddress.TabIndex = 4;
            this.lblCustAddress.Text = "单位地址";
            // 
            // lblLinkPeople
            // 
            this.lblLinkPeople.AutoSize = true;
            this.lblLinkPeople.ForeColor = System.Drawing.Color.Black;
            this.lblLinkPeople.Location = new System.Drawing.Point(271, 46);
            this.lblLinkPeople.Name = "lblLinkPeople";
            this.lblLinkPeople.Size = new System.Drawing.Size(44, 17);
            this.lblLinkPeople.TabIndex = 5;
            this.lblLinkPeople.Text = "联系人";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.ForeColor = System.Drawing.Color.Black;
            this.lblMobileNo.Location = new System.Drawing.Point(530, 46);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(32, 17);
            this.lblMobileNo.TabIndex = 6;
            this.lblMobileNo.Text = "手机";
            // 
            // lblWorkTel
            // 
            this.lblWorkTel.AutoSize = true;
            this.lblWorkTel.ForeColor = System.Drawing.Color.Black;
            this.lblWorkTel.Location = new System.Drawing.Point(531, 77);
            this.lblWorkTel.Name = "lblWorkTel";
            this.lblWorkTel.Size = new System.Drawing.Size(56, 17);
            this.lblWorkTel.TabIndex = 7;
            this.lblWorkTel.Text = "单位电话";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(14, 109);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 17);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "邮箱";
            // 
            // lblWebSite
            // 
            this.lblWebSite.AutoSize = true;
            this.lblWebSite.ForeColor = System.Drawing.Color.Black;
            this.lblWebSite.Location = new System.Drawing.Point(271, 109);
            this.lblWebSite.Name = "lblWebSite";
            this.lblWebSite.Size = new System.Drawing.Size(32, 17);
            this.lblWebSite.TabIndex = 9;
            this.lblWebSite.Text = "网址";
            // 
            // lblCustDesc
            // 
            this.lblCustDesc.AutoSize = true;
            this.lblCustDesc.ForeColor = System.Drawing.Color.Black;
            this.lblCustDesc.Location = new System.Drawing.Point(14, 201);
            this.lblCustDesc.Name = "lblCustDesc";
            this.lblCustDesc.Size = new System.Drawing.Size(56, 17);
            this.lblCustDesc.TabIndex = 10;
            this.lblCustDesc.Text = "单位描述";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.ForeColor = System.Drawing.Color.Black;
            this.lblRemark.Location = new System.Drawing.Point(14, 273);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(56, 17);
            this.lblRemark.TabIndex = 11;
            this.lblRemark.Text = "备注信息";
            // 
            // txtCustName
            // 
            this.txtCustName.IsAllowEmpty = false;
            this.txtCustName.Location = new System.Drawing.Point(76, 11);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(701, 23);
            this.txtCustName.TabIndex = 2;
            this.txtCustName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCustNo
            // 
            this.txtCustNo.IsAllowEmpty = true;
            this.txtCustNo.Location = new System.Drawing.Point(76, 43);
            this.txtCustNo.Name = "txtCustNo";
            this.txtCustNo.Size = new System.Drawing.Size(185, 23);
            this.txtCustNo.TabIndex = 3;
            this.txtCustNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.IsAllowEmpty = true;
            this.txtCustAddress.Location = new System.Drawing.Point(76, 74);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(442, 23);
            this.txtCustAddress.TabIndex = 6;
            this.txtCustAddress.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtLinkPeople
            // 
            this.txtLinkPeople.IsAllowEmpty = true;
            this.txtLinkPeople.Location = new System.Drawing.Point(333, 43);
            this.txtLinkPeople.Name = "txtLinkPeople";
            this.txtLinkPeople.Size = new System.Drawing.Size(185, 23);
            this.txtLinkPeople.TabIndex = 4;
            this.txtLinkPeople.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.IsAllowEmpty = true;
            this.txtMobileNo.Location = new System.Drawing.Point(592, 43);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(185, 23);
            this.txtMobileNo.TabIndex = 5;
            this.txtMobileNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtWorkTel
            // 
            this.txtWorkTel.IsAllowEmpty = true;
            this.txtWorkTel.Location = new System.Drawing.Point(593, 74);
            this.txtWorkTel.Name = "txtWorkTel";
            this.txtWorkTel.Size = new System.Drawing.Size(185, 23);
            this.txtWorkTel.TabIndex = 7;
            this.txtWorkTel.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtEmail
            // 
            this.txtEmail.IsAllowEmpty = true;
            this.txtEmail.Location = new System.Drawing.Point(76, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 23);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtWebSite
            // 
            this.txtWebSite.IsAllowEmpty = true;
            this.txtWebSite.Location = new System.Drawing.Point(336, 106);
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(442, 23);
            this.txtWebSite.TabIndex = 9;
            this.txtWebSite.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCustDesc
            // 
            this.txtCustDesc.IsAllowEmpty = true;
            this.txtCustDesc.Location = new System.Drawing.Point(76, 198);
            this.txtCustDesc.Multiline = true;
            this.txtCustDesc.Name = "txtCustDesc";
            this.txtCustDesc.Size = new System.Drawing.Size(702, 65);
            this.txtCustDesc.TabIndex = 14;
            this.txtCustDesc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtRemark
            // 
            this.txtRemark.IsAllowEmpty = true;
            this.txtRemark.Location = new System.Drawing.Point(76, 270);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(702, 63);
            this.txtRemark.TabIndex = 15;
            this.txtRemark.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtCustTypeId
            // 
            this.txtCustTypeId.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Ellipsis;
            this.txtCustTypeId.DisplayMember = "";
            this.txtCustTypeId.IsAllowEmpty = false;
            this.txtCustTypeId.Location = new System.Drawing.Point(104, 349);
            this.txtCustTypeId.Name = "txtCustTypeId";
            this.txtCustTypeId.QueryCheckBox = null;
            this.txtCustTypeId.QueryFieldName = null;
            this.txtCustTypeId.QueryOperateType = MMIS.Component.XQueryOperateType.Equal;
            this.txtCustTypeId.ReadOnly = true;
            this.txtCustTypeId.SelectedModel = null;
            this.txtCustTypeId.Size = new System.Drawing.Size(185, 23);
            this.txtCustTypeId.TabIndex = 0;
            this.txtCustTypeId.ValueMember = "";
            this.txtCustTypeId.Visible = false;
            this.txtCustTypeId.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel1
            // 
            this.xLabel1.AutoSize = true;
            this.xLabel1.ForeColor = System.Drawing.Color.Black;
            this.xLabel1.Location = new System.Drawing.Point(14, 139);
            this.xLabel1.Name = "xLabel1";
            this.xLabel1.Size = new System.Drawing.Size(56, 17);
            this.xLabel1.TabIndex = 102;
            this.xLabel1.Text = "发票抬头";
            // 
            // txtInvoiceTitle
            // 
            this.txtInvoiceTitle.IsAllowEmpty = true;
            this.txtInvoiceTitle.Location = new System.Drawing.Point(76, 137);
            this.txtInvoiceTitle.Name = "txtInvoiceTitle";
            this.txtInvoiceTitle.Size = new System.Drawing.Size(442, 23);
            this.txtInvoiceTitle.TabIndex = 10;
            this.txtInvoiceTitle.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.ForeColor = System.Drawing.Color.Black;
            this.xLabel2.Location = new System.Drawing.Point(531, 139);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(32, 17);
            this.xLabel2.TabIndex = 104;
            this.xLabel2.Text = "税号";
            // 
            // txtTaxNo
            // 
            this.txtTaxNo.IsAllowEmpty = true;
            this.txtTaxNo.Location = new System.Drawing.Point(593, 137);
            this.txtTaxNo.Name = "txtTaxNo";
            this.txtTaxNo.Size = new System.Drawing.Size(185, 23);
            this.txtTaxNo.TabIndex = 11;
            this.txtTaxNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtBank
            // 
            this.txtBank.IsAllowEmpty = true;
            this.txtBank.Location = new System.Drawing.Point(76, 168);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(185, 23);
            this.txtBank.TabIndex = 12;
            this.txtBank.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel3
            // 
            this.xLabel3.AutoSize = true;
            this.xLabel3.ForeColor = System.Drawing.Color.Black;
            this.xLabel3.Location = new System.Drawing.Point(14, 171);
            this.xLabel3.Name = "xLabel3";
            this.xLabel3.Size = new System.Drawing.Size(44, 17);
            this.xLabel3.TabIndex = 107;
            this.xLabel3.Text = "开户行";
            // 
            // xLabel4
            // 
            this.xLabel4.AutoSize = true;
            this.xLabel4.ForeColor = System.Drawing.Color.Black;
            this.xLabel4.Location = new System.Drawing.Point(266, 171);
            this.xLabel4.Name = "xLabel4";
            this.xLabel4.Size = new System.Drawing.Size(68, 17);
            this.xLabel4.TabIndex = 108;
            this.xLabel4.Text = "开户行账号";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.IsAllowEmpty = true;
            this.txtAccountNo.Location = new System.Drawing.Point(336, 168);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(442, 23);
            this.txtAccountNo.TabIndex = 13;
            this.txtAccountNo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // xLabel5
            // 
            this.xLabel5.AutoSize = true;
            this.xLabel5.ForeColor = System.Drawing.Color.DarkRed;
            this.xLabel5.Location = new System.Drawing.Point(14, 315);
            this.xLabel5.Name = "xLabel5";
            this.xLabel5.Size = new System.Drawing.Size(68, 17);
            this.xLabel5.TabIndex = 11;
            this.xLabel5.Text = "协议书备注";
            // 
            // chkcopy
            // 
            this.chkcopy.Location = new System.Drawing.Point(438, 349);
            this.chkcopy.Model = null;
            this.chkcopy.Name = "chkcopy";
            this.chkcopy.Size = new System.Drawing.Size(104, 23);
            this.chkcopy.TabIndex = 113;
            this.chkcopy.Text = "另存当前信息";
            this.chkcopy.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.chkcopy.CheckedChanged += new System.EventHandler(this.chkcopy_CheckedChanged);
            // 
            // frmEquipmentCustEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(790, 384);
            this.Controls.Add(this.chkcopy);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.xLabel4);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.xLabel3);
            this.Controls.Add(this.txtTaxNo);
            this.Controls.Add(this.xLabel2);
            this.Controls.Add(this.txtInvoiceTitle);
            this.Controls.Add(this.xLabel1);
            this.Controls.Add(this.txtCustTypeId);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustNo);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtLinkPeople);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtWorkTel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtWebSite);
            this.Controls.Add(this.txtCustDesc);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.lblCustTypeId);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustNo);
            this.Controls.Add(this.lblCustAddress);
            this.Controls.Add(this.lblLinkPeople);
            this.Controls.Add(this.lblMobileNo);
            this.Controls.Add(this.lblWorkTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblWebSite);
            this.Controls.Add(this.lblCustDesc);
            this.Controls.Add(this.xLabel5);
            this.Controls.Add(this.lblRemark);
            this.Name = "frmEquipmentCustEdit";
            this.Text = "送检单位";
            this.Load += new System.EventHandler(this.frmEquipmentCustEdit_Load);
            this.Controls.SetChildIndex(this.lblRemark, 0);
            this.Controls.SetChildIndex(this.xLabel5, 0);
            this.Controls.SetChildIndex(this.lblCustDesc, 0);
            this.Controls.SetChildIndex(this.lblWebSite, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.lblWorkTel, 0);
            this.Controls.SetChildIndex(this.lblMobileNo, 0);
            this.Controls.SetChildIndex(this.lblLinkPeople, 0);
            this.Controls.SetChildIndex(this.lblCustAddress, 0);
            this.Controls.SetChildIndex(this.lblCustNo, 0);
            this.Controls.SetChildIndex(this.lblCustName, 0);
            this.Controls.SetChildIndex(this.lblCustTypeId, 0);
            this.Controls.SetChildIndex(this.txtRemark, 0);
            this.Controls.SetChildIndex(this.txtCustDesc, 0);
            this.Controls.SetChildIndex(this.txtWebSite, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtWorkTel, 0);
            this.Controls.SetChildIndex(this.txtMobileNo, 0);
            this.Controls.SetChildIndex(this.txtLinkPeople, 0);
            this.Controls.SetChildIndex(this.txtCustAddress, 0);
            this.Controls.SetChildIndex(this.txtCustNo, 0);
            this.Controls.SetChildIndex(this.txtCustName, 0);
            this.Controls.SetChildIndex(this.btnOk, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.txtCustTypeId, 0);
            this.Controls.SetChildIndex(this.xLabel1, 0);
            this.Controls.SetChildIndex(this.txtInvoiceTitle, 0);
            this.Controls.SetChildIndex(this.xLabel2, 0);
            this.Controls.SetChildIndex(this.txtTaxNo, 0);
            this.Controls.SetChildIndex(this.xLabel3, 0);
            this.Controls.SetChildIndex(this.txtBank, 0);
            this.Controls.SetChildIndex(this.xLabel4, 0);
            this.Controls.SetChildIndex(this.txtAccountNo, 0);
            this.Controls.SetChildIndex(this.chkcopy, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private MMIS.Component.XLabel lblCustTypeId;
        private MMIS.Component.XLabel lblCustName;
        private MMIS.Component.XLabel lblCustNo;
        private MMIS.Component.XLabel lblCustAddress;
        private MMIS.Component.XLabel lblLinkPeople;
        private MMIS.Component.XLabel lblMobileNo;
        private MMIS.Component.XLabel lblWorkTel;
        private MMIS.Component.XLabel lblEmail;
        private MMIS.Component.XLabel lblWebSite;
        private MMIS.Component.XLabel lblCustDesc;
        private MMIS.Component.XLabel lblRemark;
        private MMIS.Component.XEditBox txtCustName;
        private MMIS.Component.XEditBox txtCustNo;
        private MMIS.Component.XEditBox txtCustAddress;
        private MMIS.Component.XEditBox txtLinkPeople;
        private MMIS.Component.XEditBox txtMobileNo;
        private MMIS.Component.XEditBox txtWorkTel;
        private MMIS.Component.XEditBox txtEmail;
        private MMIS.Component.XEditBox txtWebSite;
        private MMIS.Component.XEditBox txtCustDesc;
        private MMIS.Component.XEditBox txtRemark;
        private XSelectCodeEquipmentCustTypeEditBox txtCustTypeId;
        private Component.XLabel xLabel1;
        private Component.XEditBox txtInvoiceTitle;
        private Component.XLabel xLabel2;
        private Component.XEditBox txtTaxNo;
        private Component.XEditBox txtBank;
        private Component.XLabel xLabel3;
        private Component.XLabel xLabel4;
        private Component.XEditBox txtAccountNo;
        private Component.XLabel xLabel5;
        private Component.XCheckBox chkcopy;
        
    }
}