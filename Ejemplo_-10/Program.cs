using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo__10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto del consumo: ");
            double montoConsumo = Convert.ToDouble (Console.ReadLine());

            double descuento = 0;
            double impuesto = 0.18;
            double subtotal = montoConsumo;

            if (montoConsumo<= 100)
            {
                descuento = montoConsumo * 0.10;

            }
            else
            {
                descuento = montoConsumo * 0.20;
            }

            double totalAntesImpuesto = subtotal - descuento;
            double montoImpuesto = totalAntesImpuesto * impuesto;
            double totalConImpuesto = totalAntesImpuesto + montoImpuesto;

            Console.WriteLine($"Monto del descuento: S/ {descuento}");
            Console.WriteLine($"Impuesto : S/ {montoImpuesto}");
            Console.WriteLine($"Subtotal : S/ {subtotal}");
            Console.WriteLine($"Importe a pagar : S/ {totalConImpuesto}");
            Console.ReadKey();

        }
    }
}
