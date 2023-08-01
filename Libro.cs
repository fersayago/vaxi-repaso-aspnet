using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    public class Libro : Publicacion
    {
        

        //protected string _autor;
        private string _autor;
        public string Autor
        {
            get => _autor;
            set => _autor = value;
        }

        // ejemplo de la vida real
        public string MiPropiedad { get; set; }

        public Libro(string nombre, string autor, int cantidadPaginas, decimal precio)
            :base(nombre, precio, cantidadPaginas)
        {
            _autor = autor;
        }

        // pisa el metodo con el mismo nombre del padre
        public override string GetDescripcion() => $"Libro {Nombre} por {Autor}, con {CantidadPaginas} paginas";
        //{
        //    return $"{_nombre} por {_autor}, con {_cantidadPaginas} paginas";
        //}

        internal object GetCantidadPaginas()
        {
            return CantidadPaginas;
        }
    }

}
