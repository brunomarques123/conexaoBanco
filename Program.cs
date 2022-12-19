using System;
using Microsoft.Data.SqlClient;

namespace BaltaDataAcess
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionString = "Data Source=BRUNO;Initial Catalog=balta;Integrated Security=True";

            using (var connection = new SqlConnection(connectionString))
            {
                Console.WriteLine("Conectado");
                connection.Open();

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "Select [Id], [Title] FROM [Category]";

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetGuid(0)} - {reader.GetString(1)}");

                    }
                }

            }

        }
    }
}
