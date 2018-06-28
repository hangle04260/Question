using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trafic.Business.Interface;
using Trafic.Business.Model;

namespace Trafic.Business.Business
{
    public class AccountBO : IAccount

    {
        string path = "\\JsonData\\Account.txt";
        public List<Account> CheckAccount(string Username, string Password)
        {
            Connection con = new Connection();
            var account = JsonConvert.DeserializeObject<List<Model.Account>>(con.Json(path));
            var user = account.Where(m => m.UserName == Username&& m.Password==Password).ToList();
            return user;
        }

        public List<Model.Account> CheckUser(string Username)
        {
            Connection con = new Connection();
            var account = JsonConvert.DeserializeObject<List<Model.Account>>(con.Json(path));
            var user = account.Where(m => m.UserName == Username).ToList();
            return user;


            
        }
        
    }
}
