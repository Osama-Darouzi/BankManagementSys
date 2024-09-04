using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using DGS;

namespace BankDAL
{
    public static class clsPersonDA
    {
        internal static void _SetValues(SqlCommand cmd, string FirstName, string LastName,byte SexID, string Email, string Address, string ImagePath)
        {
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@SexID", SexID);
            cmd.Parameters.AddWithValue("@Email", Email);
            clsGenerals_ADO.SetNullableValueIfDefault(cmd, "@Address", Address);
            clsGenerals_ADO.SetNullableValueIfDefault(cmd, "@ImagePath", ImagePath);
        }

        internal static void _GetValues(SqlDataReader reader, ref string FirstName, ref string LastName,ref byte SexID, ref string Email,ref string Address, ref string ImagePath)
        {
            FirstName = reader["FirstName"].ToString();
            LastName = reader["LastName"].ToString();
            SexID = (byte)reader["SexID"];
            Email = reader["Email"].ToString();
            Address = clsGenerals_ADO.GetNullableValue<string>(reader, "Address");
            ImagePath = clsGenerals_ADO.GetNullableValue<string>(reader, "ImagePath");
        }

        private static string _ConnectionString = clsGenerals_ADO.GetConnectionString("Bank");

        private static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        private static string _ExceptionLog = @"D:\Projects\Bank\clsBank_DAL\Exception_File.txt";

        private static string _TableName = "Persons";

        public static int AddNewWith(string FirstName, string LastName,byte SexID, string Email, string Address, string ImagePath)
        {
            int PersonID = -1;

            string query = $@"INSERT INTO {_TableName} (FirstName, LastName, SexID, Email, Address, ImagePath)
                             VALUES(@FirstName, @LastName, @SexID, @Email, @Address, @ImagePath)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            _SetValues(cmd, FirstName, LastName, SexID, Email, Address, ImagePath);

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

        public static bool GetByID(int PersonID, ref string FirstName, ref string LastName, ref byte SexID, ref string Email,ref string Address, ref string ImagePath)
        {
            bool IsFound = false;

            string query = $@"SELECT * FROM {_TableName} WHERE PersonID = @PersonID AND IsActive = 1";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    _GetValues(reader, ref FirstName, ref LastName, ref SexID, ref Email,ref Address, ref ImagePath);
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


        public static bool UpdateByID(int PersonID, string FirstName, string LastName, byte SexID, string Email, string Address, string ImagePath)
        {
            bool Process = false;

            string query = $@"UPDATE {_TableName}
                             SET FirstName = @FirstName,
                             	LastName = @LastName,
                                SexID = @SexID,
                             	Email = @Email,
                                Address = @Address,
                                ImagePath = @ImagePath
                             WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            _SetValues(cmd, FirstName, LastName, SexID, Email, Address, ImagePath);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);


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

        public static bool DeleteByID(int PersonID)
        {
            bool Process = false;

            string query = $@"UPDATE {_TableName}
                             SET IsActive = 0, ImagePath = Null
                             WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue("@PersonID", PersonID);


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

        public static bool DoesExist(int PersonID)
        {
            bool IsFound = false;

            string query = $@"SELECT PersonID FROM {_TableName} WHERE PersonID = @PersonID AND IsActive = 1";

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

        
    }
}
