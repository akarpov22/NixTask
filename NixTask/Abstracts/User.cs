
namespace NixTask.Abstracts
{
    public abstract class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
