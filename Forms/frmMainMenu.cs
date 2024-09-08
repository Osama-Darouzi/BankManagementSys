using BankBusinessLayer;
using MyUC.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using ControlsUtil;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankBusinessLayer.AppGlobals;
using Guna.UI2.WinForms;

namespace Bank.Forms
{
    public partial class frmMainMenu : frmBankScreen
    {
        public frmMainMenu() : base()
        {
            InitializeComponent();

            if (SysUser == null)
            {
                _Logout();
            }

            Mode = enMode.User;
            FullName = SysUser.FirstName + " " + SysUser.LastName;
            Username = SysUser.Username;
            pbProPic.Image = SysUser.PImage;
            _ApplyPermissions();
            _InitializeToolTip();
           // RestoreButton = false;
        }

        private void _ApplyPermissions()
        {
            btnManageClients.Enabled = SysUser.HasPermissionOn(enPermissions.ManageClients);
            btnClientsActions.Enabled = SysUser.HasPermissionOn(enPermissions.ShowClientsActionsLog);
            btnClientsTransfers.Enabled = SysUser.HasPermissionOn(enPermissions.ShowTransferLog);
            btnManageUsers.Enabled = SysUser.HasPermissionOn(enPermissions.ManageUsers);
            btnUsersActions.Enabled = SysUser.HasPermissionOn(enPermissions.ShowUsersActionsLog);
            btnLoginRegistry.Enabled = SysUser.HasPermissionOn(enPermissions.LoginRegister);
        }

        private void _InitializeToolTip()
        {
            foreach (Control ctrl in this.Controls.OfType<Guna2CircleButton>())
            {
                ControlsU.ToolTipOn(ctrl, ctrl.Text);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            RestoreButton = btnRestore.Visible;
            base.OnPaint(e);
            Size size = new Size(Size.Width / 5, Size.Height / 3);
            int ImageSize = 3 * size.Width / 4;
            int UpY = Separator.Location.Y - size.Height - 30;
            int LowY = Separator.Location.Y + 30;
            
            btnManageClients.Size = size;
            btnManageClients.Location = new Point(Separator.Left, UpY);
            // btnManageClients.ImageSize = new Size(ImageSize, ImageSize);

            btnClientsActions.Size = size;
            btnClientsActions.Location = new Point(ControlsU.X_FromCenter(btnClientsActions, Width / 2), UpY);
            //btnClientsActions.ImageSize = new Size(ImageSize, ImageSize);

            btnClientsTransfers.Size = size;
            btnClientsTransfers.Location = new Point(Separator.Right - size.Width, UpY);

            btnManageUsers.Size = size;
            btnManageUsers.Location = new Point(Separator.Left, LowY);

            btnUsersActions.Size = size;
            btnUsersActions.Location = new Point(ControlsU.X_FromCenter(btnUsersActions, Width / 2), LowY);

            btnLoginRegistry.Size = size;
            btnLoginRegistry.Location = new Point(Separator.Right - size.Width, LowY);
        }

        private void btnManageClients_Click(object sender, EventArgs e)
        {

        }

        private void btnClientsActions_Click(object sender, EventArgs e)
        {

        }

        private void btnClientsTransfers_Click(object sender, EventArgs e)
        {

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsersAction_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginRegistry_Click(object sender, EventArgs e)
        {

        }

        private void btns_EnabledChanged(object sender, EventArgs e)
        {
            Guna2CircleButton btn = (Guna2CircleButton)sender;
            if (btn.Enabled)
            {
                ControlsU.ToolTipOn(btn, btn.Text);
                return;
            }
            ControlsU.ToolTipOn(btn, $"Access to {btn.Text} Denied");
        }
    }
}
