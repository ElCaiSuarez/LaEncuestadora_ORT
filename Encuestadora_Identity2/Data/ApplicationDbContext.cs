using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Encuestadora_Identity.Models;

namespace Encuestadora_Identity2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> usuarios { get; set; }

        //public DbSet<Cliente> clientes { get; set; }

        //public DbSet<Encuesta> encuestas { get; set; }

        //public DbSet<Pregunta> preguntas { get; set; }

        //public DbSet<OpcionPregunta> opciones { get; set; }

        //public DbSet<EncuestaRespondida> encuestasRespondidas { get; set; }

    }
}
