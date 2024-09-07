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

namespace Bank.Forms
{
    public partial class frmBankScreen : frmScreen
    {
        public frmBankScreen()
        {
            InitializeComponent();
        }

        private void frmBankScreen_CloseButtonClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void _Logout(bool DoForget = false)
        {
            clsUsersMemory.Logout(SysUser.ID);

            if (DoForget)
            {
                clsUsersMemory.Forget(SysUser.ID);
            }

            for (int i = Application.OpenForms.Count - 1; i > 0; i--)
            {
                Application.OpenForms[i].Close();
            }
            Application.OpenForms[0].Show();
            SysUser = null;
        }

        private void frmBankScreen_FullNameClicked(object sender, EventArgs e)
        {
            frmUserCard frmUC  = new frmUserCard();
            frmUC.User = SysUser;
            frmUC.ShowDialog();
        }
    }
}
