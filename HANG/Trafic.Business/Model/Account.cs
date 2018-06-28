using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic.Business.Model
{
    public  class Account
    {
        public Account()
        {
        }

        public Account(int accountID, string userName, string password, string fullname)
        {
            AccountID = accountID;
            UserName = userName;
            Password = password;
            Fullname = fullname;
        }

        public int AccountID { get; set; }
        public string UserName { get; set; }
        public  string Password { get; set; }
        public  string Fullname { get; set; }
    }
}
