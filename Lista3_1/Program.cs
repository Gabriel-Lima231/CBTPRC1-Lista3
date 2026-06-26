using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = -1;
            while (valor <= 0)
            {
                Console.Write("Digite um valor positivo: ");
                valor = double.Parse(Console.ReadLine());
                if (valor <= 0)
                {
                    Console.WriteLine("Erro! O valor deve ser positivo.");
                }
            }
            Console.WriteLine("Valor válido cadastrado: " + valor);
        }
    }
}