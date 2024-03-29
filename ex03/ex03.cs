using System;
/*
    3) Faça um programa que receba uma matriz 10x10 e calcule a media dos elementos da 
    diagonal principal e da diagonal secundária. 
*/

class Program
{
    static void Main()
    {
        int[,] mat = new int[10, 10];
        //Random random = new Random();

        int somaDP = 0, somaDS = 0;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"Digite o elemento {i} x {j}: ");

                if (!int.TryParse(Console.ReadLine(), out mat[i, j]))
                {
                    Console.WriteLine("Valor inválido! Tente novamente");
                    j--;
                }

                //mat[i, j] = random.Next(-10, 11);
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Matriz:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                int num = mat[i, j];
                if (i == j)
                {
                    somaDP += num;
                }

                if (i + j == 9)
                {
                    somaDS += num;
                }

                Console.Write(num + " ");
            }

            Console.WriteLine();
        }

        float mediaDP = (float)somaDP / 10;
        float mediaDS = (float)somaDS / 10;

        Console.WriteLine();
        Console.WriteLine("Média dos elementos da diagonal principal: " + mediaDP);
        Console.WriteLine("Média dos elementos da diagonal secundária: " + mediaDS);
    }
}