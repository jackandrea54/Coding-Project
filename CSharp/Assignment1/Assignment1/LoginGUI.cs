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
            string password = configuration.GetSection("AdminCredentials")["Password"];

            //Check user and password for appsetting.json file
            if(inputUser.Text == user && inputPassword.Text == password) {
                CarGUI_Admin carAdmin = new CarGUI_Admin();
                carAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login failed");
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
