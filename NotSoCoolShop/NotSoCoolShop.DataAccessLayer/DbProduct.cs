using System.Data.SqlClient;
using NotSoCoolShop.DataAccessLayer.Interfaces;
using NotSoCoolShop.Model;
using System.Configuration;

namespace NotSoCoolShop.DataAccessLayer {

    public class DbProduct : ICRUD<Product> {

        private readonly string _connectionString;

        public DbProduct() {
            _connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        }

        public void Create(Product prodToInsert) {
            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmdInsertProd = connection.CreateCommand()) {
                    cmdInsertProd.CommandText = "INSERT INTO Product(Title, Price) VALUES(@title, @price)";
                    cmdInsertProd.Parameters.AddWithValue("title", prodToInsert.Title);
                    cmdInsertProd.Parameters.AddWithValue("price", prodToInsert.Price);
                    cmdInsertProd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public Product Get(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll() {
            List<Product> products = new List<Product>();
            Product tempP;

            using (SqlConnection connection = new SqlConnection(_connectionString)) {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand()) {
                    cmd.CommandText = "SELECT id, title, price from Product";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        tempP = new Product();
                        tempP.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        tempP.Title = "NoName";
                        if (!reader.IsDBNull(reader.GetOrdinal("Title"))) {
                            tempP.Title = reader.GetString(reader.GetOrdinal("Title"));
                        }
                        tempP.Price = reader.GetDecimal(reader.GetOrdinal("Price"));
                        products.Add(tempP);
                    }
                }
            }
            return products;
        }

        public void Update(Product entity) {
            throw new NotImplementedException();
        }
    }
}
