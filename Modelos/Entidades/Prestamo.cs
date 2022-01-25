using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public float CantidadAprobada { get; set; }
        public int MesesPlazo { get; set; }
        public float Interes { get; set; }
        public float MontoTotalPagar { get; set; }
        public float CuotaMensual { get; set; }
        public DateTime FechaPago { get; set; }

        //Relacion con Solicitante
        public Solicitante Nombre { get; set; }
        public Solicitante Apellido { get; set; }
        public int SolicitanteId { get; set; }
    }
   

}
