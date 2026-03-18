using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem.View.Modals {
    public partial class AddNewVehicleMaintenanceModal : Form {
        public AddNewVehicleMaintenanceModal(string PlateNumber) {
            InitializeComponent();

            this.ControlBox = false;
            labelHeader.Text = "Adding new document to " + PlateNumber;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
