using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionServicios.Clases
{
    public  class Persona
    {
        public int Id { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string cargo { get; set; }


        public Persona(int id, string dni, string nombre, string cargo)
        {
            this.Id = id;
            this.Dni = dni;
            this.Nombre = nombre;
            this.cargo = cargo;
        }

       
    }
}
