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
    public enum enUserActions
    {
        Create = 1, Update, Delete
    }

    public static class clsUserActionsHistoryDA
    {
        private static void _SetValues(SqlCommand cmd,int UserID, int AffectedPersonID, enUserActions Action)
        {
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@AffectedPersonID", AffectedPersonID);
            cmd.Parameters.AddWithValue("@Action", (byte)Action);
        }

        private static void _GetValues(SqlDataReader reader, ref int UserID, ref int AffectedPersonID, ref enUserActions Action, ref DateTime LoginDate)
        {
            UserID = (int)reader["UserID"];
            AffectedPersonID = (int)reader["AffectedPersonID"];
            Action = (enUserActions)(byte)reader["Action"];
            LoginDate = (DateTime)reader["LoginDate"];
        }

        private static string _ConnectionString = clsGenerals_ADO.GetConnectionString("Bank");

        private static SqlConnection _Connection = new SqlConnection(_ConnectionString);

        private static string _ExceptionLog = @"D:\Projects\clsBank_DAL\Exception_File.txt";

        private static string _TableName = "UsersActionsHistory";

        private static string _PK = "LogID";

        public static int AddNewWith(int UserID, int AffectedPersonID, enUserActions Action)
        {
            int LogID = -1;

            string query = $@"INSERT INTO {_TableName}(UserID, AffectedPersonID, ActionID)
                             VALUES(@UserID, @AffectedPersonID, @Action)
                             SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            _SetValues(cmd, UserID, AffectedPersonID, Action);

            try
            {
                _Connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID))
                {
                    LogID = ID;
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

            return LogID;    
        }

        //public static bool GetByID(int UserID, ref int LogID, ref int AffectedPersonID, ref enUserActions Action, ref DateTime LoginDate)
        //{
        //    bool IsFound = false;

        //    string query = $@"SELECT * FROM {_TableName} JOIN Users on {_TableName}.UserID = Users.UserID
        //                    WHERE Users.UserID = @UserID AND IsActive = 1";

        //    SqlCommand cmd = new SqlCommand(query, _Connection);

        //    cmd.Parameters.AddWithValue($"@UserID", UserID);

        //    try
        //    {
        //        _Connection.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            IsFound = true;
        //            LogID = (int)reader["LogID"];
        //            _GetValues(reader, ref UserID, ref AffectedPersonID, ref Action, ref LoginDate);
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

        //public static bool GetByAffectedID(int AffectedPersonID, ref int LogID, ref int UserID, ref enUserActions Action, ref DateTime LoginDate)
        //{
        //    bool IsFound = false;

        //    string query = $@"SELECT * FROM {_TableName} JOIN Persons on {_TableName}.UserID = Persons.UserID
        //                        WHERE AffectedPersonID = @AffectedPersonID AND IsActive = 1";

        //    SqlCommand cmd = new SqlCommand(query, _Connection);

        //    cmd.Parameters.AddWithValue("@AffectedPersonID", AffectedPersonID);

        //    try
        //    {
        //        _Connection.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            IsFound = true;
        //            LogID = (int)reader["LogID"];
        //            _GetValues(reader, ref UserID, ref AffectedPersonID, ref Action, ref LoginDate);
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

        public static bool DeleteByID(int LogID)
        {
            bool Process = false;

            string query = $@"Delete from {_TableName} Where {_PK} = @{_PK}";

            SqlCommand cmd = new SqlCommand(query, _Connection);

            
            cmd.Parameters.AddWithValue($"@{_PK}", LogID);


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

        //public static bool DoesLogExist(int AffectedPersonID)
        //{
        //    bool IsFound = false;

        //    string query = $@"SELECT {_PK} FROM {_TableName} WHERE AffectedPersonID = @AffectedPersonID";

        //    SqlCommand cmd = new SqlCommand(query, _Connection);

        //    cmd.Parameters.AddWithValue("@AffectedPersonID", AffectedPersonID);

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

            string query = $@"Select LogID, UserID, AffectedPersonID, ActionName, LogDate
                              From {_TableName} JOIN UserActions ON {_TableName}.ActionID = UserActions.ActionID";

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
