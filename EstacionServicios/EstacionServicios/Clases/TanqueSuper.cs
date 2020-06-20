using EstacionServicios.Clases.Varios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionServicios.Clases
{
   public class TanqueSuper : Tanque
    {

        public TanqueSuper(int id, string combustible, int capacidad, int disponible) : base(id, combustible, capacidad, disponible)
        {
            this.Id = id;

            this.TipoCombustible = combustible;
            this.Capacidad = capacidad;
            this.Disponible = disponible;
        }
    }
}
