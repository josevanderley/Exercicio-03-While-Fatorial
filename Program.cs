using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03_While_Fatoral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro não negativo: ");
            int numero;

            // Certifique-se de que o usuário insira um número inteiro não negativo
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Por favor, insira um número inteiro não negativo válido: ");
            }

            int fatorial = 1;
            int i = 1;

            // Calcula o fatorial usando uma estrutura de repetição do-while
            do
            {
                fatorial *= i;
                i++;
            } while (i <= numero);

            Console.WriteLine($"O fatorial de {numero} é {fatorial}");

            Console.WriteLine("Digite 1 para sair");

            Console.ReadKey();

        }
    }
}
   
