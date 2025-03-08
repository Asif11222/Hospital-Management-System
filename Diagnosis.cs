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
using System.Xml.Linq;

namespace HospitalManagementSystem
{
    public partial class Diagnosis : Form
    {
        private DBConnect dbConnect = new DBConnect();
        private bool isLoading = true;
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            Medicine obj = new Medicine();
            obj.Show(); this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserLogin obj = new UserLogin();
            obj.Show();
            this.Hide();
        }
        void Populate()
        {
            
            string query = "SELECT DiagnosisId, PatientId, PatientName, Medicine, Symptoms, Diagnosis FROM DiagnosisTbl";
            DGVDiagnosis.DataSource = dbConnect.GetData(query);

            
            DGVDiagnosis.Columns["DiagnosisId"].HeaderText = "Diagnosis ID";
            DGVDiagnosis.Columns["PatientId"].HeaderText = "Patient ID";
            DGVDiagnosis.Columns["PatientName"].HeaderText = "Patient Name";
            DGVDiagnosis.Columns["Symptoms"].HeaderText = "Symptoms";
            DGVDiagnosis.Columns["Diagnosis"].HeaderText = "Diagnosis";

        }
            
        
      
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDiagnosisId.Text) ||
                    string.IsNullOrWhiteSpace(txtPName1.Text) ||
                    string.IsNullOrWhiteSpace(txtSymptoms.Text) ||
                    string.IsNullOrWhiteSpace(txtDiagnosis.Text) ||
                    string.IsNullOrWhiteSpace(txtMedicine.Text) ||
                    cmbDocId.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Information! Fill All Details Carefully");
                    return;
                }

                int diagnosisId;
                if (!int.TryParse(txtDiagnosisId.Text, out diagnosisId))
                {
                    MessageBox.Show("Diagnosis ID must be a valid number.");
                    return;
                }

                int patientId;
                if (!int.TryParse(CbPatientId.SelectedValue.ToString(), out patientId))
                {
                    MessageBox.Show("Invalid Patient ID.");
                    return;
                }

                int doctorId;
                if (!int.TryParse(cmbDocId.SelectedValue.ToString(), out doctorId))
                {
                    MessageBox.Show("Invalid Doctor ID.");
                    return;
                }

                string query = "INSERT INTO DiagnosisTbl (DiagnosisId, PatientId, PatientName, Medicine, Symptoms, Diagnosis) VALUES (@DiagnosisId, @PatientId, @PatientName, @Medicine, @Symptoms, @Diagnosis)";
                SqlParameter[] parameters = {
            new SqlParameter("@DiagnosisId", diagnosisId),
            new SqlParameter("@PatientId", patientId),
            new SqlParameter("@PatientName", txtPName1.Text),
            new SqlParameter("@Medicine", txtMedicine.Text),
            new SqlParameter("@Symptoms", txtSymptoms.Text),
            new SqlParameter("@Diagnosis", txtDiagnosis.Text)
        };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Diagnosis Added Successfully");

                string docPatientQuery = "INSERT INTO DocPatient (DoctorId, PatientId, PatientName, Diagnosis, Medicine, Symptoms) VALUES (@DoctorId, @PatientId, @PatientName, @Diagnosis, @Medicine, @Symptoms)";
                SqlParameter[] docPatientParameters = {
            new SqlParameter("@DoctorId", doctorId),
            new SqlParameter("@PatientId", patientId),
            new SqlParameter("@PatientName", txtPName1.Text),
            new SqlParameter("@Diagnosis", txtDiagnosis.Text),
            new SqlParameter("@Medicine", txtMedicine.Text),
            new SqlParameter("@Symptoms", txtSymptoms.Text)
        };

                dbConnect.ExecuteQuery(docPatientQuery, docPatientParameters);

                
                foreach (Form form in Application.OpenForms)
                {
                    if (form is DiagnosisReport)
                    {
                        ((DiagnosisReport)form).LoadDiagnosisReport(); 
                        break;
                    }
                }

                Populate();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("The Diagnosis ID already exists. Please use a different ID.");
                }
                else
                {
                    MessageBox.Show("An error occurred while adding the diagnosis. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDiagnosisId.Text) ||
                    string.IsNullOrWhiteSpace(txtPName1.Text) ||
                    string.IsNullOrWhiteSpace(txtSymptoms.Text) ||
                    string.IsNullOrWhiteSpace(txtDiagnosis.Text) ||
                    string.IsNullOrWhiteSpace(txtMedicine.Text) ||
                    cmbDocId.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Information! Fill All Details Carefully");
                    return;
                }

                int diagnosisId;
                if (!int.TryParse(txtDiagnosisId.Text, out diagnosisId))
                {
                    MessageBox.Show("Diagnosis ID must be a valid number.");
                    return;
                }

                int patientId;
                if (!int.TryParse(CbPatientId.SelectedValue.ToString(), out patientId))
                {
                    MessageBox.Show("Invalid Patient ID.");
                    return;
                }

                int doctorId;
                if (!int.TryParse(cmbDocId.SelectedValue.ToString(), out doctorId))
                {
                    MessageBox.Show("Invalid Doctor ID.");
                    return;
                }

                string query = "UPDATE DiagnosisTbl SET PatientId = @PatientId, PatientName = @PatientName, Medicine = @Medicine, Symptoms = @Symptoms, Diagnosis = @Diagnosis WHERE DiagnosisId = @DiagnosisId";
                SqlParameter[] parameters = {
            new SqlParameter("@DiagnosisId", diagnosisId),
            new SqlParameter("@PatientId", patientId),
            new SqlParameter("@PatientName", txtPName1.Text),
            new SqlParameter("@Medicine", txtMedicine.Text),
            new SqlParameter("@Symptoms", txtSymptoms.Text),
            new SqlParameter("@Diagnosis", txtDiagnosis.Text)
        };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Diagnosis Updated Successfully");

                string docPatientQuery = "UPDATE DocPatient SET PatientId = @PatientId, PatientName = @PatientName, Diagnosis = @Diagnosis, Medicine = @Medicine, Symptoms = @Symptoms WHERE PatientId = @PatientId AND DoctorId = @DoctorId";
                SqlParameter[] docPatientParameters = {
            new SqlParameter("@PatientId", patientId),
            new SqlParameter("@PatientName", txtPName1.Text),
            new SqlParameter("@Diagnosis", txtDiagnosis.Text),
            new SqlParameter("@Medicine", txtMedicine.Text),
            new SqlParameter("@Symptoms", txtSymptoms.Text),
            new SqlParameter("@DoctorId", doctorId)
        };

                dbConnect.ExecuteQuery(docPatientQuery, docPatientParameters);

                
                foreach (Form form in Application.OpenForms)
                {
                    if (form is DiagnosisReport)
                    {
                        ((DiagnosisReport)form).LoadDiagnosisReport(); 
                        break;
                    }
                }

                Populate();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627)
                {
                    MessageBox.Show("The Diagnosis ID already exists. Please use a different ID.");
                }
                else
                {
                    MessageBox.Show("An error occurred while updating the diagnosis. Please try again.");
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
                if (string.IsNullOrWhiteSpace(txtDiagnosisId.Text))
                {
                    MessageBox.Show("Enter Diagnosis Id");
                    return;
                }

                int diagnosisId;
                if (!int.TryParse(txtDiagnosisId.Text, out diagnosisId))
                {
                    MessageBox.Show("Diagnosis ID must be a valid number.");
                    return;
                }

                
                string checkQuery = "SELECT COUNT(*) FROM DiagnosisTbl WHERE DiagnosisId = @DiagnosisId";
                SqlParameter[] checkParameters = {
            new SqlParameter("@DiagnosisId", diagnosisId)
        };
                int count = (int)dbConnect.GetData(checkQuery, checkParameters).Rows[0][0];

                if (count == 0)
                {
                    MessageBox.Show("Diagnosis ID does not exist.");
                    return;
                }

                
                string getPatientIdQuery = "SELECT PatientId FROM DiagnosisTbl WHERE DiagnosisId = @DiagnosisId";
                SqlParameter[] getPatientIdParameters = {
            new SqlParameter("@DiagnosisId", diagnosisId)
        };
                DataTable patientIdTable = dbConnect.GetData(getPatientIdQuery, getPatientIdParameters);
                if (patientIdTable.Rows.Count == 0)
                {
                    MessageBox.Show("Could not find Patient ID associated with this Diagnosis ID.");
                    return;
                }
                int patientId = (int)patientIdTable.Rows[0]["PatientId"];

                
                string query = "DELETE FROM DiagnosisTbl WHERE DiagnosisId = @DiagnosisId";
                SqlParameter[] parameters = {
            new SqlParameter("@DiagnosisId", diagnosisId)
        };

                dbConnect.ExecuteQuery(query, parameters);
                MessageBox.Show("Diagnosis Deleted Successfully");

                
                string docPatientQuery = "DELETE FROM DocPatient WHERE PatientId = @PatientId";
                SqlParameter[] docPatientParameters = {
            new SqlParameter("@PatientId", patientId)
        };

                dbConnect.ExecuteQuery(docPatientQuery, docPatientParameters);

                
                foreach (Form form in Application.OpenForms)
                {
                    if (form is DiagnosisReport)
                    {
                        ((DiagnosisReport)form).LoadDiagnosisReport(); 
                        break;
                    }
                }

                Populate();
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547)
                {
                    MessageBox.Show("This diagnosis cannot be deleted because it is linked to other records.");
                }
                else
                {
                    MessageBox.Show("An error occurred while deleting the diagnosis. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }
        

        private void btnReload_Click(object sender, EventArgs e)
        {
            Populate();
            ResetFields();


        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {

            Populate();
            PopulatePatientIds();
            PopulateDoctorIds();
            isLoading = false;

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
        private void PopulatePatientIds()
        {
            string query = "SELECT PatientId FROM PatientTbl";
            DataTable dt = dbConnect.GetData(query);
            CbPatientId.DataSource = dt;
            CbPatientId.DisplayMember = "PatientId";
            CbPatientId.ValueMember = "PatientId";
            CbPatientId.SelectedIndex = -1; 
        }
        private void DGVDiagnosis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CbPatientId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return; 

            if (CbPatientId.SelectedValue != null)
            {
                int selectedPatientId;
                if (int.TryParse(CbPatientId.SelectedValue.ToString(), out selectedPatientId))
                {
                    string query = "SELECT PatientName FROM PatientTbl WHERE PatientId = @PatientId";
                    SqlParameter[] parameters = {
                        new SqlParameter("@PatientId", selectedPatientId)
                    };

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
                else
                {
                    MessageBox.Show("Invalid Patient ID selected.");
                }
            }

        }
        private void ResetFields()
        {
            txtDiagnosisId.Text = string.Empty;
            txtPName1.Text = string.Empty;
            txtSymptoms.Text = string.Empty;
            txtDiagnosis.Text = string.Empty;
            txtMedicine.Text = string.Empty;

            if (CbPatientId.Items.Count > 0)
            {
                CbPatientId.SelectedIndex = 0;
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPName1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Hide();
        }

        private void cmbDocId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return; 

            if (cmbDocId.SelectedValue != null)
            {
                int selectedDocId;
                if (int.TryParse(cmbDocId.SelectedValue.ToString(), out selectedDocId))
                {
                    string query = "SELECT DocName FROM DoctorsTable WHERE DocId = @DocId";
                    SqlParameter[] parameters = {
                        new SqlParameter("@DocId", selectedDocId)
                    };

                    DataTable dt = dbConnect.GetData(query, parameters);
                    if (dt.Rows.Count > 0)
                    {
                        txtDocName.Text = dt.Rows[0]["DocName"].ToString(); 
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Doctor ID selected.");
                }
            }
        }

        private void txtDocName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
