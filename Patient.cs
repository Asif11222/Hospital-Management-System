using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class Patient : Form
    {
        private DBConnect dbConnect = new DBConnect();
        public Patient()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserLogin obj = new UserLogin();
            obj.Show();
            this.Hide();
        }
        void populate()
        {
            string query = "SELECT * FROM PatientTbl";
            DGVPatient.DataSource = dbConnect.GetData(query);
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void Reset()
        {
            txtPId.Text = "";
            txtPName.Text = "";
            txtPAddress.Text = "";
            txtPAge.Text = "";
            txtMajorDisease.Text = "";
            cbBloodGroup.SelectedIndex = -1;
            cbGender.SelectedIndex = -1;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPId.Text) ||
                    string.IsNullOrWhiteSpace(txtPName.Text) ||
                    string.IsNullOrWhiteSpace(txtPAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtPAge.Text) ||
                    string.IsNullOrWhiteSpace(txtMajorDisease.Text))
                {
                    MessageBox.Show("Missing Information! Fill All Details Carefully");
                    return;
                }

                string query = "INSERT INTO PatientTbl (PatientId, PatientName, PatientAddress, PatientAge, PatientGender, PatientBG, PatientDisease) VALUES (@PatientId, @PatientName, @PatientAddress, @PatientAge, @PatientGender, @PatientBG, @PatientDisease)";
                SqlParameter[] parameters = {
                    new SqlParameter("@PatientId", txtPId.Text),
                    new SqlParameter("@PatientName", txtPName.Text),
                    new SqlParameter("@PatientAddress", txtPAddress.Text),
                    new SqlParameter("@PatientAge", txtPAge.Text),
                    new SqlParameter("@PatientGender", cbGender.SelectedItem.ToString()),
                    new SqlParameter("@PatientBG", cbBloodGroup.SelectedItem.ToString()),
                    new SqlParameter("@PatientDisease", txtMajorDisease.Text)
                };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Patient Added Successfully");
                populate();
                Reset();
            }
            catch (SqlException sqlEx)
            {
                
                if (sqlEx.Number == 2627) 
                {
                    MessageBox.Show("The Patient ID already exists. Please use a different ID.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the patient. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void DGVPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DGVPatient.SelectedRows.Count > 0)
            {
                txtPId.Text = DGVPatient.SelectedRows[0].Cells[0].Value.ToString();
                txtPName.Text = DGVPatient.SelectedRows[0].Cells[1].Value.ToString();
                txtPAddress.Text = DGVPatient.SelectedRows[0].Cells[2].Value.ToString();
                txtPAge.Text = DGVPatient.SelectedRows[0].Cells[3].Value.ToString();
                cbGender.SelectedItem = DGVPatient.SelectedRows[0].Cells[4].Value.ToString();
                cbBloodGroup.SelectedItem = DGVPatient.SelectedRows[0].Cells[5].Value.ToString();
                txtMajorDisease.Text = DGVPatient.SelectedRows[0].Cells[6].Value.ToString();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPId.Text) ||
                    string.IsNullOrWhiteSpace(txtPName.Text) ||
                    string.IsNullOrWhiteSpace(txtPAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtPAge.Text) ||
                    string.IsNullOrWhiteSpace(txtMajorDisease.Text) ||
                    cbGender.SelectedIndex == -1 ||
                    cbBloodGroup.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all fields before updating.");
                    return;
                }

                if (!int.TryParse(txtPId.Text, out int patientId))
                {
                    MessageBox.Show(" Invalid Patient ID.");
                    return;
                }

                string query = "UPDATE PatientTbl SET " +
                               "PatientName = @PatientName, " +
                               "PatientAddress = @PatientAddress, " +
                               "PatientAge = @PatientAge, " +
                               "PatientGender = @PatientGender, " +
                               "PatientBG = @PatientBG, " +
                               "PatientDisease = @PatientDisease " +
                               "WHERE PatientId = @PatientId";

                SqlParameter[] parameters = {
                    new SqlParameter("@PatientName", txtPName.Text),
                    new SqlParameter("@PatientAddress", txtPAddress.Text),
                    new SqlParameter("@PatientAge", txtPAge.Text),
                    new SqlParameter("@PatientGender", cbGender.SelectedItem.ToString()),
                    new SqlParameter("@PatientBG", cbBloodGroup.SelectedItem.ToString()),
                    new SqlParameter("@PatientDisease", txtMajorDisease.Text),
                    new SqlParameter("@PatientId", patientId)
                };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Patient Updated Successfully");
                populate();
                Reset();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) 
                {
                    MessageBox.Show("Cannot update the patient as it is linked to existing records.");
                }
                else
                {
                    MessageBox.Show("An error occurred while updating the patient. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPId.Text))
                {
                    MessageBox.Show("Enter Patient Id");
                    return;
                }

                
                string deleteDiagnosisQuery = "DELETE FROM DiagnosisTbl WHERE PatientId = @PatientId";
                SqlParameter[] diagnosisParameters = {
                    new SqlParameter("@PatientId", txtPId.Text)
                };
                dbConnect.ExecuteQuery(deleteDiagnosisQuery, diagnosisParameters);

                
                string query = "DELETE FROM PatientTbl WHERE PatientId = @PatientId";
                SqlParameter[] parameters = {
                    new SqlParameter("@PatientId", txtPId.Text)
                };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Patient Deleted Successfully");
                populate();
                Reset();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) 
                {
                    MessageBox.Show("Cannot delete the patient as it is linked to existing records.");
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the patient. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            populate();
            Reset();
        }

        private void txtMajorDisease_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }
    }
}

