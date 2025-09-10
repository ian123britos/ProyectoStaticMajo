namespace Dominio
{
    public class Nosotros
    {
        public string Tittulo { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
 
        public Nosotros(string foto, string tiutlo,string descripcion)
        {
            Foto = foto;
            Tittulo = tiutlo;
            Descripcion = descripcion;
        }



    }
}
