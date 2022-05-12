using System;
namespace ejercicios_c_
{
    class Program_17
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio 17 
                Un hospital atiende a G pacientes internados, se tiene la siguiente infiormación: 
                 Nombre del paciente 
                 Piso 
                 Cama que ocupa 
                 Enfermedad diagnosticada 
                 Edad 
                 Sexo 
                 Fecha de ingreso 
                 Días que estará internado 
                Se le solicita una aplicación que proporcione la siguiente información: 
                a) Cuántas mujeres se encuentran en el segundo piso
                b) Cuál es el promedio de edad del primer piso 
                c) A cuántos hombres se les diagnosticó cálculo 
                d) Un reporte que contenga: nombre del paciente, diagnóstico, fecha de ingreso y 
                fecha de alta 
                e) Promedio de días que estarán las mujeres 
                f) Cuantos pacientes con asma están en el 3er piso 
                g) Cuantos menores de edad se encuentran internados 
            */

            string  piso = "",
                    nombrePaciente,
                    camaOcupa = "",
                    diagnosticoEnfermedad,
                    fechaIngreso,
                    fechaAlta,
                    sexo;

            int edad = 0,
                personasPiso1 = 0,
                cantidadMujeres = 0,
                cantidadPacientes = 0,
                cantidadMujeresPrimerPiso = 0,
                cantidadHombresDIagonticoCalculo = 0,
                cantidadPacientesAsma3erPiso = 0,
                cantidadMneoresEdad = 0,
                diasInternado = 0;

            float   promedioEdadPrimerPiso = 0,
                    promedioDiasEstanMujeres= 0;

            
            Console.Write("Cantidad de pacientes: ");
            cantidadPacientes = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidadPacientes; i++)
            {
                Console.Write("Nombre del paciente: ");
                nombrePaciente = Console.ReadLine();
                Console.Write("Piso: ");
                piso = Console.ReadLine();
                Console.Write("Cama que ocupa: ");
                camaOcupa = Console.ReadLine();
                Console.Write("Diagnostico de enfermedad: ");
                diagnosticoEnfermedad = Console.ReadLine().ToLower();
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Fecha de ingreso: ");
                fechaIngreso = Console.ReadLine();
                Console.Write("Fecha de alta: ");
                fechaAlta = Console.ReadLine();
                Console.Write("Sexo [M][F]: ");
                sexo = Console.ReadLine().ToLower();
                Console.Write("Dias que estará internado: ");
                diasInternado = int.Parse(Console.ReadLine());

                if(piso == "1") personasPiso1++;
                if(piso == "1") promedioEdadPrimerPiso += edad / personasPiso1;
                if(sexo == "f") cantidadMujeres++;
                if(sexo =="f" && piso =="1") cantidadMujeresPrimerPiso++;
                if(sexo =="m" && diagnosticoEnfermedad =="calculo") cantidadHombresDIagonticoCalculo++;
                if(sexo == "f") promedioDiasEstanMujeres += diasInternado / cantidadMujeres;
                if(diagnosticoEnfermedad =="asma" && piso == "3") cantidadPacientesAsma3erPiso++;
                if(edad < 18) cantidadMneoresEdad++;

                Console.WriteLine("----------------------------");
                Console.WriteLine($"Paciente: {i+1}");
                Console.WriteLine($"Nombre del paciente: {nombrePaciente}");
                Console.WriteLine($"Diagnostico: {diagnosticoEnfermedad}");
                Console.WriteLine($"Fecha de ingreso: {fechaIngreso}");
                Console.WriteLine($"Fecha de alta: {fechaAlta}");
                Console.WriteLine("----------------------------");
              
            }

            Console.WriteLine($"Cantidad de mujeres en el segundo piso: {cantidadMujeresPrimerPiso}");
            Console.WriteLine($"Promedio de edad del primer piso: {promedioEdadPrimerPiso}");
            Console.WriteLine($"Cantidad de hombres diagnosticados con cálculo: {cantidadHombresDIagonticoCalculo}");
            Console.WriteLine($"Promedio de días que estarán las mujeres: {promedioDiasEstanMujeres}");
            Console.WriteLine($"Cantidad de pacientes con asma en el 3er piso: {cantidadPacientesAsma3erPiso}");
            Console.WriteLine($"Cantidad de menores de edad internados: {cantidadMneoresEdad}");

        }
    }
}
