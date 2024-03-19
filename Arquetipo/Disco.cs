using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquetipo
{
    public class Disco
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public int CantidadCanciones  { get; set; }
        public string UrlImagenTapa { get; set; }
        public Estilo Genero { get; set; }
        public Edicion Impresion { get; set; }


    }
}
