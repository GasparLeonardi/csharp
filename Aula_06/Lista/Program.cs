namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();
            
            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            foreach (double nota in notas) {
                Console.WriteLine(nota);
            
            }
            //Indice de um elemento
            Console.WriteLine("Posição da nota 4.0: " + notas.IndexOf(4.0));
            //Checar se o elemento existe
            Console.WriteLine("A nota 4.0 existe?: " + notas.Contains(4.0));
            
            //Deletar elemento
            notas.Remove(7.0);
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);

            }
            //Indice de um elemento
            Console.WriteLine("Posição da nota 10.0: " + notas.IndexOf(10.0));
            //Quantos elementos tem
            Console.WriteLine("Quantos elementos tem a lista? "+ notas.Count());

            //Ordenação crescente
            notas.Sort();
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }
            //Ordenação decrescente
            notas.Reverse();
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }
            //Alteração de nota
            notas[0] = 9.0;
            
            foreach (var nota in notas)
            {
                Console.WriteLine(nota);
            }
        }
    }
}