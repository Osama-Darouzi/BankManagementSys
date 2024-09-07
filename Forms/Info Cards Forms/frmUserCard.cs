using BankBusinessLayer;
using MyUC.Bank.Editors;
using MyUC.Forms;
using System;
using System.Collections.Generic;
using static BankBusinessLayer.AppGlobals;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Forms.Info_Cards_Forms
{
    public partial class frmUserCard : frmBankScreen
    {

        public event Action UserStateChanged;
        private enum enUserState{Offline, Online}

        private enUserState _userState;
        //private clsUser user = null;

        private enUserState UserState
        {
            get { return _userState; }
            set { _userState = value; UserStateChanged?.Invoke(); }
        }

        public clsUser User
        {
            get
            {
                return UCard.User;
            }
            set
            {
                UCard.User = value;
                UserState = value == SysUser ? enUserState.Online : enUserState.Offline;
            }
        }

        public frmUserCard()
        {
            InitializeComponent();
            UserStateChanged += FrmUserCard_UserStateChanged;
        }

        private void FrmUserCard_UserStateChanged()
        {
            switch (UserState)
            {
                case enUserState.Offline:
                    btnLogout.Visible = false;
                    btnForget.Visible = false;
                    UCard.Size = new Size(Width, Height - PnlHead.Height);
                    break;
                case enUserState.Online:
                    btnLogout.Visible = true;
                    btnForget.Visible = true;
                    UCard.Size = new Size(Size.Width, Size.Height - PnlHead.Height - btnForget.Height - 19);
                    break;
            }
        }

        private void UCard_ThemeChanged(Color color)
        {
            PnlHead.ForeColor = color;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _Logout();
        }

        private void btnForget_Click(object sender, EventArgs e)
        {
            _Logout(true);
        }
    }
}
