using Ordering_system.Entities;
using Ordering_system.Entities.Enums;
using System;
using System.Globalization;

namespace Ordering_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");

            Console.Write("Name: ");
            string cName = Console.ReadLine();

            Console.Write("Email: ");
            string cEmail = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime cBirthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(cName, cEmail, cBirthDate);

            Console.WriteLine("Enter order data:");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int total = int.Parse(Console.ReadLine());

            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine("Enter #{0} item data:", i);

                Console.Write("Product name: ");
                string pName = Console.ReadLine();

                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());

                Produto produto = new Produto(pName, pPrice);

                OrderItem orderItem = new OrderItem(Quantity, produto.Price, produto);

                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
