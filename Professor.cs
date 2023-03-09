using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_escola01
{
    internal class Professor
    {
        public string Nome, Cpf, Materia;
        public int Cod_Professor, idade;
        public void Exibe_professor()
        {
            Console.WriteLine("---------------------------Professor---------------------------");
            Console.WriteLine(" Nome:" + this.Nome +" \n Idade"+ this.idade + "\n Cpf:" + this.Cpf + "\n Codigo de Professor:" + this.Cod_Professor + "\n Materia que lenciona: " + this.Materia);
        }
        public Aluno Pesquisa_alunos(List<Aluno> Alunos)
        {
            Console.WriteLine("Informe o nome completo do aluno:");
            String Nome = Console.ReadLine();
            Aluno aluno = new Aluno();
            for(int i = 0; i < Alunos.Count; i++)
            {
                if(Alunos[i].nome == Nome)
                {
                    aluno = Alunos[i];
                }
            }
            return aluno;
        }
        public void Add_Nota(List<Aluno> Alunos)
        {
            Aluno aluno = Pesquisa_alunos(Alunos);
            while(true)
            {
                Console.WriteLine("Informe o trimestre que deseja cadastrar nota: ");
                Console.WriteLine("[1] - 1° Trimestre \n [2] - 2° Trimestre \n [3] - 3° Trimestre");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("Insira a nota do primeiro trimestre:");
                    aluno.nota_trimestre1 = double.Parse(Console.ReadLine());
                    break;
                }
                else if (op == 2)
                {
                    Console.WriteLine("Insira a nota do primeiro trimestre:");
                    aluno.nota_trimestre2 = double.Parse(Console.ReadLine());
                    break;
                }
                else if (op == 3)
                {
                    Console.WriteLine("Insira a nota do terceiro trimestre:");
                    aluno.nota_trimestre3 = double.Parse(Console.ReadLine());
                    break;
                }
            }

        }
    }
}
