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
using Microsoft.VisualBasic;


namespace VentanasDiscos
{
    public partial class frmAgregar : Form
    {
        private Disco disco = null;
        private DiscosNegocio negocio = new DiscosNegocio();

        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Disco disco)
        {
            InitializeComponent();
            Text = "Modificar Disco";
            this.disco = disco;
        }
        public void frmAgregar_Load(object sender, EventArgs e)
        {
            EstilosNegocio estilo = new EstilosNegocio();
            ImpresionNegocios impresion = new ImpresionNegocios();
            try
            {
                cbxEstilo.DataSource = estilo.listarEstilos();
                cbxEstilo.ValueMember = "Id";
                cbxEstilo.DisplayMember = "Descripcion";
                cbxImpresion.DataSource = impresion.listar();
                cbxImpresion.ValueMember = "Id";
                cbxImpresion.DisplayMember = "Descripcion";

                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpLanzamiento.Value = disco.FechaLanzamiento;
                    nudCanciones.Value = disco.CantidadCanciones;
                    txtImgen.Text = disco.UrlImagenTapa;
                    cbxEstilo.SelectedItem = disco.Genero.Id;
                    cbxImpresion.SelectedItem = disco.Impresion.Id;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            //DiscosNegocio negocio = new DiscosNegocio();

            try
            {

                if (disco == null)
                    disco = new Disco();



                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = dtpLanzamiento.Value;
                disco.CantidadCanciones = (int)nudCanciones.Value;
                disco.UrlImagenTapa = txtImgen.Text;
                HelperFrm.cargarImagenDGV(pbxAgregar, txtImgen.Text);
                disco.Genero = (Estilo)cbxEstilo.SelectedItem;
                disco.Impresion = (Edicion)cbxImpresion.SelectedItem;

                if (disco.Id != 0)
                {
                    Helper.modificar(disco);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {

                    Helper.agregar(disco);
                    MessageBox.Show("Agregado Exitosamente");
                }

                Close();
            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtImgen_MouseLeave(object sender, EventArgs e)
        {
            Disco nuevo = new Disco();
            nuevo.UrlImagenTapa = txtImgen.Text;
            HelperFrm.cargarImagenDGV(pbxAgregar, nuevo.UrlImagenTapa);
        }

        private void btnImagenesLocales_Click(object sender, EventArgs e)
        {

        }
    }
}
