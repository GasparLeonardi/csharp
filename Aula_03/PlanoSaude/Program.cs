namespace PlanoSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}! Qual a sua idade? ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 0 && idade <= 10) {
                Console.WriteLine("A mensalidade do plano é de 100 reais!");
            } else if (idade >= 11 && idade <= 29) {
                Console.WriteLine("A mensalidade do plano é de 200 reais!");
            } else if (idade >= 30 && idade <= 45) {
                Console.WriteLine("A mensalidade do plano é de 300 reais!");
            } else if (idade >= 46 && idade <= 59) {
                Console.WriteLine("A mensalidade do plano é de 500 reais!");
            } else if (idade >= 60 && idade <= 65) {
                Console.WriteLine("A mensalidade do plano é de 500 reais!");
            } else if (idade > 65) {
                Console.WriteLine("A mensalidade do plano é de 1000 reais!");
            } else { 
                Console.WriteLine("Idade inválida");}
        }
    }
}