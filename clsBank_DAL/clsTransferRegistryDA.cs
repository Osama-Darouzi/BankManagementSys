using DGS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlTypes;

namespace BankDAL
{
    public static class clsTransferRegistryDA
    {
        private static void _SetValues(SqlCommand cmd,int SenderID, int RecipientID, double TransferAmount,
            double SenderBalance, double RecipientBalance, int UserID)
        {
            cmd.Parameters.AddWithValue("@SenderID", SenderID);
            cmd.Parameters.AddWithValue("@RecipientID", RecipientID);
            cmd.Parameters.AddWithValue("@TransferAmount", TransferAmount);
            cmd.Parameters.AddWithValue("@SenderBalance", SenderBalance);
            cmd.Parameters.AddWithValue("@RecipientBalance", RecipientBalance);
            cmd.Parameters.AddWithValue("@UserID", UserID);
        }

        private static void _GetValues(SqlDataReader reader, ref int SenderID, ref int RecipientID, ref double TransferAmount, ref DateTime LoginDate)
        {
            SenderID = (int)reader["SenderID"];
            RecipientID = (int)reader["RecipientID"];
            TransferAmount = (double)reader["TransferAmount"];
            LoginDate = (DateTime)reader["LoginDate"];
        }

        private static string _ConnectionString = clsGenerals_ADO.GetConnectionString("Bank");

        private static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        private static string _ExceptionLog = @"D:\Projects\Bank\clsBank_DAL\Exception_File.txt";

        private static string _TableName = "TransferRegistry";

        private static string _PK = "TransferID";

        public static int AddNewWith(int SenderID, int RecipientID, double TransferAmount,
            double SenderBalance, double RecipientBalance, int UserID)
        {
            int TransferID = -1;

            string query = $@"INSERT INTO {_TableName}(SenderID, RecipientID, TransferAmount, SenderBalance, RecipientBalance, UserID)
                             VALUES(@SenderID, @RecipientID, @TransferAmount, @SenderBalance, @RecipientBalance, @UserID)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            _SetValues(cmd, SenderID, RecipientID, TransferAmount, SenderBalance, RecipientBalance, UserID);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    TransferID = ID;
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

            return TransferID;    
        }

        //public static bool GetByID(int SenderID, ref int TransferID, ref int RecipientID, ref double TransferAmount, ref DateTime LoginDate)
        //{
        //    bool IsFound = false;

        //    string query = $@"SELECT * FROM {_TableName} JOIN Users on {_TableName}.SenderID = Users.SenderID
        //                    WHERE Users.SenderID = @SenderID AND IsActive = 1";

        //    SqlCommand cmd = new SqlCommand(query, _Connection);

        //    cmd.Parameters.AddWithValue($"@SenderID", SenderID);

        //    try
        //    {
        //        _Connection.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            IsFound = true;
        //            TransferID = (int)reader["TransferID"];
        //            _GetValues(reader, ref SenderID, ref RecipientID, ref TransferAmount, ref LoginDate);
        //        }

        //        reader.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
        //        IsFound = false;
        //    }
        //    finally
        //    {
        //        _Connection.Close();
        //    }

        //    return IsFound;
        //}

        //public static bool GetByAffectedID(int RecipientID, ref int TransferID, ref int SenderID, ref double TransferAmount, ref DateTime LoginDate)
        //{
        //    bool IsFound = false;

        //    string query = $@"SELECT * FROM {_TableName} JOIN Persons on {_TableName}.SenderID = Persons.SenderID
        //                        WHERE RecipientID = @RecipientID AND IsActive = 1";

        //    SqlCommand cmd = new SqlCommand(query, _Connection);

        //    cmd.Parameters.AddWithValue("@RecipientID", RecipientID);

        //    try
        //    {
        //        _Connection.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            IsFound = true;
        //            TransferID = (int)reader["TransferID"];
        //            _GetValues(reader, ref SenderID, ref RecipientID, ref TransferAmount, ref LoginDate);
        //        }

        //        reader.Close();
        //    }
        //    catch (Exception e)
        //    {
        //        File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
        //        IsFound = false;
        //    }
        //    finally
        //    {
        //        _Connection.Close();
        //    }

        //    return IsFound;
        //}

        public static bool DeleteByID(int TransferID)
        {
            bool Process = false;

            string query = $@"Delete from {_TableName} Where {_PK} = @{_PK}";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue($"@{_PK}", TransferID);


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

        //public static bool DoesLogExist(int RecipientID)
        //{
        //    bool IsFound = false;

        //    string query = $@"SELECT {_PK} FROM {_TableName} WHERE RecipientID = @RecipientID";

        //    SqlCommand cmd = new SqlCommand(query, _Connection);

        //    cmd.Parameters.AddWithValue("@RecipientID", RecipientID);

        //    try
        //    {
        //        _Connection.Open();
        //        object result = cmd.ExecuteScalar();

        //        if (result != null)
        //        {
        //            IsFound = true;
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        File.AppendAllText(_ExceptionLog,@"//" + _TableName + @"//" + e.Message + "\n" + DateTime.Now.ToString() + "\n");
        //        IsFound = false;
        //    }
        //    finally
        //    {
        //        _Connection.Close();
        //    }

        //    return IsFound;
        //}

        public static DataTable GetAll()
        {
            DataTable History = new DataTable(_TableName);

            string query = $@"Select * From {_TableName}";

            SqlCommand cmd = new SqlCommand(query, _Connection);
            

            try
            {
                _Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    History.Load(reader);
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

            return History;
        }
    }
}
