using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_escola01
{
    internal class Aluno
    {
        public int matricula, idade;
        public String nome, turma, curso, cpf;
        public Double nota_trimestre1, nota_trimestre2, nota_trimestre3;

        public void Situacao_trimestre(Double nota_aluno)
        {
            Double nota_minima = 21.0;
            if (nota_aluno >= nota_minima)
            {
                Console.WriteLine(" Situação: Aprovado \n Nota:" + nota_aluno);
            }
            else
            {
                Console.WriteLine(" Situação: Reprovado \n Nota:" + nota_aluno);
            }
        }
        public void Situacao_ano()
        {
            Double nota_total = this.nota_trimestre1 + this.nota_trimestre2 + this.nota_trimestre3;
            Double nota_minima = 60.0;
            if (nota_total >= nota_minima)
            {
                Console.WriteLine(" Situação: Aprovado \n Nota:" + nota_total);
            }
            else
            {
                Console.WriteLine(" Situação: Reprovado \n Nota:" + nota_total);
            }
        }
        
        public void Exibe_aluno()
        {
            Console.WriteLine("---------------------------Aluno---------------------------");
            Console.WriteLine(" Nome: " + this.nome + "\n Idade: " + this.idade + "\n Matricula: " + this.matricula + "\n Cpf: " + this.cpf + "\n Turma: " + this.turma + "\n Curso:" + this.curso + "\n Nota 1° Trimestre: " + this.nota_trimestre1 + "\n Nota 2° Trimestre: " + this.nota_trimestre2 + "\n Nota 3° Trimestre: " + this.nota_trimestre3);
            Situacao_ano();
        }
    }
}
