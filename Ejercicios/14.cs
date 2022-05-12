using System;
namespace ejercicios_c_
{
    class Program_14
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio No 14 
                Una empresa cuenta con la siguiente información de sus X empleados: 
                 Clave 
                 Nombre 
                 Días trabajados 
                 Sueldo diario 
                 Monto de deducciones 
                 Monto de percepciones extras 
                 Área 
                 Edad 
                 Sexo 
                Realice la aplicación que solucione: 
                a) Reporte que contenga: nombre, área y sueldo neto a pagar. 
                b) Cuantos hombres trabajaron menos de 7 días. 
                c) Promedio de deducciones de los empleados de contabilidad. 
                d) Total de nómina que pago la tienda. 
                e) Promedio de días trabajados de las mujeres de área de sistemas. 
                f) Total de percepciones extras de los menores de 27 años. 
                g) Cuantos empleados que no trabajen en la administración ganan entre $5000 y $9000. 
            */

            int cantidadClientes = 0,
                diasTrabajados = 0,
                sueldoDiario = 0,
                cantidadMujeres = 0,
                edad = 0,
                sueldoNetoPagar = 0,
                cantidadEmpleadosGananciasEntre5000y9000 = 0,
                menos7diasHombres = 0,
                cantidadAreaContabilidad = 0,
                montoDePercepcionesExtras = 0;

            double  promedioDeduccionesContabilidad = 0,
                    totalNominaPagoTienda = 0,
                    percepcionExtraMenores27 = 0,
                    promedioDiasTrabajadosMujeresSistemas = 0,
                    deduccionesContabilidad = 0,
                    montoDeducciones = 0;

            string  clave = "",
                    nombre = "",    
                    area = "",
                    sexo ="";


            Console.Write("Cantidad de empleados: ");
            cantidadClientes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadClientes; i++)
            {
                Console.Write("Nombre del empleado: ");
                nombre = Console.ReadLine();

                Console.Write("Sexo [M][F]: ");
                sexo = Console.ReadLine().ToUpper();

                Console.Write("Clave: ");
                clave = Console.ReadLine();
               
                Console.Write("Edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.Write("Area: ");
                area = Console.ReadLine().ToUpper();

                Console.Write("Días trabajados: ");
                diasTrabajados = int.Parse(Console.ReadLine());

                Console.Write("Sueldo diario: ");
                sueldoDiario = int.Parse(Console.ReadLine());

                Console.Write("Monto deducciones: ");
                montoDeducciones = double.Parse(Console.ReadLine());
                
                Console.Write("Monto Percepciones extras: ");
                montoDePercepcionesExtras = int.Parse(Console.ReadLine());

                sueldoNetoPagar = (sueldoDiario + montoDePercepcionesExtras) * diasTrabajados;

                if(diasTrabajados < 7 ) menos7diasHombres ++;
                if(area == "CONTABILIDAD") {
                    cantidadAreaContabilidad ++;
                    deduccionesContabilidad += montoDeducciones;
                }
                if(sexo == "F") cantidadMujeres ++;

                totalNominaPagoTienda += sueldoNetoPagar;
                promedioDeduccionesContabilidad = deduccionesContabilidad / cantidadAreaContabilidad;

                if(sexo == "F" && area == "SISTEMAS")
                    promedioDiasTrabajadosMujeresSistemas += diasTrabajados / cantidadMujeres;
                if(edad < 27) percepcionExtraMenores27 += montoDePercepcionesExtras;

                //Cuantos empleados que no trabajen en la administración ganan entre $5000 y $9000
                if(area != "ADMINISTRACION" && sueldoNetoPagar >= 5000 && sueldoNetoPagar <= 9000)
                    cantidadEmpleadosGananciasEntre5000y9000 ++;
                    

                Console.WriteLine("----------------------------");
                Console.WriteLine($"Reporte empleado {i+1}");
                Console.WriteLine($"Nombre {nombre}");
                Console.WriteLine($"Area {area}");
                Console.WriteLine($"Sueldo neto a pagar {sueldoNetoPagar - montoDeducciones}");
                Console.WriteLine("----------------------------");

                
            }

            Console.WriteLine($"Cantidad de hombres que trabajaron menos de 7 días {menos7diasHombres}");
            Console.WriteLine($"Promedio de deducciones de los empleados de contabilidad {promedioDeduccionesContabilidad}");
            Console.WriteLine($"Total de nómina que pago la tienda {totalNominaPagoTienda}");
            Console.WriteLine($"Promedio de días trabajados de las mujeres de área de sistemas {promedioDiasTrabajadosMujeresSistemas}");
            Console.WriteLine($"Total de percepciones extras de los menores de 27 años {percepcionExtraMenores27}");
            Console.WriteLine($"Cantidad de empleados que no trabajen en la administración ganan entre $5000 y $9000 {cantidadEmpleadosGananciasEntre5000y9000}");
        }
    }
}
