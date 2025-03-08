using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class DiagnosisReport : Form
    {
        private DBConnect dbConnect = new DBConnect();
        public DiagnosisReport()
        {
            InitializeComponent();
        }
        public void LoadDiagnosisReport()
        {

            try
            {
                string query = @"
            SELECT 
                dp.DoctorId, 
                dp.PatientId, 
                dp.PatientName, 
                dp.Symptoms, 
                dp.Diagnosis, 
                doc.DocName AS DoctorName 
            FROM 
                DocPatient dp
            JOIN 
                DoctorsTable doc ON dp.DoctorId = doc.DocId";

                DataTable dt = dbConnect.GetData(query);
                DGVDiagReport.DataSource = dt;

                DGVDiagReport.Columns["DoctorId"].HeaderText = "Doctor ID";
                DGVDiagReport.Columns["PatientId"].HeaderText = "Patient ID";
                DGVDiagReport.Columns["PatientName"].HeaderText = "Patient Name";
                DGVDiagReport.Columns["DoctorName"].HeaderText = "Doctor Name";
                DGVDiagReport.Columns["Symptoms"].HeaderText = "Symptoms";
                DGVDiagReport.Columns["Diagnosis"].HeaderText = "Diagnosis";
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 53) 
                {
                    MessageBox.Show("Unable to connect to the database. Please check your connection settings.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (sqlEx.Number == 4060)
                {
                    MessageBox.Show("Unable to open the database. Please check your database settings.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("An error occurred while accessing the database. Please try again later.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DGVDiagReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DiagnosisReport_Load(object sender, EventArgs e)
        {
            LoadDiagnosisReport();
        }
       


        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDiagnosisReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard page = new AdminDashboard();
            page.Show();
            this.Hide();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Patient obj = new Patient();
            obj.Show();
            this.Hide();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            Diagnosis obj = new Diagnosis();
            obj.Show();
            this.Hide();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            Medicine obj = new Medicine();
            obj.Show();
            this.Hide();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            UserLogin obj = new UserLogin();
            obj.Show();
            this.Hide();
        }
    }

}
