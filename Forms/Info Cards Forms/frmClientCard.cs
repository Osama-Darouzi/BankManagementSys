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

namespace Bank.Forms.Info_Cards_Forms
{
    public partial class frmClientCard : frmBankScreen
    {
        public clsClient Client
        {
            get => CCard.Client;
            set => CCard.Client = value;
        }

        public frmClientCard()
        {
            InitializeComponent();
            PnlHead.BackColor = CCard.Theme;
        }

        private void CCard_ThemeChanged(Color color)
        {
            PnlHead.BackColor = color;
        }
    }
}
