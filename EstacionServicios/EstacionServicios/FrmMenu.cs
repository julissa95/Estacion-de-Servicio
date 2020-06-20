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
        private Surtidora objSurtidoraPremiun;
        public FrmMenu(Operaciones operaciones)
        {
            InitializeComponent();
            _objOperaciones = operaciones;
            objSurtidoraPremiun = new Surtidora()
            {
                Id = 3,
                Precio = 35,
                TipoTanque = _objOperaciones.TanquePremiun,
                Playero = new Playero(1, "78908456", "Dionel Marmori", "Playero")
            };



            LLenarDatos();
        }

        public FrmMenu()
        {
        }

        private void LLenarDatos()
        {
            lblName.Text = _objOperaciones.Estacion.Nombre;
            lblCuit.Text = _objOperaciones.Estacion.Cuit;
            lblAdress.Text = _objOperaciones.Estacion.Direccion;
            lblPhone.Text = _objOperaciones.Estacion.Telefono;
            lblHours.Text = _objOperaciones.Estacion.Horario;

            //Información de los tanques
            lblCapacidadDiesel.Text = $"Capacidad: {_objOperaciones.TanqueDiesel.GetCapacidad().ToString()}";
            lblDisponibleDiesel.Text = $"Disponible: {_objOperaciones.TanqueDiesel.GetDisponible().ToString()}";

            lblCapacidadSuper.Text = $"Capacidad: {_objOperaciones.TanqueSuper.GetCapacidad().ToString()}";
            lblDisponibleSuper.Text = $"Disponible: {_objOperaciones.TanqueSuper.GetDisponible().ToString()}";

            //Surtidora Premium
            lblPlayeroPremiun.Text = objSurtidoraPremiun.Playero.Nombre;
            lblCapacidadPremiun.Text = $"Capacidad: {_objOperaciones.TanquePremiun.GetCapacidad().ToString()}";
            lblDisponiblePremiun.Text = $"Disponible: {_objOperaciones.TanquePremiun.GetDisponible().ToString()}";
            lblOperacionesPremiun.Text = $"Nro. Autos: { objSurtidoraPremiun.Secuencia }";
            lblLitrosPremiun.Text = $"Cant. Litros: { objSurtidoraPremiun.LitrosSurtidos}";
            lblMontoPremiun.Text = $"Monto: {objSurtidoraPremiun.MontoSurtido}";
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
                TipoTanque = _objOperaciones.TanqueSuper
            };
            FrmSurtidor frmSuper = new FrmSurtidor(objSurtidoraSuper);
            frmSuper.ShowDialog();
        }

        private void BtnExtra_Click_1(object sender, EventArgs e)
        {
            objSurtidoraPremiun.MontoVenta = 0;
            FrmSurtidor frmPremiun = new FrmSurtidor(objSurtidoraPremiun);
            frmPremiun.ShowDialog();

            LLenarDatos();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
