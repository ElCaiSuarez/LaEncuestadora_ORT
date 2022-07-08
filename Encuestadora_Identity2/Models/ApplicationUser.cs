using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Encuestadora_Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Custom Tag")]
        [MaxLength(80, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public virtual string CustomTag { get; set; }
        
    }
}
