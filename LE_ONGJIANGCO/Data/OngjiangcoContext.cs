using MySql.Data.MySqlClient;
using System.Data;

namespace LE_ONGJIANGCO.Data
{

    public class OngjiangcoContext
    {
        private readonly string _connString;

        public OngjiangcoContext(string connString)
        {
            _connString = connString;
        }

        public DataTable SelectQuery(string query, MySqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(_connString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public int ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection connection = new MySqlConnection(_connString))
            {
                connection.Open();
                
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
