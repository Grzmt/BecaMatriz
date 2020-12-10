using System;

namespace BecaMatriz
{
    class Program
    {
        static void Main (string[] args)
        {
            // Cada Becario deverá criar um metódo para calcular a soma da diagonal principal de uma matriz quadrada 3 x 3 
            // O método deverá ter o nome do participante
            // exemplo: CalculaSomaDiagonalPrincipal_Ricardo();

            Program alg = new Program();
            CalculaSomaDiagonalPrincipal_Guilherme();

            void CalculaSomaDiagonalPrincipal_Guilherme()
            {
                int[,] matriz = new int[3, 3];

                matriz[0, 0] = 56;
                matriz[0, 1] = 34;
                matriz[0, 2] = 54;
                matriz[1, 0] = 45;
                matriz[1, 1] = 85;
                matriz[1, 2] = 95;
                matriz[2, 0] = 62;
                matriz[2, 1] = 84;
                matriz[2, 2] = 98;

                int soma = matriz[0, 0] + matriz[1, 1] + matriz[2, 2];
                Console.WriteLine(soma);
                Console.Read();
            }
        }
    }
}
