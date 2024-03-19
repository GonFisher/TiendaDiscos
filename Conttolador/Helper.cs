using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arquetipo;


namespace Controlador
{
    public static class Helper
    {
        public static void agregar(Disco disco)
        {
            AccesoaDatos datos = new AccesoaDatos();
            try
            {
                datos.setearConsulta("INSERT INTO DISCOS(Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion)VALUES(@titulo,@fecha,@cantidad,@image,@estilo,@edicion)");
                datos.setearParametros("@titulo", disco.Titulo);
                datos.setearParametros("@fecha", disco.FechaLanzamiento);
                datos.setearParametros("@cantidad", disco.CantidadCanciones);
                datos.setearParametros("@image", disco.UrlImagenTapa);
                datos.setearParametros("@estilo", disco.Genero.Id);
                datos.setearParametros("@edicion", disco.Impresion.Id);
                datos.ejecutaraccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public static void modificar(Disco disco)
    {
        AccesoaDatos datos = new AccesoaDatos();
        try
        {
            datos.setearConsulta("UPDATE DISCOS SET Titulo= @titulo , FechaLanzamiento= @fecha, CantidadCanciones=@canciones,UrlImagenTapa=@imagen,IdEstilo=@estilo, IdTipoEdicion=@edicion WHERE Id=@id");
            datos.setearParametros("@titulo", disco.Titulo);
            datos.setearParametros("@fecha", disco.FechaLanzamiento);
            datos.setearParametros("@canciones", disco.CantidadCanciones);
            datos.setearParametros("@imagen", disco.UrlImagenTapa);
            datos.setearParametros("@estilo", disco.Genero.Id);
            datos.setearParametros("@edicion", disco.Impresion.Id);
            datos.setearParametros("@id", disco.Id);

            datos.ejecutaraccion();
        }
        catch (Exception ex)
        {

            throw ex;
        }
        finally
        {
            datos.cerrarConexion();
        }
    }
        public static void eliminar(Disco disco)
        {
            AccesoaDatos datos = new AccesoaDatos();
            try
            {
                datos.setearConsulta("DELETE FROM DISCOS WHERE Id=@id");
                datos.setearParametros("@id", disco.Id);

                datos.ejecutaraccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public static List<Disco> buscarDB(string campo, string criterio , string parametro)
        {
            AccesoaDatos datos = new AccesoaDatos();
            List<Disco> listaDisco = new List<Disco>();

            try
            {
                string consulta = "SELECT D.id, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion AS Genero, T.Descripcion AS Impresion FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.id AND D.IdTipoEdicion=T.Id AND  ";


                 if (campo == "Titulo")
                {
                    switch (criterio)
                    {
                        case "Comienza con:":
                            consulta += "Titulo like '"+parametro+"%'";
                            break;
                        case "Termina con:":
                            consulta += "Titulo like '%"+parametro+"'";
                            break;
                       default:
                            consulta += "Titulo like '%"+parametro+"%'";
                            break;
                    }
                }else if(campo == "Genero")
                {
                    switch (criterio)
                    {
                        case "Comienza con:":
                            consulta += "E.Descripcion like '"+parametro+"%'";
                            break;
                        case "Termina con:":
                            consulta += "E.Descripcion like '%"+parametro +"'";
                            break;
                        default:
                            consulta += "E.Descripcion like '%"+parametro+"%'";
                             break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Mayor a:":
                            consulta += "D.CantidadCanciones > " + parametro;
                            break;
                        case "Menor a:":
                            consulta += "D.CantidadCanciones < " + parametro ;
                            break;
                        default:
                            consulta += "D.CantidadCanciones < " + parametro;
                            break;
                    }
                }

                datos.setearConsulta(consulta);
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

                    listaDisco.Add(aux);
                }

                return listaDisco;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
     
    }
}
