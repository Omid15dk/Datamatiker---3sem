using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace CarsAPI.Model
{
    public class Car
    {
        //Car properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }
        public string? Color { get; set; }

        //Database Access property
        public static readonly string _connectionString;

        //Database operations
        public Boolean Create(Car carToInsert)
        {
            Boolean isCreated = false;
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            string insertQuery = "INSERT INTO Cars (Name, Model, Year, Color) VALUES (@Name, @Model, @Year, @Color)";
            using var command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@Name", carToInsert.Name);
            command.Parameters.AddWithValue("@Model", carToInsert.Model);
            command.Parameters.AddWithValue("@Year", carToInsert.Year);
            command.Parameters.AddWithValue("@Color", carToInsert.Color);
            command.ExecuteNonQuery();
            isCreated = true;
            return isCreated;
        }

        [Obsolete]
        public Car Get(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                var car = new Car();
                string selectQuery = "SELECT Id, Name, Model, Year, Color FROM Cars WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            car.Id = reader.GetInt32(0);
                            car.Name = reader.GetString(1);
                            car.Model = reader.GetString(2);
                            car.Year = reader.GetString(3);
                            car.Color = reader.GetString(4);
                        }
                    }
                }
                return car;
            }
        }

        [Obsolete]
        public List<Car> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            string selectQuery = "SELECT Id, Name, Model, Year, Color FROM Cars";
            using var command = new SqlCommand(selectQuery, connection);
            using var reader = command.ExecuteReader();
            List<Car> cars = new List<Car>();
            while (reader.Read())
            {
                Car car = new Car
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Model = reader.GetString(2),
                    Year = reader.GetString(3),
                    Color = reader.GetString(4)
                };
                cars.Add(car);
            }
            return cars;
        }

        public void Update(Car carToUpdate)
        {

        }

        public void Delete(int id)
        {

        }

        public List<Car> GetByFilter(string? name = null, string? model = null, string? year = null, string? color = null)
        {
            var cars = new List<Car>();
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = @"
            SELECT Id, Name, Model, Year, Color FROM Cars
            WHERE (@Name IS NULL OR Name LIKE @Name)
            AND (@Model IS NULL OR Model LIKE @Model)
            AND (@Year IS NULL OR Year LIKE @Year)
            AND (@Color IS NULL OR Color LIKE @Color)";
            using var command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", name != null ? $"%{name}%" : DBNull.Value);
            command.Parameters.AddWithValue("@Model", model != null ? $"%{model}%" : DBNull.Value);
            command.Parameters.AddWithValue("@Year", year != null ? $"%{year}%" : DBNull.Value);
            command.Parameters.AddWithValue("@Color", color != null ? $"%{color}%" : DBNull.Value);

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                cars.Add(new Car
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Model = reader.GetString(2),
                    Year = reader.GetString(3),
                    Color = reader.GetString(4)
                });
            }
            return cars;
        }

        //Car constructors
        static Car()
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(AppContext.BaseDirectory)
                        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuration = builder.Build();
            _connectionString = configuration.GetConnectionString("MyConnection");
            Console.WriteLine("Connection String: " + _connectionString);
        }

        public override string ToString()
        {
            return $"Car(Id={Id}, Name={Name}, Model={Model}, Year={Year}, Color={Color})";
        }
    }
}
