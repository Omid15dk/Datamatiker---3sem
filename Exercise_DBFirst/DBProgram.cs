using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_DBFirst
{

    class DBProgram
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringToExercise_DBFirst"].ToString();

        static void Main()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO Product (Id, Name, Price, CreatedDate) VALUES (@id, @name, @price, @createdDate)";

                try
                {
                    conn.Open();
                    Console.WriteLine($"Connection state: {conn.State}");
                    {
                        using (SqlCommand cmd = new(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", 8);
                            cmd.Parameters.AddWithValue("@name", "Mylles pc");
                            cmd.Parameters.AddWithValue("@price", 11000);
                            cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);

                            int rows = cmd.ExecuteNonQuery();
                            Console.WriteLine($"{rows} rows inserted.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"General Error: {ex.Message}");
                }
            }
        }
    }
}
        
