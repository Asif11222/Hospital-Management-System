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
    public partial class AdminLogin : Form
    {
        DBConnect db = new DBConnect();
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbluser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin page = new UserLogin();
            page.Show();
            this.Hide();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string adminId = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(adminId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter Username and Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "SELECT COUNT(*) FROM Admin WHERE AdminId = @AdminId AND Password = @Password";
                SqlParameter[] parameters =
                {
            new SqlParameter("@AdminId", adminId),
            new SqlParameter("@Password", password)
        };

                DataTable dt = db.GetData(query, parameters);
                int count = Convert.ToInt32(dt.Rows[0][0]);

                if (count > 0)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminDashboard obj = new AdminDashboard();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
    }
}
