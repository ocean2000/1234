using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.data
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectionSTR = @"Data Source=DESKTOP-KJJQBR3\DUONGIT ;Initial Catalog=QLBH;Integrated Security=True";

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                instance = value;
            }
        }
        private DataProvider() { }

        // trả về bảng kết quả sql
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            try
            {
                DataTable data = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' '); // split ' ' in query, collect "word"
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@')) // if "word" contain '@' so it's parameter of query
                            {
                                command.Parameters.AddWithValue(item, parameter[i]); // add VALUE of parameter [i] to the parameter [j] (has been Split(), add to Listpara) which is a parameter of command SQL
                                i++; // next parameter in object[] parameter
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    connection.Close();
                }

                return data;
            }
            catch
            {
                MessageBox.Show("Erro: DataProvider");
                return null;
            }
        }

        // trả về số dòng đã đc thực hiện thành công query
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            try
            {
                int data = 0;

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();

                    connection.Close();
                }

                return data;
            }
            catch
            {
                MessageBox.Show("Erro: DataProvider");
                return 0;
            }
        }

        // trả về cột đầu của dòng đầu khi thực hiện query, và kết quả là 1 object
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            try
            {
                object data = 0;

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteScalar();

                    connection.Close();
                }

                return data;
            }
            catch
            {
                MessageBox.Show("Erro: DataProvider");
                return null;
            }
        }
    }
}
