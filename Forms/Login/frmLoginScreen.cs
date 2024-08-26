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

namespace Bank.Forms
{
	public partial class frmLoginScreen : frmScreen
	{
		public frmLoginScreen()
		{
			InitializeComponent();
			pbStar.Visible = false;
			
			RestoreButton = false;
		}

		protected static Timer tAnimation = new Timer()
		{
			Interval = 3200
		};

		private void frmLogin_Load(object sender, EventArgs e)
		{
			tAnimation.Tick += tAnimation_Tick;
			tAnimation.Start();
			lnkMadeBy.BackColor = Color.Transparent;
		}

		private void tAnimation_Tick(object sender, EventArgs e)
		{
			pbBackGraghics.Hide();
			tAnimation.Stop();
		}

        private void lnkMadeBy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			System.Diagnostics.Process.Start("https://t.me/Osama_Darouzi");
        }

    }
}
