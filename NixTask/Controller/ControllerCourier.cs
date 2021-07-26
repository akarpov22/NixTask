using NixTask.Models;
using System;

namespace NixTask.Controller
{
    public class ControllerCourier : Interfaces.IUser, Interfaces.IMain
    {
        public void Delete(int ID)
        {
            foreach (Courier courier in CourierBase.Couriers)
                if (courier.ID == ID)
                    CourierBase.Couriers.Remove(courier);
        }
        public bool Login(string login, string password)
        {
            bool check = false;
            foreach (Courier courier in CourierBase.Couriers)
                if ((courier.Login == login) && (courier.Password == password))
                    check = true;
            return check;
        }
        public void Registration(string login, string password, string name, string phone,
                                                            string district = "", string address = "")
        {
            Courier courier = new Courier(login, password, name, phone);
            courier.ID = CourierBase.MaxID++;
            CourierBase.Couriers.Add(courier);
        }
        public void Edit(Courier newCourier)
        {
            for (int i = 0; i < CourierBase.Couriers.Count; i++)
                if (CourierBase.Couriers[i].ID == newCourier.ID)
                    CourierBase.Couriers[i] = newCourier;
        }
    }
}
