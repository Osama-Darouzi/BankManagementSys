using BankDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public static class clsUsersMemory
    {
        public static bool Remember(int UserID)
        {
            if(clsRememberedUsersDA.DoesExist(UserID))
                return clsRememberedUsersDA.UpdateByID(UserID, true);

            return clsRememberedUsersDA.AddNewWith(UserID);
        }

        public static bool Forget(int UserID)
        {
            if(!clsRememberedUsersDA.DoesExist(UserID)) return false;

            return clsRememberedUsersDA.DeleteByID(UserID);
        }

        public static bool Logout(int UserID)
        {
            return clsRememberedUsersDA.UpdateByID(UserID, false);
        }

        public static clsUser GetLoggedInUser()
        {
            int UserID = clsRememberedUsersDA.GetActivatedUser();

            if(UserID == -1) return null;
            
            return clsUser.Find(UserID);
        }

        public static clsUser[] GetAllUsers()
        {
            DataTable Users = clsRememberedUsersDA.GetAllRemUsers();
            if(Users == null) return null;

            clsUser[] LoggedUsers = new clsUser[Users.Rows.Count];

            for (int i = 0; i < Users.Rows.Count; i++)
            {
                int UserID = (int)Users.Rows[i]["UserID"];
                clsUser loggedUser = clsUser.Find(UserID);

                if (loggedUser == null)
                {
                    Forget(UserID);
                    continue;
                }

                LoggedUsers[i] = loggedUser;
            }

            return LoggedUsers;
        }
    }
}
