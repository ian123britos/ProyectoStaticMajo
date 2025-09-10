using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Foto
    {
        public string Titulo { get; set; }
        public string Fotos { get; set; }
        public string Descripcion { get; set; }

        public Foto(string fotos, string tiutlo, string descripcion)
        {
            Fotos = fotos;
            Titulo = tiutlo;
            Descripcion = descripcion;
        }

    }
}
