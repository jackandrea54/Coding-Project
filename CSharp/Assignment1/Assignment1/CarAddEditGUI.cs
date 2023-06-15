using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Assignment1
{
    public partial class CarAddEditGUI : Form
    {
        //private Car _selectedCar;
        private int carId;
        //public int CarId { get; set; }
        public CarAddEditGUI(int carId)
        {   

            Models.Car selectedCar = new Models.Car();

            InitializeComponent();
            this.carId = carId;
            //_selectedCar = selectedCar;

           /* string colorName = selectedCar.Color.ToLower();
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

            
            inputCarId.Text = selectedCar.CarId.ToString();
            inputMake.Text = selectedCar.Make;
            inputColor.Text = selectedCar.Color.ToString();
            diplayColor.BackColor = color;
            inputPetName.Text = selectedCar.PetName;*/

        }

        public event EventHandler CarAdded;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CarAddEditGUI_Load(object sender, EventArgs e)
        {
            if (carId != -1)
            {   
                CarsContext _context = new CarsContext();
                // Retrieve the car from the database based on the carId
                Car car = _context.Cars.FirstOrDefault(c => c.CarId == carId);
                if (car != null)
                {
                    // Populate the form fields with the car's information for editing
                    inputCarId.Text = car.CarId.ToString();
                    inputMake.Text = car.Make;
                    inputColor.Text = car.Color;
                    inputPetName.Text = car.PetName;
                }
            }
            else
            {
                // Clear the form fields for adding a new car
                inputCarId.Text = "-1";
                inputMake.Text = string.Empty;
                inputColor.Text = string.Empty;
                inputPetName.Text = string.Empty;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   
            if (ValidateInput())
            {
                if (carId == -1 || carId == 0)
                {
                    // Get the car details from the form controls
                    string carMake = inputMake.Text;
                    string carColor = inputColor.Text;
                    string carPetName = inputPetName.Text;

                    // Create a new car object
                    Car newCar = new Car
                    {
                        Make = carMake,
                        Color = carColor,
                        PetName = carPetName
                    };

                    // Add the new car to the database using Entity Framework
                    using (var context = new CarsContext())
                    {
                        context.Cars.Add(newCar);
                        context.SaveChanges();
                    }

                    MessageBox.Show("A new Car added!");

                    // Raise the CarAdded event
                    CarAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
                else
                {   
                    // Update an existing car
                    CarsContext _context = new CarsContext();
                    Car updatedCar = _context.Cars.FirstOrDefault(c => c.CarId == carId);
                    if (updatedCar != null)
                    {
                        updatedCar.Make = inputMake.Text;
                        updatedCar.Color = inputColor.Text;
                        updatedCar.PetName = inputPetName.Text;
                        _context.Cars.Update(updatedCar);
                        int numUpdated = _context.SaveChanges();

                        if (numUpdated > 0)
                        {
                            MessageBox.Show("Car updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No changes were made to the car.");
                        }
                    }

                    CarAdded?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
            }

            // Raise the DataUpdated event
            CarAdded?.Invoke(this, EventArgs.Empty);

            // Close the form
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(inputMake.Text))
            {
                MessageBox.Show("Please enter a valid car make.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(inputColor.Text))
            {
                MessageBox.Show("Please enter a valid car color.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(inputPetName.Text))
            {
                MessageBox.Show("Please enter a valid car pet name.");
                return false;
            }

            return true;
        }

    }
}
