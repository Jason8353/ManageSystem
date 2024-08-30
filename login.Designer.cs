using System.Drawing;

namespace userForm
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.labelPsd = new System.Windows.Forms.Label();
            this.labelUid = new System.Windows.Forms.Label();
            this.txtPsd = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPsd
            // 
            this.labelPsd.AutoSize = true;
            this.labelPsd.BackColor = System.Drawing.Color.Transparent;
            this.labelPsd.Location = new System.Drawing.Point(61, 137);
            this.labelPsd.Name = "labelPsd";
            this.labelPsd.Size = new System.Drawing.Size(44, 18);
            this.labelPsd.TabIndex = 2;
            this.labelPsd.Text = "密码";
            // 
            // labelUid
            // 
            this.labelUid.AutoSize = true;
            this.labelUid.BackColor = System.Drawing.Color.Transparent;
            this.labelUid.Location = new System.Drawing.Point(61, 74);
            this.labelUid.Name = "labelUid";
            this.labelUid.Size = new System.Drawing.Size(44, 18);
            this.labelUid.TabIndex = 0;
            this.labelUid.Text = "账号";
            // 
            // txtPsd
            // 
            this.txtPsd.Location = new System.Drawing.Point(150, 127);
            this.txtPsd.Name = "txtPsd";
            this.txtPsd.Size = new System.Drawing.Size(138, 28);
            this.txtPsd.TabIndex = 3;
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(151, 69);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(138, 28);
            this.txtUid.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(98, 203);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 39);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(247, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShowPassword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkShowPassword.Location = new System.Drawing.Point(296, 129);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(101, 22);
            this.chkShowPassword.TabIndex = 6;
            this.chkShowPassword.Text = "显示密码";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // panelLogin
            // 
            this.panelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(114)))));
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.chkShowPassword);
            this.panelLogin.Controls.Add(this.button1);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.txtUid);
            this.panelLogin.Controls.Add(this.txtPsd);
            this.panelLogin.Controls.Add(this.labelUid);
            this.panelLogin.Controls.Add(this.labelPsd);
            this.panelLogin.Location = new System.Drawing.Point(185, 71);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(413, 285);
            this.panelLogin.TabIndex = 4;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(163, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "登录系统";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "login";
            this.Text = "登录界面";
            this.Load += new System.EventHandler(this.login_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPsd;
        private System.Windows.Forms.Label labelUid;
        private System.Windows.Forms.TextBox txtPsd;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label1;
    }
}