using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDocumentCardControl : UserControl {
        VehicleDocumentDto _document;

        public VehicleDocumentCardControl() {
            InitializeComponent();
        }

        public void Bind(VehicleDocumentDto document) {
            _document = document;
            IntializeData();
        }

        private void IntializeData() {
            labelType.Text = _document.Category;
            labelTitle.Text = _document.Title;
            labelExpirationDate.Text = _document.ExpirationDate?.ToString("d") ?? "N/A";

            if(_document.Category != "Required Renewal") {
                btnRenew.Visible = false;
            }
        }

    }
}
