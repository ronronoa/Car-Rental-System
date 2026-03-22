using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Helpers;

namespace VehicleManagementSystem.Helpers
{
    public class UserImageService
    {
        private readonly string _folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserImages");
        public UserImageService()
        {
            if (!Directory.Exists(_folder))
                Directory.CreateDirectory(_folder);

            Console.WriteLine($"Image saved to {_folder}");
        }

        public string Save(Image image)
        {
            string fileName = $"{Guid.NewGuid()}.png";
            string fullPath = Path.Combine(_folder, fileName);

            using (Image resized = ImageHelper.Resize(image, 256, 256))
            {
                resized.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
            }

            return fileName;
        }

        public bool Delete(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName)) 
                return true;

            string fullPath = Path.Combine(_folder, fileName);

            if (File.Exists(fullPath))
            {
                try
                {
                    File.Delete(fullPath);
                    return true;
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Failed to delete image file {fileName}: {ex.Message}");
                    return false;
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine($"Access denied when deleting image file {fileName}: {ex.Message}");
                    return false;
                }
            }

            return true;
        }

        public string GetFullPath(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName)) return null;

            return Path.Combine(_folder, fileName);
        }
    }
}
