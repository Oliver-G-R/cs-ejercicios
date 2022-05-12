using System;
namespace ejercicios_c_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio No 13 
                Un censo de X viviendas se tiene la siguiente información de cada vivienda encuestada: 
                 Calle 
                 Número 
                 Total de hombres en la vivienda 
                 Total de mujeres en la vivienda 
                 Ingreso aportado por los hombres 
                 Ingreso aportado por las mujeres 
                 Cuenta con mascota (si o no) 
                 Servicios (1= Agua y luz 2= agua, luz y teléfono 3= Agua, luz, teléfono y cable) 
                Se le solicita una aplicación que resuelva lo siguiente: 
                a) Promedio de hombres por vivienda. 
                b) Total de ingreso aportado por las mujeres. 
                c) Cuántas viviendas de la calle Aldama tienen mascotas. 
                d) Cuántas viviendas no cuentan con cable. 
                e) Promedio de ingreso aportado por los hombres. 
                f) Ingreso total de hombres y mujeres de todas las viviendas encuestadas.
            */

            int cantidadViviendas = 0,
                numCalle = 0,
                totalHombres = 0,
                totalMujeres = 0,
                tipoServicio = 0,
                cantidadPerosnasTienenMascota = 0,
                vivenCalleAldamaYTienenMascotas = 0,
                viviendasSinCable = 0,
                ingresosTotalesHombresMujeres = 0,
                ingresoAportadoHombres = 0,
                totalIngresosMujeres = 0,
                ingresoAportadoMujeres = 0;

            float promedioHombresVivienda = 0,
                  promedioHombresIngresos = 0;
                  
            string tieneMascota = "",
                   nombrecalle = "";

            Console.Write("Cantidad de viviendas: ");
            cantidadViviendas = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadViviendas; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Vivienda {i + 1}");

                Console.Write("Num Calle: ");
                numCalle = int.Parse(Console.ReadLine());

                Console.Write("Nombre Calle: ");
                nombrecalle = Console.ReadLine().ToLower();

                Console.Write("Total de hombres: ");
                totalHombres = int.Parse(Console.ReadLine());

                Console.Write("Total de mujeres: ");
                totalMujeres = int.Parse(Console.ReadLine());

                Console.Write("Ingreso aportado por los hombres: ");
                ingresoAportadoHombres = int.Parse(Console.ReadLine());

                Console.Write("Ingreso aportado por las mujeres: ");
                ingresoAportadoMujeres = int.Parse(Console.ReadLine());

                Console.Write("Tiene mascota[S/N]: ");
                tieneMascota = Console.ReadLine().ToUpper();

                Console.Write("Servicios[1= Agua y luz 2= agua, luz y teléfono 3= Agua, luz, teléfono y cable]: ");
                tipoServicio = int.Parse(Console.ReadLine());

                ingresosTotalesHombresMujeres += ingresoAportadoHombres + ingresoAportadoMujeres;
                promedioHombresVivienda += totalHombres / cantidadViviendas;
                totalIngresosMujeres += ingresoAportadoMujeres;
                promedioHombresIngresos += ingresoAportadoHombres / cantidadViviendas;
 
                if(nombrecalle == "aldama" && tieneMascota == "S") vivenCalleAldamaYTienenMascotas++;
                if (tieneMascota == "S") cantidadPerosnasTienenMascota++;
                if(tipoServicio != 3) viviendasSinCable++;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine($"Promedio de hombres por vivienda: {promedioHombresVivienda}");
            Console.WriteLine($"Total de ingreso aportado por las mujeres: {totalIngresosMujeres}");
            Console.WriteLine($"Cuántas viviendas de la calle Aldama tienen mascotas: {vivenCalleAldamaYTienenMascotas}");
            Console.WriteLine($"Cuántas viviendas no cuentan con cable: {viviendasSinCable}");
            Console.WriteLine($"Promedio de ingreso aportado por los hombres: {promedioHombresIngresos}");
            Console.WriteLine($"Ingreso total de hombres y mujeres de todas las viviendas encuestadas: {ingresosTotalesHombresMujeres}");
        }
    }
}
