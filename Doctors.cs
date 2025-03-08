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
using System.Globalization;

namespace HospitalManagementSystem
{
    public partial class Doctors : Form
    {
        private DBConnect dbConnect = new DBConnect(); 
        public Doctors()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void populate()
        {
            string query = "SELECT * FROM DoctorsTable";
            DGVDoctors.DataSource = dbConnect.GetData(query);
        }
        private void reset()
        {
            txtdoctorsId.Text = "";
            txtDictorName.Text = "";
            txtYearsOfExperience.Text = "";
            txtPassword.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtdoctorsId.Text) ||
                    string.IsNullOrWhiteSpace(txtDictorName.Text) ||
                    string.IsNullOrWhiteSpace(txtYearsOfExperience.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Missing Information! Fill All Details Carefully");
                    return;
                }

                // Validate Doctor ID
                if (!int.TryParse(txtdoctorsId.Text, out int doctorId) || doctorId < 1000 || doctorId > 2000)
                {
                    MessageBox.Show("Doctor ID must be an integer between 1000 and 2000.", "Invalid Doctor ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "INSERT INTO DoctorsTable (DocId, DocName, YearsOfExperience, Password) VALUES (@DocId, @DocName, @YearsOfExperience, @Password)";
                SqlParameter[] parameters = {
            new SqlParameter("@DocId", txtdoctorsId.Text),
            new SqlParameter("@DocName", txtDictorName.Text),
            new SqlParameter("@YearsOfExperience", txtYearsOfExperience.Text),
            new SqlParameter("@Password", txtPassword.Text)
        };

                dbConnect.ExecuteQuery(query, parameters);

                string userQuery = "INSERT INTO Users (DoctorId, DoctorPassword) VALUES (@DoctorId, @DoctorPassword)";
                SqlParameter[] userParameters = {
            new SqlParameter("@DoctorId", txtdoctorsId.Text),
            new SqlParameter("@DoctorPassword", txtPassword.Text)
        };

                dbConnect.ExecuteQuery(userQuery, userParameters);

                MessageBox.Show("Doctor Added Successfully");
                populate();
                reset();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("The Doctor ID already exists. Please use a different ID.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the doctor. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

        }

        private void DGVDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVDoctors.SelectedRows.Count > 0)
            {
                txtdoctorsId.Text = DGVDoctors.SelectedRows[0].Cells[0].Value.ToString();
                txtDictorName.Text = DGVDoctors.SelectedRows[0].Cells[1].Value.ToString();
                txtYearsOfExperience.Text = DGVDoctors.SelectedRows[0].Cells[2].Value.ToString();
                txtPassword.Text = DGVDoctors.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtdoctorsId.Text) ||
                    string.IsNullOrWhiteSpace(txtDictorName.Text) ||
                    string.IsNullOrWhiteSpace(txtYearsOfExperience.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Missing Information! Fill All Details Carefully");
                    return;
                }

                
                string query = "UPDATE DoctorsTable SET DocName = @DocName, YearsOfExperience = @YearsOfExperience, Password = @Password WHERE DocId = @DocId";
                SqlParameter[] parameters = {
            new SqlParameter("@DocName", txtDictorName.Text),
            new SqlParameter("@YearsOfExperience", txtYearsOfExperience.Text),
            new SqlParameter("@Password", txtPassword.Text),
            new SqlParameter("@DocId", txtdoctorsId.Text)
        };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Doctor Updated Successfully");
                populate();
                reset();
            }
            catch (SqlException sqlEx)
            {
                
                if (sqlEx.Number == 547) 
                {
                    MessageBox.Show("This doctor cannot be updated because it is linked to other records.");
                }
                else
                {
                    MessageBox.Show("An error occurred while updating the doctor. Please try again.");
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
                if (string.IsNullOrWhiteSpace(txtdoctorsId.Text))
                {
                    MessageBox.Show("Enter The Doctor Id");
                    return;
                }

                
                string query = "DELETE FROM DoctorsTable WHERE DocId = @DocId";
                SqlParameter[] parameters = {
            new SqlParameter("@DocId", txtdoctorsId.Text)
        };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Doctor Deleted Successfully");
                populate();
                reset();
            }
            catch (SqlException sqlEx)
            {
                
                if (sqlEx.Number == 547) 
                {
                    MessageBox.Show("This doctor cannot be deleted because it is linked to other records.");
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the doctor. Please try again.");
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
            reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserLogin obj = new UserLogin();
            obj.Show();
            this.Hide();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
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
