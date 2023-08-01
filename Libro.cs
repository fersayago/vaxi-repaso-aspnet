using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    public class Libro
    {
        // public string _nombre;
        private string _nombre;
        //protected string _autor;
        private string _autor;
        private int _cantidadPaginas;

        public Libro(string nombre, string autor, int cantidadPaginas)
        {
            _nombre = nombre;
            _autor = autor;
            _cantidadPaginas = cantidadPaginas;
        }

        public string GetDescripcion()
        {
            return $"{_nombre} por {_autor}, con {_cantidadPaginas} paginas";
        }

        // para acceder a un parametro privado se hace mediante un metodo publico
        public int getLargoDeLibro()
        {
            return _cantidadPaginas;
        }

        // metodo acceso
        public string GetNombre()
        {
            return _nombre;
        }


        // cambiar nombre
        public void SetNombre(string nuevoNombre)
        {
            _nombre = nuevoNombre;
        }

        public string GetAutor()
        {
            return _autor;
        }

        public void SetAutor(string nuevoAutor)
        {
            _autor = nuevoAutor;
        }

        public int GetCantidadPaginas()
        {
            return _cantidadPaginas;
        }

        public void SetCantidadPaginas(int nuevCantidadPaginas)
        {
            _cantidadPaginas = nuevCantidadPaginas;
        }
    }

}
