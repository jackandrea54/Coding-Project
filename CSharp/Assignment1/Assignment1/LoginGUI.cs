using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Microsoft.Extensions.Configuration;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class LoginGUI : Form
    {
        private IConfigurationRoot configuration;
        public LoginGUI()
        {
            InitializeComponent();
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            configuration = builder.Build();
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = configuration.GetSection("AdminCredentials")["Name"];
            string pass = configuration.GetSection("AdminCredentials")["Password"];


            // Check if the entered username and password match the admin credentials
            if (inputUser.Text == user && inputPassword.Text == pass)
            {
                // Display the admin dashboard or perform any action you need
                CarGUI_Admin carAdmin = new CarGUI_Admin();
                carAdmin.ShowDialog();

                // Close the login form
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
