using BankDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public static class clsUserActionLogger
    {
        public static bool AddAction(int UserID, int AffectedPersonID, enUserActions Action)
        {
            return clsUserActionsHistoryDA.AddNewWith(UserID, AffectedPersonID, Action) != -1;
        }

        public static bool Delete(int LogID)
        {
            return clsUserActionsHistoryDA.DeleteByID(LogID);
        }

        public static DataTable GetHistory()
        {
            return clsUserActionsHistoryDA.GetAll();

        }
        
        public static DataView GetHistoryByUser(int UserID)
        {
            DataTable History = GetHistory();
            DataView UserActions = History.AsDataView();

            UserActions.RowFilter = $"UserID = {UserID}";

            return UserActions;
        }

        public static DataView GetHistoryByAffected(int AffectedPersonID)
        {
            DataTable History = GetHistory();
            DataView OnPersonActions = History.AsDataView();

            OnPersonActions.RowFilter = $"AffectedPersonID = {AffectedPersonID}";

            return OnPersonActions;
        }
    }
}
