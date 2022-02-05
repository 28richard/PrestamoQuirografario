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

        
        //Configuracion de la conexion
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-3AQ862B; initial catalog= IESS; trusted_connection=true;");
        }
        

        //configurar el modelo de objetos
        protected override void OnModelCreating(ModelBuilder model) 
        {
            //configuracion de aportaciones
            // - Aportaciones y solicitante
            model.Entity<Aportaciones>()
               .HasOne(aportaciones => aportaciones.Solicitante)
               .WithMany(solicitante => solicitante.ListaAportaciones)
               .HasForeignKey(aportaciones => aportaciones.SolicitanteId);

            // relacion uno a uno solicitante con prestamo
            model.Entity<Solicitante>()
              .HasOne(solicitante => solicitante.Prestamo)
              .WithOne(prestamo => prestamo.Solicitante)
              .HasForeignKey<Solicitante>(solicitante => solicitante.PrestamoId);

            // - Aportaciones y fondos de cesantia
            model.Entity<FondosCesantia>()
               .HasOne(fondosCesantia => fondosCesantia.Aportaciones)
               .WithMany(aportaciones => aportaciones.FondosCesantia)
               .HasForeignKey(fondosCesantia => fondosCesantia.AportacionesId);

            // - Aportaciones y fondos de reserva
            model.Entity<FondosReserva>()
               .HasOne(fondosReserva => fondosReserva.Aportaciones)
               .WithMany(aportaciones => aportaciones.FondosReserva)
               .HasForeignKey(fondosReserva => fondosReserva.AportacionesId);

            // - Aportaciones y Garantia
            model.Entity<Garantias>()
               .HasOne(garantias => garantias.Aportaciones)
               .WithMany(aportaciones => aportaciones.Garantias)
               .HasForeignKey(garantias => garantias.AportacionesId);

            // - Garantias y fondos de cesantia
            model.Entity<Garantias>()
               .HasOne(garantias => garantias.FondosCesantia)
               .WithMany(fondosCesantia => fondosCesantia.Garantias)
               .HasForeignKey(garantias => garantias.FondosCesantiaId);

            // - Garantias y fondos de reserva
            model.Entity<Garantias>()
               .HasOne(garantias => garantias.FondosReserva)
               .WithMany(fondosReserva => fondosReserva.Garantias)
               .HasForeignKey(garantias => garantias.FondosReservaId);


        }

    }
}
