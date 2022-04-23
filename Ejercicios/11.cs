using System;
namespace ejercicios_c_11
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
                Ejercicio No 11 
                Existen N alumnos en un salón, se pide realice una aplicación para obtener la siguiente información: 
                a) Promedio general de calificaciones. 
                b) Nombre y promedio de cada alumno. 
                c) Promedio de calificaciones de las mujeres. 
                d) Cuantos hombres tienen un promedio mayor a 9 
                Nota: cada alumno tiene 5 calificaciones. 
           */ 

           int cantidadAlumnos = 0,
                cantidadCalificacionesPorAlumno = 5,
                promedioHombresMayorA9 = 0;
            
            double 
                  promedioGeneral = 0,
                  calificacion = 0,
                  promedioAlumno = 0,
                  promedioHombres = 0,
                  promedioMujeres = 0;

            string sexo = "",
                   nombre = "";

            Console.Write("Cantidad de alumnos: ");
            cantidadAlumnos = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadAlumnos; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Alumno {i + 1}");

                Console.Write("Nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Sexo[M][F]: ");
                sexo = Console.ReadLine().ToUpper();

                for (int j = 0; j < cantidadCalificacionesPorAlumno; j++)
                {
                    Console.Write($"Calificación {j + 1}: ");
                    calificacion += double.Parse(Console.ReadLine());
                }

                promedioAlumno += calificacion / cantidadCalificacionesPorAlumno;
                promedioGeneral += promedioAlumno / cantidadAlumnos;
                if(sexo=="F") promedioMujeres += calificacion / cantidadCalificacionesPorAlumno;
                if(sexo=="M") promedioHombres += calificacion / cantidadCalificacionesPorAlumno;
                if(promedioAlumno > 9 && sexo == "M") promedioHombresMayorA9++;
                
                Console.WriteLine("----------------------------");
                Console.WriteLine("Registro");
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Promedio: {promedioAlumno}");

                calificacion = 0;
                promedioAlumno = 0;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Resultados");
            Console.WriteLine($"Promedio general: {promedioGeneral}");
            Console.WriteLine($"Promedio de mujeres: {promedioMujeres}");
            Console.WriteLine($"Cantidad de hombres con promedio mayor a 9: {promedioHombresMayorA9}"); 
        }
    }
}
