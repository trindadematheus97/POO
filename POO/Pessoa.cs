using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Pessoa
    {
        public string Nome { get; protected set; }
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, string documento, DateTime dataNascimento)
        {
            Nome = nome;
            Documento = documento;
            DataNascimento = dataNascimento;    
        }

        public virtual void SeApresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, {Documento}, data de nascimento {DataNascimento}.");
        }
    }
}
