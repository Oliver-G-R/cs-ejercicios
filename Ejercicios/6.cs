using System;

namespace ejercicios_c_6
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
                Ejercicio No 6
                La FCAV le solicita una aplicación que permita obtener la siguiente información de sus X alumnos.
                a) Cuantos hombres estudian el 4° semestre de la carrera de C.P.
                b) Cuántas mujeres tiene entre 17 y 21 años.
                c) Cuantos alumnos no nacieron en Cd. Victoria.
                d) Cuantos alumnos estudian el 9° semestre.
                e) Cuantos alumnos de la carrera de L.T.I. son egresaron del CBTIS o Prepa n° 1. 

           */

            int cantidadRegistro = 0,
                semestre = 0,
                edad = 0,
                cantidadHombres = 0,
                noNacidosCdV = 0,
                cantidadAlumnos9Semestre = 0,
                egresadosCbtis = 0,
                cantidadMujeres1721 = 0;

            string sexo = "",
                   ciudad = "",
                   carrera = "",
                   lugarEgreso = "";

            Console.Write("Cantidad de registros: ");
            cantidadRegistro = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadRegistro; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Registro {i + 1}");
                Console.Write("Ciudad de procedencia: ");
                ciudad = Console.ReadLine().ToLower();

                Console.Write("Sexo [F][M]: ");
                sexo = Console.ReadLine().ToUpper();

                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.Write("Egresado: ");
                lugarEgreso = Console.ReadLine();

                Console.Write("Semestre: ");
                semestre = int.Parse(Console.ReadLine());

                Console.Write("Carrera: ");
                carrera = Console.ReadLine().ToUpper();

                if(sexo == "M" && semestre == 4 && carrera == "C.P") cantidadHombres++;
                if(sexo == "F" && edad >= 17 && edad <= 21) cantidadMujeres1721++;
                if(ciudad != "victoria") noNacidosCdV++;
                if(semestre == 9) cantidadAlumnos9Semestre++;
                if(lugarEgreso.Contains("cbtis") || lugarEgreso.Contains("prepa n° 1") && carrera == "LTI") egresadosCbtis++;

                Console.WriteLine("----------------------------");
            }

            Console.WriteLine($"Cantidad de hombres que estudian el 4° semestre de la carrera de C.P.: {cantidadHombres}");
            Console.WriteLine($"Cantidad de mujeres que tienen entre 17 y 21 años: {cantidadMujeres1721}");
            Console.WriteLine($"Cantidad de alumnos que no nacieron en Cd. Victoria: {noNacidosCdV}");
            Console.WriteLine($"Cantidad de alumnos que estudian el 9° semestre: {cantidadAlumnos9Semestre}");
            Console.WriteLine($"Cantidad de alumnos de la carrera de L.T.I. que egresaron del CBTIS o Prepa n° 1: {egresadosCbtis}");
        }
    }
}
