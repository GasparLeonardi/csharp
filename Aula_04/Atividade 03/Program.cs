namespace Atividade_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 1, idadeup50 = 0, idadedm21 = 0;

            
            while (idade > 0)
            {
                Console.WriteLine("\nDigite uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade > 50) idadeup50++;
                if (idade > 0 && idade < 21) idadedm21++; 
            }
            
            
            Console.WriteLine($"\nTotal de pessoas menores de 21 anos: {idadedm21}");
            Console.WriteLine($"\nTotal de pessoas maiores de 50 anos: {idadeup50}");
        }
    }
}