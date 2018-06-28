using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic.Business.Interface
{
    public  interface IAccount
    {
        List<Model.Account> CheckUser(string Username);
        List<Model.Account> CheckAccount(string Username, string Password);
    }
}
