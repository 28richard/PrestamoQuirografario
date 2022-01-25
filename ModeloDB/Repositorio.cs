using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDB
{
    public class Repositorio: DbContext
    {

        //Configuracion de las entidades
        public DbSet<Solicitante> Solicitantes { get; set; }
        public DbSet<Aportaciones> Aportaciones { get; set; }
        public DbSet<FondosReserva> FondosReservas { get; set; }
        public DbSet<FondosCesantia> FondosCesantias { get; set; }
        public DbSet<Garantias> Garantias { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
    }
}
