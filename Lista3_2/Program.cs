using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            double primeiro = double.Parse(Console.ReadLine());
            double segundo = primeiro;

            while (segundo <= primeiro)
            {
                Console.Write("Digite o segundo valor (deve ser maior que o primeiro): ");
                segundo = double.Parse(Console.ReadLine());
                if (segundo <= primeiro)
                {
                    Console.WriteLine("Erro! O segundo valor precisa ser estritamente maior.");
                }
            }
            Console.WriteLine("Valores aceitos: " + primeiro + " e " + segundo);
        }
    }
}