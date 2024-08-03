namespace Bank
{
    partial class frmLoading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.wmpIntro = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wmpIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpIntro
            // 
            this.wmpIntro.Enabled = true;
            this.wmpIntro.Location = new System.Drawing.Point(-66, -40);
            this.wmpIntro.Name = "wmpIntro";
            this.wmpIntro.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpIntro.OcxState")));
            this.wmpIntro.Size = new System.Drawing.Size(813, 590);
            this.wmpIntro.TabIndex = 0;
            this.wmpIntro.MouseDownEvent += new AxWMPLib._WMPOCXEvents_MouseDownEventHandler(this.wmpIntro_MouseDownEvent);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 430);
            this.ControlBox = false;
            this.Controls.Add(this.wmpIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmpIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpIntro;
        private System.Windows.Forms.Timer timer1;
    }
}

