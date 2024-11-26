using System.Windows.Forms;

namespace MyTransportApp
{
    public partial class MainForm : Form
    {
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtLicensePlate;
        private Button btnAddCar;
        private DataGridView dgvCars;
        private TextBox txtSearch;

        public MainForm()
        {
            InitializeComponent();
            InitializeControls(); // Метод для инициализации элементов управления
        }

        private void InitializeControls()
        {
            // Пример инициализации элементов управления (можно добавить настройки)
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtLicensePlate = new TextBox();
            btnAddCar = new Button();
            dgvCars = new DataGridView();
            txtSearch = new TextBox();

            // Добавьте ваши элементы управления на форму
            this.Controls.Add(txtMake);
            this.Controls.Add(txtModel);
            this.Controls.Add(txtYear);
            this.Controls.Add(txtLicensePlate);
            this.Controls.Add(btnAddCar);
            this.Controls.Add(dgvCars);
            this.Controls.Add(txtSearch);
        }
    }
}

