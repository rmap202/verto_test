using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app.Models
{
    public class FileModel
    {
        [Required]
        public string FileName { get; set; }

        [Required]
        public IFormFile File { get; set; }
    }
}