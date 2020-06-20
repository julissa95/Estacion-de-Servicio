using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionServicios.Clases
{
    public class Operaciones
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int TotalSecuencia { get; set; }
        public int TotalLitros { get; set; }
        public double TotalMontoSurtido { get; set; }
        public Establecimiento Estacion { get; set; }
        public Varios.Tanque TanqueDiesel { get; set; }

        public Operaciones(Establecimiento establecimiento, Varios.Tanque tqDiesel)
        {
            this.Estacion = establecimiento;
            this.TanqueDiesel = tqDiesel;
        }

        //Métodos de la Clase
        public void IniciarJornada()
        {

        }
        public void FinalizarJornada()
        {

        }

    }
}
