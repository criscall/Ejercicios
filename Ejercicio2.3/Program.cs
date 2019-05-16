using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._3
{
    class CApGrados
    {
        //Andres Avila
        //Cristian Callejas

        public static void Main(string[] args)
        {
            int gradosCent = CGrados.limInferior;
            float gradosFahr = 0;
            while (gradosCent <= CGrados.limSuperior)
            {
                gradosFahr = CGrados.ObtenerFahrenheit(gradosCent);
                System.Console.WriteLine("{0, 8:d} C {1, 8:f2}F", gradosCent, gradosFahr);
                gradosCent += CGrados.incremento;
            }
            Console.ReadLine();
        }
    }
    static class CGrados
    {
        public const int limInferior = -55;
        public const int limSuperior = 90;
        public const int incremento = 4;

        public static float ObtenerFahrenheit(float gradosC)
        {
            return 9 / 5 * gradosC + 32;
        }

    }


}
