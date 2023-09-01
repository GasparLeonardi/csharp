using Atividade.Model;
using Atividade_1.Model;

namespace Atividade
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cliente c11 = new Cliente(1, "Monkey D Luffy", 123456789, "Thousand Sunny/País de Wano");
            //c1.Visualizar();

           // Cliente c2 = new Cliente(2,"Mugiwaras",123456789, "Thousand Sunny/País de Wano");
           // c2.Visualizar();

            PessoaFisica c1 = new PessoaFisica(1, "Monkey D Luffy", 123456789, "Thousand Sunny/País de Wano", 20, "Monkey D Dragon");
            c1.Visualizar();

            PessoaJuridica c2 = new PessoaJuridica(2, "Mugiwaras", 123456789, "Thousand Sunny/País de Wano","Pirataria");
            c2.Visualizar();
        }
    }
}