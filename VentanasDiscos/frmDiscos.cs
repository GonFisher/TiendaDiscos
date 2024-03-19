using Controlador;
using Arquetipo;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace VentanasDiscos
{
    public partial class frmDiscos : Form
    {
        private List<Disco> listaDiscos = new List<Disco>();

        private DiscosNegocio negocio = new DiscosNegocio();

        public frmDiscos()
        {
            InitializeComponent();

        }

        public void frmDiscos_Load(object sender, EventArgs e)
        {
            listaDiscos = negocio.listar();
            try
            {
                HelperFrm.cargar<Disco>(listaDiscos, dgvListaDiscos);
                HelperFrm.ocultarColumnas(dgvListaDiscos, "Id");
                HelperFrm.ocultarColumnas(dgvListaDiscos, "UrlImagenTapa");

                cbxCampo.Items.Add("Titulo");
                cbxCampo.Items.Add("Genero");
                cbxCampo.Items.Add("Cantidad De Canciones");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }

        private void dgvListaDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaDiscos.CurrentRow != null)
            {
                Disco disc = new Disco();
                disc = (Disco)dgvListaDiscos.CurrentRow.DataBoundItem;
                HelperFrm.cargarImagenDGV(pbxListaDiscos, disc.UrlImagenTapa);

            }

        }

        private void btnVentanaEstilos_Click(object sender, EventArgs e)
        {
            frmEstilos estilos = new frmEstilos();
            HelperFrm.abrirVentan(estilos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregarDisco = new frmAgregar();
            HelperFrm.abrirVentan(agregarDisco);
        }

        public void btnVentanaImpresion_Click(object sender, EventArgs e)
        {
            frmImpresion impresion = new frmImpresion();
            HelperFrm.abrirVentan(impresion);
        }

        public void btnModificar_Click(object sender, EventArgs e)
        {
            Disco discoMidificar = new Disco();
            try
            {
                discoMidificar = (Disco)dgvListaDiscos.CurrentRow.DataBoundItem;
                frmAgregar modificarDisco = new frmAgregar(discoMidificar);
                modificarDisco.ShowDialog();
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());
            }
        }

        public void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrar;
            string filtro = txtFiltrar.Text;

            try
            {
                if (filtro.Length <= 3)
                {
                    listaFiltrar = listaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Impresion.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CantidadCanciones.ToString().ToLower().Contains(filtro.ToLower()));
                }
                else
                {
                    listaFiltrar = listaDiscos;
                }

                dgvListaDiscos.DataSource = null;
                dgvListaDiscos.DataSource = listaFiltrar;
                HelperFrm.ocultarColumnas(dgvListaDiscos, "Id");
                HelperFrm.ocultarColumnas(dgvListaDiscos, "UrlImagenTapa");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            Disco seleccionado = new Disco();

            DialogResult resultadoDialogo = MessageBox.Show("¿Queres Eliminar de los Registros el Disco?", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultadoDialogo == DialogResult.Yes)
            {

                seleccionado = (Disco)dgvListaDiscos.CurrentRow.DataBoundItem;
                Helper.eliminar(seleccionado);

            }
            else
            {
                Close();
            }

            listaDiscos = negocio.listar();
            HelperFrm.cargar<Disco>(listaDiscos, dgvListaDiscos);
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {

            string campo = cbxCampo.SelectedItem.ToString();

            if (campo == "Titulo" || campo == "Genero")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con:");
                cboCriterio.Items.Add("Termina con:");
                cboCriterio.Items.Add("Contiene:");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a:");
                cboCriterio.Items.Add("Menor a:");
                cboCriterio.Items.Add("Es igua a:");
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarFiltro())
                {
                    return;
                }
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string parametro = txtBusqueda.Text;

                dgvListaDiscos.DataSource = Helper.buscarDB(campo, criterio, parametro);

                if (parametro == null)
                {

                    HelperFrm.cargar<Disco>(listaDiscos, dgvListaDiscos);

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool verificarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Debes Seleccionar un Campo de busqueda");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un Criterio de Busqueda");
                return true;
            }

            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                MessageBox.Show("Debes Completar el Filtro de Busqueda");
                return true;
            }

            if (!(soloNumeros(txtBusqueda.Text)))
            {
                return true;
            }

            return false;
        }

        public bool soloNumeros(string text)
        {
            foreach (char letra in text)
            {
                if (!(char.IsNumber(letra)))
                {
                    MessageBox.Show("Seleccionaste Cantida de Cancines. Completa con Números el Campo");
                    return false;
                }

                return true;
            }

            return true;
        }
    }
}
