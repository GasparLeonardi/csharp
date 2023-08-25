namespace Pesquisa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, continua = "S";
            int idade, esporte, futebol = 0, voleiM18 = 0, basqMN18 = 0;

            do
            {
                Console.WriteLine("Digite o seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o seu esporte favorito: [1 - Fut, 2 - Vol, 3 - Basq, 4 - Outros]");
                    esporte = Convert.ToInt32(Console.ReadLine());
                } while (esporte < 1 || esporte > 4);

                if (esporte == 1)
                    futebol++;
                if (esporte == 2 && idade > 18)
                    voleiM18++;
                if (esporte == 3 && idade < 18)
                    basqMN18++;
                Console.WriteLine("Deseja continuar: S/N");
                continua = Console.ReadLine().ToUpper();

            } while (continua.Equals("S"));

            Console.WriteLine($"Pessoas que gostam de futebol: {futebol}");
            Console.WriteLine($"Pessoas que gostam de volei e são maiores de 18: {voleiM18}");
            Console.WriteLine($"Pessoas que gostam de basquete e são menores : {basqMN18}");
        }
    }
}