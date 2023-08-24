namespace Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, nomedp = ""; 
            int comida, quanti;
            float pedido=0;
            
            Console.WriteLine("Qual seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine($"\nOlá {nome}! Dentre as opções abaixo, escolha o número do pedido: ");
            Console.WriteLine("\n1 - Cachorro Quente ----- R$ 10,00 ");
            Console.WriteLine("2 - X — Salada ---------- R$ 15,00 ");
            Console.WriteLine("3 - X — Bacon ----------- R$ 18,00 ");
            Console.WriteLine("4 - Bauru --------------- R$ 12,00 ");
            Console.WriteLine("5 - Refrigerante -------- R$  8,00 ");
            Console.WriteLine("6 - Suco de laranja ----- R$ 13,00 ");
            comida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Certo, agora, escolha a quantidade: ");
            quanti = Convert.ToInt32(Console.ReadLine());

            

            switch (comida)
            {
                case 1:
                    pedido = (quanti * 10);
                    nomedp = "Cachorro Quente";
                    break;
                case 2:
                    pedido = (quanti * 15);
                    nomedp = "X — Salada";
                    break;
                case 3:
                    pedido = (quanti * 18);
                    nomedp = "X — Bacon";
                    break;
                case 4:
                    pedido = (quanti * 12);
                    nomedp = "Bauru";
                    break;
                case 5:
                    pedido = (quanti * 8);
                    nomedp = "Refrigerante";
                    break;
                case 6:
                    pedido = (quanti * 13);
                    nomedp = "Suco de laranja";
                    break;
                default:
                    Console.WriteLine("Pedido inválido!");
                    break;
            }
            Console.WriteLine($"\nO seu pedido é {quanti} {nomedp} no valor de R${pedido},00, podemos confirmar?");
        }
    }
}