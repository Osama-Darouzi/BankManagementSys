namespace Bank.Forms.Login
{
    partial class frmRememberdUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRememberdUsers));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Transparent, new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.lvRememberedUsers = new System.Windows.Forms.ListView();
            this.chImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGraghics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanklogo)).BeginInit();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBackGraghics
            // 
            this.pbBackGraghics.Click += new System.EventHandler(this.pbBackGraghics_Click);
            // 
            // pbBanklogo
            // 
            this.pbBanklogo.Location = new System.Drawing.Point(146, 8);
            // 
            // lnkMadeBy
            // 
            this.lnkMadeBy.Visible = true;
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(252, 8);
            // 
            // lvRememberedUsers
            // 
            this.lvRememberedUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(212)))), ((int)(((byte)(235)))));
            this.lvRememberedUsers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvRememberedUsers.BackgroundImage")));
            this.lvRememberedUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvRememberedUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chImage,
            this.chFullName});
            this.lvRememberedUsers.FullRowSelect = true;
            this.lvRememberedUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvRememberedUsers.HideSelection = false;
            this.lvRememberedUsers.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvRememberedUsers.Location = new System.Drawing.Point(65, 133);
            this.lvRememberedUsers.MultiSelect = false;
            this.lvRememberedUsers.Name = "lvRememberedUsers";
            this.lvRememberedUsers.Size = new System.Drawing.Size(240, 240);
            this.lvRememberedUsers.TabIndex = 9;
            this.lvRememberedUsers.UseCompatibleStateImageBehavior = false;
            this.lvRememberedUsers.View = System.Windows.Forms.View.Details;
            this.lvRememberedUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvRememberedUsers_MouseDoubleClick);
            // 
            // chImage
            // 
            this.chImage.Text = "Image";
            // 
            // chFullName
            // 
            this.chFullName.Text = "FullName";
            this.chFullName.Width = 180;
            // 
            // frmRememberdUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 489);
            this.Controls.Add(this.lvRememberedUsers);
            this.FormBtnsColor = MyUC.Forms.frmScreen.enBtnColor.Black;
            this.MinimizeButton = true;
            this.Name = "frmRememberdUsers";
            this.Text = "frmRememberdUsers";
            this.Controls.SetChildIndex(this.lvRememberedUsers, 0);
            this.Controls.SetChildIndex(this.pbBackGraghics, 0);
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.pbBanklogo, 0);
            this.Controls.SetChildIndex(this.lnkMadeBy, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackGraghics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanklogo)).EndInit();
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRememberedUsers;
        private System.Windows.Forms.ColumnHeader chImage;
        private System.Windows.Forms.ColumnHeader chFullName;
    }
}