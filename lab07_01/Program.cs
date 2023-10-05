using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lab07_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, limite;
            float resultado, total;
            resultado = 0f;
            total = 0f;
            Console.Write("Ingrese el valor de n: ");
            limite = int.Parse(Console.ReadLine());

            for (i=1; i<=limite; i++)
            {
                resultado = (16f - i) / (3f * i);
                Console.WriteLine("resultado: " + resultado);
                total = total + resultado; 
            }
            Console.WriteLine("total: " + total);
            Console.ReadKey();
        }
    }
}
