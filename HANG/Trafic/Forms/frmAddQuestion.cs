using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trafic.Business;

namespace Trafic.Forms
{
    public partial class frmAddQuestion : Form
    {
        #region Variables
            IDepartment departmentBO;
        #endregion

        #region Events Form
            public frmAddQuestion()
            {
                InitializeComponent();
                this.departmentBO = this.departmentBO ?? new DepartmentBO();
            }
            private void frmAddQuestion_Load(object sender, EventArgs e)
            {
                var departments = this.departmentBO.GetData();
                Trafic.Utils.clsGlobal.LookUp(ref cboDepartment, departments, "DepartmentID", "DepartmentName");
                if (departments.Count > 0)
                    cboDepartment.EditValue = departments[0].DepartmentID;

                List<Business.Model.Result> results = new List<Business.Model.Result>();
                Business.Model.Result result = new Business.Model.Result();
                result.ResultNumber = 3;
                result.ResultName = "3 Đáp án";
                results.Add(result);

                result = new Business.Model.Result();
                result.ResultNumber = 4;
                result.ResultName = "4 Đáp án";
                results.Add(result);

                Trafic.Utils.clsGlobal.LookUp(ref cboQuestionNumber, departments, "ResultNumber", "ResultName");
                cboQuestionNumber.EditValue = results[0].ResultNumber;
            }

            private void btnSave_Click(object sender, EventArgs e)
            {

            }
            private void btnCancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        #endregion

        #region Private methods

        #endregion
    }
}
