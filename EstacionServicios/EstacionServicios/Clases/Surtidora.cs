using EstacionServicios.Clases.Varios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionServicios.Clases
{
    public class Surtidora : ISurtidora
    {
        public int Id { get; set; }
        public int Secuencia { get; set; }
        public int LitrosSurtidos { get; set; }
        public double MontoSurtido { get; set; }
        public double MontoVenta { get; set; }
        //public Persona Playero { get; set; }
        public Varios.Tanque TipoTanque { get; set; } //El tanque
        public double Precio { get; set; } //Se puede mover a la clase tanque
        public Playero Playero { get; set; }

        public void SurtirCombustible(int litros)
        {
            TipoTanque.ExtaerCombustible(litros);
            this.LitrosSurtidos += litros;
            this.MontoVenta += this.Precio * litros; //Unica Venta

        }

        public void Conteo()
        {
            this.Secuencia++;
        }


    }
}
