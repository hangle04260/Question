using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic.Business.Business
{
    public  class Connection
    {
        public  string Json(string path)
        {
            string jsonPath = Directory.GetCurrentDirectory();
            jsonPath = jsonPath.Replace(@"\bin\Debug", "") + @""+path+"";
            StreamReader jsonFile = new StreamReader(jsonPath);

           return jsonFile.ReadToEnd();

            
        }
    }
}
