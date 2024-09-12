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
    public partial class frmClientEditor : frmScreen
    {
        public clsClient Client
        {
            get => CEditor.Client; set => CEditor.Client = value;
        }
        public frmClientEditor()
        {
            InitializeComponent();
            
        }

        private void _FillComboBox()
        {
            object obj = new object();
            obj.ToString();
            cbSearch.Items.Add
        }

        private void CEditor_ThemeChanged(Color color)
        {
            PnlHead.BackColor = color;
        }
    }
}
