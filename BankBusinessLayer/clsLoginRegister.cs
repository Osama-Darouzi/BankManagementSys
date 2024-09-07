using BankDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public static class clsLoginRegister
    {

        public static bool AddLogin(clsUser user)
        {
            return clsLoginRegistryDA.AddNewWith(user.ID, user.Username, user.Permissions) != -1;
        }

        public static bool Delete(int LoginID)
        {
            return clsLoginRegistryDA.DeleteByID(LoginID);
        }

        public static DataTable GetLoginRegistry()
        {
            return clsLoginRegistryDA.GetAllLogins();

        }
        
        public static DataView GetLoginRegistryBy(int UserID)
        {
            DataTable AllLogins = clsLoginRegistryDA.GetAllLogins();
            DataView UserLogins = AllLogins.AsDataView();

            UserLogins.RowFilter = $"UserID = {UserID}";

            return UserLogins;
        }

        public static DataView GetLoginRegistryBy(string Username)
        {
            return clsLoginRegistryDA.GetAllLogins(Username).AsDataView();
        }
    }
}
