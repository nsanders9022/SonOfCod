using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace SonOfCod.Models
{
    [Table("Images")]
    public class Image
    {
        [Key]
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
    }
}
