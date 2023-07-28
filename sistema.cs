using System;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            int function;
            int[] notasDisponiveis = { 100, 50, 10, 5, 1 };

            Console.Write("Digite o valor do saque: ");
            int valorSaque = int.Parse(Console.ReadLine());

            if (valorSaque < 10 || valorSaque > 600)
            {
                Console.WriteLine("Valor de saque inválido. Valores válidos estão entre 10 e 600.");
            }
            else
            {
                Console.WriteLine("Quantidade de notas fornecidas:");
                foreach (int nota in notasDisponiveis)
                {
                    int quantidadeNotas = valorSaque / nota;
                    valorSaque %= nota;
                    Console.WriteLine($"{quantidadeNotas} nota(s) de {nota} reais");
                }
            }

        }
    }
}
