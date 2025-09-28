
namespace NotSoCoolShop.Model {

    public class OrderLine {

        public OrderLine(Product product, int quantity) {
            Product = product;
            Quantity = quantity;
        }

        public OrderLine(Product product, int quantity, Order order) : this(product, quantity) {
            Order = order;
        }

        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }

    }
}
