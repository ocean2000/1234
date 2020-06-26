using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.DAL
{
    public class DBConnect
    {
        private static DBConnect instance;
        public static DBConnect Instance
        {
            get { if (instance == null) instance = new DBConnect(); return DBConnect.instance; }
            private set => instance = value;
        }
        private DBConnect() { }
        private string connectionSTR = @"Data Source=.\DUONGIT ;Initial Catalog=QLBH;Integrated Security=True";
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                return data;
            }
        }
        public int ExecuteNonQuery(string query)
        {

            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                data = command.ExecuteNonQuery();

                return data;
            }
        }
    }
}
