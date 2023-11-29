

using Microsoft.Data.SqlClient;
using System.Data;


namespace ShopBanLaptop2.Models
{
    public class DataProvider
    {
        public string conStr = @"Data Source=HIEUHIEN;Initial Catalog=backup_16-10-2023;Integrated Security=True;Trust Server Certificate=True";
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            set { DataProvider.Instance = value; }
        }

        //===================================================================================
        public DataTable executeQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object executeScaler(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}