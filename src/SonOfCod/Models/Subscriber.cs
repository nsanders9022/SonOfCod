﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace SonOfCod.Models
{
    [Table("Subscribers")]
    public class Subscriber
    {
        [Key]
        public int SubscriberId { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }
    }
}
