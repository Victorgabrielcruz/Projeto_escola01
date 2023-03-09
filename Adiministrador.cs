using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_escola01
{
    internal class Adiministrador
    {
        private int senha = 12398;

        public Aluno Cadastra_aluno()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("idade do aluno: ");
            aluno.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero de Matricula: ");
            aluno.matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Cpf:");
            aluno.cpf = Console.ReadLine();
            Console.WriteLine("Curso: ");
            aluno.curso = Console.ReadLine();
            Console.WriteLine("Turma: ");
            aluno.turma = Console.ReadLine();
            aluno.Exibe_aluno();
            return aluno;
        }
        public Professor Cadastra_professor()
        {
            Professor professor = new Professor();

            Console.WriteLine("Nome do Professor: ");
            professor.Nome = Console.ReadLine();
            Console.WriteLine("idade do professor: ");
            professor.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Cpf:");
            professor.Cpf = Console.ReadLine();
            Console.WriteLine("Matqeria que o professor ministra: ");
            professor.Materia = Console.ReadLine();
            Console.WriteLine("Codigo do Professor: ");
            professor.Cod_Professor = int.Parse(Console.ReadLine());
            professor.Exibe_professor();
            return professor;
        }
        public int Verifica_senha(int Senha)
        {
            if (Senha == this.senha)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}
