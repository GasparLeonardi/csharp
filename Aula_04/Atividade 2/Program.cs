namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, par = 0, impar = 0;

            //Console.WriteLine("Insira o número:");
           // num = Convert.ToInt32(Console.ReadLine());   

            for (int contador = 1; contador <= 10; contador++) 
            {
                Console.WriteLine($"Insira o {contador}º número:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    par++;
                }
                else 
                { 
                    impar++; 
                }

            }
            Console.WriteLine($"Total de números pares: {par}");
            Console.WriteLine($"Total de números pares: {impar}");
        }
    }
}