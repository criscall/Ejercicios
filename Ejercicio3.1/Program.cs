using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3._1
{
    class Program
    {
        //Andres Avila
        //Cristian Callejas
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el radio ");
            var radio = Console.ReadLine();
            var respuesta = double.TryParse(radio, out double val);
            
            if (respuesta == (true))
            {
                val = double.Parse(radio);
                double po = Math.Pow(val, 3);
                double res = 4  * Math.PI * po / 3;
                Console.WriteLine($"Resultado: {res}");
                Console.ReadLine();
            }
            else
            {
                Console.Write("ERROR, RECUERDE QUE EL VALOR INGRESADO DEBE SER NUMERO ");
            }
        }
    }
}
