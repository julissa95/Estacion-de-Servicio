using EstacionServicios.Clases.Varios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionServicios.Clases
{
    public class Operaciones : IOperacion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int TotalSecuencia { get; set; }
        public int TotalLitros { get; set; }
        public double TotalMontoSurtido { get; set; }
        public Establecimiento Estacion { get; set; }
        public Varios.Tanque TanqueDiesel { get; set; }
        public Varios.Tanque TanqueSuper { get; set; }
        public Varios.Tanque TanquePremiun { get; set; }

        
        public Operaciones(Establecimiento establecimiento, Varios.Tanque tqDiesel, Varios.Tanque tqSuper, Varios.Tanque tqPremiun)
        {
            this.Estacion = establecimiento;
            this.TanqueDiesel = tqDiesel;
            this.TanqueSuper = tqSuper;
            this.TanquePremiun = tqPremiun;
        }

        public void IniciarJornada()
        {
            throw new NotImplementedException();
        }

        public void FinalizarJornada()
        {
            throw new NotImplementedException();
        }



        //Métodos de la Clase


    }
}
