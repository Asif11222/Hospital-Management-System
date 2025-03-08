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
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class Medicine : Form
    {
        private DBConnect dbConnect = new DBConnect();
        public Medicine()
        {
            InitializeComponent();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            Doctors obj = new Doctors();
            obj.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserLogin obj = new UserLogin();
            obj.Show();
            this.Hide();
        }

        private void DGVMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMedicineId.Text = DGVMedicine.SelectedRows[0].Cells[0].Value.ToString();
            txtMedicineName.Text = DGVMedicine.SelectedRows[0].Cells[1].Value.ToString();
            txtMedicineType.Text = DGVMedicine.SelectedRows[0].Cells[2].Value.ToString();
            txtByDoctor.Text = DGVMedicine.SelectedRows[0].Cells[3].Value.ToString();
        }
        void populate()
        {
            string query = "SELECT * FROM MedicineTbl";
            DGVMedicine.DataSource = dbConnect.GetData(query);
        }
        private void reset()
        {
            txtMedicineId.Text = "";
            txtMedicineName.Text = "";
            txtMedicineType.Text = "";
            txtByDoctor.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtMedicineId.Text) ||
                    string.IsNullOrWhiteSpace(txtMedicineName.Text) ||
                    string.IsNullOrWhiteSpace(txtMedicineType.Text) ||
                    string.IsNullOrWhiteSpace(txtByDoctor.Text))
                {
                    MessageBox.Show("Missing Information! Fill All Details Carefully");
                    return;
                }

                string query = "INSERT INTO MedicineTbl (MedicineId, MedicineName, MedicineType, ByDoctor) VALUES (@MedicineId, @MedicineName, @MedicineType, @ByDoctor)";
                SqlParameter[] parameters = {
                    new SqlParameter("@MedicineId", txtMedicineId.Text),
                    new SqlParameter("@MedicineName", txtMedicineName.Text),
                    new SqlParameter("@MedicineType", txtMedicineType.Text),
                    new SqlParameter("@ByDoctor", txtByDoctor.Text)
                };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Medicine Added Successfully");
                populate();
                reset();
            }
            catch (SqlException sqlEx)
            {
                
                if (sqlEx.Number == 2627) 
                {
                    MessageBox.Show("The Medicine ID already exists. Please use a different ID.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the medicine. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMedicineId.Text))
                {
                    MessageBox.Show("Please select a medicine to delete.");
                    return;
                }

                string query = "DELETE FROM MedicineTbl WHERE MedicineId = @MedicineId";
                SqlParameter[] parameters = {
                    new SqlParameter("@MedicineId", txtMedicineId.Text)
                };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Medicine Deleted Successfully");
                populate();
                reset();
            }
            catch (SqlException sqlEx)
            {
                
                if (sqlEx.Number == 547) 
                {
                    MessageBox.Show("Cannot delete the medicine as it is linked to existing records.");
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the medicine. Please try again.");
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

        private void Medicine_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
