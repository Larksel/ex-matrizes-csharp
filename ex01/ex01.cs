using System;

/*
    1) Faça um programa que preencha uma matriz de ordem 5 com números inteiros, calcule e mostre 
    - a quantidade de números negativos 
    - soma dos números positivos 
    - valores primos desse vetor. 
*/

class Program
{
    static void Main()
    {
        int[,] mat = new int[5, 5];
        Random random = new Random();

        List<int> primos = new List<int>();
        
        int quantNeg = 0;
        int somaPos = 0;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                mat[i, j] = random.Next(-5, 5);
            }
        }

        Console.WriteLine("Matriz:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                int num = mat[i, j];

                Console.Write($"{num} ");

                if (num < 0)
                {
                    quantNeg++;
                }
                else
                {
                    somaPos += num;
                }

                bool ehPrimo = true;

                for (int k = 2; k <= Math.Sqrt(num); k++)
                {
                    if (num % k == 0)
                    {
                        ehPrimo = false;
                        break;
                    }
                }

                if (ehPrimo && num > 1)
                {
                    primos.Add(num);
                }
            }

            Console.WriteLine();
        }

        Console.Write("Valores primos: ");
        foreach (int num in primos)
        {
            Console.Write(num + ", ");
        }
        Console.WriteLine();
        Console.WriteLine($"Quantidade de números negativos: {quantNeg}");
        Console.WriteLine($"Soma dos números positivos: {somaPos}");
    }
}