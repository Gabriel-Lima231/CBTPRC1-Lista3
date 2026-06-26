using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int i = 1;
            while (i <= 100)
            {
                soma += i;
                i++;
            }
            Console.WriteLine("A soma dos inteiros de 1 a 100 é: " + soma);
        }
    }
}
