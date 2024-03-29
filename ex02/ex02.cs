using System;

/*
    2)Crie um programa que preencha uma matriz 2x4 com números inteiros, calcule e mostre:
    a)A quantidade de elementos entre 12 e 20 em cada linha;
    b)A média dos elementos pares da matriz.
*/

class Program
{
    static void Main()
    {
        int[,] mat = new int[2, 4];
        Random random = new Random();

        int qntL1 = 0;
        int qntL2 = 0;
        int somaPares = 0;
        int qntPares = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                mat[i, j] = random.Next(0, 31);
            }
        }

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int num = mat[i, j];

                Console.Write(num + " ");

                if (num % 2 == 0)
                {
                    qntPares++;
                    somaPares += num;
                }

                if (num >= 12 && num <= 20)
                {
                    if (i == 0)
                    {
                        qntL1++;
                    } else
                    {
                        qntL2++;
                    }
                }
            }

            Console.WriteLine();
        }

        float mediaPares = (float) somaPares / qntPares;

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Quantidade de elementos entre 12 e 20: ");
        Console.WriteLine("- Linha 1: " + qntL1);
        Console.WriteLine("- Linha 2: " + qntL2);
        Console.WriteLine("Media dos elementos pares: " + mediaPares);
    }
}