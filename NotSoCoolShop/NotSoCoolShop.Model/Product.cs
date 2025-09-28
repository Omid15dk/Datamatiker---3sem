
namespace NotSoCoolShop.Model {

    public class Product {

        public Product() { }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public List<OrderLine> OrderLines { get; set; }

        public Product(string title, decimal price) {
            Title = title;
            Price = price;
        }

        public Product(int id, string title, decimal price) : this(title, price) {
            Id = id;
        }

        public override string ToString() {
            return $"{Id} {Title} ({Price})";
        }

    }

}
