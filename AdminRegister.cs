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
    public partial class AdminRegister : Form
    {
        DBConnect db = new DBConnect();
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {

            string adminId = textUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(adminId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!adminId.StartsWith("2001") && !adminId.StartsWith("2"))
            {
                MessageBox.Show("Admin ID must start from 2001.");
                return;
            }

            try
            {
                string query = "INSERT INTO Admin (AdminId, Password) VALUES (@AdminId, @Password)";
                SqlParameter[] parameters =
                {
            new SqlParameter("@AdminId", adminId),
            new SqlParameter("@Password", password)
        };

                db.ExecuteQuery(query, parameters);

                string userQuery = "INSERT INTO Users (AdminId, AdminPassword) VALUES (@AdminId, @AdminPassword)";
                SqlParameter[] userParameters = {
            new SqlParameter("@AdminId", adminId),
            new SqlParameter("@AdminPassword", password)
        };

                db.ExecuteQuery(userQuery, userParameters);

                MessageBox.Show("Registration successful! You can login now.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                UserLogin loginForm = new UserLogin();
                this.Hide();
                loginForm.Show();
            }
            catch (SqlException sqlEx)
            {
                
                if (sqlEx.Number == 2627) 
                {
                    MessageBox.Show("The Admin ID is already taken. Please choose a different ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            UserLogin page = new UserLogin();
            page.Show();
            this.Hide();
        }
    }
}
