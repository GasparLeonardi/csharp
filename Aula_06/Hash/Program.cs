namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>()
            {
                "Allan",
                "Robson",
                "João",
                "Ingrid",
                "Allan",
                "Robson",

            };
            foreach (var nome in setNomes) 
            { 
                Console.WriteLine(nome);
            }
            setNomes.Add("Samantha");
            setNomes.Add(null);
            setNomes.Add("Julia");

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("O nome julia existe? " + setNomes.Contains("Julia"));

            List<string> hashList = setNomes.ToList();

            hashList.Sort();

            foreach (var hash in hashList)
            {
                Console.WriteLine(hash);

            }



        }
    }
}