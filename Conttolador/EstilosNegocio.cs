using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arquetipo;
using Controlador;

namespace Controlador
{
    public class EstilosNegocio
    {
        AccesoaDatos datos = new AccesoaDatos();
        List<Estilo> listaEstilos = new List<Estilo>();

        public List<Estilo> listarEstilos()
        {
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion, Historia, UrlImage FROM ESTILOS;");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Estilo aux = new Estilo();

                    aux.Id = (int)datos.Lector["id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["Historia"] is DBNull))
                      aux.Historia = (string)datos.Lector["Historia"];
                    if (!(datos.Lector["UrlImage"] is DBNull))
                        aux.UrlImage = (string)datos.Lector["UrlImage"];
                   

                    listaEstilos.Add(aux);

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

            return listaEstilos;
        }

    }
}
