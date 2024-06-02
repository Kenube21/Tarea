using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operarios = 0, tecnicos = 0, profesionales = 0;
            double sn_operarios = 0, sn_tecnicos = 0, sn_profesionales = 0;

            while (true)
            {
                // Leer datos del empleado
                Console.Write("Ingrese Cedula: ");
                string cedula = Console.ReadLine();

                Console.Write("Ingrese el Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese Tipo Empleado (1-Operario, 2-Tecnico, 3-Profesional): ");
                int t_empleado = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el precio por hora: ");
                double precio_hora = double.Parse(Console.ReadLine());

                Console.Write("Ingrese Horas Laboradas: ");
                double cantidad_horas = double.Parse(Console.ReadLine());

                // Calcular el salario ordinario
                double salario_ordinario = precio_hora * cantidad_horas;

                // Calcular el aumento
                double aumento = 0;
                if (t_empleado == 1) // Operario
                {
                    aumento = salario_ordinario * 0.15;
                }
                else if (t_empleado == 2) // Técnico
                {
                    aumento = salario_ordinario * 0.10;
                }
                else if (t_empleado == 3) // Profesional
                {
                    aumento = salario_ordinario * 0.05;
                }

                // Calcular el salario bruto
                double salario_bruto = salario_ordinario + aumento;

                // Calcular la deducción del CCSS
                double deduccion = salario_bruto * 0.0917;

                // Calcular el salario neto
                double salario_neto = salario_bruto - deduccion;

                // Mostrar los resultados
                Console.WriteLine($"\nCedula: {cedula}");
                Console.WriteLine($"Nombre Empleado: {nombre}");
                Console.WriteLine($"Tipo Empleado: {t_empleado}");
                Console.WriteLine($"Salario por Hora: {precio_hora}");
                Console.WriteLine($"Cantidad de Horas: {cantidad_horas}");
                Console.WriteLine($"Salario Ordinario: {salario_ordinario}");
                Console.WriteLine($"Aumento: {aumento}");
                Console.WriteLine($"Salario Bruto: {salario_bruto}");
                Console.WriteLine($"Deducción CCSS: {deduccion}");
                Console.WriteLine($"Salario Neto: {salario_neto}\n");

                // Acumular estadísticas
                if (t_empleado == 1)
                {
                    operarios++;
                    sn_operarios += salario_neto;
                }
                else if (t_empleado == 2)
                {
                    tecnicos++;
                    sn_tecnicos += salario_neto;
                }
                else if (t_empleado == 3)
                {
                    profesionales++;
                    sn_profesionales += salario_neto;
                }

                // Preguntar si desea continuar
                Console.Write("¿Desea ingresar otro empleado? (s/n): ");
                string continuar = Console.ReadLine().ToLower();
                if (continuar != "s")
                {
                    break;
                }
            }

            // Mostrar estadísticas
            Console.WriteLine("\nEstadísticas:");
            if (operarios > 0)
            {
                Console.WriteLine($"Cantidad Empleados Tipo Operarios: {operarios}");
                Console.WriteLine($"Acumulado Salario Neto para Operarios: {sn_operarios}");
                Console.WriteLine($"Promedio Salario Neto para Operarios: {sn_operarios / operarios}");
            }

            if (tecnicos > 0)
            {
                Console.WriteLine($"Cantidad Empleados Tipo Técnico: {tecnicos}");
                Console.WriteLine($"Acumulado Salario Neto para Técnicos: {sn_tecnicos}");
                Console.WriteLine($"Promedio Salario Neto para Técnicos: {sn_tecnicos / tecnicos}");
            }

            if (profesionales > 0)
            {
                Console.WriteLine($"Cantidad Empleados Tipo Profesional: {profesionales}");
                Console.WriteLine($"Acumulado Salario Neto para Profesional: {sn_profesionales}");
                Console.WriteLine($"Promedio Salario Neto para Profesionales: {sn_profesionales / profesionales}");
            }
            Console.Read();
        }
    }
}
