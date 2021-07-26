using System.Collections.Generic;


namespace NixTask.Models
{
    public class CourierBase
    {
        public static int MaxID = 0;
        public static List<Courier> Couriers = new List<Courier>();
    }
    public class Courier : Abstracts.User
    {
        private List<int> _idOrders { get; set; }
        public Courier(string login, string password, string name, string phone)
        {
            Login = login;
            Password = password;
            Name = name;
            Phone = phone;
            _idOrders = new List<int>();
            CourierBase.Couriers.Add(this);
            ID = CourierBase.MaxID++;
        }
        public void AddComplateOrder(int ID)
        {
            _idOrders.Add(ID);
        }
    }
}
