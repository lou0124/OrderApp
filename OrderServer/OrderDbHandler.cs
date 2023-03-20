using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace OrderServer
{
    internal class OrderDbHandler
    {
        private static OrderDbHandler staticSingleton;
        private SqlConnection connection;

        public static OrderDbHandler Instance()
        {
            if (staticSingleton == null)
            {
                staticSingleton = new OrderDbHandler();
            }
            return staticSingleton;
        }
        private OrderDbHandler()
        {
            connection = new SqlConnection("server=.\\SQLEXPRESS;database=Order;uid=sa;pwd=12345");
            connection.Open();
        }
        public List<String[]> ReadTable(string table)
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
        public void excuteSql(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public bool checkRecord(string select)
        {
            SqlCommand command = new SqlCommand(select, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool result = reader.HasRows;
            reader.Close();
            command.Dispose();
            return result;
        }

        public DataSet getData(string table)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + table, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }

        public void connectionDispose()
        {
            connection.Dispose();
        }
    }
}
