using Bank.Forms.Editors;
using Bank.Forms.Info_Cards_Forms;
using BankBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Forms.SubFroms
{
    public partial class frmManageClients : frmBankScreen
    {
        private clsClient _client;

        public clsClient Client
        {
            get => _client;
            set
            {
                _client = value;
                if (_client != null)
                {
                    _RefreshStatPie();
                    pbPFP.Image = value.PImage;
                }
            }
        }

        public frmManageClients()
        {
            InitializeComponent();
            sdbtnMngClients.Visible = false;
            frmManageClients_ThemeChanged(PnlHead.BackColor, BackColor);
        }

        private void _LoadClients()
        {
            DataTable Clients = clsClient.GetAllClients();
            dgvClients.DataSource = Clients;
            dgvClients.ClearSelection();
        }

        private void _EmptyValues()
        {
            statPie.Visible = false;
            pbPFP.Visible = false;
        }

        private void _SpecialTreatForBlackGuys()
        {
        
            dgvClients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            statPie.lblPart.ForeColor = statPie.lblPercentage.ForeColor = Color.White;
                    
        }

        private void _RefreshStatPie()
        {
            statPie.Visible = true;
            pbPFP.Visible = true;
            statPie.Part = Client.Balance;
            statPie.PartName = $"{Client.FirstName}\'s Balance";
            statPie.Total = clsClient.TotalBalances;
            pbPFP.Invalidate();
        }

        private void frmManageClients_Load(object sender, EventArgs e)
        {
            _LoadClients();

        }

        private void frmManageClients_ThemeChanged(Color MainColor, Color SubColor)
        {
            if (MainColor == Color.Black)
            {
                _SpecialTreatForBlackGuys();
                return;
            }
            statPie.lblPart.ForeColor = statPie.lblPercentage.ForeColor = Color.Black;
            dgvClients.ColumnHeadersDefaultCellStyle.BackColor = MainColor;
            splitter.Panel2.BackColor = MainColor ;
            dgvClients.BackgroundColor = SubColor;
            dgvClients.DefaultCellStyle.BackColor = SubColor;
            
            foreach (Guna2Button btn in splitter.Panel2.Controls.OfType<Guna2Button>())
            {
                btn.FillColor = SubColor;
            }

            dgvClients.DefaultCellStyle.SelectionBackColor = Color.Silver;
        }

        private void dgvClients_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null || dgvClients.CurrentRow.Cells["ClientID"].Value == null)
            {
                _EmptyValues();
                return; 
            }
            Client = clsClient.Find((int)dgvClients.CurrentRow.Cells["ClientID"].Value);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvClients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmClientCard CCard = new frmClientCard();
            CCard.Client = Client;
            CCard.ShowDialog();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmClientEditor clientEditor = new frmClientEditor();
            clientEditor.ShowDialog();
            _LoadClients();
        }
    }
}
