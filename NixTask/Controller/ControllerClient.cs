using NixTask.Models;
using System;

namespace NixTask.Controller
{
    public class ControllerClient : Interfaces.IUser, Interfaces.IMain
    {
        public void Delete(int ID)
        {
            foreach (Client client in ClientBase.Clients)
                if (client.ID == ID)
                    ClientBase.Clients.Remove(client);
        }
        public bool Login(string login, string password)
        {
            bool check = false;
            foreach (Client client in ClientBase.Clients)
                if ((client.Login == login) && (client.Password == password))
                    check = true;
            return check;
        }
        public void Registration(string login, string password, string name, string phone,
                                                            string district, string address)
        {
            Client client = new Client(login, password, name, phone, district, address);
            client.ID = ClientBase.MaxID++;
            client.DateRegistration = DateTime.Now;
            ClientBase.Clients.Add(client);
        }
        public void Edit(Client newClient)
        {
            for (int i = 0; i < ClientBase.Clients.Count; i++)
                if (ClientBase.Clients[i].ID == newClient.ID)
                    ClientBase.Clients[i] = newClient;
        }
    }
}
