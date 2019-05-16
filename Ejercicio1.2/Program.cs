using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Andres Avila
            //Cristian Callejas
            //Fecha: 15/05/2019

            string letra = "q";
            foreach (byte a in System.Text.Encoding.UTF8.GetBytes(letra.ToCharArray()))
             Console.Write(a.ToString()+"\n");


            string letra1 = "Q";
            foreach (byte a in System.Text.Encoding.UTF8.GetBytes(letra1.ToCharArray()))
                Console.Write(a.ToString() + "\n");

            Console.ReadKey();


        }
    }
}
