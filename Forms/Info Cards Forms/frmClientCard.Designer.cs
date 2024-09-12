namespace Bank.Forms.Info_Cards_Forms
{
    partial class frmClientCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientCard));
            this.CCard = new BankUC.ClientCard();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Location = new System.Drawing.Point(0, 35);
            this.pnlSide.Size = new System.Drawing.Size(47, 608);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 544);
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.PnlHead.Size = new System.Drawing.Size(398, 35);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            // 
            // pbStar
            // 
            this.pbStar.Size = new System.Drawing.Size(35, 35);
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(151, 1);
            this.pbProPic.Size = new System.Drawing.Size(35, 35);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Location = new System.Drawing.Point(189, 8);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(266, 8);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(192, 8);
            // 
            // CCard
            // 
            this.CCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CCard.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.CCard.Location = new System.Drawing.Point(0, 35);
            this.CCard.MinimumSize = new System.Drawing.Size(398, 602);
            this.CCard.Name = "CCard";
            this.CCard.PFP = ((System.Drawing.Image)(resources.GetObject("CCard.PFP")));
            this.CCard.Size = new System.Drawing.Size(398, 608);
            this.CCard.TabIndex = 0;
            this.CCard.Theme = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.CCard.ThemeChanged += new MyUC.MyUC_Shared.ColorEveHan(this.CCard_ThemeChanged);
            // 
            // frmClientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(398, 643);
            this.CloseStyle = MyUC.Forms.frmScreen.enCloseStyle.Back;
            this.Controls.Add(this.CCard);
            this.MinimumSize = new System.Drawing.Size(398, 643);
            this.Mode = MyUC.Forms.frmScreen.enMode.Normal;
            this.Name = "frmClientCard";
            this.RestoreButton = false;
            this.Text = "frmClientCard";
            this.TimeSynchronization = false;
            this.UsernameVisibility = false;
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.pnlSide, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.CCard, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BankUC.ClientCard CCard;
    }
}