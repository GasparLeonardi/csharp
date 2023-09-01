using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2.Model
{
    public class Gerente : Funcionario
    {
        string filial;
        string superior;
        public Gerente(string nome, string sobrenome, string cargo, int salario, int vrva, string filial, string superior) : base(nome, sobrenome, cargo, salario, vrva)
        {
            this.filial = filial;
            this.superior = superior;
        }

        public string GetFilial()
        {
            return this.filial;
        }
        public void GetFilial(string filial)
        {
            this.filial = filial;
        }
        public string GetSuperior()
        {
            return this.superior;
        }
        public void GetSuperior(string superior)
        {
            this.filial = superior;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Filial que gerencia: {this.filial}");
            Console.WriteLine($"Superior: {this.superior}");
        }
    }
}
