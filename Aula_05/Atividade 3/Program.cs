namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz01 = { { 1, 2, 3 , 4}, { 5, 6, 7, 8 }, { 9, 10, 11, 12} , {13,14,15,16 } };
            int somaDiagonal = 0, n = 4, somaSec = 0;

            Console.Write($"\nElementos da Diagonal Principal: \n");
            

            for (int indiceLinha = 0; indiceLinha < Math.Sqrt(matriz01.Length); indiceLinha ++)
            {
                for (int indiceColuna = 0; indiceColuna < Math.Sqrt(matriz01.Length); indiceColuna++)
                {
                    Console.Write($"{matriz01[indiceLinha, indiceColuna]} ");
                    if (indiceLinha == indiceColuna) {
                        somaDiagonal = somaDiagonal + matriz01[indiceColuna, indiceLinha];
                    }
                    indiceLinha++;
                }
            }
            Console.Write($"\nSoma dos elementos da Diagonal Principal: {somaDiagonal}\n");

            ///////////////////////////////////
            ///
            Console.Write($"\nElementos da Diagonal Secundária: \n");

            for (int indiceLinha = 0; indiceLinha < n; indiceLinha++)
            {
                for (int indiceColuna = 0; indiceColuna < n; indiceColuna++)
                {
                    if ((indiceLinha + indiceColuna) == (n - 1))
                    {
                        Console.Write($"{matriz01[indiceLinha, indiceColuna]} ");
                        somaSec = somaSec + matriz01[indiceColuna, indiceLinha];
                    }
                }
            }
            Console.Write($"\nSoma dos elementos da Diagonal Secundária: {somaSec}\n");


        }
    }
}