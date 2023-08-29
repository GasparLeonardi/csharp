namespace Atividade_2___Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stackBook = new Stack<string>();
            int opcao = 1;
            string? nome;

            while (opcao > 0 && opcao < 4)
            {

                Console.WriteLine("\n***********************************************");
                Console.WriteLine("\n");
                Console.WriteLine("  1 - Adicionar um novo livro na pilha  ");
                Console.WriteLine("  2 - Listar todos os livros   ");
                Console.WriteLine("  3 - Retirar um livro da pilha   ");
                Console.WriteLine("  0 - Sair   ");
                Console.WriteLine("\n");
                Console.WriteLine("***********************************************");
                Console.WriteLine("Entre com a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("\nDigite o nome do livro que deseja adicionar: \n");
                        nome = Console.ReadLine();
                        stackBook.Push(nome);
                        Console.WriteLine("\nLivro adicionado!\n");

                        break;
                    case 2:
                        Console.WriteLine("\nLista de Livros na Pilha: \n");
                        foreach (var nomeFor in stackBook)
                        {
                            Console.WriteLine(nomeFor);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nPilha: \n");
                        if (stackBook.Count == 0)
                        {
                            Console.WriteLine("\nA Pilha está vazia!\n");
                        }
                        else
                        {
                            stackBook.Pop();
                            foreach (var nomeFor in stackBook)
                            {
                                Console.WriteLine(nomeFor);
                            }
                            Console.WriteLine("\nUm Livro foi retirado da pilha!\n");
                        }
                        break;
                    default:
                        Console.WriteLine("\nPrograma Finalizado!");
                        break;

                }
                if (opcao == 0)
                {
                    Console.WriteLine("\nPrograma Finalizado!");
                }
            }
        }
    }
}