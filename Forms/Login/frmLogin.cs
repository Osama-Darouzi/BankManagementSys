using Bank.Properties;
using MyUC;
using System;
using MyUC.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using BankBusinessLayer;
using System.Windows.Forms;
using Bank.Forms.Login;
using static BankBusinessLayer.AppGlobals;

namespace Bank.Forms
{
	public partial class frmLogin : frmLoginScreen
	{
		public frmLogin() : base()
		{
			InitializeComponent();
		}

		ErrorProvider ErrCapsLock;

		private void _RememberingProcess()
		{
			if (chkRemember.Checked)
			{
				clsUsersMemory.Remember(SysUser.ID);
			}
		}

		private void _Login()
		{
			if (SysUser == null)
			{
				return;
			}

			this.Hide();
			frmMainMenu menu = new frmMainMenu();
			menu.ShowDialog();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{
			SysUser = clsUsersMemory.GetLoggedInUser();
			_Login();
			tControlsShow.Start();
			errLogin.Icon = SystemIcons.Error;
			ErrCapsLock = new ErrorProvider();
			
		}

		private void tControlsShow_Tick(object sender, EventArgs e)
		{

			lnkMadeBy.Show();
			txtUsername.Show();
			txtPassword.Show();
			chkRemember.Show();
			btnLogin.Show();
			btnRemembered.Show();
			tControlsShow.Stop();
			
		}


        private void btnLogin_Click(object sender, EventArgs e)
        {
			SysUser = clsUser.Find(txtUsername.Text, txtPassword.Text);

			if (SysUser != null)
			{
				clsLoginRegister.AddLogin(SysUser);
				_RememberingProcess();
				_Login();
			}
        }

		private void ChildForms_LocationChanged(object sender, EventArgs e)
		{
			Form child = sender as Form;
			this.Location = child.Location;
		}

		private void frmRememberedDataBack(string Username)
		{
			txtUsername.Text = Username;
		}

        private void btnRemembered_Click(object sender, EventArgs e)
        {
			frmRememberdUsers rememberdUsers = new frmRememberdUsers();
			rememberdUsers.Location = this.Location;
			rememberdUsers.IdDataBack += frmRememberedDataBack;
			rememberdUsers.LocationChanged += ChildForms_LocationChanged;
			rememberdUsers.ShowDialog();
        }
    }
}
