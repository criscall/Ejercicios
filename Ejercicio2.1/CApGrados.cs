using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2._1
{
    //Andres Avila
    //Cristian Callejas

    class CApGrados
    {
        const int limInferior = -55;
        const int limSuperior = 90;
        const int incremento = 4;

        public static float ObtenerFahrenheit(float gradosC)
        {
            return 9F / 5F * gradosC + 32;
        }
        public static void Main(string[] args)
        {
           int gradosCent = limInferior;
           float gradosFahr = 0;
           while (gradosCent <= limSuperior)
            {
                gradosFahr = ObtenerFahrenheit(gradosCent);
                System.Console.WriteLine("{0, 8:d} C {1, 8:f2}F", gradosCent, gradosFahr);
                gradosCent += incremento;
                Console.ReadLine();

            }
            
        }
    }
}
