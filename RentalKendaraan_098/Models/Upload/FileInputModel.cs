using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RentalKendaraan_098.Models.Upload
{
    public class FileInputModel
    {
        public static FileAccess Create { get; internal set; }
        public IFormFile FileToUpload { get; set; }
    }
}
