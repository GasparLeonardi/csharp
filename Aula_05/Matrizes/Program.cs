﻿namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz01 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] matriz02 = new int[2, 2];
            int[,] matriz03 = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[] vetor = { 1, 2, 3, 4, 5 };

            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz01.Length); indiceLinha++) 
            { 
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz01.Length); indiceColuna++) 
                {
                    Console.WriteLine($"matriz01[{indiceColuna}, {indiceLinha}] = {matriz01[indiceLinha, indiceColuna]}");
                }
            }
            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz02.Length); indiceColuna++)
                {
                    Console.WriteLine($"matriz02[{indiceLinha}, {indiceColuna}] = ");
                    matriz02[indiceLinha, indiceColuna] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz02.Length); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz02.Length); indiceColuna++)
                {
                    Console.WriteLine($"matriz02[{indiceLinha}, {indiceColuna}] = {matriz02[indiceLinha, indiceColuna]}");
                }
            }

            for (int indiceLinha = 0; indiceLinha < matriz03.GetLength(0); indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < matriz03.GetLength(1); indiceColuna++)
                {
                    Console.WriteLine($"matriz03[{indiceLinha}, {indiceColuna}] = {matriz03[indiceLinha, indiceColuna]}");
                }
            }

            foreach (int elemento in vetor) 
            {
                Console.WriteLine(elemento);
            }
        }
    }
}