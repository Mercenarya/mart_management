using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Groccery_Application
{
    
    class MainConnection
    {
        SqlConnection conn;
        public void open_connection()
        {
            string conn_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Groccery_Application\Groccery_Application\grocery.mdf;Integrated Security=True";
            conn = new SqlConnection(conn_string);
            conn.Open();
            
        }
        public int crud_inquery(string sql)
        {
            open_connection();
            SqlCommand qry = new SqlCommand(sql, conn);
            int kq = qry.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public bool login(string sql)
        {
            open_connection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            bool rows = rd.HasRows;
            rd.Close();
            return rows;
        }
        public DataTable getTBdata(string sql)
        {
            
            DataTable dt = new DataTable();
            open_connection();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
    }
}

