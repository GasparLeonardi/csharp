using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade.Model
{
    public class Cliente
    {
        private string nome = string.Empty;
        private string sobrenome = string.Empty;
        private int documentoRG;
        private string endereco = string.Empty;
        private int documentoCPF;

        public Cliente(string nome, string sobrenome, int documentoRG, string endereco, int documentoCPF)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.documentoRG = documentoRG;
            this.endereco = endereco;
            this.documentoCPF = documentoCPF;
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
        public int GetDocumentoRG()
        {
            return documentoRG;
        }
        public void SetDocumentoRG(int documentoRG)
        {
            this.documentoRG = documentoRG;
        }
        public string GetEndereco()
        {
            return endereco;
        }
        public void SetEndereco(string nome)
        {
            this.nome = endereco;
        }
        public int GetDocumentoCPF()
        {
            return documentoCPF;
        }
        public void SetDocumentoCPF(int documentoCPF)
        {
            this.documentoCPF = documentoCPF;
        }
        public void Visualizar()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine(" Dados do Cliente                               ");
            Console.WriteLine("************************************************");
            Console.WriteLine($"Nome e sobrenome: {this.nome} {this.sobrenome}");
            Console.WriteLine($"RG: {this.documentoRG}");
            Console.WriteLine($"CPF: {this.documentoCPF}");
            Console.WriteLine($"Endereço: {this.endereco}");
            Console.WriteLine("************************************************");
        }

    }

}
