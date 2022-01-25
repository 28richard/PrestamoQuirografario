using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class FondosCesantia
    {
        public float PorcentajeFC { get; set; }
        public float AportacionFC { get; set; }

        //Relacion con Aportaciones
        public Aportaciones Salario { get; set; }
        public int ApotacionesId { get; set; }
    }
}
