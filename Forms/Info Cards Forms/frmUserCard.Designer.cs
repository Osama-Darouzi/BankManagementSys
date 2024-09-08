namespace Bank.Forms.Info_Cards_Forms
{
    partial class frmUserCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserCard));
            this.UCard = new BankUC.UserCard();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnForget = new Guna.UI2.WinForms.Guna2Button();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.Transparent;
            this.PnlHead.Size = new System.Drawing.Size(645, 35);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(-415, 1);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Location = new System.Drawing.Point(-314, 16);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(513, 8);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(-311, 42);
            // 
            // UCard
            // 
            this.UCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.UCard.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.UCard.Location = new System.Drawing.Point(0, 35);
            this.UCard.MinimumSize = new System.Drawing.Size(644, 534);
            this.UCard.Name = "UCard";
            this.UCard.PFP = ((System.Drawing.Image)(resources.GetObject("UCard.PFP")));
            this.UCard.Size = new System.Drawing.Size(645, 534);
            this.UCard.TabIndex = 0;
            this.UCard.Theme = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.UCard.ThemeChanged += new MyUC.MyUC_Shared.ColorEveHan(this.UCard_ThemeChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(155)))), ((int)(((byte)(48)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(452, 575);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Depth = 50;
            this.btnLogout.ShadowDecoration.Enabled = true;
            this.btnLogout.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnLogout.Size = new System.Drawing.Size(114, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextOffset = new System.Drawing.Point(0, -1);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnForget
            // 
            this.btnForget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnForget.BackColor = System.Drawing.Color.Transparent;
            this.btnForget.BorderRadius = 10;
            this.btnForget.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnForget.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnForget.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnForget.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnForget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnForget.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForget.ForeColor = System.Drawing.Color.White;
            this.btnForget.Location = new System.Drawing.Point(91, 575);
            this.btnForget.Name = "btnForget";
            this.btnForget.ShadowDecoration.Depth = 50;
            this.btnForget.ShadowDecoration.Enabled = true;
            this.btnForget.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btnForget.Size = new System.Drawing.Size(199, 40);
            this.btnForget.TabIndex = 11;
            this.btnForget.Text = "Logout And Forget";
            this.btnForget.TextOffset = new System.Drawing.Point(0, -1);
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // frmUserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 629);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.UCard);
            this.MinimizeButton = true;
            this.Name = "frmUserCard";
            this.Text = "frmUserCard";
            this.TimeSynchronization = false;
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.UCard, 0);
            this.Controls.SetChildIndex(this.btnLogout, 0);
            this.Controls.SetChildIndex(this.btnForget, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BankUC.UserCard UCard;
        protected Guna.UI2.WinForms.Guna2Button btnLogout;
        protected Guna.UI2.WinForms.Guna2Button btnForget;
    }
}