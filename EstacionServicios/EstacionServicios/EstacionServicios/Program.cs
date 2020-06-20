using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstacionServicios.Clases;

namespace EstacionServicios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenu(Iniciar())); //quedamos aqui
        }

        static private Operaciones Iniciar()
        {
            //Aqui traemos de la base de datos

            //Crear el objeto establecimiento
            Establecimiento objEstablecimiento = new Establecimiento()
            {
                Id = 1,
                Cuit = "53435353",
                Nombre = "Estación de Servicios Callao",
                Telefono = "242424242",
                Direccion = "Av Callao 3456",
                Horario = "09:00 a 21:00 hrs"
            };

            //Creamos los tanques del Establecimiento
            Clases.Varios.Tanque objTanqueDiesel = new Clases.Varios.Tanque(1,"DIESEL",2000,2000);
            Clases.Varios.Tanque objTanqueSuper = new Clases.Varios.Tanque(2, "SUPER", 3000, 3000);
            Clases.Varios.Tanque objTanquePremiun = new Clases.Varios.Tanque(3, "PREMIUN", 2500, 2500);

            Operaciones objOperacion = new Operaciones(objEstablecimiento, objTanqueDiesel);

            return objOperacion;
        }


    }
}
