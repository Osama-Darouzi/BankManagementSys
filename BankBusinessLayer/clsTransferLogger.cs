using BankDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public static class clsTransferLogger
    {
        public static bool AddAction(int SenderID, int RecipientID, double TransferAmount,
            double SenderBalance, double RecipientBalance, int UserID)
        {
            return clsTransferRegistryDA.AddNewWith(SenderID, RecipientID, TransferAmount, SenderBalance, RecipientBalance, UserID) != -1;
        }

        public static bool Delete(int TransferID)
        {
            return clsTransferRegistryDA.DeleteByID(TransferID);
        }

        public static DataTable GetHistory()
        {
            return clsTransferRegistryDA.GetAll();

        }
        
        public static DataView GetHistoryByUser(int SenderID)
        {
            DataTable History = GetHistory();
            DataView UserActions = History.AsDataView();

            UserActions.RowFilter = $"SenderID = {SenderID}";

            return UserActions;
        }

        public static DataView GetHistoryByAffected(int RecipientID)
        {
            DataTable History = GetHistory();
            DataView OnPersonActions = History.AsDataView();

            OnPersonActions.RowFilter = $"RecipientID = {RecipientID}";

            return OnPersonActions;
        }
    }
}
