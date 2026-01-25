using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.Services.Interfaces {
    internal interface IVehicleService {
        void AddVehicle(Vehicle vehicle);
    }
}
