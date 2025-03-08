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
    public partial class UserLogin : Form
    {
        private DBConnect dbConnect = new DBConnect();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLogin page = new AdminLogin();
            page.Show();
            this.Hide();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                if (username.StartsWith("100") || username.StartsWith("1"))
                {
                    string doctorQuery = "SELECT * FROM DoctorsTable WHERE DocId = @Username AND Password = @Password";
                    SqlParameter[] doctorParameters = {
                        new SqlParameter("@Username", username),
                        new SqlParameter("@Password", password)
                    };

                    var doctorResult = dbConnect.GetData(doctorQuery, doctorParameters);

                    if (doctorResult.Rows.Count > 0)
                    {
                        MessageBox.Show("Doctor login successful!");
                        
                        DoctorDashBoard doctorForm = new DoctorDashBoard(username);
                        doctorForm.Show();
                        this.Hide();
                        return;
                    }
                }
                
                else if (username.StartsWith("200") || username.StartsWith("2"))
                {
                    string adminQuery = "SELECT * FROM Admin WHERE AdminId = @Username AND Password = @Password";
                    SqlParameter[] adminParameters = {
                        new SqlParameter("@Username", username),
                        new SqlParameter("@Password", password)
                    };

                    var adminResult = dbConnect.GetData(adminQuery, adminParameters);

                    if (adminResult.Rows.Count > 0)
                    {
                        MessageBox.Show("Admin login successful!");
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        this.Hide();
                        return;
                    }
                }

                MessageBox.Show("Invalid username or password.");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("An error occurred while trying to log in. Please try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAdminRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminRegister page = new AdminRegister();
            page.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
