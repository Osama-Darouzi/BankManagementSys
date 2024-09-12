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

namespace Bank.Forms.Editors
{
    public partial class frmUserEditor : frmScreen
    {

        public clsUser User { get => uEditor.User; set => uEditor.User = value; }
        public frmUserEditor()
        {
            InitializeComponent();
        }

        private void uEditor_ThemeChanged(Color color)
        {
            PnlHead.BackColor = color;
        }
    }
}
