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
using Controlador;

namespace VentanasDiscos
{
    public partial class frmImpresion : Form
    {
        public frmImpresion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmImpresion_Load(object sender, EventArgs e)
        {
            ImpresionNegocios impresion = new ImpresionNegocios();
            HelperFrm.cargar<Edicion>(impresion.listar(), dgvListaImpresion);

            HelperFrm.ocultarColumnas(dgvListaImpresion,"Imagen");

        }


        private void dgvListaImpresion_SelectionChanged(object sender, EventArgs e)
        {
            Edicion seleccionada = new Edicion();
            if(dgvListaImpresion.CurrentRow != null)
            {
                seleccionada=(Edicion)dgvListaImpresion.CurrentRow.DataBoundItem;
                HelperFrm.cargarImagenDGV(pbxImpresion,seleccionada.Imagen);

            }

        }
    }
}
