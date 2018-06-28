using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Trafic.Business.Business;
using Trafic.Business.Model;

namespace Trafic.Business
{
    public class QuestionBO: IQuestion
    {
        string path = "\\JsonData\\Questions.txt";
        public List<Model.Question> GetData(int departmentID, string searchString)
        {
            try {
                string jsonPath = Directory.GetCurrentDirectory();
                jsonPath = jsonPath.Replace(@"\bin\Debug", "") + @"\JsonData\Questions.txt";
                StreamReader jsonFile = new StreamReader(jsonPath);
                
                string jsonText = jsonFile.ReadToEnd();
                var serializer = new JsonSerializer();

                var questions = JsonConvert.DeserializeObject<List<Model.Question>>(jsonText);

                if (departmentID != -1 && !string.IsNullOrEmpty(searchString))
                    return questions.Where(m => m.DepartmentID == departmentID && m.QuestionName.Contains(searchString)).ToList();
                else
                {
                    if(departmentID != -1)
                        return questions.Where(m => m.DepartmentID == departmentID).ToList();
                    else if(!string.IsNullOrEmpty(searchString))
                        return questions.Where(m => m.QuestionName.Contains(searchString)).ToList();
                }
                return questions.Where(m => m.QuestionName.Contains(searchString)).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable GetDepartmentALL()
        {
            Connection con = new Connection();
            var department = JsonConvert.DeserializeObject<List<Model.Question>>(con.Json(path));
            List<Model.Question> dt = (from c in department select c).ToList();

            return ConvertToDataTable.ToDataTable(dt);
        }

        public DataTable GetDepartmentnameFromDepartmentID(int departmentID)
        {
           
            Connection con = new Connection();
            var department = JsonConvert.DeserializeObject<List<Model.Question>>(con.Json(path));
            List<Model.Question> dt = (from c in department where c.DepartmentID == departmentID select c).ToList();

            return ConvertToDataTable.ToDataTable(dt);
        }
    }
}
