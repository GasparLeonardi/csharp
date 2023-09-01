using Atividade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1.Model
{
    public class PessoaJuridica : Cliente
    {
        private string ramo;
        public PessoaJuridica(int tipo, string nomeraz, int documento, string endereco, string ramo) : base(tipo, nomeraz, documento, endereco)
        {
            this.ramo = ramo;
        }
        public string GetRamo()
        {
            return this.ramo;
        }
        public void GetRamo(string ramo)
        {
            this.ramo = ramo;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Ramo de negocio: {this.ramo}");
        }
    }
}
