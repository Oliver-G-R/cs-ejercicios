using System;
namespace ejercicios_c_9
{
    class Program
    {
        static void Main(string[] args)
        {
          /*
                Ejercicio No 9 
                Una tienda de mascotas ha realizado N ventas, se pide una aplicación que proporcione la siguiente 
                información: 
                a) Ingreso total de las ventas. 
                b) Cuantos perros se vendieron. 
                c) Cuantos gatos se vendieron entre $300 y $500. 
                d) Cual fue el ingreso por la venta de mascotas que no sean ni gatos ni perros.
          */

            int cantidadDeVentas = 0,
                ventaDePerros = 0,
                ingresoTotalVentas = 0,
                cantidadGatosEntre300y500 = 0,
                ingresosMascotas = 0,
                costoMascota = 0;
            
            string mascota = "";
            
            Console.Write("Cantidad de ventas: ");
            cantidadDeVentas = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadDeVentas; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Venta {i + 1}");

                Console.Write("Mascota: ");
                mascota = Console.ReadLine().ToLower();

                Console.Write("Costo de la mascota: ");
                costoMascota = int.Parse(Console.ReadLine());

                ingresoTotalVentas += costoMascota;

                if(mascota != "perro" && mascota != "gato") ingresosMascotas += costoMascota;
                if (mascota == "perro") ventaDePerros++;
                if (mascota == "gato" && costoMascota >= 300 && costoMascota <= 500) cantidadGatosEntre300y500++;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Ingreso total de las ventas: ${ingresoTotalVentas}");
            Console.WriteLine($"Cantidad de perros vendidos: {ventaDePerros}");
            Console.WriteLine($"Cantidad de gatos entre $300 y $500: {cantidadGatosEntre300y500}");
            Console.WriteLine($"Ingresos por mascotas que no sean ni perros ni gatos: ${ingresosMascotas}");
        }
    }
}
