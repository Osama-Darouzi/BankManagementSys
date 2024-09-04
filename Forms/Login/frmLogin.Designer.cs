namespace Bank.Forms
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
            Guna.UI2.WinForms.Suite.TextBoxState textBoxState2 = new Guna.UI2.WinForms.Suite.TextBoxState();
            Guna.UI2.WinForms.Suite.TextBoxState textBoxState1 = new Guna.UI2.WinForms.Suite.TextBoxState();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.tControlsShow = new System.Windows.Forms.Timer(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.errLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUsername = new MyUC.ctrlFramedTextBox();
            this.txtPassword = new MyUC.ctrlFramedTextBox();
            this.btnRemembered = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGraghics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanklogo)).BeginInit();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBanklogo
            // 
            this.pbBanklogo.Location = new System.Drawing.Point(146, 8);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(-2582, 0);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Location = new System.Drawing.Point(-1080, 26);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(252, 8);
            this.lblTime.Text = "8:01 AM";
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.BackColor = System.Drawing.Color.Transparent;
            this.chkRemember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkRemember.FlatAppearance.BorderSize = 0;
            this.chkRemember.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRemember.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemember.Location = new System.Drawing.Point(94, 293);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(117, 18);
            this.chkRemember.TabIndex = 4;
            this.chkRemember.Text = "Remmember me.";
            this.chkRemember.UseVisualStyleBackColor = false;
            this.chkRemember.Visible = false;
            // 
            // tControlsShow
            // 
            this.tControlsShow.Interval = 1000;
            this.tControlsShow.Tick += new System.EventHandler(this.tControlsShow_Tick);
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(136, 344);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errLogin
            // 
            this.errLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errLogin.ContainerControl = this;
            this.errLogin.Icon = ((System.Drawing.Icon)(resources.GetObject("errLogin.Icon")));
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            textBoxState2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.ForeColor = System.Drawing.Color.Transparent;
            this.txtUsername.HeaderColor = System.Drawing.Color.White;
            this.txtUsername.HName = "Username";
            this.txtUsername.LengthLabelColor = System.Drawing.Color.Red;
            this.txtUsername.Location = new System.Drawing.Point(84, 134);
            this.txtUsername.Max = ((ushort)(50));
            this.txtUsername.Min = ((ushort)(5));
            this.txtUsername.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 56);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            textBoxState1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HeaderColor = System.Drawing.Color.White;
            this.txtPassword.HName = "Password";
            this.txtPassword.LengthLabelColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(84, 211);
            this.txtPassword.Max = ((ushort)(50));
            this.txtPassword.Min = ((ushort)(8));
            this.txtPassword.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 56);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Visible = false;
            // 
            // btnRemembered
            // 
            this.btnRemembered.BackColor = System.Drawing.Color.Transparent;
            this.btnRemembered.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemembered.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemembered.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemembered.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemembered.FillColor = System.Drawing.Color.Gainsboro;
            this.btnRemembered.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemembered.ForeColor = System.Drawing.Color.White;
            this.btnRemembered.Image = global::Bank.Properties.Resources.save_user;
            this.btnRemembered.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnRemembered.ImageSize = new System.Drawing.Size(26, 26);
            this.btnRemembered.Location = new System.Drawing.Point(30, 147);
            this.btnRemembered.Name = "btnRemembered";
            this.btnRemembered.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRemembered.Size = new System.Drawing.Size(37, 37);
            this.btnRemembered.TabIndex = 13;
            this.btnRemembered.Visible = false;
            this.btnRemembered.Click += new System.EventHandler(this.btnRemembered_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 489);
            this.Controls.Add(this.btnRemembered);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkRemember);
            this.FormBtnsColor = MyUC.Forms.frmScreen.enBtnColor.Black;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MinimizeButton = true;
            this.Name = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Controls.SetChildIndex(this.pbBackGraghics, 0);
            this.Controls.SetChildIndex(this.chkRemember, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.pbBanklogo, 0);
            this.Controls.SetChildIndex(this.lnkMadeBy, 0);
            this.Controls.SetChildIndex(this.btnRemembered, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGraghics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanklogo)).EndInit();
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Timer tControlsShow;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider errLogin;
        private MyUC.ctrlFramedTextBox txtUsername;
        private MyUC.ctrlFramedTextBox txtPassword;
        private Guna.UI2.WinForms.Guna2CircleButton btnRemembered;
    }
}