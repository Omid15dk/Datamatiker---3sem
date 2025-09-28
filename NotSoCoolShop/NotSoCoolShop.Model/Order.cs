
namespace NotSoCoolShop.Model {

    public class Order {

        public Order() {
            OrderLines = new List<OrderLine>();
        }

        public int Id { get; set; }
        public decimal Totalprice { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public Customer Customer { get; set; }


    }

}
