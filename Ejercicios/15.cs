using System;
namespace ejercicios_c_
{
    class Program_15
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio No 15 
                La CFE cuenta con los siguientes datos de sus X usuarios: 
                 Clave del cliente 
                 Nombre del cliente 
                 Dirección 
                 Lectura anterior 
                 Lectura actual 
                 Zona (1 = residencial 2 = urbana 3 = rural 
                 Tipo de servicio (a = comercial B = residencial) 
                 Costo por kw consumido 

                Realice la aplicación que proporcione: 
                a) Cuál es el ingreso de la zona residencial. 
                b) Cual fue el promedio de consumo en Kw de la zona urbana. 
                c) Cuantos usuarios del tipo comercial tuvieron un consumo menor de 1000 Kw. 
                d) Ingreso total por concepto de cobro del servicio de luz de los X usuarios. 
                e) Cuantos usuarios son de la zona rural. 
                f) Cuantos usuarios tuvieron un excedente menor a 100 kw. 
                g) Cuantos usuarios no pagaron excedente. 
                h) Cuantos usuarios de la zona urbana pagaron menos de $1357. 
                i) Promedio de usuarios por zona. 
            */

            int cantidadUsuarios = 0,
                lecturaAnterior = 0,
                lecturaActual = 0,
                consumoKwPersona = 0,
                /* ingresoZonaResidencial = 0,
                costoPersonaPKwConsumido = 0, */
                zona = 0,
                costoPorKwConsumido = 0;

            string  clave = "",
                    nombre = "",
                    direccion = "",
                    tipoDeServicio = "";

            for (int i = 0; i < cantidadUsuarios; i++)
            {
                Console.Write("Clave del cliente: ");
                clave = Console.ReadLine();

                Console.Write("Nombre del cliente: ");
                nombre = Console.ReadLine();

                Console.Write("Dirección: ");
                direccion = Console.ReadLine();

                Console.Write("Lectura anterior: ");
                lecturaAnterior = int.Parse(Console.ReadLine());

                Console.Write("Lectura actual: ");
                lecturaActual = int.Parse(Console.ReadLine());

                Console.Write("Zona (1 = residencial 2 = urbana 3 = rural): ");
                zona = int.Parse(Console.ReadLine());

                Console.Write("Tipo de servicio (a = comercial B = residencial): ");
                tipoDeServicio = Console.ReadLine().ToLower();

                Console.Write("Costo por kw consumido: ");
                costoPorKwConsumido = int.Parse(Console.ReadLine());

                consumoKwPersona = lecturaActual - lecturaAnterior;
                if(zona == 1 && tipoDeServicio == "a"){}
                else if(zona == 1 && tipoDeServicio == "b"){}
                else if(zona == 2 && tipoDeServicio == "a"){}
                else if(zona == 2 && tipoDeServicio == "b"){}
                else if(zona == 3 && tipoDeServicio == "a"){}
                else if(zona == 3 && tipoDeServicio == "b"){}




            }
            

        }
    }
}
