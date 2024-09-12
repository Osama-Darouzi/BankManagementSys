using MyUC.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using static BankBusinessLayer.AppGlobals;
using System.Windows.Forms;
using BankBusinessLayer;
using Bank.Forms.Info_Cards_Forms;
using System.Net.Sockets;
using Guna.UI2.WinForms;
using Bank.Forms.SubFroms;

namespace Bank.Forms
{
    public partial class frmBankScreen : frmScreen
    {
        protected static bool _IsLogout = false;
        private bool _sdPnlsVisibility = false;

        [Category("Appearance")]
        public bool SidePanels
        {
            get => _sdPnlsVisibility;
            set
            {
                _sdPnlsVisibility = value;
                pnlMenu.Visible = pnlSide.Visible = value;
            }
        }

        public frmBankScreen()
        {
            InitializeComponent();

            if (SysUser == null && Application.OpenForms.Count != 0)
            {
                _Logout();
            }
            else
            {
                FullName = SysUser.FirstName + " " + SysUser.LastName;
                Username = SysUser.Username;
                pbProPic.Image = SysUser.PImage;
            }


            frmBankScreen_ThemeChanged(PnlHead.BackColor, BackColor);
            _ApplyPermissions();
        }

        private void _ApplyPermissions()
        {
            if (SysUser == null) return;

            sdbtnMngClients.Enabled = SysUser.HasPermissionOn(enPermissions.ManageClients);
            sdbtnClientsActions.Enabled = SysUser.HasPermissionOn(enPermissions.ShowClientsActionsLog);
            sdbtnClientsTransfers.Enabled = SysUser.HasPermissionOn(enPermissions.ShowTransferLog);
            sdbtnMngUsers.Enabled = SysUser.HasPermissionOn(enPermissions.ManageUsers);
            sdbtnUsersActions.Enabled = SysUser.HasPermissionOn(enPermissions.ShowUsersActionsLog);
            sdbtnLoginRegistry.Enabled = SysUser.HasPermissionOn(enPermissions.LoginRegister);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //pnlSide.SendToBack();
            //pnlMenu.SendToBack();
            //pnlSide.Location = new Point(0, PnlHead.Bottom);
            pnlMenu.Location = new Point(0, Height - pnlMenu.Height);

            //pnlSide.Height = Height - pnlMenu.Height - PnlHead.Height;

            base.OnPaint(e);
        }

        private void frmBankScreen_CloseButtonClicked(object sender, EventArgs e)
        {
            switch (CloseStyle)
            {
                case enCloseStyle.Close:
                    Application.Exit();
                    break;
                case enCloseStyle.Back:
                    Close();
                    break;
            }
        }

        protected void _Logout(bool DoForget = false)
        {
            for (int i = Application.OpenForms.Count - 1; i > 0; i--)
            {
                Application.OpenForms[i].Close();
            }
            Application.OpenForms[0].Show();

            if (SysUser == null) return;

            clsUsersMemory.Logout(SysUser.ID);

            if (DoForget)
            {
                clsUsersMemory.Forget(SysUser.ID);
            }

            SysUser = null;
            _IsLogout = true;
        }

        private void frmBankScreen_FullNameClicked(object sender, EventArgs e)
        {
            frmUserCard frmUC  = new frmUserCard();
            frmUC.User = SysUser;
            frmUC.ShowDialog();
        }

        private void frmBankScreen_ThemeChanged(Color PanelColor, Color BackColor)
        {
            pnlMenu.BackColor = PanelColor;
            pnlSide.BackColor = PanelColor;
            foreach (Control ctrl in pnlSide.Controls)
            {
                if (ctrl is Guna2Button)
                {
                    Guna2Button btn = (Guna2Button)ctrl;
                    btn.FillColor = BackColor;
                }
            }
        }

        protected void sdbtnManageClients_Click(object sender, EventArgs e)
        {
            frmManageClients frmManageClients = new frmManageClients();
            frmManageClients.ShowDialog();
        }

        protected void sdbtnClientsActions_Click(object sender, EventArgs e)
        {

        }

        protected void sdbtnClientsTransfers_Click(object sender, EventArgs e)
        {

        }

        protected void sdbtnManageUsers_Click(object sender, EventArgs e)
        {
            
        }

        protected void sdbtnUsersAction_Click(object sender, EventArgs e)
        {

        }

        protected void sdbtnLoginRegistry_Click(object sender, EventArgs e)
        {

        }
    }
}
