using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquetipo
{
    public class Edicion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
