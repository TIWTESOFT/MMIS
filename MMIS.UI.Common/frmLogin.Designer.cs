namespace MMIS.UI.Common
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new MMIS.Component.XEditBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassWord = new MMIS.Component.XEditBox();
            this.btnLogin = new MMIS.Component.XButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new MMIS.Component.XButton();
            this.chkEditPass = new MMIS.Component.XCheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblWelcome = new MMIS.Component.XLabel();
            this.tmWelcome = new System.Windows.Forms.Timer(this.components);
            this.chkRememberUser = new MMIS.Component.XCheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名";
            // 
            // txtUserName
            // 
            this.txtUserName.IsAllowEmpty = false;
            this.txtUserName.Location = new System.Drawing.Point(111, 115);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(211, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "密   码";
            // 
            // txtPassWord
            // 
            this.txtPassWord.IsAllowEmpty = false;
            this.txtPassWord.Location = new System.Drawing.Point(111, 152);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(211, 23);
            this.txtPassWord.TabIndex = 1;
            this.txtPassWord.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // btnLogin
            // 
            this.btnLogin.ImageIndex = 0;
            this.btnLogin.ImageList = this.ImageList;
            this.btnLogin.Location = new System.Drawing.Point(166, 191);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "登录";
            this.btnLogin.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            // 
            // btnCancel
            // 
            this.btnCancel.ImageIndex = 2;
            this.btnCancel.ImageList = this.ImageList;
            this.btnCancel.Location = new System.Drawing.Point(247, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkEditPass
            // 
            this.chkEditPass.Location = new System.Drawing.Point(333, 151);
            this.chkEditPass.Model = null;
            this.chkEditPass.Name = "chkEditPass";
            this.chkEditPass.Size = new System.Drawing.Size(89, 20);
            this.chkEditPass.TabIndex = 2;
            this.chkEditPass.Text = "修改密码";
            this.chkEditPass.Visible = false;
            this.chkEditPass.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.lblSystem.ForeColor = System.Drawing.Color.Navy;
            this.lblSystem.Location = new System.Drawing.Point(118, 33);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(254, 31);
            this.lblSystem.TabIndex = 5;
            this.lblSystem.Text = "计量中心信息管理系统";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.ForeColor = System.Drawing.Color.Navy;
            this.lblWelcome.Location = new System.Drawing.Point(234, 237);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(188, 17);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "欢迎使用计量中心信息管理系统！";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // tmWelcome
            // 
            this.tmWelcome.Enabled = true;
            this.tmWelcome.Interval = 300;
            this.tmWelcome.Tick += new System.EventHandler(this.tmWelcome_Tick);
            // 
            // chkRememberUser
            // 
            this.chkRememberUser.Location = new System.Drawing.Point(333, 116);
            this.chkRememberUser.Model = null;
            this.chkRememberUser.Name = "chkRememberUser";
            this.chkRememberUser.Size = new System.Drawing.Size(89, 20);
            this.chkRememberUser.TabIndex = 8;
            this.chkRememberUser.Text = "记住用户名";
            this.chkRememberUser.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MMIS.UI.Common.Properties.Resources.image001;
            this.pictureBox3.Location = new System.Drawing.Point(32, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(424, 30);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.chkRememberUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.chkEditPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "计量中心信息管理系统";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Component.XEditBox txtUserName;
        private System.Windows.Forms.Label label2;
        private Component.XEditBox txtPassWord;
        private Component.XButton btnLogin;
        private Component.XButton btnCancel;
        private Component.XCheckBox chkEditPass;
        internal System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblSystem;
        private Component.XLabel lblWelcome;
        private System.Windows.Forms.Timer tmWelcome;
        private Component.XCheckBox chkRememberUser;
    }
}