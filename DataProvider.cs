using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace QuanLySach
{
    public class DataProvider
    {
        private static string cnnString = "Data Source=IMPEONY\\PEONY;Initial Catalog=QuanLySach;Integrated Security=True";
        public static SqlConnection conn;
        public static SqlDataAdapter adapter;
        public static SqlCommand cmd;

        public static void OpenConnect()
        {
            conn = new SqlConnection(cnnString);
            
            try
            {
                conn.Open();
            }catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                };
        }

        public static void CloseConnect()
        {
            conn.Close();
        }

        public DataTable executeQuery(string query )
        {
            DataTable data = new DataTable();
            cmd = new SqlCommand(query, conn);
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            adapter.Dispose();

            return data;
        }

        public static void UpdateData(string sql, string[] name = null, object[] value = null)
        {
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Clear();
            if (value != null)
            {
                for (int i = 0; i < value.Length; i++)
                    cmd.Parameters.AddWithValue(name[i], value[i]);
            }
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static void executeNonQuery(string sql)
        {
            cmd = new SqlCommand(sql, conn);         
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public static int executeScalar(string sql)
        {
            int i = 0;
            cmd = new SqlCommand(sql, conn);
            i = (int)cmd.ExecuteScalar();
            return i;
        }
    }
}
