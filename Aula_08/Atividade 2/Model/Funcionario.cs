using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2.Model
{
    public class Funcionario
    {
        private string nome = string.Empty;
        private string sobrenome = string.Empty;
        private string cargo = string.Empty;
        private int salario;
        private int vrva;

        public Funcionario(string nome, string sobrenome, string cargo, int salario, int vrva)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.cargo = cargo;
            this.salario = salario;
            this.vrva = vrva;
        }

        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public string GetSobrenome()
        {
            return sobrenome;
        }
        public void SetSobrenome(string sobrenome)
        {
            this.nome = sobrenome;
        }
        public int GetSalario()
        {
            return salario;
        }
        public void SetSalario(int salario)
        {
            this.salario = salario;
        }
        public int GetVrva()
        {
            return vrva;
        }
        public void SetVrva(int vrva)
        {
            this.vrva = vrva;
        }

        public void Visualizar()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine(" Dados do Funcionario                           ");
            Console.WriteLine("************************************************");
            Console.WriteLine($"Nome e sobrenome: {this.nome} {this.sobrenome}");
            Console.WriteLine($"Cargo: {this.cargo}");
            Console.WriteLine($"Salario: {(this.salario).ToString("C")}");
            Console.WriteLine($"VR e VA: {(this.vrva).ToString("C")}");
            Console.WriteLine("************************************************");
        }
    }
}
