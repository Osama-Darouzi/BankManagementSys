using DGS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace BankDAL
{
    public static class clsClientsDA
    {
         private static void _SetValues(SqlCommand cmd,int PersonID, string AccountNumber, string PinCode, double Balance)
        {
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            cmd.Parameters.AddWithValue("@PinCode", PinCode);
            cmd.Parameters.AddWithValue("@Balance", Balance);
        }

        private static void _GetValues(SqlDataReader reader, ref int PersonID, ref string FirstName, ref string LastName
            , ref string Email, ref string Address, ref string ImagePath, ref string AccountNumber, ref string PinCode, ref double Balance)
        {
            PersonID = (int)reader["PersonID"];
            clsPersonDA._GetValues(reader, ref FirstName, ref LastName, ref Email, ref Address, ref ImagePath);
            AccountNumber = reader["AccountNumber"].ToString();
            PinCode = reader["PinCode"].ToString();
            Balance = (double)reader["Balance"];
        }

        private static string _ConnectionString = clsGenerals_ADO.GetConnectionString("Bank");

        private static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        private static string _ExceptionLog = @"D:\Projects\Bank\clsBank_DAL\Exception_File.txt";

        private static string _TableName = "Clients";

        private static string _PK = "ClientID";

        public static int AddNewWith(int PersonID, string AccountNumber, string PinCode, double Balance)
        {
            int ClientID = -1;

            string query = $@"INSERT INTO {_TableName}
                             VALUES(@PersonID, @AccountNumber, @PinCode, @Balance)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            _SetValues(cmd, PersonID, AccountNumber, PinCode, Balance);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    ClientID = ID;
                }
            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
            }
            finally
            {
                _Connection.Close();
            }

            return ClientID;    
        }

        public static bool GetByID(int ClientID, ref int PersonID, ref string FirstName, ref string LastName
            , ref string Email, ref string Address, ref string ImagePath, ref string AccountNumber, ref string PinCode, ref double Balance)
        {
            bool IsFound = false;

            string query = $@"SELECT * FROM {_TableName} JOIN Persons on {_TableName}.PersonID = Persons.PersonID
                            WHERE {_PK} = @{_PK} AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue($"@{_PK}", ClientID);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    _GetValues(reader, ref PersonID, ref FirstName, ref LastName, ref Email, ref Address, ref ImagePath, ref AccountNumber, ref PinCode, ref Balance);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
                IsFound = false;
            }
            finally
            {
                _Connection.Close();
            }

            return IsFound;
        }

        public static bool GetByAccountNumber(string AccountNumber, ref int ClientID, ref int PersonID, ref string FirstName, ref string LastName
            , ref string Email, ref string Address, ref string ImagePath, ref string PinCode, ref double Balance)
        {
            bool IsFound = false;

            string query = $@"SELECT * FROM {_TableName} JOIN Persons on {_TableName}.PersonID = Persons.PersonID
                            WHERE AccountNumber = @AccountNumber AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ClientID = (int)reader["ClientID"];
                    _GetValues(reader, ref PersonID, ref FirstName, ref LastName, ref Email, ref Address, ref ImagePath, ref AccountNumber, ref PinCode, ref Balance);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
                IsFound = false;
            }
            finally
            {
                _Connection.Close();
            }

            return IsFound;
        }

        public static bool UpdateByID(int ClientID, string AccountNumber, string PinCode, double Balance)
        {
            bool Process = false;

            string query = $@"UPDATE {_TableName}
                             SET 
                                AccountNumber = @AccountNumber,
                             	PinCode = @PinCode,
                             	Balance = @Balance
                             WHERE {_PK} = @{_PK}";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            cmd.Parameters.AddWithValue("@PinCode", PinCode);
            cmd.Parameters.AddWithValue("@Balance", Balance);
            cmd.Parameters.AddWithValue($"@{_PK}", ClientID);


            try
            {
                _Connection.Open();
                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    Process = true;
                }
            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
                Process = false;
            }
            finally
            {
                _Connection.Close();
            }

            return Process;
        }

        public static bool UpdateBalance(int ClientID, double Balance)
        {
            bool Process = false;

            string query = $@"UPDATE {_TableName}
                             SET 
                             	Balance = @Balance
                             WHERE {_PK} = @{_PK}";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue("@Balance", Balance);
            cmd.Parameters.AddWithValue($"@{_PK}", ClientID);


            try
            {
                _Connection.Open();
                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    Process = true;
                }
            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
                Process = false;
            }
            finally
            {
                _Connection.Close();
            }

            return Process;
        }

        public static bool DeleteByID(int ClientID)
        {
            bool Process = false;

            string query = $@"UPDATE {_TableName} 
                            SET IsActive = 0
                            WHERE {_PK} = @{_PK}";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue($"@{_PK}", ClientID);


            try
            { 
                _Connection.Open();
                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    Process = true;
                }

            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
                Process = false;
            }
            finally
            {
                _Connection.Close();
            }

            return Process;
        }

        public static bool DeleteByAccountNumber(string AccountNumber)
        {
            bool Process = false;

            string query = $@"UPDATE {_TableName} 
                            SET IsActive = 0
                            WHERE AccountNumber = @AccountNumber";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue($"@AccountNumber", AccountNumber);


            try
            { 
                _Connection.Open();
                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    Process = true;
                }

            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
                Process = false;
            }
            finally
            {
                _Connection.Close();
            }

            return Process;
        }

        public static bool DoesExist(int ClientID)
        {
            bool IsFound = false;

            string query = $@"SELECT {_PK} FROM {_TableName} WHERE {_PK} = @{_PK} AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue($"@{_PK}", ClientID);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
                IsFound = false;
            }
            finally
            {
                _Connection.Close();
            }

            return IsFound;
        }

        public static bool DoesExist(string AccountNumber)
        {
            bool IsFound = false;

            string query = $@"SELECT {_PK} FROM {_TableName} WHERE AccountNumber = @AccountNumber AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
                IsFound = false;
            }
            finally
            {
                _Connection.Close();
            }

            return IsFound;
        }

        public static bool DoesExistByPersonID(int PersonID)
        {
            bool IsFound = false;

            string query = $@"SELECT {_PK} FROM {_TableName} WHERE PersonID = @PersonID AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
                IsFound = false;
            }
            finally
            {
                _Connection.Close();
            }

            return IsFound;
        }

        public static DataTable GetAllClients(string FullNameFilter = "")
        {
            DataTable AllClients = new DataTable(_TableName);

            string query = $@"Select ClientID, FirstName, LastName, Email, Address, AccountNumber, PinCode, Balance 
                            from Clients join Persons on Clients.PersonID = Persons.PersonID
                            WHERE Clients.IsActive = 1  AND FirstName + ' ' + LastName Like '%' + @Filter + '%'";

            SqlCommand cmd = new SqlCommand(query, _Connection);
            cmd.Parameters.AddWithValue("@Filter", FullNameFilter);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    AllClients.Load(reader);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
            }
            finally
            {
                _Connection.Close();
            }

            return AllClients;
        }

        public static int GetClientPersonID(int ClientID)
        {
            int PersonID = -1;

            string query = $@"SELECT PersonID FROM {_TableName} WHERE {_PK} = @{_PK} AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue($"@{_PK}", ClientID);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    PersonID = ID;
                }

            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
               
            }
            finally
            {
                _Connection.Close();
            }

            return PersonID;
        }

        public static int GetClientPersonID(string AccountNumber)
        {
            int PersonID = -1;

            string query = $@"SELECT PersonID FROM {_TableName} WHERE AccountNumber = @AccountNumber AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    PersonID = ID;
                }

            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
               
            }
            finally
            {
                _Connection.Close();
            }

            return PersonID;
        }

        public static double GetTotalBalances()
        {
            double TotalBalances = 0;

            string query = $@"SELECT SUM(Balance) FROM Clients WHERE IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);


            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && double.TryParse(result.ToString(), out double TB))
                {
                    TotalBalances = TB;
                }

            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
               
            }
            finally
            {
                _Connection.Close();
            }

            return TotalBalances;
        }
    }
}
