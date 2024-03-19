using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arquetipo;

namespace Controlador
{
    public class ImpresionNegocios
    {
		private List<Edicion> lista = new List<Edicion>();
		private Edicion tipo = new Edicion();
        public List<Edicion> listar()
        {
			AccesoaDatos datos = new AccesoaDatos();
			lista = new List<Edicion>();
			try
			{
				datos.setearConsulta("SELECT Id,Descripcion, ImagenD FROM TIPOSEDICION");
				datos.ejecutarConsulta();

				while (datos.Lector.Read())
				{
					Edicion aux = new Edicion();

					aux.Id =(int)datos.Lector["Id"];
					aux.Descripcion =(string)datos.Lector["Descripcion"];
					
					if (!(datos.Lector["ImagenD"] is DBNull))
					 aux.Imagen =(string)datos.Lector["ImagenD"];

					lista.Add(aux);
				}

			}
			catch (Exception ex)
			{

				throw ex;
			}
			finally
			{
				datos.cerrarConexion();
			}

			return lista;

        }
    }
}
