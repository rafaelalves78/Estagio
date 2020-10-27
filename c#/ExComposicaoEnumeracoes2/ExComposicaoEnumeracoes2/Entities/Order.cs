using System;
using System.Text;
using System.Collections.Generic;
using ExComposicaoEnumeracoes2.Entities.Enums;
using System.Globalization;

namespace ExComposicaoEnumeracoes2.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.Moment = moment;
            this.Status = status;
            this.Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order Moment: " + Moment);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: " + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
