using System;

namespace ejercicios_c_4
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
                Ejercicio No 4
                Una empresa de autotransporte tiene la siguiente información de sus pasajeros: sexo, ciudad de
                destino, hora de salida y costo del boleto.
                Realice una aplicación que proporcione la siguiente información:
                A) Cuantas personas su destino es Tampico.
                B) Cuantas personas su costo de boleto se encuentra entre $ 200 y $ 300.
                C) Cuantas personas saldrán a las 9 ó 10 am.
                D) Monto total de la venta de boletos. 
           */

            int cantidadPersonas = 0,
                cantidadPersonasDestinoTampico = 0,
                cantidadPersonasCostoBoleto = 0,
                cantidadPersonasHoraSalida = 0;
               

            double costoBoleto = 0,
                   totalVenta = 0;

            string destino = "",
                   horaSalida = "";

            Console.Write("Cantidad de personas: ");
            cantidadPersonas = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadPersonas; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Persona {i + 1}");
                Console.Write("Destino: ");
                destino = Console.ReadLine();


                Console.Write("Costo boleto: ");
                costoBoleto = double.Parse(Console.ReadLine());

                Console.Write("Hora salida [9][10]: ");
                horaSalida = Console.ReadLine();

                if (destino.Contains("tampico")) cantidadPersonasDestinoTampico++;
                if (costoBoleto >= 200 && costoBoleto <= 300) cantidadPersonasCostoBoleto++;
                if (horaSalida == "9" || horaSalida == "10") cantidadPersonasHoraSalida++;

                totalVenta += costoBoleto;

                Console.WriteLine("----------------------------");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Cantidad de personas que su destino es Tampico: {cantidadPersonasDestinoTampico}");
            Console.WriteLine($"Cantidad de personas que su costo de boleto se encuentra entre $ 200 y $ 300: {cantidadPersonasCostoBoleto}");
            Console.WriteLine($"Cantidad de personas que saldrán a las 9 o 10 am: {cantidadPersonasHoraSalida}");
            Console.WriteLine($"Monto total de la venta de boletos: {totalVenta}");
        }
    }
}
