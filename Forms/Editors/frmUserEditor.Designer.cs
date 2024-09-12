namespace Bank.Forms.Editors
{
    partial class frmUserEditor
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
            this.uEditor = new MyUC.Bank.Editors.UserEditor();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.PnlHead.Size = new System.Drawing.Size(763, 35);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            // 
            // pbStar
            // 
            this.pbStar.Location = new System.Drawing.Point(0, 1);
            this.pbStar.Size = new System.Drawing.Size(35, 35);
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(321, 1);
            this.pbProPic.Size = new System.Drawing.Size(35, 35);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Location = new System.Drawing.Point(363, 8);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(631, 8);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(366, 8);
            // 
            // uEditor
            // 
            this.uEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uEditor.Location = new System.Drawing.Point(0, 35);
            this.uEditor.MinimumSize = new System.Drawing.Size(763, 607);
            this.uEditor.Name = "uEditor";
            this.uEditor.Size = new System.Drawing.Size(763, 620);
            this.uEditor.TabIndex = 12;
            this.uEditor.Theme = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.uEditor.ThemeChanged += new MyUC.MyUC_Shared.ColorEveHan(this.uEditor_ThemeChanged);
            // 
            // frmUserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(763, 655);
            this.CloseStyle = MyUC.Forms.frmScreen.enCloseStyle.Back;
            this.Controls.Add(this.uEditor);
            this.Mode = MyUC.Forms.frmScreen.enMode.Normal;
            this.Name = "frmUserEditor";
            this.RestoreButton = false;
            this.Text = "frmUserEditor";
            this.TimeSynchronization = false;
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.uEditor, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyUC.Bank.Editors.UserEditor uEditor;
    }
}