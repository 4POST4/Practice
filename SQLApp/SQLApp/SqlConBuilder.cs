using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public static class SqlConBuilder
    {
        public static SqlConnectionStringBuilder ConnectionStringBuilder;
        public static SqlConnection Connection;
        public static SqlCommand Command;
        public static SqlDataAdapter SqlAdapter;
        public static SqlDataReader Reader;
        public static Boolean ConnectionTest()
        {


            Connection.ConnectionString = ConnectionStringBuilder.ConnectionString;
            try
            {
                Connection.Open();
                return true;
            }
            catch (Exception ex) // 
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }


        }
        static SqlConBuilder()
        {
            Connection = new SqlConnection();
            ConnectionStringBuilder = new SqlConnectionStringBuilder();
            ConnectionStringBuilder.DataSource = "tsoop.c6oo9thiejqr.us-east-1.rds.amazonaws.com";
            ConnectionStringBuilder.InitialCatalog = "TSOOPEX";

            Command = new SqlCommand("", Connection);
        }
            public static Boolean Read(ref DataGridView data)
        {
            try
            {
                Connection.Open();
                Reader = Command.ExecuteReader();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                Connection.Close();
            }
        }

    }
}
