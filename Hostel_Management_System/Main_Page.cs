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
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            //Search Querry ID in DataBase
        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            frmStudentRecord stdobj = new frmStudentRecord();
            this.Hide();
            stdobj.Show();
        }

        private void btnRoomAllotment_Click(object sender, EventArgs e)
        {
            //Call Studet Record From
        }

        private void btnMess_Click(object sender, EventArgs e)
        {
            //Call Mess Record From
        }

        private void btnStaffRecord_Click(object sender, EventArgs e)
        {
            //Call Staff Record From
        }

        private void btnElectricity_Click(object sender, EventArgs e)
        {
            //Call Electricity Record From
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            //Call Review From
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
