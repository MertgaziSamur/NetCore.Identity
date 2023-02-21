using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Models
{
    public class RoleCreateModel
    {
        [Required(ErrorMessage = "Ad alanı gerklidir")]
        public string Name { get; set; }
    }
}
