using System;
using System.Collections.Generic;
using System.Text;

namespace Aula3
{
    class Aluno
    {
        public string Nome;
        public string Turma;
        public int idade;
        public int NMat;
        public decimal Mensalidade;

        public void ExibirAluno() //Método
        {
            Console.WriteLine($"Aluno: {Nome} - Turma: {Turma} - Mensalidade: {Mensalidade}");
           // Console.WriteLine($"Aluno: {Nome} - Turma: {Turma} - Idade: {idade}");
        }

        //Método que vai efetuar a troca de turma.
        public void TrocarTurma(string novaTurma)
        {
            Turma = novaTurma;
        }

        public void Desconto(decimal desconto)
        {
            Mensalidade = Mensalidade - (desconto / 100)*Mensalidade;
        }

    }
}
