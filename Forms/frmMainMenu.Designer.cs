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
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnManageClients = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLoginRegistry = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnUsersAction = new Guna.UI2.WinForms.Guna2CircleButton();
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
            this.PnlHead.Size = new System.Drawing.Size(1099, 94);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            // 
            // pbStar
            // 
            this.pbStar.Image = ((System.Drawing.Image)(resources.GetObject("pbStar.Image")));
            this.pbStar.Location = new System.Drawing.Point(1, 1);
            this.pbStar.Size = new System.Drawing.Size(94, 94);
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(436, 0);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Location = new System.Drawing.Point(537, 10);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(937, 8);
            this.lblTime.Text = "5:56 AM";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(538, 42);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Shapes1.BorderColor = System.Drawing.Color.White;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(0, 335);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(1116, 10);
            this.guna2Shapes1.TabIndex = 12;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // btnManageClients
            // 
            this.btnManageClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageClients.FillColor = System.Drawing.Color.Transparent;
            this.btnManageClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClients.ForeColor = System.Drawing.Color.Black;
            this.btnManageClients.Image = ((System.Drawing.Image)(resources.GetObject("btnManageClients.Image")));
            this.btnManageClients.ImageOffset = new System.Drawing.Point(0, 37);
            this.btnManageClients.ImageSize = new System.Drawing.Size(150, 150);
            this.btnManageClients.Location = new System.Drawing.Point(113, 126);
            this.btnManageClients.Name = "btnManageClients";
            this.btnManageClients.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnManageClients.Size = new System.Drawing.Size(200, 200);
            this.btnManageClients.TabIndex = 12;
            this.btnManageClients.Text = "Manage Clients";
            this.btnManageClients.TextOffset = new System.Drawing.Point(0, 20);
            this.btnManageClients.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // btnLoginRegistry
            // 
            this.btnLoginRegistry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginRegistry.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginRegistry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginRegistry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoginRegistry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoginRegistry.FillColor = System.Drawing.Color.Transparent;
            this.btnLoginRegistry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegistry.ForeColor = System.Drawing.Color.Black;
            this.btnLoginRegistry.Image = global::Bank.Properties.Resources.user__3_;
            this.btnLoginRegistry.ImageOffset = new System.Drawing.Point(0, 37);
            this.btnLoginRegistry.ImageSize = new System.Drawing.Size(150, 150);
            this.btnLoginRegistry.Location = new System.Drawing.Point(457, 363);
            this.btnLoginRegistry.Name = "btnLoginRegistry";
            this.btnLoginRegistry.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLoginRegistry.Size = new System.Drawing.Size(200, 200);
            this.btnLoginRegistry.TabIndex = 13;
            this.btnLoginRegistry.Text = "Users Actions";
            this.btnLoginRegistry.TextOffset = new System.Drawing.Point(0, 20);
            // 
            // btnUsersAction
            // 
            this.btnUsersAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsersAction.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsersAction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsersAction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsersAction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsersAction.FillColor = System.Drawing.Color.Transparent;
            this.btnUsersAction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsersAction.ForeColor = System.Drawing.Color.Black;
            this.btnUsersAction.Image = global::Bank.Properties.Resources._enter;
            this.btnUsersAction.ImageOffset = new System.Drawing.Point(-10, 37);
            this.btnUsersAction.ImageSize = new System.Drawing.Size(125, 125);
            this.btnUsersAction.Location = new System.Drawing.Point(801, 363);
            this.btnUsersAction.Name = "btnUsersAction";
            this.btnUsersAction.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUsersAction.Size = new System.Drawing.Size(200, 200);
            this.btnUsersAction.TabIndex = 14;
            this.btnUsersAction.Text = "Login Registry";
            this.btnUsersAction.TextOffset = new System.Drawing.Point(0, 20);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.Black;
            this.btnManageUsers.Image = global::Bank.Properties.Resources.user_management;
            this.btnManageUsers.ImageOffset = new System.Drawing.Point(0, 37);
            this.btnManageUsers.ImageSize = new System.Drawing.Size(150, 150);
            this.btnManageUsers.Location = new System.Drawing.Point(113, 363);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnManageUsers.Size = new System.Drawing.Size(200, 200);
            this.btnManageUsers.TabIndex = 15;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextOffset = new System.Drawing.Point(0, 20);
            // 
            // btnClientsActions
            // 
            this.btnClientsActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientsActions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsActions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsActions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientsActions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientsActions.FillColor = System.Drawing.Color.Transparent;
            this.btnClientsActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsActions.ForeColor = System.Drawing.Color.Black;
            this.btnClientsActions.Image = ((System.Drawing.Image)(resources.GetObject("btnClientsActions.Image")));
            this.btnClientsActions.ImageOffset = new System.Drawing.Point(0, 30);
            this.btnClientsActions.ImageSize = new System.Drawing.Size(140, 140);
            this.btnClientsActions.Location = new System.Drawing.Point(457, 126);
            this.btnClientsActions.Name = "btnClientsActions";
            this.btnClientsActions.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClientsActions.Size = new System.Drawing.Size(200, 200);
            this.btnClientsActions.TabIndex = 16;
            this.btnClientsActions.Text = "Transactions History";
            this.btnClientsActions.TextOffset = new System.Drawing.Point(0, 20);
            this.btnClientsActions.Click += new System.EventHandler(this.guna2CircleButton5_Click);
            // 
            // btnClientsTransfers
            // 
            this.btnClientsTransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientsTransfers.BackColor = System.Drawing.Color.Transparent;
            this.btnClientsTransfers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsTransfers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientsTransfers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientsTransfers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientsTransfers.FillColor = System.Drawing.Color.Transparent;
            this.btnClientsTransfers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientsTransfers.ForeColor = System.Drawing.Color.Black;
            this.btnClientsTransfers.Image = global::Bank.Properties.Resources.Transfer;
            this.btnClientsTransfers.ImageOffset = new System.Drawing.Point(0, 37);
            this.btnClientsTransfers.ImageSize = new System.Drawing.Size(125, 125);
            this.btnClientsTransfers.Location = new System.Drawing.Point(801, 126);
            this.btnClientsTransfers.Name = "btnClientsTransfers";
            this.btnClientsTransfers.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClientsTransfers.Size = new System.Drawing.Size(200, 200);
            this.btnClientsTransfers.TabIndex = 17;
            this.btnClientsTransfers.Text = "Transfer History";
            this.btnClientsTransfers.TextOffset = new System.Drawing.Point(0, 20);
            this.btnClientsTransfers.Click += new System.EventHandler(this.guna2CircleButton6_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1099, 600);
            this.Controls.Add(this.btnClientsTransfers);
            this.Controls.Add(this.btnClientsActions);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.btnUsersAction);
            this.Controls.Add(this.btnLoginRegistry);
            this.Controls.Add(this.btnManageClients);
            this.Controls.Add(this.guna2Shapes1);
            this.MinimizeButton = true;
            this.MinimumSize = new System.Drawing.Size(0, 94);
            this.Mode = MyUC.Forms.frmScreen.enMode.User;
            this.Name = "frmMainMenu";
            this.RestoreButton = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.guna2Shapes1, 0);
            this.Controls.SetChildIndex(this.btnManageClients, 0);
            this.Controls.SetChildIndex(this.btnLoginRegistry, 0);
            this.Controls.SetChildIndex(this.btnUsersAction, 0);
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

        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2CircleButton btnManageClients;
        private Guna.UI2.WinForms.Guna2CircleButton btnLoginRegistry;
        private Guna.UI2.WinForms.Guna2CircleButton btnUsersAction;
        private Guna.UI2.WinForms.Guna2CircleButton btnManageUsers;
        private Guna.UI2.WinForms.Guna2CircleButton btnClientsActions;
        private Guna.UI2.WinForms.Guna2CircleButton btnClientsTransfers;
    }
}