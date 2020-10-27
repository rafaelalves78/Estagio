using System;
using System.Globalization;
using ExComposicaoEnumeracoes2.Entities;
using ExComposicaoEnumeracoes2.Entities.Enums;

namespace ExComposicaoEnumeracoes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string nameClient = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nameClient, email, birthDate);

            Console.WriteLine();

            Console.WriteLine("Enter order data:");
            Console.WriteLine();

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine();

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);

                OrderItem item = new OrderItem(quantity, product);

                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine(order);
            Console.WriteLine();
        }
    }
}
