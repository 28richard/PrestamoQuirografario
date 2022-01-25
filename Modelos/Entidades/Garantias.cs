using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Garantias
    {
        public int CantidadAportaciones { get; set; }
        public float TotalGarantias { get; set; }

        //Relacion con Aportaciones
        public Aportaciones salario { get; set; }

        //Relacion fondos de reserva
        public FondosReserva AportacionFR { get; set; }

        //Relacion fondos de cesantia
        public FondosReserva AportacionFC { get; set; }
    }
}
