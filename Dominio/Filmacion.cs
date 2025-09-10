using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Filmacion
    {
        public string Titulo {  get; set; }
        public string Video { get; set; }

        public Filmacion(string titulo, string video)
        {
            Titulo = titulo;
            Video = video;
        }
    }
}
