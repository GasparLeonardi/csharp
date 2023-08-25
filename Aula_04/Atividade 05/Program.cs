namespace Atividade_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num, soma = 0;
            
            do
                {
                    Console.WriteLine("\nDigite um número: ");
                    num = Convert.ToInt32(Console.ReadLine());
                if (num > 0) { soma = num + soma; }

                } while (num != 0);


            Console.WriteLine($"\nA soma dos números positivos é: {soma}");

        }
    }
}