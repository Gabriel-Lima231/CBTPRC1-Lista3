using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = -1;
            while (valor <= 0)
            {
                Console.Write("Digite um valor positivo para ver a tabuada: ");
                valor = int.Parse(Console.ReadLine());
                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido.");
                }
            }

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(valor + " x " + i + " = " + (valor * i));
                i++;
            }
        }
    }
}