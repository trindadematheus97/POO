using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Professor : Pessoa
    {
        public List<string> Turmas { get; private set; }
        public decimal Salario { get; set; }

        public Professor(string nome, string documento, DateTime dataNascimento, decimal salario)
            :base(nome, documento, dataNascimento)
        {
            Turmas = new List<string> { "A", "B"};
            Salario = salario;
        }

        public override void SeApresentar()
        {
            base.SeApresentar();

            var turmas = string.Join(',', Turmas);

            Console.WriteLine($"Meu salário é {Salario}, ministro para as turmas {turmas}.");
        }
    }
}
