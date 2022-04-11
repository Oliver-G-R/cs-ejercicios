using System;

namespace ejercicios_c_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio No 1
                Realizar una aplicación que permita conocer:
                a) Cuantos hombres hay en el grupo.
                b) Cuántas mujeres son de Cd. Victoria.
                c) Cuantos son egresados del Cbtis.
                d) Cuantos cumplen años en Julio 
            */

            int cantidadRegistro = 0,
                cantidadHombres = 0,
                cantidadMujeresCDV = 0,
                cantidadEgresadosCbtis = 0,
                cantidadCumpleJulio = 0;

            string cumple = "",
                   sexo = "", 
                   ciudad = "", 
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

                Console.Write("Egresado: ");
                lugarEgreso = Console.ReadLine().ToLower();  

                Console.Write("Mes de cumpleaños: ");
                cumple = Console.ReadLine().ToLower();
                Console.WriteLine("----------------------------");


                if(sexo == "M") cantidadHombres++;
                if(lugarEgreso == "cbtis") cantidadEgresadosCbtis++;
                if(cumple == "julio") cantidadCumpleJulio++;
                if(ciudad == "victoria" && sexo == "F") cantidadMujeresCDV++;

            }

            Console.WriteLine($"Cantidad de hombres: {cantidadHombres}");
            Console.WriteLine($"Cantidad de mujeres de Cd. Victoria: {cantidadMujeresCDV}");
            Console.WriteLine($"Cantidad de egresados del Cbtis: {cantidadEgresadosCbtis}");
            Console.WriteLine($"Cantidad de personas que cumplen años en Julio: {cantidadCumpleJulio}");
        
        }
    }
}
