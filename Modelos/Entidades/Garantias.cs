using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Garantias
    {
        public int GarantiasId { get; set; }
        public int CantidadAportaciones { get; set; }
        public float TotalGarantias { get; set; }

        //Relacion con Aportaciones
        public Aportaciones Aportaciones { get; set; }
  

        //Relacion fondos de reserva
        public FondosReserva FondosReserva { get; set; }
 

        //Relacion fondos de cesantia
        public FondosCesantia fondosCesantia { get; set; }

    }
}
