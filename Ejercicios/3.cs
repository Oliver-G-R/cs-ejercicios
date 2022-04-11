using System;

namespace ejercicios_c_3
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
                Ejercicio No 3
                Una empresa tiene X vendedores, de cada vendedor tiene las ventas de dos bimestres.
                Realice una aplicación que proporcione la siguiente información:
                a) Cuantos vendedores son mujeres.
                b) Total de ventas de la empresa.
                c) Nombre y promedio de venta por vendedor.
                d) Cuantos vendedores tienen mayor monto de ventas en el segundo bimestres 
           */
            int cantidadVendedores = 0,
                cantidadMujeres = 0,
                cantidadVendoresMayorMonto = 0;
            
            double venta1 = 0,
                   venta2 = 0,
                   totalVentasEmpleado = 0,
                   promedioVentas = 0,
                   totalVentasEmpresa = 0;

            
            string  nombre = "",
                    sexo = "";

            Console.Write("Cantidad de vendedores: ");
            cantidadVendedores = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadVendedores; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Vendedor {i + 1}");
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                
                Console.Write("Sexo [F][M]: ");
                sexo = Console.ReadLine().ToUpper();

                Console.Write("Venta 1: ");
                venta1 = double.Parse(Console.ReadLine());
                
                Console.Write("Venta 2: ");
                venta2 = double.Parse(Console.ReadLine());
                
                totalVentasEmpleado = venta1 + venta2;
                promedioVentas = totalVentasEmpleado / 2;
                totalVentasEmpresa += totalVentasEmpleado;

                if(venta2 > venta1) cantidadVendoresMayorMonto++;
                if(sexo == "F") cantidadMujeres++;
                
                
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Promedio: {promedioVentas}");
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Total de ventas: {totalVentasEmpresa}");
            Console.WriteLine($"Cantidad de vendedores con mayor monto en el segundo bimestre: {cantidadVendoresMayorMonto}");
            Console.WriteLine($"Cantidad de mujeres: {cantidadMujeres}");

        }
    }
}
