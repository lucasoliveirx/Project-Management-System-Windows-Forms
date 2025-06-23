using System.Data;
using System.Data.SqlClient;

namespace ControleProjetos.Data
{
    public class DataContext
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB; Database=ControleDeProjetos; TrustServerCertificate=True;";

        SqlConnection _context { get; }

        public DataContext()
        {
            _context = new SqlConnection(connectionString);
        }

        // Open Connection if Closed
        public SqlConnection OpenConnectionIfClosed()
        {
            if (_context.State != ConnectionState.Open)
            {
                _context.Open();
            }
            return _context;
        }


        public int ExecuteQuery(string query)
        {
            OpenConnectionIfClosed();
            SqlCommand sqlCommand = new SqlCommand(query, _context);
            return sqlCommand.ExecuteNonQuery();
        }

        public DataSet ReadQuery(string query)
        {
            OpenConnectionIfClosed();
            DataSet dataSet = new DataSet();
            return SelectRows(dataSet, connectionString, query);
        }

        // Sql Data Adapter
        private static DataSet SelectRows(DataSet dataset,
           string connectionString, string queryString)
        {
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(
                    queryString, connection);
                adapter.Fill(dataset);
                return dataset;
            }
        }
    }

}
