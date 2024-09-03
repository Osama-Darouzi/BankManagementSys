using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ImageProcessing;
using BankDAL;

namespace BankBusinessLayer
{
    public enum enPermissions
    {
        admin = -1,
        ManageClients = 1,
        ShowClientsList = 1 << 1,
        AddNewClient = 1 << 2,
        UpdateClient = 1 << 3,
        DeleteClient = 1 << 4,

        ShowTransferLog = 1 << 5,
        ShowClientsActionsLog = 1 << 6,
        LoginRegister = 1 << 7,
        ShowUsersActionsLog = 1 << 8,
        DeleteHistoryRecords = 1 << 9,

        ManageUsers = 1 << 10,
        ShowUsersList = 1 << 11,
        AddNewUser = 1 << 12,
        UpdateUser = 1 << 13,
        DeleteUser = 1 << 14,
        TransferBalances = 1 << 15,
        
    }

    public class clsUser : clsPerson
    {
        private enMode _Mode;

        private int _UserID;

        public int ID { get { return _UserID; } }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Permissions {get; set; }

        public bool IsAdmin { get { return Permissions == -1; } }

        private bool _Add()
        {
            _UserID = clsUserDA.AddNewWith(PersonID, Username, Password, Permissions);
            return ID != -1;
        }

        private bool _Update()
        {
            
            return clsUserDA.UpdateByID(_UserID,  Username, Password, Permissions);
        }

        protected void _ObjPreparer(int UserID = -1, string Username = "", string Password = "", int Permissions = -1)
        {

            _UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.Permissions = Permissions;
        }

        public clsUser() : base()
        {
            _Mode = enMode.AddNew;
            _ObjPreparer();
        }

        public clsUser(string firstName, string lastName, string email, string address, Image Pfp, string username, string password, int permissions)
            : base(firstName, lastName, email, address, Pfp)
        {
            _Mode = enMode.AddNew;
            _ObjPreparer(-1, username, password, permissions);
        }

        private clsUser(int UserID, int PersonID, string firstName, string lastName, string email, string address, Image Pfp, string username, string password, int permissions) 
            : base(PersonID, firstName, lastName, email, address, Pfp)
        {
            _Mode = enMode.Update;
            _ObjPreparer(UserID, username, password, permissions);
        }

        public static bool DoesExist(int UserID)
        {
            return clsUserDA.DoesExist(UserID);
        }

        public static bool DoesExist(string Username)
        {
            return clsUserDA.DoesExist(Username);
        }

        public new static bool Delete(int UserID)
        {
            int PersonID = clsUserDA.GetUserPersonID(UserID);
            return clsUserDA.DeleteByID(UserID) && clsPerson.Delete(PersonID);
        }

        public static bool Delete(string Username)
        {
            int PersonID = clsUserDA.GetUserPersonID(Username);
            return clsUserDA.DeleteByUsername(Username) && clsPerson.Delete(PersonID);
        }

        public static clsUser Find(int UserID)
        {
            int PersonID = -1;
            int Permissions = -1;
            string FirstName = "", LastName = "", Email = "", Address = "", ImagePath = "", Username = "", Password = "";

            if (clsUserDA.GetByID(UserID, ref PersonID, ref FirstName, ref LastName, ref Email, ref Address, ref ImagePath
                , ref Username, ref Password, ref Permissions))
            {
                Image Pfp = ImageHandler.GetImage(ImagePath);
                return new clsUser(UserID, PersonID, FirstName, LastName, Email, Address, Pfp, Username, Password, Permissions);
            }

            return null;
        }

        public static clsUser Find(string Username)
        {
            int UserID = -1, PersonID = -1;
            int Permissions = -1;
            string FirstName = "", LastName = "", Email = "", Address = "", ImagePath = "", Password = "";

            if (clsUserDA.GetByUsername(Username, ref UserID, ref PersonID, ref FirstName, ref LastName, ref Email, ref Address, ref ImagePath
                , ref Password, ref Permissions))
            {
                Image Pfp = ImageHandler.GetImage(ImagePath);
                return new clsUser(UserID, PersonID, FirstName, LastName, Email, Address, Pfp, Username, Password, Permissions);
            }

            return null;
        }

        public static clsUser Find(string Username, string Password)
        {
            clsUser user = Find(Username);

            if (user != null && user.Password == Password)
            {
                return user;
            }

            return null;
        }

        public override bool Save()
        {
            bool PersonSave = base.Save();
            bool SaveState = false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if(SaveState = _Add())
                    {
                        _Mode = enMode.Update;
                    }
                    break;
                case enMode.Update:
                    SaveState = _Update();
                    break;
            }

            return SaveState && PersonSave;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDA.GetAllUsers();
        }

        public static DataTable Search(string FullNameFilter)
        {
            return clsUserDA.GetAllUsers(FullNameFilter);
        }
    }
}
