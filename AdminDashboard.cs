using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            Doctors doctorForm = new Doctors();
            doctorForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserLogin obj = new UserLogin();
            obj.Show();
            this.Hide();
        }

        private void SearchDoc_Click(object sender, EventArgs e)
        {
            DoctorSearch doctorForm = new DoctorSearch();
            doctorForm.Show();
            this.Hide();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            PatientSearch doctorForm = new PatientSearch();
            doctorForm.Show();
            this.Hide();
        }

        private void btnDiagrep_Click(object sender, EventArgs e)
        {
            DiagnosisReport doctorForm = new DiagnosisReport();
            doctorForm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Appoinment appoinment = new Appoinment();
            appoinment.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
