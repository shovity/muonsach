using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Data
    {
        private SqlConnection getSqlConnection ()
        {
            return new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = muonsach; Integrated Security = True");
        }

        public DataTable getDataTable (string command)
        {
            SqlConnection connection = getSqlConnection();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }

        public void executeNonQuery (string command)
        {
            SqlConnection connection = getSqlConnection();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(command, connection);

            sqlCommand.ExecuteNonQuery();
            sqlCommand.Dispose();
            connection.Close();
        }
    }
}
