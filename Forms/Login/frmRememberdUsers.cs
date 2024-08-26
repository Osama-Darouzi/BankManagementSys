using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank.Forms.Login
{
    public partial class frmRememberdUsers : frmLoginScreen
    {
        public frmRememberdUsers()
        {
            InitializeComponent();
            tAnimation.Enabled = false;
            pbBackGraghics.Visible = false;
            pbBackGraghics.SizeMode = PictureBoxSizeMode.Zoom;
            RemUsers = clsUsersMemory.GetAllUsers();
            RefreshListView();

        }

        public delegate void UserDataBackEveHan(string Username);
        public event UserDataBackEveHan IdDataBack;

        private clsUser[] RemUsers;
        private ImageList UsersPFPs = new ImageList();

        private ListViewItem UserToLV_item(clsUser user)
        {
            ListViewItem item = new ListViewItem();
            item.Font = new Font("Microsoft YaHei", 14, FontStyle.Bold);
            ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, user.FullName);
            item.SubItems.Add(subItem);
            item.ImageKey = user.ID.ToString();
            item.Tag = user.Username;
            return item;
        }
        
        private void FillImageList()
        {
            UsersPFPs.Images.Clear();
            UsersPFPs.ColorDepth = ColorDepth.Depth32Bit;
            UsersPFPs.ImageSize = new Size(50, 50);

            foreach (clsUser user in RemUsers)
            {
                UsersPFPs.Images.Add(user.ID.ToString(), user.PImage);
            }
        }

        private void RefreshListView()
        {
            lvRememberedUsers.Items.Clear();
            FillImageList();
            lvRememberedUsers.SmallImageList = UsersPFPs;

            foreach (clsUser user in RemUsers)
            {
                lvRememberedUsers.Items.Add(UserToLV_item(user));
            }
        }

        private void lvRememberedUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string Username = lvRememberedUsers.SelectedItems[0].Tag.ToString();

            IdDataBack?.Invoke(Username);

            this.Close();
        }

        private void pbBackGraghics_Click(object sender, EventArgs e)
        {

        }
    }
}
