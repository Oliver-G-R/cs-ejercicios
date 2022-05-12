using System;
namespace ejercicios_c_12
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
                Ejercicio No 12 
                Una liga de futbol, cuenta con M equipos, de cada equipo tiene los siguientes datos: juegos ganados, 
                juegos empatados, juegos perdidos, goles anotados y goles recibidos. 
                Se le pide una aplicación que proporcione la siguiente información: 
                a) Un reporte que contenga: nombre del equipo, total de puntos y diferencia de goles. 
                b) Cuantos equipos tienen entre 12 y 20 puntos. 
                c) Cuantos equipos tienen diferencia de goles negativa. 
                d) Promedio de puntos de los equipos con más de 20 puntos.
           */

            int cantidadEquipos = 0,
                juegosGnanados = 0,
                juegosEmpatados = 0,
                juegosPerdidos = 0,
                totalPuntos = 0,
                diferenciaGoles = 0,
                equiposEntre12y20Puntos = 0,
                equiposConDiferenciaNegativa = 0,
                golesAnotados = 0,
                golesRecibidos = 0;

            string nombreEquipo = "";

            double promedioPuntos = 0;

            Console.Write("Cantidad de equipos: ");
            cantidadEquipos = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadEquipos; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Equipo {i + 1}");

                Console.Write("Nombre: ");
                nombreEquipo = Console.ReadLine();

                Console.Write("Juegos Ganados: ");
                juegosGnanados = int.Parse(Console.ReadLine());

                Console.Write("Juegos Empatados: ");
                juegosEmpatados = int.Parse(Console.ReadLine());

                Console.Write("Juegos Perdidos: ");
                juegosPerdidos = int.Parse(Console.ReadLine());

                Console.Write("Goles Anotados: ");
                golesAnotados = int.Parse(Console.ReadLine());

                Console.Write("Goles Recibidos: ");
                golesRecibidos = int.Parse(Console.ReadLine());

                totalPuntos = juegosGnanados + golesAnotados;
                diferenciaGoles = golesAnotados - golesRecibidos;

                if(totalPuntos > 20) promedioPuntos += totalPuntos / cantidadEquipos;
                if(totalPuntos >= 12 && totalPuntos <= 20) equiposEntre12y20Puntos++;
                if(diferenciaGoles < 0) equiposConDiferenciaNegativa++;

                Console.WriteLine("----------------------------");
                Console.WriteLine($"Nombre: {nombreEquipo}");
                Console.WriteLine($"Total de puntos: {totalPuntos}");
                Console.WriteLine($"Diferencia de goles: {diferenciaGoles}");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Promedio de puntos: {promedioPuntos}");
            Console.WriteLine($"Equipos entre 12 y 20 puntos: {equiposEntre12y20Puntos}");
            Console.WriteLine($"Equipos con diferencia negativa: {equiposConDiferenciaNegativa}");
        }
    }
}
