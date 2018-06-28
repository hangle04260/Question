using DevExpress.Office.Utils;
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
using Trafic.Business.Model;
namespace Trafic.Forms
{
    public partial class frmQuestion : Form
    {
        #region Variables
            IQuestion questionBO;
            IDepartment departmentBO;
        #endregion

        #region Events form
            public frmQuestion()
            {
            this.questionBO = this.questionBO ?? new QuestionBO();
            this.departmentBO = this.departmentBO ?? new DepartmentBO();
            InitializeComponent();
            
            QuestionBO q = new QuestionBO();
           
            gridControl1.DataSource = q.GetDepartmentnameFromDepartmentID(1);

        }
        private void frmQuestion_Load(object sender, EventArgs e)
            {
            var departments = this.departmentBO.GetData();
            Trafic.Utils.clsGlobal.LookUp(ref cboDepartment, departments, "DepartmentID", "DepartmentName");
            //LoadData();
            if (departments.Count > 0)
                cboDepartment.EditValue = departments[0].DepartmentID;
        }
            private void btnSearch_Click(object sender, EventArgs e)
            {
                //LoadData();
            }
            private void btnAddNew_Click(object sender, EventArgs e)
            {
                frmAddQuestion frm = new frmAddQuestion();
                frm.ShowDialog();
            }
        #endregion

        #region Private methods
            private void LoadData()
        {
            int departmentID = Convert.ToInt32(cboDepartment.EditValue);
            var questions = this.questionBO.GetData(departmentID, txtSearch.Text);
            gridControl1.DataSource = questions;
        }
        #endregion

        private void cboDepartment_MouseClick(object sender, MouseEventArgs e)
        {

            
        }

        private void cboDepartment_Click(object sender, EventArgs e)
        {
           

        }

        private void cboDepartment_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }

        private void cboDepartment_Properties_Enter(object sender, EventArgs e)
        {
            //DepartmentBO department = new DepartmentBO();
            //QuestionBO q = new QuestionBO();
            //string a = department.getDepartmentName(cboDepartment.Text);
            //gridControl1.DataSource = q.GetDepartmentnameFromDepartmentID(Int32.Parse(a));
        }

        private void cboDepartment_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void cboDepartment_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void cboDepartment_TextChanged(object sender, EventArgs e)
        {
            DepartmentBO department = new DepartmentBO();
            QuestionBO q = new QuestionBO();
            var a = department.getDepartmentName(cboDepartment.Text);
            string b = "0";
            foreach (var temp in a)
            {
                b = temp.DepartmentID.ToString();
            }
            if(b!="0")
            {
                gridControl1.DataSource = q.GetDepartmentnameFromDepartmentID(Int32.Parse(b));
            }
            if(b=="0")
            {
                gridControl1.DataSource = q.GetDepartmentALL();
            }

        }

        private void cboDepartment_ListChanged(object sender, ListChangedEventArgs e)
        {
           
        }

        private void cboDepartment_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
