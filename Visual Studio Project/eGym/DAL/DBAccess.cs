using System;
using System.Data.SqlClient;
using System.Data;
<<<<<<< HEAD
using System.Configuration;
using System.Collections.Generic;
<<<<<<< HEAD

=======
>>>>>>> f298301f047dbb801d5472be36ab01a33de25ebe
=======
using System.Collections.Generic;
using System.Configuration;
>>>>>>> 971ef86cf09a1915fab344afbc3097230234f2f3

namespace DAL
{
    public class DBAccess
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 971ef86cf09a1915fab344afbc3097230234f2f3
=======
        public static string connString;
        public static string Route;

=======

>>>>>>> f298301f047dbb801d5472be36ab01a33de25ebe
        public static string connString;
        public static string Route;


<<<<<<< HEAD
=======
>>>>>>> 971ef86cf09a1915fab344afbc3097230234f2f3
>>>>>>> f298301f047dbb801d5472be36ab01a33de25ebe
        #region Utilities

        public DBAccess()
        {
            connString = "";
        }

        //Returns the ConnectionString from the Web.Config file
        public static string GetConnectionString()
        {
            try
            {
                var appSR = new AppSettingsReader();
<<<<<<< HEAD
<<<<<<< HEAD
                connString = ConfigurationManager.ConnectionStrings["Espacio"].ConnectionString;
=======
                connString = ConfigurationManager.ConnectionStrings["CuerposCelestes"].ConnectionString;
>>>>>>> f298301f047dbb801d5472be36ab01a33de25ebe
=======
                connString = ConfigurationManager.ConnectionStrings["Medicamentos"].ConnectionString;
>>>>>>> 971ef86cf09a1915fab344afbc3097230234f2f3
                return connString;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Returns the SQLConnection
        public static SqlConnection GetConnection()
        {
            try
            {
                if (connString == "" || connString == null)
                {
                    connString = GetConnectionString();
                }
                return new SqlConnection(connString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Returns an initialized SqlCommand
        public static IDbCommand GetCommand()
        {
            return new SqlCommand();
        }

        #endregion


        #region SQL Methods

        //Executes SQL code that doesn't return anything.
        public static void ExecuteNonQuery(string pSQL)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(pSQL, GetConnection());
                cmd.Connection.Open();
                cmd.CommandTimeout = 0;
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Executes SQL code that returns an IDataReader implemented class
        public static IDataReader ExecuteQuery(string pSQL, bool dif)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(pSQL, GetConnection());
                cmd.Connection.Open();
                cmd.CommandTimeout = 0;

                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //Executes SQL code that returns a DataSet
        public static DataSet ExecuteQuery(SqlCommand pCmd)
        {
            try
            {
                SqlDataAdapter adp;
                DataSet tempDataset = new DataSet();

                pCmd.Connection = GetConnection();
                pCmd.CommandTimeout = 0;

                adp = new SqlDataAdapter(pCmd);
                adp.Fill(tempDataset);

                pCmd.Connection.Close();

                return tempDataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Executes the SP but does'nt return anything
        public static void ExecuteSP(SqlCommand pCmd, string pName)
        {
            try
            {
                pCmd.Connection = GetConnection();
                pCmd.CommandText = pName;
                pCmd.CommandType = CommandType.StoredProcedure;
                pCmd.Connection.Open();
                pCmd.ExecuteReader();
                pCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Executes the SP but does'nt return anything
        public static void ExecuteSPNonQuery(SqlCommand pCmd, string pName)
        {
            try
            {
                pCmd.Connection = GetConnection();
                pCmd.CommandText = pName;
                pCmd.CommandType = CommandType.StoredProcedure;
                pCmd.Connection.Open();
                pCmd.ExecuteNonQuery();
                pCmd.Connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Executes the SP and returns a filled dataset
        public static DataSet ExecuteSPWithDS(ref SqlCommand pCmd, string pName)
        {
            try
            {
                SqlDataAdapter adp;
                DataSet tempDataset = new DataSet();

                pCmd.Connection = GetConnection();
                pCmd.CommandText = pName;
                pCmd.CommandType = CommandType.StoredProcedure;
                pCmd.CommandTimeout = 0;

                adp = new SqlDataAdapter(pCmd);
                adp.Fill(tempDataset);

                pCmd.Connection.Close();

                return tempDataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
<<<<<<< HEAD

<<<<<<< HEAD




        #endregion

    }
}
=======
        #endregion
    }
}
>>>>>>> 971ef86cf09a1915fab344afbc3097230234f2f3
=======
=======
>>>>>>> 971ef86cf09a1915fab344afbc3097230234f2f3
        #endregion
    }
}
>>>>>>> f298301f047dbb801d5472be36ab01a33de25ebe
