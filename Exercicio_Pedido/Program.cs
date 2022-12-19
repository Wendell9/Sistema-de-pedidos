using Exercicio_Pedido.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Pedido.Enums;
using System.Data;

namespace Exercicio_Pedido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, email, product;
            int numberofitems, quantity;
            OrderStatus status;
            double price;
            DateTime birthdate, orderdata;

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            birthdate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthdate);
            Console.WriteLine("Enter order data:");
            orderdata = DateTime.Now;
            Console.Write("Status: ");
            Enum.TryParse(Console.ReadLine(), out status);
            Order order = new Order(orderdata, status, client);
            Console.Write("How many items would yu like to order? ");
            numberofitems = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberofitems; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                product = Console.ReadLine();
                Console.Write("Product price: ");
                price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                quantity = int.Parse(Console.ReadLine());
                Product objproduct = new Product(product, price);
                OrderItem orderItem = new OrderItem(quantity, price, objproduct);
                order.AddItem(orderItem);
            }
            Console.WriteLine(order);
        }
    }
}
