using System;

namespace Licao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3) Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule \n" +
                                  " mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula:\n" +
                                  " DIFERENCA = (A * B - C * D).");
            Console.WriteLine();
            int A = 5;
            int B = 6;
            int C = 7;
            int D = 8;
            int DF = (A * B - C * D);
            Console.WriteLine("A diferenca e " + DF);
            Console.WriteLine();
            int A1 = 5;
            int B2 = 6;
            int C3 = -7;
            int D4 = 8;
            int DF2 = A1 * B2 - C3 * D4;
            Console.WriteLine("A diferenca e " + DF2);

            
        }
    }
}
