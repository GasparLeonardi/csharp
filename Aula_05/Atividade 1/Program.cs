namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };

            int indice;
            
            Console.WriteLine("Digite o número que você deseja encontrar: ");
            indice = Convert.ToInt32(Console.ReadLine());

            if (Array.IndexOf(vetor01, indice) == -1)
                {
                    Console.WriteLine($"\nO número {indice} não foi encontrado!");
                }
                else {
                    
                    Console.WriteLine($"\nO número {indice} está localizado na posição: " + Array.IndexOf(vetor01, indice));

                }
                
            }


        }
    }
