using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class FondosCesantia
    {
        public int FondosCesantiaId { get; set; }
        public float PorcentajeFC { get; set; }
        public float AportacionFC { get; set; }

        //Relacion con Aportaciones
        public Aportaciones Aportaciones { get; set; }
        public int AportacionesId { get; set; }

        public Garantias Garantias { get; set; }
    }
}
