using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class UserAccount
    {
        private readonly string full_name;
        protected readonly string user_name;
        protected readonly string user_password;
        protected readonly string work_dep;

        public string V { get; }

        public UserAccount(string name, string uName, string password, string department)
        {
            full_name = name;
            user_name = uName;
            user_password = password;
            work_dep = department;
        }

        public UserAccount(string name, string uName, string password, string v, string department) : this(name, uName, password, department)
        {
            V = v;
        }

        public virtual bool ValidateLogin(string uName, string password)
            => user_name == uName && user_password == password;
        public string GetFullName() => full_name;
    }
    public class Cashier : UserAccount
    {
        private readonly string department;
        public Cashier(string name, string department,
                       string uName, string password)
            : base(name, uName, password, department)
        {
            this.department = department;
        }
        public override bool ValidateLogin(string uName, string password)
            => base.ValidateLogin(uName, password);
        public string GetDepartment() => department;
    }
}
