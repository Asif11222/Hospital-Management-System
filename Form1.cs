using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }
        int startPoint;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            ProgressBar1.Value = startPoint;
            if (ProgressBar1.Value == 100)
            {
                ProgressBar1.Value = 0;
                timer1.Stop();
                UserLogin page = new UserLogin();
                page.Show();
                this.Hide();
            }
        }

        private void CircleProgressIndicator_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
