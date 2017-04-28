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
    [Table("Content")]
    public class Content
    {
        [Key]
        public int ContentId { get; set; }

        public string Title { get; set; }

        public string Details { get; set; }
    }
}
