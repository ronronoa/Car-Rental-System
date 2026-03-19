using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Data.Enums {
    internal class VehicleDocumentEnums {
        public enum Type {
            Permanent, 
            FixedExpiry, 
            RequiredRenewal,
        }

        public enum IssuingAuthority {
            LTO,
            DOTr,
            MMDA,
            DENR
        }

    }
}
