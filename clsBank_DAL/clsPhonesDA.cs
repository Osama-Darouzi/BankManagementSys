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
    public static class clsPhonesDA
    {
        private static void SetValues(SqlCommand cmd,int PersonID, string Phone)
        {
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
        }

        private static string _ConnectionString = clsGenerals_ADO.GetConnectionString("Bank");

        private static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        private static string _ExceptionLog = @"D:\Projects\Bank\clsBank_DAL\Exception_File.txt";

        private static string _TableName = "Phones";

        public static int AddNewWith(int PersonID, string Phone)
        {
            int PhoneID = -1;

            string query = @"INSERT INTO Phones
                             VALUES(@PersonID, @Phone)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            SetValues(cmd, PersonID, Phone);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    PhoneID = ID;
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

            return PhoneID;    
        }

        public static bool UpdateByID(int PhoneID, int PersonID, string Phone)
        {
            bool Process = false;

            string query = @"UPDATE Phones
                             SET PersonID = @PersonID,
                             Phone = @Phone
                             WHERE PhoneID = @PhoneID";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            SetValues(cmd, PersonID, Phone);
            cmd.Parameters.AddWithValue("@PhoneID", PhoneID);


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

        public static bool DeleteByID(int PhoneID)
        {
            bool Process = false;

            string query = @"DELETE FROM Phones WHERE PhoneID = @PhoneID";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue("@PhoneID", PhoneID);


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

        public static bool DoesExist(int PhoneID)
        {
            bool IsFound = false;

            string query = @"SELECT PhoneID FROM Phones WHERE PhoneID = @PhoneID";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@PhoneID", PhoneID);

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

        public static DataTable GetAllPhonesWith(int PersonID)
        {
            bool IsFound = false;
            DataTable PersonPhones = new DataTable("PersonsPhones");

            string query = @"SELECT * FROM Phones WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PersonPhones.Load(reader);
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

            return PersonPhones;
        }
    }
}
