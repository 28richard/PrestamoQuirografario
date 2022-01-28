using Modelo.Entidades;
using ModeloDB;
using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista de solicitantes
            Solicitante Richard = new Solicitante() { Nombre="Richard", Apellido="Herrera", Cedula="1724664873",Direccion="Beaterio",Telefono=0993929753,Correo="herrerap45@gmail.com"};
            Solicitante Guissel = new Solicitante() { Nombre = "Guissel", Apellido = "Sanchez",Cedula = "1724664873", Direccion = "Beaterio", Telefono = 0993929753, Correo = "herrerap45@gmail.com" };
            Solicitante Marlon = new Solicitante() { Nombre = "Marlon", Apellido = "Quimbita", Cedula = "1724664873", Direccion = "Beaterio", Telefono = 0993929753, Correo = "herrerap45@gmail.com" };

            //lista de aportaciones
            //Aportaciones Richard
             Aportaciones AporteRic1 = new Aportaciones() 
            { 
                Solicitante=Richard,
                Salario=425,
                NombreEmpresa="Bunky",
                RucEmpresa="1724664873001",
                AporteEmpresa=44,
                AporteAfiliado=38,
                FechaAportacion=new DateTime(2022,1,27),
                EstadoAportacion="Pagado"
            };
            Aportaciones AporteG1 = new Aportaciones()
            {
                Solicitante = Guissel,
                Salario = 430,
                NombreEmpresa = "MEGACOB",
                RucEmpresa = "1725418873001",
                AporteEmpresa = 45,
                AporteAfiliado = 39,
                FechaAportacion = new DateTime(2022, 1, 27),
                EstadoAportacion = "Pagado"
            };
            Repositorio repos = new Repositorio();
            repos.Aportaciones.Add(AporteRic1);
            repos.Aportaciones.Add(AporteG1);
            repos.SaveChanges();
        }

    
    }
}
