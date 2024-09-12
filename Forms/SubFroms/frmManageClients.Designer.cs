namespace Bank.Forms.SubFroms
{
    partial class frmManageClients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageClients));
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.dgvClients = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAddClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.pbPFP = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.statPie = new MyUC.StatPie();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPFP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSide
            // 
            this.pnlSide.Size = new System.Drawing.Size(47, 654);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Location = new System.Drawing.Point(0, 601);
            // 
            // PnlHead
            // 
            this.PnlHead.Size = new System.Drawing.Size(1200, 46);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            // 
            // pbStar
            // 
            this.pbStar.Size = new System.Drawing.Size(46, 46);
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(514, 1);
            this.pbProPic.Size = new System.Drawing.Size(46, 46);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Location = new System.Drawing.Point(572, 14);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(1038, 8);
            this.lblTime.Text = "6:24 PM";
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(575, 14);
            // 
            // splitter
            // 
            this.splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitter.IsSplitterFixed = true;
            this.splitter.Location = new System.Drawing.Point(47, 46);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.dgvClients);
            this.splitter.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitter.Panel1MinSize = 255;
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.btnAddClient);
            this.splitter.Panel2.Controls.Add(this.btnUpdateClient);
            this.splitter.Panel2.Controls.Add(this.btnDeleteClient);
            this.splitter.Panel2.Controls.Add(this.btnTransfer);
            this.splitter.Panel2.Controls.Add(this.pbPFP);
            this.splitter.Panel2.Controls.Add(this.statPie);
            this.splitter.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitter.Panel2MinSize = 50;
            this.splitter.Size = new System.Drawing.Size(1153, 654);
            this.splitter.SplitterDistance = 936;
            this.splitter.SplitterWidth = 1;
            this.splitter.TabIndex = 6;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.AllowUserToResizeColumns = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvClients.ColumnHeadersHeight = 25;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClients.GridColor = System.Drawing.Color.Silver;
            this.dgvClients.Location = new System.Drawing.Point(0, 0);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersVisible = false;
            dataGridViewCellStyle16.NullValue = "NULL";
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvClients.Size = new System.Drawing.Size(936, 654);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClients.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClients.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgvClients.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvClients.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClients.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClients.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClients.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClients.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvClients.ThemeStyle.ReadOnly = true;
            this.dgvClients.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClients.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvClients.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClients.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.dgvClients.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClients.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.dgvClients.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClients.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_RowEnter);
            this.dgvClients.SelectionChanged += new System.EventHandler(this.dgvClients_SelectionChanged);
            this.dgvClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvClients_MouseDoubleClick);
            // 
            // btnAddClient
            // 
            this.btnAddClient.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnAddClient.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnAddClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.btnAddClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddClient.Image = global::Bank.Properties.Resources.Add;
            this.btnAddClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddClient.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnAddClient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddClient.Location = new System.Drawing.Point(-1, 474);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAddClient.Size = new System.Drawing.Size(221, 45);
            this.btnAddClient.TabIndex = 12;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnUpdateClient.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnUpdateClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.btnUpdateClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateClient.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateClient.Image")));
            this.btnUpdateClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateClient.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnUpdateClient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdateClient.Location = new System.Drawing.Point(-2, 519);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnUpdateClient.Size = new System.Drawing.Size(221, 45);
            this.btnUpdateClient.TabIndex = 11;
            this.btnUpdateClient.Text = "Edit Client";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.CustomBorderColor = System.Drawing.Color.Silver;
            this.btnDeleteClient.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDeleteClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteClient.Image = global::Bank.Properties.Resources.Delete;
            this.btnDeleteClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteClient.ImageOffset = new System.Drawing.Point(18, 0);
            this.btnDeleteClient.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteClient.Location = new System.Drawing.Point(-1, 564);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(222, 45);
            this.btnDeleteClient.TabIndex = 10;
            this.btnDeleteClient.Text = "Delete Client";
            // 
            // btnTransfer
            // 
            this.btnTransfer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransfer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Black;
            this.btnTransfer.Image = global::Bank.Properties.Resources.Transfer;
            this.btnTransfer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransfer.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnTransfer.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTransfer.Location = new System.Drawing.Point(0, 609);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(221, 45);
            this.btnTransfer.TabIndex = 9;
            this.btnTransfer.Text = "Transfer Balance";
            this.btnTransfer.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pbPFP
            // 
            this.pbPFP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPFP.BackColor = System.Drawing.Color.Transparent;
            this.pbPFP.ImageRotate = 0F;
            this.pbPFP.Location = new System.Drawing.Point(58, 50);
            this.pbPFP.Name = "pbPFP";
            this.pbPFP.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbPFP.Size = new System.Drawing.Size(100, 100);
            this.pbPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPFP.TabIndex = 8;
            this.pbPFP.TabStop = false;
            this.pbPFP.UseTransparentBackground = true;
            // 
            // statPie
            // 
            this.statPie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statPie.Location = new System.Drawing.Point(5, 2);
            this.statPie.Name = "statPie";
            this.statPie.Part = 0D;
            this.statPie.PartColor = System.Drawing.Color.Tomato;
            this.statPie.PartName = "Part";
            this.statPie.PartVisibility = true;
            this.statPie.Size = new System.Drawing.Size(206, 267);
            this.statPie.TabIndex = 7;
            this.statPie.Total = 0D;
            this.statPie.TotalColor = System.Drawing.Color.CornflowerBlue;
            this.statPie.TotalName = "Total";
            this.statPie.TotalVisibility = false;
            // 
            // frmManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.CloseStyle = MyUC.Forms.frmScreen.enCloseStyle.Back;
            this.Controls.Add(this.splitter);
            this.Mode = MyUC.Forms.frmScreen.enMode.User;
            this.Name = "frmManageClients";
            this.PbStarVisibility = true;
            this.SidePanels = true;
            this.Text = "frmManageClients";
            this.UsernameVisibility = false;
            this.ThemeChanged += new MyUC.MyUC_Shared.Color2EveHan(this.frmManageClients_ThemeChanged);
            this.Load += new System.EventHandler(this.frmManageClients_Load);
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.pnlSide, 0);
            this.Controls.SetChildIndex(this.pnlMenu, 0);
            this.Controls.SetChildIndex(this.splitter, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPFP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.SplitContainer splitter;
        private MyUC.StatPie statPie;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbPFP;
        protected Guna.UI2.WinForms.Guna2DataGridView dgvClients;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClient;
        private Guna.UI2.WinForms.Guna2Button btnAddClient;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClient;
    }
}