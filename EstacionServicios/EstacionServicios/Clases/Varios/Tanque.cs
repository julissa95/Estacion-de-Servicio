using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionServicios.Clases.Varios
{
    public abstract class Tanque
    {
        public int Id { get; set; }
       // protected string TipoCombustible { get; set; }
        public int Capacidad { get; set; }
        public int Disponible { get; set; }
        public string TipoCombustible { get; internal set; }

        //Constructor
        public Tanque(int id,string combustible, int capacidad, int disponible)
        {
            this.Id = id;
            this.TipoCombustible = combustible;
            this.Capacidad = capacidad;
            this.Disponible = disponible;
        }

        //Métodos
        public int GetCapacidad()
        {
            return this.Capacidad;
        }
        public int GetDisponible()
        {
            return this.Disponible;
        }
        public void ExtaerCombustible(int litros)
        {
            this.Disponible -= litros;
        }
        public void CargarTanque()
        {
            this.Disponible = this.Capacidad;
        }
    }
}
