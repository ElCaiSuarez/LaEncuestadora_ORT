﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class Encuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int EncuestaId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo encuesta")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public virtual string tituloEncuesta { get; set; }

        [Display(Name = "Fecha creación")]
        [DataType(DataType.Date)]
        public virtual DateTime datetimeCreacionEncuesta { get; set; }

        [Display(Name = "Fecha vencimiento")]
        [DataType(DataType.Date)]
        public virtual DateTime datetimeVencimientoEncuesta { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //RELACION 1 a 1 CON PuntosEncuesta
        [Display(Name = "Puntos encuesta")]
        [EnumDataType(typeof(PuntosEncuesta))]
        public virtual PuntosEncuesta puntosEncuesta { get; set; }

        //reference navigation property de CLIENTE
        public virtual Cliente Cliente { get; set; }

        //RELACION 1 a N CON PREGUNTA (ENCUESTA es la entidad principal y PREGUNTA es la entidad dependiente)
        [Display(Name = "Preguntas")]
        public virtual ICollection<Pregunta> preguntas { get; set; }
        
        //CAMBIAMOS A ENCUESTA RESPONDIDA
        ////RELACION N a N CON USUARIO
        //[Display(Name = "EncuestasUsuarios")]
        //public ICollection<EncuestasUsuarios> EncuestasUsuarios { get; set; }




    }
}
