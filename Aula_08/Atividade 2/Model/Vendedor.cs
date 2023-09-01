using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2.Model
{
    public class Vendedor : Funcionario
    {
        int metas;
        string departamento;
        public Vendedor(string nome, string sobrenome, string cargo, int salario, int vrva, int metas, string departamento) : base(nome, sobrenome, cargo, salario, vrva)
        {
            this.metas = metas;
            this.departamento = departamento;
        }

        public int GetMetas()
        {
            return this.metas;
        }
        public void SerMetas(int metas)
        {
            this.metas = metas;
        }

        public string GetDepartamento()
        {
            return this.departamento;
        }
        public void SetParentes(string departamento)
        {
            this.departamento = departamento;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Metas de vendas: {this.metas}");
            Console.WriteLine($"Departamento: {this.departamento}");
        }
    }
}
