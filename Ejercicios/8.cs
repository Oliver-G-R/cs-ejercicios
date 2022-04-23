using System;
namespace ejercicios_c_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio No 8 
                La empresa CHUE-K tiene W artículos se pide una aplicación que proporcione la siguiente 
                información: 
                a) Cuantos artículos son televisores. 
                b) Cuantos artículos tienen como proveedor LG. 
                c) Cuantos artículos tienen un precio de venta entre $500 y $1200. 
                d) Cuantas computadoras de la marca HP o COMPAQ cuestan menos de $6000.
           */

            int cantidadArticulos = 0,
                cantidadTelevisores = 0,
                cantidadProvedorLG = 0,
                cantidadPrecioVenta = 0,
                precioVenta = 0,
                cantidadComputadorasHPCOMPAQ = 0;

            string  marca = "",
                    proveedor = "",
                    articulo = "";
            

            Console.Write("Cantidad de artículos: ");
            cantidadArticulos = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadArticulos; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Artículo {i + 1}");

                Console.Write("Articulo: ");
                articulo = Console.ReadLine().ToLower();

                Console.Write("Proveedor: ");
                proveedor = Console.ReadLine().ToLower();

                Console.Write("Marca: ");
                marca = Console.ReadLine().ToLower();

                Console.Write("Precio de venta: ");
                precioVenta = int.Parse(Console.ReadLine());

                if (articulo == "television") cantidadTelevisores++;
                if (proveedor == "lg") cantidadProvedorLG++;
                if (precioVenta >= 500 && precioVenta <= 1200) cantidadPrecioVenta++;
                if (marca == "hp" || marca == "compaq") 
                    if(precioVenta < 6000 && articulo == "computadora")
                    cantidadComputadorasHPCOMPAQ++;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Cantidad de televisores: {cantidadTelevisores}");
            Console.WriteLine($"Cantidad de provedores LG: {cantidadProvedorLG}");
            Console.WriteLine($"Cantidad de artículos con precio de venta entre 500 y 1200: {cantidadPrecioVenta}");
            Console.WriteLine($"Cantidad de computadoras HP o COMPAQ que cuestan menos de 6000: {cantidadComputadorasHPCOMPAQ}");
        }
    }
}
