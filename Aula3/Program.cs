using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
           Aluno a1 = new Aluno();
           Aluno a2 = new Aluno();
           Aluno a3 = new Aluno();

            a1.Nome = "Vinicius";
            a1.Turma = "C#";
            a1.idade = 25;
            a1.NMat = 1003;
            a1.Mensalidade = 500;

            a2.Nome = "Fernando";
            a2.Turma = "C#";
            a2.idade = 22;

            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Aluno: {a1.Nome} - Turma: {a1.Turma} - Idade: {a1.idade}");

            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Aluno: {a2.Nome} - Turma: {a2.Turma} - Idade: {a2.idade}");

            Console.WriteLine(new String('-', 50));
            a1.ExibirAluno();
            a2.ExibirAluno();

            Console.WriteLine(new String('-', 50));
            a1.TrocarTurma("ASP.NET Core");
            a1.ExibirAluno();
            a1.Desconto(10);
            a1.ExibirAluno();

            Console.WriteLine(new String('-', 50));






        }
    }
}
