using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool calcularNovamente = true;
            while (calcularNovamente)
            {
                int n = -1;
                while (n < 0)
                {
                    Console.Write("Digite um valor para calcular o fatorial (não pode ser negativo): ");
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Erro! O número deve ser maior ou igual a zero.");
                    }
                }

                long fatorial = 1;
                int i = n;
                while (i > 1)
                {
                    fatorial *= i;
                    i--;
                }

                Console.WriteLine(n + "! = " + fatorial);

                string resposta = "";
                while (resposta != "S" && resposta != "N")
                {
                    Console.Write("Deseja fazer um novo cálculo? (S/N): ");
                    resposta = Console.ReadLine().ToUpper();
                    if (resposta != "S" && resposta != "N")
                    {
                        Console.WriteLine("Resposta inválida! Digite apenas S ou N.");
                    }
                }

                if (resposta == "N")
                {
                    calcularNovamente = false;
                }
            }
        }
    }
}
