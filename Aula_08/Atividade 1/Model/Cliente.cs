using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Model
{
    public class Cliente
    {
        private int tipo;
        private string nomeraz = string.Empty;
        private int documento;
        private string endereco = string.Empty;

        public Cliente(int tipo, string nomeraz, int documento, string endereco)
        {
            this.tipo = tipo;
            this.nomeraz = nomeraz;
            this.documento = documento;
            this.endereco = endereco;
        }

        public int GetTipo()
        {
            return tipo;
        }
        public void SetTipo(int tipo)
        {
            this.tipo = tipo;
        }
        public string GetNomeraz()
        {
            return nomeraz;
        }
        public void SetNomeraz(string nomeraz)
        {
            this.nomeraz = nomeraz;
        }
        public int GetDocumento()
        {
            return documento;
        }
        public void SetDocumento(int documento)
        {
            this.documento = documento;
        }
        public string GetEndereco()
        {
            return endereco;
        }
        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public virtual void Visualizar()
        {
            string tipo = string.Empty;

            switch (this.tipo)
            {
                case 1:
                    tipo = "Pessoa Física";
                    break;
                case 2:
                    tipo = "Pessoa Jurídica";
                    break;    
            }
            Console.WriteLine("************************************************");
            Console.WriteLine(" Dados do Cliente                               ");
            Console.WriteLine("************************************************");
            Console.WriteLine($"Tipo de Cliente: {tipo}                        ");
            Console.WriteLine($"Nome/Razão Social: {this.nomeraz}              ");
            Console.WriteLine($"CPF/CNPJ: {this.documento}                     ");
            Console.WriteLine($"Endereço: {this.endereco}                      ");
        }

    }
}
