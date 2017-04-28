using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SonOfCod.ViewModels
{
    public class SubscriberViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        //[DataType(DataType.Password)]
        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
