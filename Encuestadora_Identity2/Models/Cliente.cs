using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Encuestadora_Identity.Models;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class Cliente : ApplicationUser
    {
        
        [Display(Name = "Nombre empresa")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public virtual string empresaCliente { get; set; }
        
        [Display(Name = "Cuit empresa")]
        [MaxLength(11, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public virtual string cuitCliente { get; set; }

        [Display(Name = "Domicilio empresa")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public virtual string domicilioCliente { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //RELACION 1 a 1 CON PrecioCliente
        [Display(Name = "Membresia")]
        [EnumDataType(typeof(PrecioCliente))]
        public virtual PrecioCliente precioCliente { get; set; }

        //RELACION 1 a N CON ENCUESTA (CLIENTE es la entidad principal y ENCUESTA es la entidad dependiente)
        [Display(Name = "Encuestas")]
        public virtual ICollection<Encuesta> encuestas { get; set; }



    }
}
