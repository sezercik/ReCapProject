using Core.Results;
using Core.Utilities.Helpers.FileHelper.Constants;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class ImageHelperManager : IFileHelper
    {
        public IResult Delete(string filePath)
        {
            var result = CheckIfImageFileExists(filePath);
            if (!result)
            {
                return new ErrorResult();
            }
            DeleteImageFile(filePath);
            return new SuccessResult();
        }

        public IResult Update(IFormFile file, string filePath, string root)
        {
            var result = CheckIfImageFileExists(filePath);
            if (!result)
            {
                return new ErrorResult();
            }
            DeleteImageFile(filePath);
            return Upload(file, root);
        }


        public IResult Upload(IFormFile file, string root)
        {
            var fileExists = CheckIfFileExists(file);
            if(fileExists.Message != null)
            {
                return new ErrorResult(fileExists.Message);
            }

            var extension = Path.GetExtension(file.FileName);
            var extensionValid = ChechIfImageExtensionValid(extension);

            string guid = Guid.NewGuid().ToString(); 
            string filePath = guid + extension;

            if (extensionValid.Message != null)
            {
                return new ErrorResult(extensionValid.Message);
            }

            var directoryCheck = CheckIfDirectoryExits(root);
            if (!directoryCheck)
            {
                Directory.CreateDirectory(root);
            }

            CreateImageFile(root + filePath, file);
            return new SuccessResult(filePath);
        }

        private void CreateImageFile(string directory, IFormFile file)
        {
            using (FileStream fileStream = File.Create(directory))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();//dosyayı oluşturur ve kalanları siler
            }
        }

        private bool CheckIfDirectoryExits(string root)
        {
            return Directory.Exists(root);
        }

        private IResult ChechIfImageExtensionValid(string extension)
        {
            foreach (var ext in ImageHelperMessages.Extensions)
            {
                if(extension == ext)
                {
                    return new SuccessResult();
                }
            }
            return new ErrorResult(ImageHelperMessages.WrongExtension);
        }

        private IResult CheckIfFileExists(IFormFile file)
        {
            if(file != null && file.Length > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult(ImageHelperMessages.FileDoesNotExist);//constanttan çek
        }

        private static bool CheckIfImageFileExists(string filePath)
        {
            return File.Exists(filePath);
        }
        private static void DeleteImageFile(string filePath)
        {
            File.Delete(filePath);
        }

    }
}
