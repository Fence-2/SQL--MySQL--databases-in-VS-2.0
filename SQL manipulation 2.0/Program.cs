using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQL_manipulation_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "server=localhost;user=root;database=people;password=1234321;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = "INSERT INTO men (id, name, age) VALUES (4, 'Kate', 19)";
            //string query = "UPDATE men SET age = 40 WHERE id = 3";
            //string query = "DELETE FROM men WHERE id < 3";
            MySqlCommand command = new MySqlCommand(query, connection);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
