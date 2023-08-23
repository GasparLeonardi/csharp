namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4;

            Console.WriteLine("Insira o primeiro valor: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o quarto valor: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"\nCálculo: ({n1} * {n2}) - {n3} * {n4} = " + ((n1 * n2) - (n3 * n4)));
            Console.WriteLine("\nDiferença é: " + ((n1 * n2) - (n3 * n4)));
            
        }
    }
}