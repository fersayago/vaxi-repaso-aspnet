using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    public class Publicacion
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }
        public int CantidadPaginas { get; set; }

        public Publicacion(string nombre, decimal precio, int cantidadPaginas)
        {
            // Propiedad = parametro;
            Nombre = nombre;
            Precio = precio;
            CantidadPaginas = cantidadPaginas;
        }

        // con el virtual podemos hacer que el metodo se pueda sobreescribir por las clases hijas
        public virtual string GetDescripcion() => $"{Nombre} precio {Precio}";
    }
}
