using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrderServer
{
    internal static class OrderDbHandler
    {
        static SqlConnection connection;
        static OrderDbHandler()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS;database=Order;uid=sa;pwd=12345");
            connection.Open();
        }
        public static List<String[]> ReadTable(string table)
        {
            List<String[]> orders = new List<String[]>();
            SqlCommand command = new SqlCommand("SELECT * FROM " + table, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                List<string> list = new List<string>();
                for (int i = 0; i < reader.FieldCount; i++)
                    list.Add(reader[i].ToString());
                orders.Add(list.ToArray());
            }
            reader.Close();
            command.Dispose();
            return orders;
        }
        public static void excuteSql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public static bool checkRecord(string select)
        {
            SqlCommand command = new SqlCommand(select, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool result = reader.HasRows;
            reader.Close();
            command.Dispose();
            return result;
        }

        public static void connectionDispose()
        {
            connection.Dispose();
        }
    }
}
