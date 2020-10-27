using System;
using System.Globalization;
using ExercicioEnumeracoesComposicao.Entities;
using ExercicioEnumeracoesComposicao.Entities.Enums;


namespace ExercicioEnumeracoesComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY::");
            Console.WriteLine(order);
            
        }
    }
}
