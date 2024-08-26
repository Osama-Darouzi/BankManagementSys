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

namespace Bank.Forms
{
    public partial class frmMainMenu : frmScreen
    {
        public frmMainMenu() : base()
        {
            InitializeComponent();

            if (SysUser == null)
            {
                Close();
                Application.OpenForms[0].Show();
            }

            Mode = enMode.User;
            FullName = SysUser.FirstName + " " + SysUser.LastName;
            Username = SysUser.Username;
            pbProPic.Image = SysUser.PImage;
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Size size = new Size(Size.Width / 5, Size.Width / 5);
            int ImageSize = 3 * size.Width / 4;
            int UpY = Separator.Location.Y - size.Width - 30;
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

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoginRegistry_Click(object sender, EventArgs e)
        {

        }

        private void btnUsersAction_Click(object sender, EventArgs e)
        {

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
    }
}
