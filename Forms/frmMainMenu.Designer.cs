namespace Bank.Forms
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.Separator = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnManageClients = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnUsersActions = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLoginRegistry = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnManageUsers = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClientsActions = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClientsTransfers = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.MinimumSize = new System.Drawing.Size(0, 94);
            this.PnlHead.Size = new System.Drawing.Size(1000, 94);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            // 
            // pbStar
            // 
            this.pbStar.Location = new System.Drawing.Point(0, 0);
            this.pbStar.Size = new System.Drawing.Size(94, 94);
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(387, 0);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Location = new System.Drawing.Point(488, 10);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(838, 8);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(489, 42);
            // 
            // Separator
            // 
            this.Separator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Separator.BorderColor = System.Drawing.Color.White;
            this.Separator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Separator.LineEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Separator.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.Separator.LineThickness = 6;
            this.Separator.Location = new System.Drawing.Point(63, 335);
            this.Separator.Name = "Separator";
            this.Separator.PolygonSkip = 1;
            this.Separator.Rotate = 0F;
            this.Separator.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.Separator.Size = new System.Drawing.Size(888, 10);
            this.Separator.TabIndex = 12;
            this.Separator.Zoom = 100;
            // 
            // btnManageClients
            // 
            this.btnManageClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClients.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnManageClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageClients.FillColor = System.Drawing.Color.Transparent;
            this.btnManageClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClients.ForeColor = System.Drawing.Color.Black;
            this.btnManageClients.Image = ((System.Drawing.Image)(resources.GetObject("btnManageClients.Image")));
            this.btnManageClients.ImageOffset = new System.Drawing.Point(0, 37);
            this.btnManageClients.ImageSize = new System.Drawing.Size(150, 150);
            this.btnManageClients.Location = new System.Drawing.Point(63, 120);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnManageClients.Size = new System.Drawing.Size(200, 200);
            this.btnManageClients.TabIndex = 12;
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.TextOffset = new System.Drawing.Point(0, 20);
            this.btnManageClients.EnabledChanged += new System.EventHandler(this.btns_EnabledChanged);
            this.btnManageClients.Click += new System.EventHandler(this.btnManageClients_Click);
            // 
            // btnUsersActions
            // 
            this.btnUsersActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsersActions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsersActions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsersActions.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnUsersActions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsersActions.Enabled = false;
            this.btnUsersActions.FillColor = System.Drawing.Color.Transparent;
            this.btnUsersActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersActions.ForeColor = System.Drawing.Color.Black;
            this.btnUsersActions.Image = global::Bank.Properties.Resources.People_Cruds;
            this.btnUsersActions.ImageOffset = new System.Drawing.Point(0, 37);
            this.btnUsersActions.ImageSize = new System.Drawing.Size(150, 150);
            this.btnUsersActions.Location = new System.Drawing.Point(407, 363);
            this.btnUsersActions.Name = "btnUsersActions";
            this.btnUsersActions.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUsersActions.Size = new System.Drawing.Size(200, 200);
            this.btnUsersActions.TabIndex = 13;
            this.btnUsersActions.Text = "Users Actions";
            this.btnUsersActions.TextOffset = new System.Drawing.Point(0, 20);
            this.btnUsersActions.EnabledChanged += new System.EventHandler(this.btns_EnabledChanged);
            this.btnUsersActions.Click += new System.EventHandler(this.btnLoginRegistry_Click);
            // 
            // btnLoginRegistry
            // 
            this.btnLoginRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginRegistry.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginRegistry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginRegistry.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnLoginRegistry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoginRegistry.FillColor = System.Drawing.Color.Transparent;
            this.btnLoginRegistry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegistry.ForeColor = System.Drawing.Color.Black;
            this.btnLoginRegistry.Image = global::Bank.Properties.Resources._enter;
            this.btnLoginRegistry.ImageOffset = new System.Drawing.Point(-10, 37);
            this.btnLoginRegistry.ImageSize = new System.Drawing.Size(125, 125);
            this.btnLoginRegistry.Location = new System.Drawing.Point(751, 363);
            this.btnLoginRegistry.Name = "btnLoginRegistry";
            this.btnLoginRegistry.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLoginRegistry.Size = new System.Drawing.Size(200, 200);
            this.btnLoginRegistry.TabIndex = 14;
            this.btnLoginRegistry.Text = "Login Registry";
            this.btnLoginRegistry.TextOffset = new System.Drawing.Point(0, 20);
            this.btnLoginRegistry.EnabledChanged += new System.EventHandler(this.btns_EnabledChanged);
            this.btnLoginRegistry.Click += new System.EventHandler(this.btnUsersAction_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUsers.Enabled = false;
            this.btnManageUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.Black;
            this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
            this.btnManageUsers.ImageOffset = new System.Drawing.Point(0, 37);
            this.btnManageUsers.ImageSize = new System.Drawing.Size(150, 150);
            this.btnManageUsers.Location = new System.Drawing.Point(63, 363);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnManageUsers.Size = new System.Drawing.Size(200, 200);
            this.btnManageUsers.TabIndex = 15;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextOffset = new System.Drawing.Point(0, 20);
            this.btnManageUsers.EnabledChanged += new System.EventHandler(this.btns_EnabledChanged);
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnClientsActions
            // 
            this.btnClientsActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientsActions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsActions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsActions.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnClientsActions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientsActions.FillColor = System.Drawing.Color.Transparent;
            this.btnClientsActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsActions.ForeColor = System.Drawing.Color.Black;
            this.btnClientsActions.Image = ((System.Drawing.Image)(resources.GetObject("btnClientsActions.Image")));
            this.btnClientsActions.ImageOffset = new System.Drawing.Point(0, 30);
            this.btnClientsActions.ImageSize = new System.Drawing.Size(140, 140);
            this.btnClientsActions.Location = new System.Drawing.Point(407, 120);
            this.btnClientsActions.Name = "btnClientsActions";
            this.btnClientsActions.Padding = new System.Windows.Forms.Padding(25);
            this.btnClientsActions.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClientsActions.Size = new System.Drawing.Size(200, 200);
            this.btnClientsActions.TabIndex = 16;
            this.btnClientsActions.Text = "Transactions History";
            this.btnClientsActions.TextOffset = new System.Drawing.Point(0, 20);
            this.btnClientsActions.EnabledChanged += new System.EventHandler(this.btns_EnabledChanged);
            this.btnClientsActions.Click += new System.EventHandler(this.btnClientsActions_Click);
            // 
            // btnClientsTransfers
            // 
            this.btnClientsTransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientsTransfers.BackColor = System.Drawing.Color.Transparent;
            this.btnClientsTransfers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsTransfers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsTransfers.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnClientsTransfers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientsTransfers.FillColor = System.Drawing.Color.Transparent;
            this.btnClientsTransfers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsTransfers.ForeColor = System.Drawing.Color.Black;
            this.btnClientsTransfers.Image = global::Bank.Properties.Resources.Transfer;
            this.btnClientsTransfers.ImageOffset = new System.Drawing.Point(0, 37);
            this.btnClientsTransfers.ImageSize = new System.Drawing.Size(125, 125);
            this.btnClientsTransfers.Location = new System.Drawing.Point(751, 120);
            this.btnClientsTransfers.Name = "btnClientsTransfers";
            this.btnClientsTransfers.Padding = new System.Windows.Forms.Padding(50);
            this.btnClientsTransfers.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClientsTransfers.Size = new System.Drawing.Size(200, 200);
            this.btnClientsTransfers.TabIndex = 17;
            this.btnClientsTransfers.Text = "Transfer History";
            this.btnClientsTransfers.TextOffset = new System.Drawing.Point(0, 20);
            this.btnClientsTransfers.EnabledChanged += new System.EventHandler(this.btns_EnabledChanged);
            this.btnClientsTransfers.Click += new System.EventHandler(this.btnClientsTransfers_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnClientsTransfers);
            this.Controls.Add(this.btnClientsActions);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnLoginRegistry);
            this.Controls.Add(this.btnUsersActions);
            this.Controls.Add(this.btnManageClients);
            this.Controls.Add(this.Separator);
            this.MinimumSize = new System.Drawing.Size(0, 94);
            this.Mode = MyUC.Forms.frmScreen.enMode.User;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ed";
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.Separator, 0);
            this.Controls.SetChildIndex(this.btnManageClients, 0);
            this.Controls.SetChildIndex(this.btnUsersActions, 0);
            this.Controls.SetChildIndex(this.btnLoginRegistry, 0);
            this.Controls.SetChildIndex(this.btnManageUsers, 0);
            this.Controls.SetChildIndex(this.btnClientsActions, 0);
            this.Controls.SetChildIndex(this.btnClientsTransfers, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Shapes Separator;
        private Guna.UI2.WinForms.Guna2CircleButton btnManageClients;
        private Guna.UI2.WinForms.Guna2CircleButton btnUsersActions;
        private Guna.UI2.WinForms.Guna2CircleButton btnLoginRegistry;
        private Guna.UI2.WinForms.Guna2CircleButton btnManageUsers;
        private Guna.UI2.WinForms.Guna2CircleButton btnClientsActions;
        private Guna.UI2.WinForms.Guna2CircleButton btnClientsTransfers;
    }
}