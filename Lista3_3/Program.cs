using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo = "";
            while (sexo != "F" && sexo != "M")
            {
                Console.Write("Digite o sexo (F/M): ");
                sexo = Console.ReadLine().ToUpper();
                if (sexo != "F" && sexo != "M")
                {
                    Console.WriteLine("Resposta inválida! Tente novamente.");
                }
            }
            Console.WriteLine("Sexo validado com sucesso: " + sexo);
        }
    }
}
