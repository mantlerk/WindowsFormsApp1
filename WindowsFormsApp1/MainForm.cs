using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MyTransportApp.Models;
using MyTransportApp.Services;

namespace MyTransportApp
{
    public partial class MainForm : Form
    {
        private List<Car> allCars = new List<Car>();
        private DataService dataService = new DataService();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            PopulateDataGrid();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void LoadData()
        {
            (allCars, _, _) = dataService.LoadData();
        }

        private void PopulateDataGrid()
        {
            dgvCars.DataSource = allCars.ToList();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string make = txtMake.Text;
            string model = txtModel.Text;
            int year = int.Parse(txtYear.Text);
            string licensePlate = txtLicensePlate.Text;

            if (ValidateCarInput(make, model, year, licensePlate))
            {
                var car = new Car { Make = make, Model = model, Year = year, LicensePlate = licensePlate };
                allCars.Add(car);
                dataService.SaveData(allCars, new List<Driver>(), new List<Client>());
                PopulateDataGrid();
            }
        }

        private bool ValidateCarInput(string make, string model, int year, string licensePlate)
        {
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model) ||
                year < 1886 || string.IsNullOrWhiteSpace(licensePlate))
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно.");
                return false;
            }
            return true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            var filteredCars = allCars.Where(c => c.Make.ToLower().Contains(searchTerm) ||
                                                   c.Model.ToLower().Contains(searchTerm)).ToList();
            dgvCars.DataSource = filteredCars;
        }
    }
}
