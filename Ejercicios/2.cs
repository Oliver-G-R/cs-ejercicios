using System;

namespace ejercicios_c_2
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
                Ejercicio No 2
                Realizar una aplicación para N alumnos que realice lo siguiente:
                a) Escriba el nombre y promedio de 6 calificaciones de cada alumno.
                b) Cuántas mujeres no aprobaron la primera calificación.
                c) Cuantos hombres no aprobaron la primera calificación.
                d) Cuantos obtuvieron promedio aprobatorio. 
            */

            int cantidadAlumnos = 0,
                cantidadMujeres = 0,
                cantidadHombres = 0,
                cantidadPromedioAprobatorio = 0;
            
            string nombre = "",
                   sexo = "";

            double promedio = 0,
                   calificacion1 = 0,
                   calificacion2 = 0,
                   calificacion3 = 0,
                   calificacion4 = 0,
                   calificacion5 = 0,
                   calificacion6 = 0;
            
            Console.Write("Cantidad de alumnos: ");
            cantidadAlumnos = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Alumno {i + 1}");
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Sexo [F][M]: ");
                sexo = Console.ReadLine().ToUpper();
                
                Console.Write("Calificacion 1: ");
                calificacion1 = double.Parse(Console.ReadLine());
                
                Console.Write("Calificacion 2: ");
                calificacion2 = double.Parse(Console.ReadLine());
                
                Console.Write("Calificacion 3: ");
                calificacion3 = double.Parse(Console.ReadLine());
                
                Console.Write("Calificacion 4: ");
                calificacion4 = double.Parse(Console.ReadLine());
                
                Console.Write("Calificacion 5: ");
                calificacion5 = double.Parse(Console.ReadLine());
                
                Console.Write("Calificacion 6: ");
                calificacion6 = double.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------");

                promedio = (calificacion1 + calificacion2 + calificacion3 + calificacion4 + calificacion5 + calificacion6) / 6;

                Console.WriteLine($"Promedio: {promedio}");

                if(calificacion1 < 6 && sexo == "F") cantidadMujeres++;
                if(calificacion1 < 6 && sexo == "M") cantidadHombres++;
                if(promedio >= 6) cantidadPromedioAprobatorio++;

            }

            Console.WriteLine($"Cantidad de mujeres que no aprobaron la primera calificación: {cantidadMujeres}");
            Console.WriteLine($"Cantidad de hombres que no aprobaron la primera calificación: {cantidadHombres}");
            Console.WriteLine($"Cantidad de alumnos que aprobaron el promedio aprobatorio: {cantidadPromedioAprobatorio}");
        }
    }
}
