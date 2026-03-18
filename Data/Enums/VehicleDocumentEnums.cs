using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Data.Enums {
    internal class VehicleDocumentEnums {
        public enum Type {
            Registration,
            Insurance,
            SafetyInspection,
            EmissionTest,
            CommercialPermit,
            TaxiLicense,
            RentalPermit,
            WeightCertificate,
            ImportDocuments,
            WarrantyDocument,
            ServiceContract,
            Other
        }

        public enum IssuingAuthority {
            LTO,
            DOTr,
            MMDA,
            DENR
        }

    }
}
