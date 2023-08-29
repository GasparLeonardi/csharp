using System.Runtime.ConstrainedExecution;

namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coresL = new List<string>();
            string? cores; 

            
            for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Escolha 5 cores: ");
                cores = Console.ReadLine();
                coresL.Add(cores);
            }

            Console.WriteLine("\nListar todas as cores:\n");
            foreach (string cor in coresL)
            {
                Console.WriteLine(cor);
            }
            coresL.Sort();
            Console.WriteLine("\nOrdenar as cores:\n");
            foreach (string cor in coresL)
            {
                Console.WriteLine(cor);
            }

        }
    }
}