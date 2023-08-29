namespace Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Breno");
            pilha.Push("Eduardo");
            pilha.Push("Julia");
            pilha.Push("Leonardo");
            pilha.Push("Gaspar");

            pilha.Pop();

            foreach (var nome in pilha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("Quem é o ultimo da pilha? " + pilha.Peek());
            Console.WriteLine("Gaspar faz parte na pilha? " + pilha.Contains("Gaspar"));
            Console.WriteLine("Número de pessoas na pilha: " + pilha.Count);
        }
    }
}