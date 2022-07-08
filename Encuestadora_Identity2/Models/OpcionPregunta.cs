using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class OpcionPregunta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int OpcionPreguntaId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo opción")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public virtual string tituloOpcion { get; set; }

        //[Display(Name = "Selección")]
        //public virtual bool opcionSeleccionada { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //foreign key PREGUNTA
        public virtual int PreguntaId { get; set; }
        //reference navigation property de PREGUNTA
        [ForeignKey("PreguntaId")]
        public virtual Pregunta Pregunta { get; set; }

        
    }
}
