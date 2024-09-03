using DGS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BankDAL
{
    public static class clsUserDA
    {
        private static void _SetValues(SqlCommand cmd,int PersonID, string Username, string Password, int Permissions)
        {
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Permissions", Permissions);
        }

        private static void _GetValues(SqlDataReader reader, ref int PersonID, ref string FirstName, ref string LastName,ref byte Sex
            , ref string Email,ref string Address, ref string ImagePath, ref string Username, ref string Password, ref int Permissions)
        {
            PersonID = (int)reader["PersonID"];
            clsPersonDA._GetValues(reader, ref FirstName, ref LastName, ref Sex, ref Email, ref Address, ref ImagePath);
            Username = reader["Username"].ToString();
            Password = reader["Password"].ToString();
            Permissions = (int)reader["Permissions"];
        }

        private static string _ConnectionString = clsGenerals_ADO.GetConnectionString("Bank");

        private static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        private static string _ExceptionLog = @"D:\Projects\Bank\clsBank_DAL\Exception_File.txt";

        private static string _TableName = "Users";

        private static string _PK = "UserID";

        public static int AddNewWith(int PersonID, string Username, string Password, int Permissions)
        {
            int UserID = -1;

            string query = $@"INSERT INTO {_TableName}
                             VALUES(@PersonID, @Username, @Password, @Permissions)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            _SetValues(cmd, PersonID, Username, Password, Permissions);

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

        public static bool GetByID(int UserID, ref int PersonID, ref string FirstName, ref string LastName, byte Sex,
            ref string Email,ref string Address, ref string ImagePath, ref string Username, ref string Password, ref int Permissions)
        {
            bool IsFound = false;

            string query = $@"SELECT * FROM {_TableName} JOIN Persons on {_TableName}.PersonID = Persons.PersonID
                            WHERE {_PK} = @{_PK} AND {_TableName}.IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue($"@{_PK}", UserID);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    _GetValues(reader, ref PersonID, ref FirstName, ref LastName, ref Sex, ref Email,ref Address, ref ImagePath, ref Username, ref Password, ref Permissions);
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

        public static bool GetByUsername(string Username, ref int UserID, ref int PersonID, ref string FirstName, ref string LastName,
           ref byte Sex, ref string Email, ref string Address, ref string ImagePath, ref string Password, ref int Permissions)
        {
            bool IsFound = false;

            string query = $@"SELECT * FROM {_TableName} JOIN Persons on {_TableName}.PersonID = Persons.PersonID
                                WHERE Username = @Username AND {_TableName}.IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@Username", Username);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    UserID = (int)reader["UserID"];
                    _GetValues(reader, ref PersonID, ref FirstName, ref LastName, ref Sex, ref Email, ref Address, ref ImagePath, ref Username, ref Password, ref Permissions);
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

        public static bool UpdateByID(int UserID, string Username, string Password, int Permissions)
        {
            bool Process = false;

            string query = $@"UPDATE {_TableName}
                             SET 
                                Username = @Username,
                             	Password = @Password,
                             	Permissions = @Permissions
                             WHERE {_PK} = @{_PK}";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@Username", Username);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@Permissions", Permissions);
            cmd.Parameters.AddWithValue($"@{_PK}", UserID);


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

            string query = $@"UPDATE {_TableName} 
                            SET IsActive = 0
                            WHERE {_PK} = @{_PK}";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue($"@{_PK}", UserID);


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

        public static bool DeleteByUsername(string Username)
        {
            bool Process = false;

            string query = $@"UPDATE {_TableName} 
                            SET IsActive = 0
                            WHERE Username = @Username";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue($"@Username", Username);


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

            string query = $@"SELECT {_PK} FROM {_TableName} WHERE {_PK} = @{_PK} AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue($"@{_PK}", UserID);

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

        public static bool DoesExist(string Username)
        {
            bool IsFound = false;

            string query = $@"SELECT {_PK} FROM {_TableName} WHERE Username = @Username AND IsActive = 1";

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

        public static DataTable GetAllUsers(string FullNameFilter = "")
        {
            DataTable AllUsers = new DataTable(_TableName);

            string query = $@"Select UserID, FirstName, LastName, Email, Address, Username, Password, Permissions 
                            from Users join Persons on Users.PersonID = Persons.PersonID
                            WHERE Users.IsActive = 1  AND FirstName + ' ' + LastName Like '%' + @Filter + '%'";

            SqlCommand cmd = new SqlCommand(query, _Connection);
            cmd.Parameters.AddWithValue("@Filter", FullNameFilter);

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

        public static int GetUserPersonID(int UserID)
        {
            int PersonID = -1;

            string query = $@"SELECT PersonID FROM {_TableName} WHERE {_PK} = @{_PK} AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue($"@{_PK}", UserID);

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

        public static int GetUserPersonID(string Username)
        {
            int PersonID = -1;

            string query = $@"SELECT PersonID FROM {_TableName} WHERE Username = @Username AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@Username", Username);

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
    }
}
