using Atividade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1.Model
{
    public class PessoaFisica : Cliente
    {
        private int idade;
        private string parentes;
        public PessoaFisica(int tipo, string nomeraz, int documento, string endereco, int idade, string parentes) : base(tipo, nomeraz, documento, endereco)
        {
            this.idade = idade;
            this.parentes = parentes;
        }

        public int GetIdade() 
        { 
            return this.idade;
        }
        public void SetIdade(int idade) 
        { 
            this.idade = idade; 
        }

        public string GetParentes() 
        { 
            return this.parentes; 
        }
        public void SetParentes(string parentes) 
        {
            this.parentes = parentes;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Idade: {this.idade}");
            Console.WriteLine($"Pai/mãe: {this.parentes}");
        }
    }
}
