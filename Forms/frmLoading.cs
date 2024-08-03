using Bank.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            wmpIntro.URL = @"D:\Downloads\Bank program intro.mp4";
            timer1.Start();
        }

        private void IntroClose()
        {
            timer1.Stop();
            wmpIntro.Ctlcontrols.stop();
            this.Visible = false;
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            IntroClose();
        }

        private void wmpIntro_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
        {
            IntroClose();
        }
    }
}
