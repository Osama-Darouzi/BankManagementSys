namespace Bank.Forms
{
    partial class frmLoginScreen
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
            this.lnkMadeBy = new System.Windows.Forms.LinkLabel();
            this.pbBackGraghics = new System.Windows.Forms.PictureBox();
            this.pbBanklogo = new System.Windows.Forms.PictureBox();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGraghics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanklogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.Transparent;
            this.PnlHead.Size = new System.Drawing.Size(369, 35);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            // 
            // pbStar
            // 
            this.pbStar.Location = new System.Drawing.Point(1, 0);
            this.pbStar.Size = new System.Drawing.Size(35, 35);
            this.pbStar.Visible = false;
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(-3662, 0);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Location = new System.Drawing.Point(-2160, 26);
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Digital-7 Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(222, 8);
            this.lblTime.Size = new System.Drawing.Size(57, 17);
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
            this.lnkMadeBy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMadeBy_LinkClicked);
            // 
            // pbBackGraghics
            // 
            this.pbBackGraghics.BackColor = System.Drawing.Color.Transparent;
            this.pbBackGraghics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBackGraghics.Image = global::Bank.Properties.Resources.Bank_LoginScreen;
            this.pbBackGraghics.Location = new System.Drawing.Point(0, 0);
            this.pbBackGraghics.Name = "pbBackGraghics";
            this.pbBackGraghics.Size = new System.Drawing.Size(369, 489);
            this.pbBackGraghics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackGraghics.TabIndex = 0;
            this.pbBackGraghics.TabStop = false;
            // 
            // pbBanklogo
            // 
            this.pbBanklogo.BackColor = System.Drawing.Color.Transparent;
            this.pbBanklogo.Image = global::Bank.Properties.Resources.BankLoginLogo;
            this.pbBanklogo.Location = new System.Drawing.Point(146, 21);
            this.pbBanklogo.Name = "pbBanklogo";
            this.pbBanklogo.Size = new System.Drawing.Size(75, 75);
            this.pbBanklogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBanklogo.TabIndex = 8;
            this.pbBanklogo.TabStop = false;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Bank.Properties.Resources.Bank_LoginScreenFixed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 489);
            this.Controls.Add(this.lnkMadeBy);
            this.Controls.Add(this.pbBanklogo);
            this.Controls.Add(this.pbBackGraghics);
            this.DoubleBuffered = true;
            this.FormBtnsColor = MyUC.Forms.frmScreen.enBtnColor.White;
            this.MinimizeButton = true;
            this.Name = "frmLoginScreen";
            this.RestoreButton = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TimeSynchronization = false;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.Controls.SetChildIndex(this.pbBackGraghics, 0);
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.pbBanklogo, 0);
            this.Controls.SetChildIndex(this.lnkMadeBy, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGraghics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanklogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox pbBackGraghics;
        protected System.Windows.Forms.PictureBox pbBanklogo;
        protected System.Windows.Forms.LinkLabel lnkMadeBy;
    }
}