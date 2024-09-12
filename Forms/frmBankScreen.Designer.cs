namespace Bank.Forms
{
    partial class frmBankScreen
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
            this.pnlSide = new System.Windows.Forms.Panel();
            this.sdbtnUsersActions = new Guna.UI2.WinForms.Guna2Button();
            this.sdbtnLoginRegistry = new Guna.UI2.WinForms.Guna2Button();
            this.sdbtnMngUsers = new Guna.UI2.WinForms.Guna2Button();
            this.sdbtnClientsActions = new Guna.UI2.WinForms.Guna2Button();
            this.sdbtnClientsTransfers = new Guna.UI2.WinForms.Guna2Button();
            this.sdbtnMngClients = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.pnlSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            // 
            // pnlSide
            // 
            this.pnlSide.Controls.Add(this.sdbtnUsersActions);
            this.pnlSide.Controls.Add(this.sdbtnLoginRegistry);
            this.pnlSide.Controls.Add(this.sdbtnMngUsers);
            this.pnlSide.Controls.Add(this.sdbtnClientsActions);
            this.pnlSide.Controls.Add(this.sdbtnClientsTransfers);
            this.pnlSide.Controls.Add(this.sdbtnMngClients);
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Location = new System.Drawing.Point(0, 46);
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(47, 404);
            this.pnlSide.TabIndex = 1;
            this.pnlSide.Visible = false;
            // 
            // sdbtnUsersActions
            // 
            this.sdbtnUsersActions.BackColor = System.Drawing.Color.Transparent;
            this.sdbtnUsersActions.BorderRadius = 21;
            this.sdbtnUsersActions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnUsersActions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnUsersActions.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.sdbtnUsersActions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sdbtnUsersActions.FillColor = System.Drawing.Color.White;
            this.sdbtnUsersActions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sdbtnUsersActions.ForeColor = System.Drawing.Color.White;
            this.sdbtnUsersActions.HoverState.FillColor = System.Drawing.Color.Silver;
            this.sdbtnUsersActions.Image = global::Bank.Properties.Resources.People_Cruds;
            this.sdbtnUsersActions.ImageOffset = new System.Drawing.Point(0, -2);
            this.sdbtnUsersActions.ImageSize = new System.Drawing.Size(38, 38);
            this.sdbtnUsersActions.Location = new System.Drawing.Point(1, 207);
            this.sdbtnUsersActions.Name = "sdbtnUsersActions";
            this.sdbtnUsersActions.ShadowDecoration.BorderRadius = 20;
            this.sdbtnUsersActions.ShadowDecoration.Color = System.Drawing.Color.White;
            this.sdbtnUsersActions.ShadowDecoration.Depth = 90;
            this.sdbtnUsersActions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.sdbtnUsersActions.Size = new System.Drawing.Size(45, 45);
            this.sdbtnUsersActions.TabIndex = 5;
            this.sdbtnUsersActions.Click += new System.EventHandler(this.sdbtnUsersAction_Click);
            // 
            // sdbtnLoginRegistry
            // 
            this.sdbtnLoginRegistry.BackColor = System.Drawing.Color.Transparent;
            this.sdbtnLoginRegistry.BorderRadius = 21;
            this.sdbtnLoginRegistry.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnLoginRegistry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnLoginRegistry.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.sdbtnLoginRegistry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sdbtnLoginRegistry.FillColor = System.Drawing.Color.White;
            this.sdbtnLoginRegistry.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sdbtnLoginRegistry.ForeColor = System.Drawing.Color.White;
            this.sdbtnLoginRegistry.HoverState.FillColor = System.Drawing.Color.Silver;
            this.sdbtnLoginRegistry.Image = global::Bank.Properties.Resources._enter;
            this.sdbtnLoginRegistry.ImageOffset = new System.Drawing.Point(-1, 0);
            this.sdbtnLoginRegistry.ImageSize = new System.Drawing.Size(34, 34);
            this.sdbtnLoginRegistry.Location = new System.Drawing.Point(1, 258);
            this.sdbtnLoginRegistry.Name = "sdbtnLoginRegistry";
            this.sdbtnLoginRegistry.ShadowDecoration.BorderRadius = 20;
            this.sdbtnLoginRegistry.ShadowDecoration.Color = System.Drawing.Color.White;
            this.sdbtnLoginRegistry.ShadowDecoration.Depth = 90;
            this.sdbtnLoginRegistry.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.sdbtnLoginRegistry.Size = new System.Drawing.Size(45, 45);
            this.sdbtnLoginRegistry.TabIndex = 4;
            this.sdbtnLoginRegistry.Click += new System.EventHandler(this.sdbtnLoginRegistry_Click);
            // 
            // sdbtnMngUsers
            // 
            this.sdbtnMngUsers.BackColor = System.Drawing.Color.Transparent;
            this.sdbtnMngUsers.BorderRadius = 21;
            this.sdbtnMngUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnMngUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnMngUsers.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.sdbtnMngUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sdbtnMngUsers.FillColor = System.Drawing.Color.White;
            this.sdbtnMngUsers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sdbtnMngUsers.ForeColor = System.Drawing.Color.White;
            this.sdbtnMngUsers.HoverState.FillColor = System.Drawing.Color.Silver;
            this.sdbtnMngUsers.Image = global::Bank.Properties.Resources.user_management;
            this.sdbtnMngUsers.ImageSize = new System.Drawing.Size(42, 42);
            this.sdbtnMngUsers.Location = new System.Drawing.Point(1, 156);
            this.sdbtnMngUsers.Name = "sdbtnMngUsers";
            this.sdbtnMngUsers.ShadowDecoration.BorderRadius = 20;
            this.sdbtnMngUsers.ShadowDecoration.Color = System.Drawing.Color.White;
            this.sdbtnMngUsers.ShadowDecoration.Depth = 90;
            this.sdbtnMngUsers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.sdbtnMngUsers.Size = new System.Drawing.Size(45, 45);
            this.sdbtnMngUsers.TabIndex = 3;
            this.sdbtnMngUsers.Click += new System.EventHandler(this.sdbtnManageUsers_Click);
            // 
            // sdbtnClientsActions
            // 
            this.sdbtnClientsActions.BackColor = System.Drawing.Color.Transparent;
            this.sdbtnClientsActions.BorderRadius = 21;
            this.sdbtnClientsActions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnClientsActions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnClientsActions.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.sdbtnClientsActions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sdbtnClientsActions.FillColor = System.Drawing.Color.White;
            this.sdbtnClientsActions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sdbtnClientsActions.ForeColor = System.Drawing.Color.White;
            this.sdbtnClientsActions.HoverState.FillColor = System.Drawing.Color.Silver;
            this.sdbtnClientsActions.Image = global::Bank.Properties.Resources.Transactions;
            this.sdbtnClientsActions.ImageOffset = new System.Drawing.Point(1, -4);
            this.sdbtnClientsActions.ImageSize = new System.Drawing.Size(42, 42);
            this.sdbtnClientsActions.Location = new System.Drawing.Point(1, 55);
            this.sdbtnClientsActions.Name = "sdbtnClientsActions";
            this.sdbtnClientsActions.ShadowDecoration.BorderRadius = 20;
            this.sdbtnClientsActions.ShadowDecoration.Color = System.Drawing.Color.White;
            this.sdbtnClientsActions.ShadowDecoration.Depth = 90;
            this.sdbtnClientsActions.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.sdbtnClientsActions.Size = new System.Drawing.Size(45, 45);
            this.sdbtnClientsActions.TabIndex = 2;
            this.sdbtnClientsActions.Click += new System.EventHandler(this.sdbtnClientsActions_Click);
            // 
            // sdbtnClientsTransfers
            // 
            this.sdbtnClientsTransfers.BackColor = System.Drawing.Color.Transparent;
            this.sdbtnClientsTransfers.BorderRadius = 21;
            this.sdbtnClientsTransfers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnClientsTransfers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnClientsTransfers.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.sdbtnClientsTransfers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sdbtnClientsTransfers.FillColor = System.Drawing.Color.White;
            this.sdbtnClientsTransfers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sdbtnClientsTransfers.ForeColor = System.Drawing.Color.White;
            this.sdbtnClientsTransfers.HoverState.FillColor = System.Drawing.Color.Silver;
            this.sdbtnClientsTransfers.Image = global::Bank.Properties.Resources.Transfer;
            this.sdbtnClientsTransfers.ImageOffset = new System.Drawing.Point(1, 1);
            this.sdbtnClientsTransfers.ImageSize = new System.Drawing.Size(32, 32);
            this.sdbtnClientsTransfers.Location = new System.Drawing.Point(1, 106);
            this.sdbtnClientsTransfers.Name = "sdbtnClientsTransfers";
            this.sdbtnClientsTransfers.ShadowDecoration.BorderRadius = 20;
            this.sdbtnClientsTransfers.ShadowDecoration.Color = System.Drawing.Color.White;
            this.sdbtnClientsTransfers.ShadowDecoration.Depth = 90;
            this.sdbtnClientsTransfers.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.sdbtnClientsTransfers.Size = new System.Drawing.Size(45, 45);
            this.sdbtnClientsTransfers.TabIndex = 1;
            this.sdbtnClientsTransfers.Click += new System.EventHandler(this.sdbtnClientsTransfers_Click);
            // 
            // sdbtnMngClients
            // 
            this.sdbtnMngClients.BackColor = System.Drawing.Color.Transparent;
            this.sdbtnMngClients.BorderRadius = 21;
            this.sdbtnMngClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnMngClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sdbtnMngClients.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.sdbtnMngClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sdbtnMngClients.FillColor = System.Drawing.Color.White;
            this.sdbtnMngClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sdbtnMngClients.ForeColor = System.Drawing.Color.White;
            this.sdbtnMngClients.HoverState.FillColor = System.Drawing.Color.Silver;
            this.sdbtnMngClients.Image = global::Bank.Properties.Resources.team;
            this.sdbtnMngClients.ImageOffset = new System.Drawing.Point(1, 0);
            this.sdbtnMngClients.ImageSize = new System.Drawing.Size(40, 40);
            this.sdbtnMngClients.Location = new System.Drawing.Point(1, 4);
            this.sdbtnMngClients.Name = "sdbtnMngClients";
            this.sdbtnMngClients.ShadowDecoration.BorderRadius = 20;
            this.sdbtnMngClients.ShadowDecoration.Color = System.Drawing.Color.White;
            this.sdbtnMngClients.ShadowDecoration.Depth = 90;
            this.sdbtnMngClients.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.sdbtnMngClients.Size = new System.Drawing.Size(45, 45);
            this.sdbtnMngClients.TabIndex = 0;
            this.sdbtnMngClients.Click += new System.EventHandler(this.sdbtnManageClients_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.Location = new System.Drawing.Point(0, 350);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(47, 99);
            this.pnlMenu.TabIndex = 2;
            this.pnlMenu.Visible = false;
            // 
            // frmBankScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSide);
            this.Name = "frmBankScreen";
            this.PbStarVisibility = true;
            this.Text = "frmBankScreen";
            this.FullNameClicked += new System.EventHandler(this.frmBankScreen_FullNameClicked);
            this.CloseButtonClicked += new System.EventHandler(this.frmBankScreen_CloseButtonClicked);
            this.ThemeChanged += new MyUC.MyUC_Shared.Color2EveHan(this.frmBankScreen_ThemeChanged);
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.pnlSide, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.pnlSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected Guna.UI2.WinForms.Guna2Button sdbtnUsersActions;
        protected Guna.UI2.WinForms.Guna2Button sdbtnLoginRegistry;
        protected Guna.UI2.WinForms.Guna2Button sdbtnMngUsers;
        protected Guna.UI2.WinForms.Guna2Button sdbtnClientsActions;
        protected Guna.UI2.WinForms.Guna2Button sdbtnClientsTransfers;
        protected System.Windows.Forms.Panel pnlSide;
        protected System.Windows.Forms.Panel pnlMenu;
        protected Guna.UI2.WinForms.Guna2Button sdbtnMngClients;
    }
}