using Arquetipo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentanasDiscos
{
    public static class HelperFrm
    {
        public static void ocultarColumnas(DataGridView dgv, string columna)
        {
            dgv.Columns[columna].Visible = false; 
        }
        public static void cargarImagenDGV(PictureBox pbx, string cadena)
        {
            try
            {
                pbx.Load(cadena);
            }
            catch (Exception ex)
            {

                pbx.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
        public static void cargar<T>(object objeto ,DataGridView dgv)
        {
           
            List<T> values = new List<T>();
            values = (List<T>)objeto;       
            dgv.DataSource = values;

        }

        public static void abrirVentan(Form frm)
        {
            try
            {
                frm.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("No se puede abrir esta Ventana");
            }
        }

        
    }
}
