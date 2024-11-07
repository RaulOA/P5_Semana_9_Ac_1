using System;

namespace P5_Semana_9_Ac_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creación de objetos de la clase Libro
            Libro libro1 = new Libro("Libro A", "Autor A", 200, 25.00m);
            Libro libro2 = new Libro("Libro B", "Autor B", 150, 18.50m);
            Libro libro3 = new Libro("Libro C", "Autor C", 300, 30.00m);

            // Llamada a MostrarDetalles
            libro1.MostrarDetalles();
            libro2.MostrarDetalles();
            libro3.MostrarDetalles();

            // Aplicar un descuento del 10% y mostrar el nuevo precio
            libro1.Descuento(10);
            libro2.Descuento(10);
            libro3.Descuento(10);
            Console.WriteLine("\nDespués de aplicar el descuento:");
            libro1.MostrarDetalles();
            libro2.MostrarDetalles();
            libro3.MostrarDetalles();

            // Calcular y mostrar el precio con impuesto
            Console.WriteLine("\nPrecio con impuesto:");
            Console.WriteLine($"Libro A: {libro1.CalcularPrecioConImpuesto():C}");
            Console.WriteLine($"Libro B: {libro2.CalcularPrecioConImpuesto():C}");
            Console.WriteLine($"Libro C: {libro3.CalcularPrecioConImpuesto():C}");

            // Creación y uso de un objeto LibroDigital
            LibroDigital libroDigital = new LibroDigital("Libro Digital", "Autor Digital", 100, 20.00m, 5.5);
            libroDigital.MostrarDetalles();
            libroDigital.Descargar();

            Console.ReadLine();
        }
    }
}
