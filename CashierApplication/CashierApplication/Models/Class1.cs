namespace CashierApplication.Models
{
    public class UserAccount
    {
        public string FullName { get; }
        public string UserName { get; }
        protected string Password { get; }

        public UserAccount(string fullName, string userName, string password)
        {
            FullName = fullName;
            UserName = userName;
            Password = password;
        }

        public virtual bool ValidateLogin(string userName, string password) =>
            UserName == userName && Password == password;
    }
}

// Models/Cashier.cs
namespace CashierApplication.Models
{
    public class Cashier : UserAccount
    {
        public string Department { get; }

        public Cashier(string fullName, string department,
                       string userName, string password)
            : base(fullName, userName, password)
        {
            Department = department;
        }
    }
}