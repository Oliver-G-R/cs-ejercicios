using System;
namespace ejercicios_c_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio No 10 
                Una biblioteca le solicita una aplicación que le proporcione la siguiente información de sus W libros:
                a) cuantos libros son del área de matemáticas. 
                b) Cuantos libros de la editorial McGraw Hill son del área informática. 
                c) Cuantos libros de la editorial Trillas son de administración y tiene menos de 253 páginas. 
                d) Promedio de página por libro. 
                e) Promedio de página de los libros del área de contabilidad. 
            */

            int cantidadLibros = 0,
                cantidadLibrosAreaMatematicas = 0,
                cantidadEditorialAreaInformaticaMcgrawHill = 0,
                cantidadAreaMatematicasTrillas = 0,
                cantidadPaginas = 0,
                promedioPaginasPorLibro = 0,
                cantidadLibrosContabilidad = 0,
                promedioPaginasPorLibroAreaContabilidad = 0;

            string area = "",
                   editorial = "";

            Console.Write("Cantidad de libros: ");
            cantidadLibros = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadLibros; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Libro {i + 1}");

                Console.Write("Area: ");
                area = Console.ReadLine().ToLower();

                Console.Write("Editorial: ");
                editorial = Console.ReadLine().ToLower();

                Console.Write("Cantidad de páginas: ");
                cantidadPaginas = int.Parse(Console.ReadLine());

                promedioPaginasPorLibro += cantidadPaginas / cantidadLibros;

                if (area == "matematicas") cantidadLibrosAreaMatematicas++;
                if (editorial == "mcgraw hill" && area == "informatica") cantidadEditorialAreaInformaticaMcgrawHill++;
                if (editorial == "trillas" && cantidadPaginas < 253 && area == "adminsitracion") cantidadAreaMatematicasTrillas++;
                if(area == "contabilidad"){
                    cantidadLibrosContabilidad++;
                    promedioPaginasPorLibroAreaContabilidad += cantidadPaginas / cantidadLibrosContabilidad;
                }
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Cantidad de libros del área de matemáticas: {cantidadLibrosAreaMatematicas}");
            Console.WriteLine($"Cantidad de libros de la editorial McGraw Hill del área informática: {cantidadEditorialAreaInformaticaMcgrawHill}");
            Console.WriteLine($"Cantidad de libros de la editorial Trillas del área de administración y tiene menos de 253 páginas: {cantidadAreaMatematicasTrillas}");
            Console.WriteLine($"Promedio de página por libro: {promedioPaginasPorLibro}");
            Console.WriteLine($"Promedio de página de los libros del área de contabilidad: {promedioPaginasPorLibroAreaContabilidad}");
        }
    }
}
