using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Pedido.Enums;

namespace Exercicio_Pedido.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        List<OrderItem> orders = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public Order()
        {
        }

        public void AddItem(OrderItem request)
        {
            orders.Add(request);
        }
        public void RemoveItem(OrderItem request)
        {
            orders.Remove(request);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in orders)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client}");
            sb.AppendLine("Order items");
            foreach (OrderItem item in orders)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total Price: {Total()}");
            return sb.ToString();
        }
    }
}
