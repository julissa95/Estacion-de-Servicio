using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionServicios.Clases
{
    public class Establecimiento
    {
        public int Id { get; set; }
        public string Cuit { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Horario { get; set; }
    }
}
