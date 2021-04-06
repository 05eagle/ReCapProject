using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.Helper
{
    public class FileHelper
    {
        public static string Add(IFormFile image)
        {
            string directory = Environment.CurrentDirectory + @"\Images";
            string fileName = CreateNewFileName(image.FileName);
            string path = Path.Combine(directory);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                image.CopyTo(stream);
            }

            
            return fileName;
        }

        public static string CreateNewFileName(string fileName)
        {
            string[] file = fileName.Split('.');
            string extension = file[1];
            string newFileName = string.Format(@"{0}." + extension, Guid.NewGuid()); return newFileName;
        }


        public static string Update(string sourcePath, IFormFile file)
        {
            var result = newPath(file);
            using (var stream = new FileStream(result.newPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            File.Delete(sourcePath);

            return result.Path2;
        }

        public static IResult Delete(string path)
        {
            File.Delete(path);
            return new SuccessResult();
        }

        public static (string newPath, string Path2) newPath(IFormFile file)
        {
            FileInfo ff = new FileInfo(file.FileName);
            string fileExtension = ff.Extension;
            var newFileName = Guid.NewGuid().ToString("N") + fileExtension;
            string path12 = @"\Images\";
            string result = Environment.CurrentDirectory + path12 + newFileName;
            return (result, $"\\Images\\{newFileName}");
        }
    }
}
