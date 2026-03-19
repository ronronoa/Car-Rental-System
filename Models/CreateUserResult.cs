using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Models
{
    public class CreateUserResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int UserId { get; set; }
        public string TemporaryPassword { get; set; }

        public static implicit operator int(CreateUserResult v)
        {
            return v?.UserId ?? 0;
        }
    }
}
