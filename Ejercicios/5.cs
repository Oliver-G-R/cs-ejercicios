using System;

namespace ejercicios_c_5
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
                Ejercicio No 5
                Un cine tiene la siguiente información de W boletos vendidos: sala, horario y tipo de pago.
                Realice una aplicación que proporcione la siguiente información:
                A) Cuantos boletos se compraron para la función de las 5 pm del martes en la sala 4.
                B) Cuantos boletos de contado se vendieron para el miércoles.
                C) Cuantos boletos fueron pagados con tarjeta de crédito.
                D) Ingreso total de la venta de boletos para el fin de semana. 
           */

            int cantidadBoletos = 0,
                cantidadBoletosSala4 = 0,
                cantidadBoletosContado = 0,
                cantidadBoletosTarjeta = 0;

            double ingresoTotal = 0,
                   costoBoleto = 0;

            string sala = "",
                   horario = "",
                   dia = "",
                   tipoPago = "";

            Console.Write("Cantidad de boletos: ");
            cantidadBoletos = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadBoletos; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Boletos {i + 1}");
                Console.Write("Sala: ");
                sala = Console.ReadLine();

                Console.Write("Horario: ");
                horario = Console.ReadLine();

                Console.Write("Día: ");
                dia = Console.ReadLine();

                Console.Write("Costo de boleto: ");
                costoBoleto = double.Parse(Console.ReadLine());

                Console.Write("Tipo de pago [contado][tarjeta]: ");
                tipoPago = Console.ReadLine();

                if (sala == "4" && horario == "5" && dia.Contains("martes")) cantidadBoletosSala4++;
                if (tipoPago == "contado") cantidadBoletosContado++;
                if (tipoPago == "tarjeta") cantidadBoletosTarjeta++;
                if(dia.Contains("sabado") || dia.Contains("domingo")) ingresoTotal += costoBoleto;
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Cantidad de boletos para la función de las 5 pm del martes en la sala 4: {cantidadBoletosSala4}");
            Console.WriteLine($"Cantidad de boletos de contado: {cantidadBoletosContado}");
            Console.WriteLine($"Cantidad de boletos de tarjeta: {cantidadBoletosTarjeta}");
            Console.WriteLine($"Ingreso total de la venta de boletos para el fin de semana: {ingresoTotal}");


        }
    }
}
