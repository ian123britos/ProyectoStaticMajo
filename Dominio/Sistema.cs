using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        public List<Barra> ListaBarras {  get; set; }
        public List<Cabina> ListaCabinas {  get; set; }
        public List<Filmacion> ListaFilmacion {  get; set; }
        public List<Foto> ListaFotos { get; set; }
        public List<Nosotros> ListaNosotros { get; set; }
        public List<Quince> ListaQuinces { get; set; }

        //Inicializo las listas:
        private Sistema()
        {
            ListaBarras = new List<Barra>();
            ListaCabinas = new List<Cabina>();
            ListaFilmacion = new List<Filmacion>();
            ListaFotos = new List<Foto>();
            ListaNosotros = new List<Nosotros>();
            ListaQuinces = new List<Quince>();
        
        }
    }
}
