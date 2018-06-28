using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trafic.Utils
{
    public static class clsGlobal
    {
        public static string jsonQuestionPath = @"\JsonData\JsonQuestion.txt";

        public static bool LookUp(ref LookUpEdit lookEdit,  object dataSource, string valueMember, string displayMember)
        {
            lookEdit.Properties.DataSource = dataSource;
            lookEdit.Properties.ValueMember = valueMember;
            lookEdit.Properties.DisplayMember = displayMember;
            return true;
        }
    }
}
