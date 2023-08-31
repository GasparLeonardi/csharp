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
        }
    }
}