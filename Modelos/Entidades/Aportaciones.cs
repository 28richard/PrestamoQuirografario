using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Aportaciones
    {
        public int AportacionesId { get; set; }
        public float Salario { get; set; }
        public string NombreEmpresa { get; set; }
        public string RucEmpresa { get; set; }
        public float AporteEmpresa { get; set; }    
        public float AporteAfiliado { get; set; }
        public DateTime FechaAportacion { get; set; }
        public string EstadoAportacion { get; set; }


        //Relacion con solicitante 
        public Solicitante Solicitante { get; set; }
        public int SolicitanteId { get; set; }

        //relacion con fondos de cesantia
        public FondosCesantia FondosCesantia { get; set; }
      //  public int FondosCesantiaId { get; set; }

        //relacion con fondos de reserva
        public FondosReserva FondosReserva { get; set; }
       // public int FondosReservaId { get; set; }

        //relacion con fondos de cesantia
        public Garantias Garantias { get; set; }
        //public int GarantiasId { get; set; }
    }
}