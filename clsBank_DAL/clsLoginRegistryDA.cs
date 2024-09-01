using DGS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankDAL
{
    public static class clsLoginRegistryDA
    {
        private static void _SetValues(SqlCommand cmd,int UserID, string Username, int Permissions)
        {
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Permissions", Permissions);
        }

        private static void _GetValues(SqlDataReader reader, ref int UserID, ref string Username, ref int Permissions, ref DateTime LoginDate)
        {
            UserID = (int)reader["UserID"];
            Username = reader["Username"].ToString();
            LoginDate = (DateTime)reader["LoginDate"];
            Permissions = (int)reader["Permissions"];
        }

        private static string _ConnectionString = clsGenerals_ADO.GetConnectionString("Bank");

        private static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        private static string _ExceptionLog = @"D:\Projects\clsBank_DAL\Exception_File.txt";

        private static string _TableName = "LoginRegistry";

        private static string _PK = "LoginID";

        public static int AddNewWith(int UserID, string Username, int Permissions)
        {
            int LoginID = -1;

            string query = $@"INSERT INTO {_TableName}(UserID, Username, Permissions)
                             VALUES(@UserID, @Username, @Permissions)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            _SetValues(cmd, UserID, Username, Permissions);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    LoginID = ID;
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

            return LoginID;    
        }

        public static bool GetByID(int UserID, ref int LoginID, ref string Username, ref int Permissions, ref DateTime LoginDate)
        {
            bool IsFound = false;

            string query = $@"SELECT * FROM {_TableName} JOIN Users on {_TableName}.UserID = Users.UserID
                            WHERE Users.UserID = @UserID AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue($"@UserID", UserID);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LoginID = (int)reader["LoginID"];
                    _GetValues(reader, ref UserID, ref Username, ref Permissions, ref LoginDate);
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

        public static bool GetByUsername(string Username, ref int LoginID, ref int UserID, ref int Permissions, ref DateTime LoginDate)
        {
            bool IsFound = false;

            string query = $@"SELECT * FROM {_TableName} JOIN Persons on {_TableName}.UserID = Persons.UserID
                                WHERE Username = @Username AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@Username", Username);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    LoginID = (int)reader["LoginID"];
                    _GetValues(reader, ref UserID, ref Username, ref Permissions, ref LoginDate);
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

        public static bool DeleteByID(int LoginID)
        {
            bool Process = false;

            string query = $@"Delete from {_TableName} Where {_PK} = @{_PK}";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue($"@{_PK}", LoginID);


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

        public static bool DoesLoginExist(string Username)
        {
            bool IsFound = false;

            string query = $@"SELECT {_PK} FROM {_TableName} WHERE Username = @Username";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@Username", Username);

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

        public static DataTable GetAllLogins(string UsernameFilter = "")
        {
            DataTable AllUsers = new DataTable(_TableName);

            string query = $@"Select * from {_TableName} 
                            WHERE Username Like '%' + @Filter + '%'";

            SqlCommand cmd = new SqlCommand(query, _Connection);
            cmd.Parameters.AddWithValue("@Filter", UsernameFilter);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
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

    }
}
