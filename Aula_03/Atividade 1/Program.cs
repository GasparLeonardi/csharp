namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA, numB, numC, resultado;

            Console.WriteLine($"Vamos verificar se A + B é maior ou menor que C!");
            Console.WriteLine($"\nEscolha um valor para A? ");
            numA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nEscolha um valor para B? ");
            numB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nEscolha um valor para C? ");
            numC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nO resultado de {numA} + {numB} é: " + (numA + numB));

            resultado = numA + numB;

            if (numA + numB > numC)
            {
                Console.WriteLine($"\nLogo a soma de A + B é Maior do que C({numC})!");
            }
            else if (resultado==numC) {
                Console.WriteLine($"\nLogo a soma de A + B é Igual a C({numC})!");
            } else {
                Console.WriteLine($"\nLogo a soma de A + B é Menor do que C({numC})!");
            }
        }
    }
}