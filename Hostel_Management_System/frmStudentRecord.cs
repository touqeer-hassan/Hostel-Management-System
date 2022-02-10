using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Hostel_Management_System
{
    public partial class frmStudentRecord : Form
    {
        public frmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnAddAStudent_Click(object sender, EventArgs e)
        {
            frmAddaStudent objadstd = new frmAddaStudent();
            objadstd.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string ConStr = "DATA SOURCE=localhost:1521/ORCL;USER ID=SCOTT;Password=cped;";
            OracleConnection OracleCon = new OracleConnection(ConStr);
            OracleCon.Open();
            OracleCommand cmd = new OracleCommand("select * from Student");
            DataTable dtb1 = new DataTable();
            OracleData.Fill(dgvStudent);
            OracleCon.Close();

        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
