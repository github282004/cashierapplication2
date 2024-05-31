using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    internal class Cashier : UserAccount
    {
        private string department;


        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {

            this.full_name = name;
            this.department = department;
            this.user_name = uName;
            this.user_password = password;
        }
        public override bool validateLogin(string uName, string password)
        {
            if (user_name == "cashier" && user_password == "12345") { 
                return true;
        }
         else
        {
        return false;
        }
    }
    public string getDepartment()
    {
        return department;
    }      
   }
}
