using System.Drawing;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Forms;

namespace VehicleManagementSystem.View.Forms {
    public partial class frmVehicleDetails : Form {
        VehicleDto _vehicle;

        public frmVehicleDetails(VehicleDto vehicle) {
            _vehicle = vehicle;

            InitializeComponent();
            LoadUI();
            LoadVehicleInformation();
        }

        private void LoadVehicleInformation() {
            inputCategory.Text = _vehicle.Category;
            inputColor.Text = _vehicle.Color;
            inputManufacturer.Text = _vehicle.Manufacturer;
            inputModel.Text = _vehicle.Model;
            inputPlateNum.Text = _vehicle.LicensePlate;
            inputPurchasePrice.Text = "₱" +  _vehicle.PurchasePrice.ToString();
            inputSeatingCap.Text = _vehicle.SeatingCapacity.ToString();
            inputVehicleIdentification.Text = _vehicle.VIN;
            inputYearModel.Text = _vehicle.YearModel.ToString();

            inputPurchaseDate.Value = _vehicle.PurchaseDate;
            inputPurchaseDate.Enabled = false;
        }

        private void LoadUI() {
            labelSubHeader.Text = GetVehicleSubHeader(_vehicle);
            pictureVehicle.Image = Helpers.GetVehicleImage(_vehicle.ImagePath);
            labelStatus.FillColor = Helpers.GetStatusColor(_vehicle.CurrentStatus);
            labelStatus.Text = _vehicle.CurrentStatus.ToString();
            labelStatus.Location = new Point(labelSubHeader.Right + 5, labelSubHeader.Location.Y);
        }

        private string GetVehicleSubHeader(VehicleDto vehicle) {
            return $"{vehicle.Manufacturer} - {vehicle.Model} {vehicle.YearModel}";
        }

        // Automatically add Double Buffering to the whole form
        // Boilerplate From Stackoverflow
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void backBtn_Click(object sender, System.EventArgs e) {
            NavigationHelper.OpenForm(new frmVehicleManagement());
        }
    }
}
