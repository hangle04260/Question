using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafic.Business
{
    public interface IDepartment
    {
        List<Model.Department> GetData();
        List<Model.Department> getDepartmentName(string departmentname);
    }
}
