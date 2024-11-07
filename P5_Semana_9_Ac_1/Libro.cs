using System;

namespace P5_Semana_9_Ac_1
{
    // Clase Libro que hereda de Producto
    class Libro : Producto
    {
        // Propiedades
        public string Titulo { get; }
        public string Autor { get; }

        private int _numeroPaginas;
        public int NumeroPaginas
        {
            get => _numeroPaginas;
            set => _numeroPaginas = value >= 0 ? value : 0;
        }

        private decimal _precio;
        public decimal Precio
        {
            get => _precio;
            set => _precio = value >= 0 ? value : 0;
        }

        // Constructores
        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public Libro(string titulo, string autor, int numeroPaginas, decimal precio)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            Precio = precio;
        }

        // Método MostrarDetalles
        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Páginas: {NumeroPaginas}, Precio: {Precio:C}");
        }

        // Sobrecarga de MostrarDetalles
        public void MostrarDetalles(bool mostrarPrecio)
        {
            if (mostrarPrecio)
                MostrarDetalles();
            else
                Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Páginas: {NumeroPaginas}");
        }

        // Método para aplicar descuento
        public void Descuento(decimal porcentaje)
        {
            Precio -= Precio * porcentaje / 100;
        }

        // Implementación del método abstracto
        public override decimal CalcularPrecioConImpuesto()
        {
            return Precio * 1.13m;
        }
    }
}
