using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public class ConnectDB
    {

        //public ConnectDBs()
        //{
        //    //
        //    // TODO: Add constructor logic here
        //}
        private string strConnection()
        {
            string conDatabase = @"Data Source = VCS-IT-CHARINTH; Initial Catalog = Inventory; Persist Security Info = True; User ID = sa; Password = 1234";
            return conDatabase;
        }
        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection(strConnection());
            return conn;
        }
    }
    public class Cls_DB {
        public Cls_DB()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public object GetScalar(string sql)
        {
            //ดึงค่าล่าสุดของ OrderNo
            SqlConnection conn = new ConnectDB().connection();
            conn.Open();

            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                object result = command.ExecuteScalar();
                conn.Close();
                return result;
            }
        }
        public DataTable GetData(string sql, string tblName)
        {
            SqlConnection conn = new ConnectDB().connection();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, tblName);
            return ds.Tables[0];

        }

        public DataTable GetData(string sql, string tblName, SqlParameterCollection parameters)
        {
            SqlConnection conn = new ConnectDB().connection();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            foreach (SqlParameter param in parameters)
            {
                da.SelectCommand.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
            }
            da.Fill(ds, tblName);
            return ds.Tables[0];
        }

        public int ExecuteData(string sql)
        {
            int i;
            SqlConnection conn = new ConnectDB().connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public int ExecuteData(string sql, SqlParameterCollection parameters)
        {
            int i;
            SqlConnection conn = new ConnectDB().connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
            }
            conn.Open();
            i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }

        public DataSet ExcStorePro(string stpName, string tblName, SqlParameterCollection parameters)
        {
            SqlConnection conn = new ConnectDB().connection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stpName;
            foreach (SqlParameter param in parameters)
            {
                cmd.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, tblName);
            return ds;


        }

        internal DataTable GetData()
        {
            throw new NotImplementedException();
        }
    }
}
