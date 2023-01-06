using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Estudante : Pessoa
    {
        public string Turma { get; private set; }
        public List<int> Notas { get; private set; }

        public Estudante(string turma, string nome, string documento, DateTime dataNascimento)
            : base(nome, documento, dataNascimento)
        {
            Turma = turma;
            Notas = new List<int> { 5, 10, 4, 2, 7 };
        }

        public override void SeApresentar()
        {
            var media = Notas.Average();

            Console.WriteLine($"Aluno: {Nome}, Turma: {Turma}, Media: {media}");
        }
    }
}
