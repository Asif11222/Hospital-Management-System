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
    public partial class PatientSearch : Form
    {
        private DBConnect dbConnect = new DBConnect();
        public PatientSearch()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AdminDashboard obj = new AdminDashboard();
            obj.Show();
            this.Hide();
        }

        private void btnDocSearch_Click(object sender, EventArgs e)
        {
            
            string patientId = txtPId.Text.Trim();

            if (string.IsNullOrWhiteSpace(patientId))
            {
                MessageBox.Show("Please enter a Patient ID to search.");
                return;
            }

            try
            {
                string query = "SELECT * FROM PatientTbl WHERE PatientId = @PatientId";
                SqlParameter[] parameters = {
                    new SqlParameter("@PatientId", patientId)
                };

                DataTable result = dbConnect.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DGVPatient.DataSource = result;
                }
                else
                {
                    MessageBox.Show("No patient found with the provided ID.");
                    DGVPatient.DataSource = null; 
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DGVPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
