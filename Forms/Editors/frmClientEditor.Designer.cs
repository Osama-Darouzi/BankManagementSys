namespace Bank.Forms.Editors
{
    partial class frmClientEditor
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
            this.CEditor = new MyUC.Bank.Editors.ClientEditor();
            this.cbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.PnlHead.Controls.Add(this.cbSearch);
            this.PnlHead.Size = new System.Drawing.Size(475, 90);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkFullName, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            this.PnlHead.Controls.SetChildIndex(this.lblUsername, 0);
            this.PnlHead.Controls.SetChildIndex(this.cbSearch, 0);
            // 
            // pbStar
            // 
            this.pbStar.Size = new System.Drawing.Size(90, 90);
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(132, 1);
            this.pbProPic.Size = new System.Drawing.Size(90, 90);
            // 
            // lnkFullName
            // 
            this.lnkFullName.Location = new System.Drawing.Point(226, 36);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(343, 8);
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(229, 36);
            // 
            // CEditor
            // 
            this.CEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEditor.Location = new System.Drawing.Point(0, 90);
            this.CEditor.MinimumSize = new System.Drawing.Size(474, 561);
            this.CEditor.Name = "CEditor";
            this.CEditor.Size = new System.Drawing.Size(475, 620);
            this.CEditor.TabIndex = 1;
            this.CEditor.Theme = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(251)))));
            this.CEditor.ThemeChanged += new MyUC.MyUC_Shared.ColorEveHan(this.CEditor_ThemeChanged);
            // 
            // cbSearch
            // 
            this.cbSearch.AutoRoundedCorners = true;
            this.cbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cbSearch.BorderRadius = 17;
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearch.ItemHeight = 30;
            this.cbSearch.Location = new System.Drawing.Point(43, 45);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(382, 36);
            this.cbSearch.Sorted = true;
            this.cbSearch.TabIndex = 12;
            // 
            // frmClientEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(475, 710);
            this.CloseStyle = MyUC.Forms.frmScreen.enCloseStyle.Back;
            this.Controls.Add(this.CEditor);
            this.Mode = MyUC.Forms.frmScreen.enMode.Normal;
            this.Name = "frmClientEditor";
            this.RestoreButton = false;
            this.Text = "frmClientEditor";
            this.TimeSynchronization = false;
            this.UsernameVisibility = false;
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.CEditor, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyUC.Bank.Editors.ClientEditor CEditor;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearch;
    }
}