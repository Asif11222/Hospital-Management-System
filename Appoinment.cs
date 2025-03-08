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
    public partial class Appoinment : Form
    {
        private DBConnect dbConnect = new DBConnect();
        private bool isLoading = true;
        public Appoinment()
        {
            InitializeComponent();
        }

        private void Appoinment_Load(object sender, EventArgs e)
        {
            PopulatePatientIds();
            PopulateDoctorIds();
            PopulateAppointments();
            isLoading = false;

        }
        private void PopulatePatientIds()
        {
            string query = "SELECT PatientId FROM PatientTbl";
            DataTable dt = dbConnect.GetData(query);
            CbPatientId.DataSource = dt;
            CbPatientId.DisplayMember = "PatientId";
            CbPatientId.ValueMember = "PatientId";
            CbPatientId.SelectedIndex = -1;
        }
        private void PopulateDoctorIds()
        {
            string query = "SELECT DocId FROM DoctorsTable";
            DataTable dt = dbConnect.GetData(query);
            cmbDocId.DataSource = dt;
            cmbDocId.DisplayMember = "DocId";
            cmbDocId.ValueMember = "DocId";
            cmbDocId.SelectedIndex = -1;
        }
        private void PopulateAppointments()
        {
            string query = "SELECT SINo, PatientID, PatientName, DoctorId, DoctorName, Date, Time FROM AppointmentTbl";
            DGVAppointment.DataSource = dbConnect.GetData(query);
        }

        private void txtSlNo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CbPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (CbPatientId.SelectedValue != null)
            {
                int selectedPatientId = Convert.ToInt32(CbPatientId.SelectedValue);
                string query = "SELECT PatientName FROM PatientTbl WHERE PatientId = @PatientId";
                SqlParameter[] parameters = { new SqlParameter("@PatientId", selectedPatientId) };
                DataTable dt = dbConnect.GetData(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    txtPName1.Text = dt.Rows[0]["PatientName"].ToString();
                }
                else
                {
                    txtPName1.Text = string.Empty;
                }
            }

        }

        private void cmbDocId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;

            if (cmbDocId.SelectedValue != null)
            {
                int selectedDocId = Convert.ToInt32(cmbDocId.SelectedValue);
                string query = "SELECT DocName FROM DoctorsTable WHERE DocId = @DocId";
                SqlParameter[] parameters = { new SqlParameter("@DocId", selectedDocId) };
                DataTable dt = dbConnect.GetData(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    txtDocName.Text = dt.Rows[0]["DocName"].ToString();
                }
                else
                {
                    txtDocName.Text = string.Empty;
                }
            }

        }

        private void txtDate_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPName1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDocName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTime_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void V_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(CbPatientId.Text) ||
                    string.IsNullOrWhiteSpace(cmbDocId.Text) ||
                    string.IsNullOrWhiteSpace(txtDate.Text) ||
                    string.IsNullOrWhiteSpace(txtTime.Text))
                {
                    MessageBox.Show("Missing Information! Fill All Details Carefully");
                    return;
                }

               
                int patientId = Convert.ToInt32(CbPatientId.SelectedValue);
                int doctorId = Convert.ToInt32(cmbDocId.SelectedValue);
                string appointmentDate = txtDate.Text;
                string appointmentTime = txtTime.Text;

               
                string query = "INSERT INTO AppointmentTbl (PatientID, PatientName, DoctorId, DoctorName, Date, Time) VALUES (@PatientId, @PatientName, @DoctorId, @DoctorName, @Date, @Time)";
                SqlParameter[] parameters = {
            new SqlParameter("@PatientId", patientId),
            new SqlParameter("@PatientName", txtPName1.Text),
            new SqlParameter("@DoctorId", doctorId),
            new SqlParameter("@DoctorName", txtDocName.Text),
            new SqlParameter("@Date", appointmentDate),
            new SqlParameter("@Time", appointmentTime)
        };

              
                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Appointment Added Successfully");
                PopulateAppointments();
            }
            catch (SqlException sqlEx)
            {
              
                MessageBox.Show($"SQL Error: {sqlEx.Message} (Error Number: {sqlEx.Number})");
            }
            catch (Exception ex)
            {
              
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }

        }
        private void ResetFields()
        {
            CbPatientId.SelectedIndex = -1;
            cmbDocId.SelectedIndex = -1;
            txtPName1.Text = string.Empty;
            txtDocName.Text = string.Empty;
            txtDate.Text = string.Empty;
            txtTime.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVAppointment.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an appointment to delete.");
                    return;
                }

                int selectedRowIndex = DGVAppointment.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DGVAppointment.Rows[selectedRowIndex];
                int slNo = Convert.ToInt32(selectedRow.Cells["SlNo"].Value);

                string query = "DELETE FROM AppointmentTbl WHERE SlNo = @SlNo";
                SqlParameter[] parameters = { new SqlParameter("@SlNo", slNo) };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Appointment deleted successfully.");
                PopulateAppointments();
            }
            catch (SqlException sqlEx)
            {
               
                if (sqlEx.Number == 547) 
                {
                    MessageBox.Show("This appointment cannot be deleted because it is linked to other records.");
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the appointment. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }
        private int GetNextAvailableSlNo()
        {
           
            string query = "SELECT MIN(SINo) + 1 AS NextSlNo FROM AppointmentTbl WHERE SINo + 1 NOT IN (SELECT SINo FROM AppointmentTbl)";
            DataTable dt = dbConnect.GetData(query);

            if (dt.Rows.Count > 0 && dt.Rows[0]["NextSlNo"] != DBNull.Value)
            {
                return Convert.ToInt32(dt.Rows[0]["NextSlNo"]);
            }

          
            query = "SELECT ISNULL(MAX(SINo), 0) + 1 AS NextSlNo FROM AppointmentTbl";
            dt = dbConnect.GetData(query);
            return Convert.ToInt32(dt.Rows[0]["NextSlNo"]);
        }
        private void BtnReload_Click(object sender, EventArgs e)
        {
            PopulateAppointments();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            // Delete Button
            try
            {
               
                if (DGVAppointment.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an appointment to delete.");
                    return;
                }

              
                int selectedRowIndex = DGVAppointment.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = DGVAppointment.Rows[selectedRowIndex];

               
                int slNo = Convert.ToInt32(selectedRow.Cells["SINo"].Value);

               
                string query = "DELETE FROM AppointmentTbl WHERE SINo = @SlNo";
                SqlParameter[] parameters = { new SqlParameter("@SlNo", slNo) };

               
                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Appointment deleted successfully.");

               
                PopulateAppointments();
            }
            catch (SqlException sqlEx)
            {
               
                if (sqlEx.Number == 547) 
                {
                    MessageBox.Show("This appointment cannot be deleted because it is linked to other records.");
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the appointment. Please try again.");
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void DGVAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
