using Arquetipo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Controlador
{
    public class DiscosNegocio
    {

        AccesoaDatos datos = new AccesoaDatos();
        List<Disco> listaDiscos = new List<Disco>();

        public List<Disco> listar()
        {

            try
            {
                datos.setearConsulta("SELECT D.id, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion AS Genero, T.Descripcion AS Impresion FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.id AND D.IdTipoEdicion=T.Id;");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Id = (int)datos.Lector["id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    aux.Genero = new Estilo();
                    aux.Genero.Descripcion = (string)datos.Lector["Genero"];
                    aux.Impresion = new Edicion();
                    aux.Impresion.Descripcion = (string)datos.Lector["Impresion"];


                    listaDiscos.Add(aux);

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

            return listaDiscos;
        }
    }
}
