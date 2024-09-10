using DGS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL
{
    public static class clsRememberedUsersDA
    {
        private static void SetValues(SqlCommand cmd,int UserID, bool IsActive)
        {
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@UserID", UserID);
        }

        private static string _ConnectionString = clsGenerals_ADO.GetConnectionString("Bank");

        private static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        private static string _ExceptionLog = @"D:\Projects\Bank\clsBank_DAL\Exception_File.txt";

        private static string _TableName = "RememberedUsers";

        public static bool AddNewWith(int UserID)
        {
            bool AddingProcess = false;
            string query = $@"INSERT INTO {_TableName}(UserID)
                             VALUES(@UserID)";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                _Connection.Open();
                int AffectedRows = cmd.ExecuteNonQuery();

                if (AffectedRows > 0)
                {
                    AddingProcess = true;
                }
            }
            catch (Exception e)
            {
                File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n\n");
            }
            finally
            {
                _Connection.Close();
            }

            return AddingProcess;    
        }

        public static bool UpdateByID(int UserID,bool IsActive)
        {
            bool Process = false;

            string query = $@"UPDATE {_TableName}
                             SET IsActive = @IsActive
                             WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            SetValues(cmd, UserID, IsActive);

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

        public static bool DeleteByID(int UserID)
        {
            bool Process = false;

            string query = $@"DELETE FROM {_TableName} WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue("@UserID", UserID);


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

        public static bool DoesExist(int UserID)
        {
            bool IsFound = false;

            string query = $@"SELECT UserID FROM {_TableName} WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

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

        public static DataTable GetAllRemUsers()
        {
            DataTable AllUsers = new DataTable(_TableName);

            string query = $@"Select * From {_TableName}";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    AllUsers.Load(reader);
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

            return AllUsers;
        }

        public static int GetActivatedUser()
        {
            int UserID = -1;

            string query = $@"SELECT UserID FROM {_TableName} WHERE IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    UserID = ID;
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

            return UserID;
        }

    }
}
