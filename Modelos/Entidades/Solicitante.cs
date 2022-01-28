using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Solicitante
    {
        public int SolicitanteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }

        //relacion uno a n con aportaciones
        public IEnumerable<Aportaciones> ListaAportaciones { get; set; }
        
    }
}
