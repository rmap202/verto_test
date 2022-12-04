using app.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace app.Controllers
{
    public class FileController : Controller
    {
        string _fileLocation = "wwwroot/Files";

        // POST: Upload a file to the DB.
        [HttpPost]
        public JsonResult UploadFile(FileModel file)
        {
            if (ModelState.IsValid)
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(), _fileLocation);

                // Create a folder if it exists.
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                FileInfo fileInfo= new FileInfo(file.FileName);
                string fileName = file.FileName + fileInfo.Extension;

                string fullFileName = Path.Combine(path, fileName);

                using (var stream = new FileStream(fullFileName, FileMode.Create))
                {
                    file.File.CopyTo(stream);
                }
            }

            return Json("");
        }
    }
}