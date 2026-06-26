using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maior = 0;
            double soma = 0;
            int cont = 1;

            while (cont <= 10)
            {
                double valor = -1;
                while (valor <= 0)
                {
                    Console.Write("Digite o " + cont + "º valor positivo: ");
                    valor = double.Parse(Console.ReadLine());
                    if (valor <= 0)
                    {
                        Console.WriteLine("Erro! Apenas números positivos.");
                    }
                }

                if (cont == 1)
                {
                    maior = valor;
                }
                else if (valor > maior)
                {
                    maior = valor;
                }

                soma += valor;
                cont++;
            }

            double media = soma / 10;
            Console.WriteLine("a. Maior valor: " + maior);
            Console.WriteLine("b. Soma dos valores: " + soma);
            Console.WriteLine("c. Média aritmética: " + media);
        }
    }
}