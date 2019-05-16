using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        //Andres Avila
        //Cristian Callejas

        static void Main(string[] args)
        {
            //Autor: Cristian Callejas
            //Fecha: 15/05/2019

            int a = 10, b = 3, c = 1, d, e;
            float x, y;
            x = a / b;

            //c = a < b && c;
            if ((a < b) && (a<c)) ; //el error se daba por que cuando hay una comparacion debe  ser una condicion 

            d = a + b++;
            e = ++a - b;
            y = (float)a / b;
        }
    }
}
