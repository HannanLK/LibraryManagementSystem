using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.FORMS
{
    public partial class Login_Form : Form
    {

        public Login_Form()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            // Check if the entered credentials are correct
            if (IsValidCredentials(username, password))
            {
                // Show the dashboard form if credentials are correct
                Dashboard_Form dashboardForm = new Dashboard_Form();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                // Show a message box for invalid credentials
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidCredentials(string username, string password)
        {
            // Hardcoded validation for demo purposes
            return (username == "admin" && password == "admin");
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

        }
    }
}
