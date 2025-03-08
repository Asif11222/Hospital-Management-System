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
    public partial class DoctorDashBoard : Form
    {
        private DBConnect dbConnect = new DBConnect();
        private string doctorId;
        public DoctorDashBoard(string docId)
        {
            InitializeComponent();
            doctorId = docId;
            LoadDoctorInfo();
            LoadDiagnosisData();
        }
        private void LoadDiagnosisData()
        {
            string query = "SELECT PatientId, PatientName, Diagnosis, Medicine, Symptoms FROM DocPatient WHERE DoctorId = @DoctorId";
            SqlParameter[] parameters = { new SqlParameter("@DoctorId", doctorId) };
            DataTable diagnosisData = dbConnect.GetData(query, parameters);
            DGVDoctors.DataSource = diagnosisData;

            DGVDoctors.Columns["PatientId"].HeaderText = "Patient ID";
            DGVDoctors.Columns["PatientName"].HeaderText = "Patient Name";
            DGVDoctors.Columns["Diagnosis"].HeaderText = "Diagnosis";
            DGVDoctors.Columns["Medicine"].HeaderText = "Medicine";
            DGVDoctors.Columns["Symptoms"].HeaderText = "Symptoms";

            DGVDoctors.Columns["PatientId"].Width = 100;
            DGVDoctors.Columns["PatientName"].Width = 150;
            DGVDoctors.Columns["Diagnosis"].Width = 200;
            DGVDoctors.Columns["Medicine"].Width = 150;
            DGVDoctors.Columns["Symptoms"].Width = 150;
        }
        private void LoadDoctorInfo()
        {
            string query = "SELECT DocName, YearsOfExperience, Password FROM DoctorsTable WHERE DocId = @DocId";
            SqlParameter[] parameters = { new SqlParameter("@DocId", doctorId) };
            DataTable doctorInfo = dbConnect.GetData(query, parameters);

            if (doctorInfo.Rows.Count > 0)
            {
                txtdoctorsId.Text = doctorId;
                txtDictorName.Text = doctorInfo.Rows[0]["DocName"].ToString();
                txtYearsOfExperience.Text = doctorInfo.Rows[0]["YearsOfExperience"].ToString();
                txtPassword.Text = doctorInfo.Rows[0]["Password"].ToString();
            }
        }

        private void txtdoctorsId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDictorName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtYearsOfExperience_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newPassword = txtPassword.Text;
            string query = "UPDATE DoctorsTable SET Password = @Password WHERE DocId = @DocId";
            SqlParameter[] parameters = {
                new SqlParameter("@Password", newPassword),
                new SqlParameter("@DocId", doctorId)
            };

            dbConnect.ExecuteQuery(query, parameters);
            MessageBox.Show("Password updated successfully!");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDoctorInfo();
            LoadDiagnosisData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin loginForm = new UserLogin();
            loginForm.Show();
            this.Hide();
        }

        private void DGVDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMedicineId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchMedicine_Click(object sender, EventArgs e)
        {
            try
            {
                string medicineId = txtMedicineId.Text.Trim();

                if (string.IsNullOrWhiteSpace(medicineId))
                {
                    MessageBox.Show("Please enter a Medicine ID to search.");
                    return;
                }

               
                string query = "SELECT * FROM MedicineTbl WHERE MedicineId = @MedicineId";
                SqlParameter[] parameters = {
            new SqlParameter("@MedicineId", medicineId)
        };

               
                DataTable result = dbConnect.GetData(query, parameters);

             
                if (result.Rows.Count > 0)
                {
                    DgvSearchMEdicine.DataSource = result; 
                }
                else
                {
                    MessageBox.Show("No medicine found with the provided ID.");
                    DgvSearchMEdicine.DataSource = null; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for the medicine: " + ex.Message);
            }
        }

        private void DoctorDashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
