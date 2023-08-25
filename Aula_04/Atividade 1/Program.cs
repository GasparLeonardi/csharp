namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite dois números, sendo que o segundo deve ser maior que o primeiro!");
            Console.WriteLine("Digite o primeiro número do intervalo:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número do intervalo:");
            num2 = Convert.ToInt32(Console.ReadLine());


            if (num1 < num2)
            {
                Console.WriteLine($"No Intervalo entre {num1} e {num2}:");
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        
                        Console.WriteLine($"{i} é múltiplo de 3 e 5.");
                    }
                }
            } else { Console.WriteLine("Intervalo inválido!"); }
        }
    }
}