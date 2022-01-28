using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class FondosReserva
    {
        public int FondosReservaId { get; set; }
        public float PorcentajeFR { get; set; }
        public float AportacionFR { get; set; }

        //Relacion con Aportaciones
        public Aportaciones Aportaciones { get; set; }
        public int ApotacionesId  { get; set; }
    }
}
