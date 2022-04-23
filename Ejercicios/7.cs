using System;

namespace ejercicios_c_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio No 7 
                La empresa CHUE-K tiene N artículos con la siguiente información: clave del artículo, descripción, 
                límite superior, límite inferior, existencias, precio de compra, precio de venta y proveedor. 
                
                Se le solicita realice una aplicación que proporcione la siguiente información: 
                a) Cuál es el total de existencias de las licuadoras. 
                b) Si se venden todos los artículos cual sería el total de ingresos. 
                c) Un reporte que contenga el nombre de los artículos cuyas existencias sean menores al límite  inferior.

                d) Cuantos artículos tienen como proveedor SONY. 
                e) Listado que contenga: la clave del artículo, descripción y la utilidad.
            */

            int cantidadArticulos = 0,
                excistenciaLicuadoras = 0,
                totalIngresos = 0,
                limiteInferior = 0,
                limiteSuperior = 0,
                existencias = 0,
                precioVenta = 0,
                precioCompra = 0,
                cantidadProvedorSony = 0;

            string clave = "",
                   utilidad = "",
                   descripcion = "",
                   articulo = "",
                   proveedor = "";

            string[] articulosMenoresLimiteInferior;
            
            Console.Write("Cantidad de artículos: ");
            cantidadArticulos = int.Parse(Console.ReadLine());
            articulosMenoresLimiteInferior = new string[cantidadArticulos];


            for (int i = 0; i < cantidadArticulos; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Artículo {i + 1}");

                Console.Write("Articulo: ");
                articulo = Console.ReadLine().ToLower();

                Console.Write("Proveedor: ");
                proveedor = Console.ReadLine().ToLower();

                Console.Write("Clave: ");
                clave = Console.ReadLine();

                Console.Write("Utilidad: ");
                utilidad = Console.ReadLine();

                Console.Write("Descripción: ");
                descripcion = Console.ReadLine();
                
                Console.Write("Costo de venta: ");
                precioVenta = int.Parse(Console.ReadLine());

                Console.Write("Costo de compra: ");
                precioCompra = int.Parse(Console.ReadLine());

                Console.Write("Existencias: ");
                existencias = int.Parse(Console.ReadLine());

                Console.Write("Limite inferior: ");
                limiteInferior = int.Parse(Console.ReadLine());

                Console.Write("Limite superior: ");
                limiteSuperior = int.Parse(Console.ReadLine());

                totalIngresos += precioVenta - precioCompra;
                
                if (proveedor == "sony") cantidadProvedorSony++;
                if(articulo == "licuadora") excistenciaLicuadoras += existencias;
                if(existencias < limiteInferior) articulosMenoresLimiteInferior[i] = articulo;

                Console.WriteLine("----------------------------");
                Console.WriteLine("Registro");
                Console.WriteLine($"Descripcion: {descripcion}");
                Console.WriteLine($"Clave: {clave}");
                Console.WriteLine($"Utilidad: {utilidad}");
            }        
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Existencias de licuadora: {excistenciaLicuadoras}");
            Console.WriteLine($"Total de ingresos: {totalIngresos}");
            Console.WriteLine($"Cantidad de articulos de sony: {cantidadProvedorSony}");
            Console.WriteLine("Articulos cuya existencias es menores al limite inferior: ");
            
            for (int i = 0; i < articulosMenoresLimiteInferior.Length; i++)
                Console.WriteLine($"{i+1}.- {articulosMenoresLimiteInferior[i]}");
            
            Console.WriteLine("----------------------------");
        }
    }
}
