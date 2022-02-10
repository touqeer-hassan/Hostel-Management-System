using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System
{
    public partial class frmAddaStudent : Form
    {
        public frmAddaStudent()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Save and Submit record to the databse
            string ConStr = "DATA SOURCE=localhost:1521/ORCL;USER ID=SCOTT;Password=cped;";
            OracleConnection OracleCon = new OracleConnection(ConStr);

            string Add = txtAddress.Text;
            string City = txtCity.Text;
            string CINC = txtcnic.Text;
            string Cont = txtContact.Text;
            string Eml = txtEmail.Text;
            string FathName = txtFatherName.Text;
            string StdName = txtName.Text;
            string Provn = txtProvince.Text;
            string Rollno = txtRollNo.Text;
            string Sem = txtSemester.Text;
            string Sess = txtSession.Text;

            OracleCon.Open();

            OracleCommand cmd = new OracleCommand("UPDATE STUDENT SET SNAME=StdName,GID="+ +"SPHONENUMBER=Cont,CITYID="+ +"PROVISSIONID="+ +"DEPTID="++"");


            OracleCon.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtCity.Text = "";
            txtcnic.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtFatherName.Text = "";
            txtName.Text = "";
            txtProvince.Text = "";
            txtRollNo.Text = "";
            txtSemester.Text = "";
            txtSession.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentRecord stdobj = new frmStudentRecord();
            this.Hide();
            stdobj.Show();
        }
    }
}
