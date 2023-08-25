namespace Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, cargon = "";
            int cargo, salario;
            float aumento, reajustado = 0;

            Console.WriteLine("Bem vinde! Qual seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine($"\nOlá {nome}, por gentileza, escolha o código do seu cargo:");
            Console.WriteLine("\n1 - Gerente");
            Console.WriteLine("2 - Vendedor");
            Console.WriteLine("3 - Supervisor");
            Console.WriteLine("4 - Motorista");
            Console.WriteLine("5 - Estoquista");
            Console.WriteLine("6 - Técnico de TI");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Muito bem, agora informe o seu salário: ");
            salario = Convert.ToInt32(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajustado = salario + (salario * 10) / 100;
                    cargon = "Gerente";
                    break;
                case 2:
                    reajustado = (salario * 7) / 100;
                    cargon = "Vendedor";
                    break;
                case 3:
                    reajustado = (salario * 9) / 100;
                    cargon = "Supervisor";
                    break;
                case 4:
                    reajustado = (salario * 6) / 100;
                    cargon = "Motorista";
                    break;
                case 5:
                    reajustado = (salario * 5) / 100;
                    cargon = "Estoquista";
                    break;
                case 6:
                    reajustado = (salario * 8) / 100;
                    cargon = "Técnico de TI";
                    break;
                default:
                    Console.WriteLine("Cargo inválido!");
                    break;
            }
            Console.WriteLine($"\nSeguem os dadados referentes ao reajuste: ");
            Console.WriteLine($"\nColaborador: {nome}");
            Console.WriteLine($"Cargo: {cargon}");
            Console.WriteLine($"Sálario reajustado: {reajustado}");
        }

        }
    }
