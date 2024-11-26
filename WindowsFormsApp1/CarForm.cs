using System;
using System.Windows.Forms;

namespace MyTransportApp.Forms
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Логика сохранения информации о машине...
            this.Close();
        }
    }
}
