using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Pedido.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public override string ToString()
        {
            return $"{Product.Name}, ${Price.ToString("F2")}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2")}";
        }
    }
}
