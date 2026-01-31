using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Classes {
    public static class Helpers {

        static public string SaveImageToAppData(string sourceImagePath, string subFolder) {
            string baseImagePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                AppConfig.ApplicationDataFolderName,
                "Images"
            );

            string targetPath = Path.Combine(baseImagePath, subFolder);

            Directory.CreateDirectory(targetPath);

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceImagePath);
            string destinationPath = Path.Combine(targetPath, fileName);

            File.Copy(sourceImagePath, destinationPath, true);

            return destinationPath;
        }

    }
}
