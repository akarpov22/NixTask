using System;
using System.Collections.Generic;

namespace NixTask.Models
{
    public class ClientBase
    {
        public static int MaxID = 0;
        public static List<Client> Clients = new List<Client>();
    }
    public class Client : Abstracts.User
    {
        private DateTime? _dateRegistration;
        public string District { get; set; }
        public string Address { get; set; }
        public DateTime? DateRegistration
        {
            get { return _dateRegistration; }
            set 
            {
                if (_dateRegistration == null)
                    _dateRegistration = value;
            }
        }

        public Client(string login, string password, string name, string phone, string district, string address)
        {
            Login = login;
            Password = password;
            Name = name;
            Phone = phone;
            District = district;
            Address = address;
        }
    }
}
