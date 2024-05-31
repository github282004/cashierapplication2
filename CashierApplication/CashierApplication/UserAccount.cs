using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal abstract class UserAccount
    {
        protected string full_name;
        protected string user_password;
        protected string user_name;
        
        public UserAccount(string name, string password, string Uname)
        {
            this.full_name = name;
            this.user_password = password;
            this.user_name = Uname;
        }
        public abstract bool validateLogin(string username, string password);
        public string getFullName() {
            return this.full_name;
        }

        
    }
    
}
