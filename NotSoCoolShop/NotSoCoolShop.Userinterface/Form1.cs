using NotSoCoolShop.BusinessLogic;
using NotSoCoolShop.Model;

namespace NotSoCoolShop.Userinterface {
    public partial class Form1 : Form {

        private ProductController _productController;

        public Form1() {
            InitializeComponent();

            _productController = new ProductController();
        }

        private void ButtonInsert_Click(object sender, EventArgs e) {

            string inTitle = this.textBoxTitle.Text;
            string inPrice = this.textBoxPrice.Text;

            if (!String.IsNullOrEmpty(inTitle) && !String.IsNullOrEmpty(inPrice)) {
                string title = inTitle.Trim();
                if (Decimal.TryParse(inPrice, out decimal price)) {
                    Product newProduct = new Product(title, price);
                    _productController.Create(newProduct);
                    UpdateListBoxProducts();
                }
            }
        }

        private void ButtonGetAll_Click(object sender, EventArgs e) {
            UpdateListBoxProducts();
        }

        private void ListBoxProducts_SelectedIndexChanged(object sender, EventArgs e) {
            var selProd = listBoxProducts.SelectedItem.ToString();
            MessageBox.Show(selProd);
        }

        private void UpdateListBoxProducts() {
            var allProducts = _productController.GetAll();
            // MessageBox.Show("" + allProducts.Count());
            listBoxProducts.Items.Clear();
            foreach (Product prod in allProducts) {
                listBoxProducts.Items.Add(prod);
            }
        }


    }
}
