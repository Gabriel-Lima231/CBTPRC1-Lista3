using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabuada = 1;
            while (tabuada <= 20)
            {
                Console.WriteLine("--- TABUADA DO " + tabuada + " ---");
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine(tabuada + " x " + i + " = " + (tabuada * i));
                    i++;
                }
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
                tabuada++;
            }
        }
    }
}
