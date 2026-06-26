using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int termo1 = 1;
            int termo2 = 1;
            Console.Write(termo1 + ", " + termo2);

            int cont = 3;
            while (cont <= 30)
            {
                int proximo = termo1 + termo2;
                Console.Write(", " + proximo);
                termo1 = termo2;
                termo2 = proximo;
                cont++;
            }
            Console.WriteLine();
        }
    }
}
