using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool executarGlobal = true;
            while (executarGlobal)
            {
                int n = 0;
                while (n <= 0 || n >= 20)
                {
                    Console.Write("Digite a quantidade de números (N positivo e menor que 20): ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0 || n >= 20)
                    {
                        Console.WriteLine("Erro! Quantidade inválida.");
                    }
                }

                double maior = 0;
                double menor = 0;
                double soma = 0;
                int positivos = 0;
                int negativos = 0;
                int cont = 1;

                while (cont <= n)
                {
                    Console.Write("Digite o " + cont + "º número: ");
                    double valor = double.Parse(Console.ReadLine());

                    if (cont == 1)
                    {
                        maior = valor;
                        menor = valor;
                    }
                    else
                    {
                        if (valor > maior)
                        {
                            maior = valor;
                        }
                        if (valor < menor)
                        {
                            menor = valor;
                        }
                    }

                    soma += valor;

                    if (valor > 0)
                    {
                        positivos++;
                    }
                    else if (valor < 0)
                    {
                        negativos++;
                    }

                    cont++;
                }

                double media = soma / n;
                double pctPositivos = ((double)positivos / n) * 100;
                double pctNegativos = ((double)negativos / n) * 100;

                Console.WriteLine("a. Maior valor: " + maior);
                Console.WriteLine("b. Menor valor: " + menor);
                Console.WriteLine("c. Soma dos valores: " + soma);
                Console.WriteLine("d. Média aritmética: " + media);
                Console.WriteLine("e. Porcentagem de valores positivos: " + pctPositivos + "%");
                Console.WriteLine("f. Porcentagem de valores negativos: " + pctNegativos + "%");

                string continuar = "";
                while (continuar != "S" && continuar != "N")
                {
                    Console.Write("Deseja uma nova execução do programa? (S/N): ");
                    continuar = Console.ReadLine().ToUpper();
                    if (continuar != "S" && continuar != "N")
                    {
                        Console.WriteLine("Resposta inválida! Digite apenas S ou N.");
                    }
                }

                if (continuar == "N")
                {
                    executarGlobal = false;
                }
            }
        }
    }
}