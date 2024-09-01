using BankDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using ImageProcessing;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsClient : clsPerson
    {
        private enMode _Mode;

        private int _ClientID;

        private double _Balance;

        public int ID { get { return _ClientID; } }

        public string AccountNumber { get; set; }

        public string PinCode { get; set; }

        public double Balance 
        { 
            get
            {
                return _Balance;
            }
            private set
            {
                _Balance = value;
                clsClientsDA.UpdateBalance(_ClientID, _Balance);
            }
        }

        public static double TotalBalances {get { return clsClientsDA.GetTotalBalances(); }}

        private bool _Add()
        {
            _ClientID = clsClientsDA.AddNewWith(PersonID, AccountNumber, PinCode, Balance);
            return ID != -1;
        }

        private bool _Update()
        {
            return clsClientsDA.UpdateByID(_ClientID,  AccountNumber, PinCode, Balance);
        }

        private void P_Deposit(double Amount)
        {
            Balance += Amount;
        }

        private bool P_Withdraw(double Amount)
        {
            if (IsWithdrawPossible(Amount))
            {
                P_Deposit(-Amount);
                return true;
            }

            return false;
        }

        protected void _ObjPreparer(int ClientID = -1, string AccountNumber = "", string PinCode = "", double Balance = 0)
        {

            _ClientID = ClientID;
            this.AccountNumber = AccountNumber;
            this.PinCode = PinCode;
            _Balance = Balance;
        }

        public clsClient() : base()
        {
            _Mode = enMode.AddNew;
            _ObjPreparer();
        }

        public clsClient(string firstName, string lastName, string email, string address, Image Pfp, string accountNumber, string pinCode, double balance)
            : base(firstName, lastName, email, address, Pfp)
        {
            _Mode = enMode.AddNew;
            _ObjPreparer(-1, accountNumber, pinCode, balance);
        }

        private clsClient(int ClientID, int PersonID, string firstName, string lastName, string email, string address, Image Pfp, string accountNumber, string pinCode, double balance) 
            : base(PersonID, firstName, lastName, email, address, Pfp)
        {
            _Mode = enMode.Update;
            _ObjPreparer(ClientID, accountNumber, pinCode, balance);
        }

        public static bool DoesExist(int ClientID)
        {
            return clsClientsDA.DoesExist(ClientID);
        }

        public static bool DoesExist(string AccountNumber)
        {
            return clsClientsDA.DoesExist(AccountNumber);
        }

        public new static bool Delete(int ClientID)
        {
            int PersonID = clsClientsDA.GetClientPersonID(ClientID);
            return clsClientsDA.DeleteByID(ClientID) && clsPerson.Delete(PersonID);
        }

        public static bool Delete(string AccountNumber)
        {
            int PersonID = clsClientsDA.GetClientPersonID(AccountNumber);
            return clsClientsDA.DeleteByAccountNumber(AccountNumber) && clsPerson.Delete(PersonID);
        }

        public static clsClient Find(int ClientID)
        {
            int PersonID = -1;
            double Balance = -1;
            string FirstName = "", LastName = "", Email = "", Address = "", ImagePath = "", AccountNumber = "", PinCode = "";

            if (clsClientsDA.GetByID(ClientID, ref PersonID, ref FirstName, ref LastName, ref Email, ref Address, ref ImagePath
                , ref AccountNumber, ref PinCode, ref Balance))
            {
                Image Pfp = ImageHandler.GetImage(ImagePath);
                return new clsClient(ClientID, PersonID, FirstName, LastName, Email, Address, Pfp, AccountNumber, PinCode, Balance);
            }

            return null;
        }

        public static clsClient Find(string AccountNumber)
        {
            int ClientID = -1, PersonID = -1;
            double Balance = -1;
            string FirstName = "", LastName = "", Email = "", Address = "", ImagePath = "", PinCode = "";

            if (clsClientsDA.GetByAccountNumber(AccountNumber, ref ClientID, ref PersonID, ref FirstName, ref LastName
                , ref Email, ref Address, ref ImagePath, ref PinCode, ref Balance))
            {
                Image Pfp = ImageHandler.GetImage(ImagePath);
                return new clsClient(ClientID, PersonID, FirstName, LastName, Email, Address, Pfp, AccountNumber, PinCode, Balance);
            }

            return null;
        }

        public static clsClient Find(string AccountNumber, string PinCode)
        {
            clsClient user = Find(AccountNumber);

            if (user != null && user.PinCode == PinCode)
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

        public void Deposit(double Amount)
        {
            clsClientActionLogger.AddAction(_ClientID, Amount, enClientActions.Deposit);
            P_Deposit(Amount);
        }

        public bool IsWithdrawPossible(double Amount)
        {
            return Balance - Amount >= 0;
        }

        public bool Withdraw(double Amount)
        {
            bool WithdrawState = P_Withdraw(Amount);

            if (WithdrawState)
                clsClientActionLogger.AddAction(_ClientID, Amount, enClientActions.Withdraw);

            return WithdrawState;
        }

        public bool TransferTo(int ClientID, double Amount)
        {
            if (IsWithdrawPossible(Amount))
            {
                clsClient Recipient = Find(ClientID);

                if (Recipient == null)
                {
                    return false;
                }

                Recipient.P_Deposit(Amount);
                this.P_Withdraw(Amount);
                clsTransferLogger.AddAction(this.ID, Recipient.ID, Amount, this.Balance, Recipient.Balance, AppGlobals.SysUser.ID);
                return true;
            }

            return false;
        }

        public static DataTable GetAllClients()
        {
            return clsClientsDA.GetAllClients();
        }

        public static DataTable Search(string FullNameFilter)
        {
            return clsClientsDA.GetAllClients(FullNameFilter);
        }
    }
}
