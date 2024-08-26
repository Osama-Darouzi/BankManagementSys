using BankBusinessLayer;
using MyUC.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
