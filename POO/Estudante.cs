using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Estudante : Pessoa
    {
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento) : base(nome, documento, dataNascimento)
        {
            Turma = turma;
            Notas = new List<int> { 2, 5, 3, 6, 1, 10 };
        }

        public string Turma { get; set; }
        public List<int> Notas { get; set; }

        public override void SeApresentar()
        {
            base.SeApresentar();

            var media = Notas.Average();

            Console.WriteLine($"Sou um estudante da turma {Turma}, Media de Nota: {media}");
        }


    }
}