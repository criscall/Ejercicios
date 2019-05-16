
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._4
{
    class Program
    {
        //Andres Avila
        //Cristian Callejas
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el valor de a:");
            double a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor de b:");
            double a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor de c:");
            double a3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor de d:");
            double a4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor de x:");
            double x = double.Parse(Console.ReadLine());

            CEcuacion ecu = new CEcuacion(a1, a2, a3, a4);
            Console.WriteLine(ecu.ValorPara(x));
            Console.ReadKey();

        }
    }
}
