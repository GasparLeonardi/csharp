namespace Atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int operacao, saque;
            float saldo = 1000;

            Console.WriteLine("Bem vinde! Qual seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine($"\nOlá {nome}, por gentileza, escolha o código da operação:");
            Console.WriteLine("\n1 - Saldo");
            Console.WriteLine("2 - Saque");
            Console.WriteLine("3 - Depósito");
            operacao = Convert.ToInt32(Console.ReadLine());


            switch (operacao)
            {
                case 1:
                    Console.WriteLine($"Saldo: R$ {saldo}");
                    break;
                case 2:
                    Console.WriteLine($"\nPor gentileza, digite o valor do saque:");
                    saque = Convert.ToInt32(Console.ReadLine());
                    if (saldo > saque) {
                        Console.WriteLine($"\nNovo Saldo: " + (saldo - saque));
                    
                    } else
                    {
                        Console.WriteLine("Saldo Insuficiente!");
                    }
                    break;
                case 3:
                    Console.WriteLine($"\nPor gentileza, digite o valor do depósito:");
                    saque = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nNovo Saldo: " + (saldo + saque));

                    break;
                default:
                    Console.WriteLine("\nOperação Inválida!");
                    break;
            }

        }
    }
}