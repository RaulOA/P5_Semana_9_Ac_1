using System;

namespace P5_Semana_9_Ac_1
{
    // Clase derivada LibroDigital que hereda de Libro
    class LibroDigital : Libro
    {
        public double TamanioArchivo { get; set; }

        public LibroDigital(string titulo, string autor, int numeroPaginas, decimal precio, double tamanioArchivo)
            : base(titulo, autor, numeroPaginas, precio)
        {
            TamanioArchivo = tamanioArchivo;
        }

        // Método Descargar
        public void Descargar()
        {
            Console.WriteLine($"Descargando '{Titulo}' de {Autor}...");
        }

        // Sobrescritura de MostrarDetalles para incluir tamaño de archivo
        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Tamaño del archivo: {TamanioArchivo} MB");
        }
    }
}
