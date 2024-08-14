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
            Guna.UI2.WinForms.Suite.TextBoxState textBoxState7 = new Guna.UI2.WinForms.Suite.TextBoxState();
            Guna.UI2.WinForms.Suite.TextBoxState textBoxState8 = new Guna.UI2.WinForms.Suite.TextBoxState();
            this.tLogin = new System.Windows.Forms.Timer(this.components);
            this.chkRemmember = new System.Windows.Forms.CheckBox();
            this.tControlsShow = new System.Windows.Forms.Timer(this.components);
            this.btnLogin = new System.Windows.Forms.Button();
            this.errLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnkMadeBy = new System.Windows.Forms.LinkLabel();
            this.pbBackGraghics = new System.Windows.Forms.PictureBox();
            this.txtUsername = new MyUC.ctrlFramedTextBox();
            this.txtPassword = new MyUC.ctrlFramedTextBox();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGraghics)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.Transparent;
            this.PnlHead.Size = new System.Drawing.Size(369, 70);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkUsername, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            // 
            // pbStar
            // 
            this.pbStar.Image = ((System.Drawing.Image)(resources.GetObject("pbStar.Image")));
            this.pbStar.Location = new System.Drawing.Point(1, 0);
            this.pbStar.Size = new System.Drawing.Size(70, 70);
            this.pbStar.Visible = false;
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(-206, 0);
            // 
            // lnkUsername
            // 
            this.lnkUsername.Location = new System.Drawing.Point(-206, 26);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Digital-7 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(222, 8);
            this.lblTime.Size = new System.Drawing.Size(57, 17);
            // 
            // tLogin
            // 
            this.tLogin.Interval = 3200;
            this.tLogin.Tick += new System.EventHandler(this.tLogin_Tick);
            // 
            // chkRemmember
            // 
            this.chkRemmember.AutoSize = true;
            this.chkRemmember.BackColor = System.Drawing.Color.Transparent;
            this.chkRemmember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.chkRemmember.FlatAppearance.BorderSize = 0;
            this.chkRemmember.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkRemmember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRemmember.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemmember.Location = new System.Drawing.Point(94, 250);
            this.chkRemmember.Name = "chkRemmember";
            this.chkRemmember.Size = new System.Drawing.Size(117, 18);
            this.chkRemmember.TabIndex = 4;
            this.chkRemmember.Text = "Remmember me.";
            this.chkRemmember.UseVisualStyleBackColor = false;
            this.chkRemmember.Visible = false;
            // 
            // tControlsShow
            // 
            this.tControlsShow.Interval = 1000;
            this.tControlsShow.Tick += new System.EventHandler(this.tControlsShow_Tick);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(136, 301);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Visible = false;
            // 
            // errLogin
            // 
            this.errLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errLogin.ContainerControl = this;
            this.errLogin.Icon = ((System.Drawing.Icon)(resources.GetObject("errLogin.Icon")));
            // 
            // lnkMadeBy
            // 
            this.lnkMadeBy.AutoSize = true;
            this.lnkMadeBy.BackColor = System.Drawing.Color.Transparent;
            this.lnkMadeBy.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkMadeBy.Location = new System.Drawing.Point(12, 465);
            this.lnkMadeBy.Name = "lnkMadeBy";
            this.lnkMadeBy.Size = new System.Drawing.Size(80, 14);
            this.lnkMadeBy.TabIndex = 7;
            this.lnkMadeBy.TabStop = true;
            this.lnkMadeBy.Text = "Osama Darouzi";
            this.lnkMadeBy.Visible = false;
            // 
            // pbBackGraghics
            // 
            this.pbBackGraghics.BackColor = System.Drawing.Color.Transparent;
            this.pbBackGraghics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackGraghics.Image = global::Bank.Properties.Resources.Bank_Login;
            this.pbBackGraghics.Location = new System.Drawing.Point(0, 0);
            this.pbBackGraghics.Name = "pbBackGraghics";
            this.pbBackGraghics.Size = new System.Drawing.Size(369, 489);
            this.pbBackGraghics.TabIndex = 0;
            this.pbBackGraghics.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            textBoxState7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedState = textBoxState7;
            this.txtUsername.ForeColor = System.Drawing.Color.Transparent;
            this.txtUsername.HName = "Username";
            this.txtUsername.Location = new System.Drawing.Point(84, 91);
            this.txtUsername.Max = ((short)(100));
            this.txtUsername.Min = ((short)(0));
            this.txtUsername.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 56);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            textBoxState8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState = textBoxState8;
            this.txtPassword.HName = "Password";
            this.txtPassword.Location = new System.Drawing.Point(84, 168);
            this.txtPassword.Max = ((short)(100));
            this.txtPassword.Min = ((short)(0));
            this.txtPassword.Mode = MyUC.ctrlFramedTextBox.enMode.Normal;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 56);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Visible = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Bank.Properties.Resources.Bank_Login_Fixed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 489);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lnkMadeBy);
            this.Controls.Add(this.chkRemmember);
            this.Controls.Add(this.pbBackGraghics);
            this.DoubleBuffered = true;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Controls.SetChildIndex(this.pbBackGraghics, 0);
            this.Controls.SetChildIndex(this.chkRemmember, 0);
            this.Controls.SetChildIndex(this.lnkMadeBy, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.txtUsername, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGraghics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackGraghics;
        private System.Windows.Forms.Timer tLogin;
        private System.Windows.Forms.CheckBox chkRemmember;
        private System.Windows.Forms.Timer tControlsShow;
        private System.Windows.Forms.LinkLabel lnkMadeBy;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider errLogin;
        private MyUC.ctrlFramedTextBox txtUsername;
        private MyUC.ctrlFramedTextBox txtPassword;
    }
}