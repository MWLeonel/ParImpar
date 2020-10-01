using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine();
                Console.WriteLine($"O número digitado {numero} é PAR!");
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"O número digitado {numero} é ÍMPAR!");
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
            }
        }
    }
}
