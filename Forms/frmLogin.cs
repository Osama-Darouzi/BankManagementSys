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
using System.Threading;
using System.Windows.Forms;

namespace Bank.Forms
{
	public partial class frmLogin : frmScreen
	{
		public frmLogin()
		{
			InitializeComponent();
			pbStar.Visible = false;
		}

		ErrorProvider ErrCapsLock;

		private void frmLogin_Load(object sender, EventArgs e)
		{
			this.Visible = false;
			//frmLoading frmLoading = new frmLoading();
			//frmLoading.ShowDialog();
			this.Visible = true;
			tLogin.Start();
			tControlsShow.Start();
			errLogin.Icon = SystemIcons.Error;
			ErrCapsLock = new ErrorProvider();
			
			//chkRemmember.Parent = lnkMadeBy.Parent = pbBackGraghics;
			txtUsername.Refresh();
			lnkMadeBy.BackColor = Color.Transparent;


		}

		private void tLogin_Tick(object sender, EventArgs e)
		{
			pbBackGraghics.Hide();
			tLogin.Stop();
			
		}

		private void tControlsShow_Tick(object sender, EventArgs e)
		{

			txtUsername.Show();
			txtPassword.Show();
			chkRemmember.Show();
			btnLogin.Show();
			lnkMadeBy.Show();
			tControlsShow.Stop();
		}


	}
}
