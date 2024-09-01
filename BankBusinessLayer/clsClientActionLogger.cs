using BankDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public static class clsClientActionLogger
    {
        public static bool AddAction(int ClientID, double Amount, enClientActions Action)
        {
            return clsClientActionsHistoryDA.AddNewWith(ClientID, Amount, Action) != -1;
        }

        public static bool Delete(int LogID)
        {
            return clsClientActionsHistoryDA.DeleteByID(LogID);
        }

        public static DataTable GetHistory()
        {
            return clsClientActionsHistoryDA.GetAll();

        }
        
        public static DataView GetHistoryByUser(int ClientID)
        {
            DataTable History = GetHistory();
            DataView UserActions = History.AsDataView();

            UserActions.RowFilter = $"ClientID = {ClientID}";

            return UserActions;
        }

    }
}
