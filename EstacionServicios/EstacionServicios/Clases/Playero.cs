using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionServicios.Clases
{
   public class Playero : Persona
    {
            private string Cargo { get; set; }

            public Playero(int id, string dni, string nonbre, string cargo) : base(id, dni, nonbre, cargo)
            {
                this.Cargo = Cargo;
            }

    }
}
