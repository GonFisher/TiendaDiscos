using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arquetipo;

namespace VentanasDiscos
{
    public partial class frmEstilos : Form
    {
        EstilosNegocio negocio = new EstilosNegocio();

        public frmEstilos()
        {
            InitializeComponent();
        }

        public void frmEstilos_Load(object sender, EventArgs e)
        {

            HelperFrm.cargar<Estilo>(negocio.listarEstilos(), dgvEstilos);
            HelperFrm.ocultarColumnas(dgvEstilos, "id");
            HelperFrm.ocultarColumnas(dgvEstilos, "UrlImage");



        }

        private void dgvEstilos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstilos.CurrentRow != null)
            {
                Estilo estilo = new Estilo();
                estilo = (Estilo)dgvEstilos.CurrentRow.DataBoundItem;

                HelperFrm.cargarImagenDGV(pbxEstilos, estilo.UrlImage);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
