using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trafic.Business.Business;
using Trafic.Business.Model;

namespace Trafic.Business
{

    public class DepartmentBO : IDepartment
    {
        string path = "\\JsonData\\Departments.txt";
        public List<Model.Department> GetData()
        {
            try
            {
                string jsonPath = Directory.GetCurrentDirectory();
                jsonPath = jsonPath.Replace(@"\bin\Debug", "") + @"\JsonData\Departments.txt";
                StreamReader jsonFile = new StreamReader(jsonPath);

                string jsonText = jsonFile.ReadToEnd();
                var serializer = new JsonSerializer();
                var departments = JsonConvert.DeserializeObject<List<Model.Department>>(jsonText).Where(m => m.IsActive == true).ToList();
                Model.Department department = new Model.Department();
                department.DepartmentID = -1;
                department.DepartmentName = "Tất cả";

                departments.Insert(0, department);
                return departments;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Model.Department> getDepartmentName(string departmentname)
        {
            Connection con = new Connection();
            var departments = JsonConvert.DeserializeObject<List<Model.Department>>(con.Json(path));
            List<Model.Department> d = (from c in departments where c.DepartmentName == departmentname select c).ToList();
            return d;
        }
    }
}
