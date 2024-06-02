using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables para estadísticas
            int totalEntradasSol = 0, totalEntradasSombra = 0, totalEntradasPreferencial = 0;
            int acumuladoSol = 0, acumuladoSombra = 0, acumuladoPreferencial = 0;

            // Ciclo para ingresar datos de ventas
            while (true)
            {
                // Solicitar datos de la venta
                Console.Write("Ingrese el número de factura: ");
                string numeroFactura = Console.ReadLine();

                Console.Write("Ingrese la cédula del comprador: ");
                string cedula = Console.ReadLine();

                Console.Write("Ingrese el nombre del comprador: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese la localidad deseada (1- Sol Norte/Sur, 2- Sombra Este/Oeste, 3- Preferencial): ");
                int localidad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese la cantidad de entradas (máximo 4): ");
                int cantidadEntradas = int.Parse(Console.ReadLine());
                if (cantidadEntradas > 4) cantidadEntradas = 4;

                // Determinar precio y nombre de la localidad
                int precioEntrada = 0;
                string nombreLocalidad = "";

                if (localidad == 1)
                {
                    precioEntrada = 10500;
                    nombreLocalidad = "Sol Norte/Sur";
                }
                else if (localidad == 2)
                {
                    precioEntrada = 20500;
                    nombreLocalidad = "Sombra Este/Oeste";
                }
                else if (localidad == 3)
                {
                    precioEntrada = 25500;
                    nombreLocalidad = "Preferencial";
                }

                // Calcular costos
                int subtotal = cantidadEntradas * precioEntrada;
                int cargosServicios = cantidadEntradas * 1000;
                int totalPagar = subtotal + cargosServicios;

                // Mostrar información de la venta
                Console.WriteLine("\nVenta:");
                Console.WriteLine($"Número de Factura: {numeroFactura}");
                Console.WriteLine($"Cédula: {cedula}");
                Console.WriteLine($"Nombre comprador: {nombre}");
                Console.WriteLine($"Localidad: {nombreLocalidad}");
                Console.WriteLine($"Cantidad de Entradas: {cantidadEntradas}");
                Console.WriteLine($"Subtotal: {subtotal} colones");
                Console.WriteLine($"Cargos por Servicios: {cargosServicios} colones");
                Console.WriteLine($"Total a pagar: {totalPagar} colones\n");

                // Actualizar estadísticas
                if (localidad == 1)
                {
                    totalEntradasSol += cantidadEntradas;
                    acumuladoSol += subtotal;
                }
                else if (localidad == 2)
                {
                    totalEntradasSombra += cantidadEntradas;
                    acumuladoSombra += subtotal;
                }
                else if (localidad == 3)
                {
                    totalEntradasPreferencial += cantidadEntradas;
                    acumuladoPreferencial += subtotal;
                }

                // Preguntar si desea ingresar otra venta
                Console.Write("¿Desea ingresar otra venta? (s/n): ");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta != "s")
                {
                    break;
                }
            }

            // Mostrar estadísticas finales
            Console.WriteLine("\nEstadísticas finales:");
            Console.WriteLine($"Cantidad Entradas Localidad Sol Norte/Sur: {totalEntradasSol}");
            Console.WriteLine($"Acumulado Dinero Localidad Sol Norte/Sur: {acumuladoSol} colones");
            Console.WriteLine($"Cantidad Entradas Localidad Sombra Este/Oeste: {totalEntradasSombra}");
            Console.WriteLine($"Acumulado Dinero Localidad Sombra Este/Oeste: {acumuladoSombra} colones");
            Console.WriteLine($"Cantidad Entradas Localidad Preferencial: {totalEntradasPreferencial}");
            Console.WriteLine($"Acumulado Dinero Localidad Preferencial: {acumuladoPreferencial} colones");

            Console.ReadLine();
        }
    }
}
