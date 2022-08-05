using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper.Constants
{
    public class ImageHelperMessages
    {
        public static List<string> Extensions = new() { ".jpg", ".png", ".jpeg" };
        public static string WrongExtension = "Hatalı dosya uzantısı";
        public static string FileDoesNotExist = "Dosya bulunamadı";

    }
}
