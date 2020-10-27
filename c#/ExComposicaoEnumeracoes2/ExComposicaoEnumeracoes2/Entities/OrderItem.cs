using System.Globalization;
using System.Text;

namespace ExComposicaoEnumeracoes2.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public double Price { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, Product product)
        {
            this.Quantity = quantity;
            this.Product = product;
            this.Price = Product.Price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Items: ");
            sb.Append(Product.Name + ", ");
            sb.Append("$" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", ");
            sb.Append("Quantity: " + Quantity + ", ");
            sb.Append("Subtotal: " + SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
