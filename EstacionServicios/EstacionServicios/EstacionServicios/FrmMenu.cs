using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstacionServicios.Clases;

namespace EstacionServicios
{
    public partial class FrmMenu : Form
    {
        static private Operaciones _objOperaciones; //Solo se declara
        private Surtidora objSurtidoraDiesel;
        private Surtidora objSurtidoraSuper;

        public FrmMenu(Operaciones operaciones)
        {
            InitializeComponent();
            _objOperaciones = operaciones;

            

        LLenarDatos();
        }

        private void LLenarDatos()
        {
            lblName.Text = _objOperaciones.Estacion.Nombre;
            lblCuit.Text = _objOperaciones.Estacion.Cuit;
            lblAdress.Text = _objOperaciones.Estacion.Direccion;
            //Información de los tanques
            lblCapacidadDiesel.Text = $"Capacidad: {_objOperaciones.TanqueDiesel.GetCapacidad().ToString()}";
            lblDisponibleDiesel.Text = $"Disponible: {_objOperaciones.TanqueDiesel.GetDisponible().ToString()}";
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnDiesel_Click(object sender, EventArgs e)
        {
            objSurtidoraDiesel = new Surtidora()
            {
                Id = 1,
                Precio = 10,
                TipoTanque = _objOperaciones.TanqueDiesel
            };
            FrmSurtidor frmDiesel = new FrmSurtidor(objSurtidoraDiesel);
            frmDiesel.ShowDialog();
        }

        private void btnCorriente_Click(object sender, EventArgs e)
        {
            objSurtidoraSuper = new Surtidora()
            {
                Id = 2,
                Precio = 25,
                //TipoTanque = _objOperaciones.
            };
            FrmSurtidor frmSuper = new FrmSurtidor(objSurtidoraSuper);
            frmSuper.ShowDialog();
        }
    }
}
