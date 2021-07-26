
namespace NixTask.Interfaces
{
    interface IUser
    {
        public void Registration(string login, string password, string name, string phone,
                                                        string district = "", string address = "");
        public bool Login(string name, string password);
    }
}
