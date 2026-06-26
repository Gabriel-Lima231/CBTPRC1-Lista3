using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            while (x <= 0)
            {
                Console.Write("Digite o valor de X (positivo): ");
                x = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite o valor inicial do intervalo (A): ");
            int a = int.Parse(Console.ReadLine());
            int b = a;

            while (b <= a)
            {
                Console.Write("Digite o valor final do intervalo (B deve ser maior que A): ");
                b = int.Parse(Console.ReadLine());
                if (b <= a)
                {
                    Console.WriteLine("Erro! B precisa ser maior que A.");
                }
            }

            int i = b;
            while (i >= a)
            {
                Console.WriteLine(x + " x " + i + " = " + (x * i));
                i--;
            }
        }
    }
}