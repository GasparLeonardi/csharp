using Atividade.Model;

namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Danilo","Leonardi",123456789,"Rua 123",123456789);
            c1.Visualizar();

            Cliente c2 = new Cliente("Monkey", "D. Luffy", 100000000, "Navio Thousand Sunny", 100000000);
            c2.Visualizar();
        }
    }
}