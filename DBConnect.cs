using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class DBConnect
    {
        private SqlConnection conn;

        public DBConnect()
        {
            conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=HosMS;Integrated Security=True;Encrypt=False");
        }

        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                OpenConnection();
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        public DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                if (parameters != null)
                {
                    da.SelectCommand.Parameters.AddRange(parameters);
                }
                DataTable dt = new DataTable();
                OpenConnection();
                da.Fill(dt);
                CloseConnection();
                return dt;
            }
        }

        public void Dispose()
        {
            CloseConnection();
            conn.Dispose();
        }
    

}


    }
    
