using System;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Presenters;

namespace VehicleManagementSystem.Forms {
    public partial class frmVehicleManagement : Form {

        private vehicleManagementPresenter _presenter;

        public frmVehicleManagement() {
            InitializeComponent();
        }

        public void RenderVehicles() {

        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            NavigationHelper.OpenForm(new frmAddNewVehicle());
            frmMain.Instance.AddHeaderLabel(AppConfig.SubTitles.AddNewVehicle);
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

 
    }
}
