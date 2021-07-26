using System;
using System.Collections.Generic;
using NixTask.Interfaces;

namespace NixTask.Models
{
    public class OrderBase : IMain
    {
        public static int MaxID = 0;
        public static List<Order> Orders = new List<Order>();
        public void Delete(int ID)
        {
            foreach (Order order in OrderBase.Orders)
                if (order.ID == ID)
                    OrderBase.Orders.Remove(order);
        }
        public void Complete(int ID)
        {
            foreach (Order order in OrderBase.Orders)
                if (order.ID == ID)
                    order.Status = true;
        }
    }
    public class Order
    {
        public int ID { get; set; }
        private DateTime? _creatorDate;
        public List<(Product product, int Count)> Position { get; set; }
        public string Comments { get; set; }
        private Client _client;
        public bool Status = false;
        public DateTime? CreatorDate 
        {
            get { return _creatorDate; }
            set
            {
                if (_creatorDate == null)
                    _creatorDate = value;
            }
        }
        public Client Client
        {
            get { return _client; }
            set
            {
                if (_client == null)
                    _client = value;
            }
        }
        public Order(Client client, List<(Product product, int Count)> position, string comments)
        {
            Client = client;
            Position = position;
            Comments = comments;
            CreatorDate = DateTime.Now;
            ID = OrderBase.MaxID++;
            OrderBase.Orders.Add(this);
        }
    }
}
