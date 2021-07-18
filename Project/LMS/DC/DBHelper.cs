using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;// this is to work with database
using System.Data;// to use the data set



namespace OOP.DL
{
    public class DBHelper
    {
        //By making a method as static it can be call by just using the class name (no need to create  an object)
        public static int NonQuery(string query,string connString)
        {
            try
            {
                //creating a connection to the SQL server
                SqlConnection conn = new SqlConnection(connString);
                //create the command using and create connection object
                SqlCommand comm = new SqlCommand(query, conn);
                //open the connection
                conn.Open();

                return comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
                throw ex;
        
           }
        }
        public static DataSet GetDataSet(string query, string connString)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                SqlDataAdapter dap = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();//this is to store query results
                conn.Open();
                dap.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        }

   }



