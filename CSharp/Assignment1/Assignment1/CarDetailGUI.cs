using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment1
{
    public partial class CarDetailsGUI : Form
    {
        //private Car _selectedCar;
        public CarDetailsGUI(Models.Car selectedCar)
        {
            InitializeComponent();

            //_selectedCar = selectedCar;

            string colorName = selectedCar.Color.ToLower();
            Color color;

            // Check if the color name is a known color
            if (Enum.TryParse(colorName, out KnownColor knownColor))
            {
                // Convert known color name to color
                color = Color.FromKnownColor(knownColor);
            }
            else
            {
                // Convert custom color name to color
                color = ColorTranslator.FromHtml(colorName);
            }

            displayId.Text = selectedCar.CarId.ToString();
            displayMake.Text = selectedCar.Make;
            displayTextColor.Text = selectedCar.Color.ToString();
            displayColor.BackColor = color;
            displayPetName.Text = selectedCar.PetName;
        }




        private void CarDetailsGUI_Load(object sender, EventArgs e)
        {

        }

        private void displayId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CarGUI carGUI = new CarGUI();
            carGUI.Close();
        }
    }
}
