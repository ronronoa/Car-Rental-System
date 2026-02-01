using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Interfaces {
    public interface IVehicleManagementView {
        void DisplayVehicles(List<VehicleDto> vehicles);
        void ShowError(string message);
    }
}
