using System;
namespace ejercicios_c_
{
    class Program_16
    {
        static void Main(string[] args)
        {
            /*
                Ejercicio No 16 
                Un supermercado tiene la siguiente información de X clientes: 
                 Total de artículos adquiridos 
                 Descripción de cada artículo 
                 Precio de cada artículo 
                 Unidades adquiridas de cada artículo 
                Se le solicita realizar una aplicación que proporcione la siguiente información: 
                a) Cuanto pagará cada cliente por la despensa 
                b) Cuanto fue el ingreso total 
                c) Cuantos clientes compraron Atún 
                d) Cuantos clientes compraron mas de un kilo de tomate 
                e) Cuantos clientes compraron menos de 1 kilo de carne 
                f) Cuantos kilos de papa de vendieron 
                g) Que producto se vendió mas, la uva roja o la uva blanca 
            */

            int cantidadClientes = 0,
                totalArticulosAdquiridos = 0,
                precioCadaArticulo = 0,
                cantidadClientesCompraAtun = 0,
                uvaRojaCantidad = 0,
                ingresoTotal = 0,
                uvaBlancaCantidad = 0,
                cantidadClientesCompraMasDeUnKiloTomate = 0,
                cantidadClientesCompraMenosDeUnKiloCarne = 0,
                costoTotalDespensa = 0,
                unidadesAdquiridas = 0;

            string  descripcion = "",
                    productoQueSeVendioMasUvas = "";

                
            float   kilo = 0, 
                    ventaKilosPapa = 0;
            
            Console.Write("Cantidad de clientes: ");
            cantidadClientes = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadClientes; i++)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Cliente {i + 1}");

                Console.Write("Total de artículos adquiridos: ");
                totalArticulosAdquiridos = int.Parse(Console.ReadLine());

                for (int j = 0; j < totalArticulosAdquiridos; j++)
                {
                    Console.WriteLine("----------------------------");
                    Console.WriteLine($"Artículo {j + 1}");

                    Console.Write("Descripción: ");
                    descripcion = Console.ReadLine().ToLower();

                    Console.Write("Precio: ");
                    precioCadaArticulo = int.Parse(Console.ReadLine());

                    Console.Write("Kilos: ");
                    kilo = float.Parse(Console.ReadLine());

                    Console.Write("Unidades adquiridas: ");
                    unidadesAdquiridas = int.Parse(Console.ReadLine());

                    costoTotalDespensa += precioCadaArticulo * unidadesAdquiridas;

                    if(descripcion.Contains("atun")) cantidadClientesCompraAtun++;
                    if(descripcion.Contains("tomate") && kilo > 1) cantidadClientesCompraMasDeUnKiloTomate++;
                    if(descripcion.Contains("carne") && kilo < 1)  cantidadClientesCompraMenosDeUnKiloCarne++;
                    if(descripcion.Contains("papa")) ventaKilosPapa += kilo;
                    if(descripcion.Contains("uva roja")) uvaRojaCantidad += unidadesAdquiridas;
                    if(descripcion.Contains("uva blanca")) uvaBlancaCantidad += unidadesAdquiridas;
                }


                Console.WriteLine("----------------------------");
                Console.WriteLine($"Costo total a pagar por despensa: ${costoTotalDespensa}");
            }
            if(uvaBlancaCantidad > uvaRojaCantidad) 
                productoQueSeVendioMasUvas = "Uva blanca";
            else productoQueSeVendioMasUvas = "Uva roja";
            ingresoTotal += costoTotalDespensa * cantidadClientes;
            
            Console.WriteLine($"Ingreso Total: {ingresoTotal}");
            Console.WriteLine($"Cantidad de clientes que compraron Atún: {cantidadClientesCompraAtun}");
            Console.WriteLine($"Cantidad de clientes que compraron mas de un kilo de tomate: {cantidadClientesCompraMasDeUnKiloTomate}");
            Console.WriteLine($"Cantidad de clientes que compraron menos de 1 kilo de carne: {cantidadClientesCompraMenosDeUnKiloCarne}");
            Console.WriteLine($"Cantidad de kilos de papa vendidos: {ventaKilosPapa}");
            Console.WriteLine($"Producto que se vendió mas entre las uvas: {productoQueSeVendioMasUvas}");
        }
    }
}
