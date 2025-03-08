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
    public partial class DoctorSearch : Form
    {
        private DBConnect dbConnect = new DBConnect();
        public DoctorSearch()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AdminDashboard obj = new AdminDashboard();
            obj.Show();
            this.Hide();
        }

        private void txtdoctorsId_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void DGVDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDocSearch_Click(object sender, EventArgs e)
        {
            string doctorId = txtdoctorsId.Text.Trim();

            if (string.IsNullOrWhiteSpace(doctorId))
            {
                MessageBox.Show("Please enter a Doctor ID to search.");
                return;
            }

            try
            {
                string query = "SELECT * FROM DoctorsTable WHERE DocId = @DocId";
                SqlParameter[] parameters = {
                    new SqlParameter("@DocId", doctorId)
                };

                DataTable result = dbConnect.GetData(query, parameters);

                if (result.Rows.Count > 0)
                {
                    DGVDoctors.DataSource = result;
                }
                else
                {
                    MessageBox.Show("No doctor found with the provided ID.");
                    DGVDoctors.DataSource = null;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DoctorSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
