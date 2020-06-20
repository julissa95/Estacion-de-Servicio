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
    public partial class FrmSurtidor : Form
    {
        private Surtidora _objSurtidora;

        public FrmSurtidor(Surtidora surtidora)
        {
            InitializeComponent();
            this._objSurtidora = surtidora;
            LlenarDatos();
        }

        private void LlenarDatos()
        {
            lblDisponible.Text = _objSurtidora.TipoTanque.GetDisponible().ToString();
            lblPrecio.Text = _objSurtidora.Precio.ToString();
            lblTipoCombustible.Text = _objSurtidora.TipoTanque.TipoCombustible;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtLitros.Value += 1;
            _objSurtidora.SurtirCombustible(int.Parse(txtLitros.Value.ToString()));
        }

        private void btnSurtir_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnFinalizar.Enabled = true;
            btnCalcular.Enabled = false;
            btnSurtir.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            btnCalcular.Enabled = true;
            btnFinalizar.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblMonto.Text = $"Monto de Venta: {_objSurtidora.MontoSurtido.ToString()}";
        }
    }
}
