using Atividade_2.Model;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario c1 = new Funcionario("Michael", "Scott", "Diretor" , 2000, 1000);
            c1.Visualizar();

            Funcionario c2 = new Funcionario("Kelly", "Kapoor", "Customer Service", 1500, 500);
            c2.Visualizar();

            Gerente c3 = new Gerente("Jan", "Levinson", "Gerente", 3000, 1500, "Scranton", "David Wallace");
            c3.Visualizar();

            Vendedor c4 = new Vendedor("Jim", "Halpert","Vendedor", 1000,200,10000,"Vendas de Papel");
            c4.Visualizar();
        }
    }
}