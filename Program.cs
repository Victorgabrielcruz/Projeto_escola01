using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_escola01
{
    internal class Program
    {

        static void Main(string[] args)
        {

            List <Aluno> alunos = new List<Aluno>();
            Aluno aluno ;
            List <Professor> professores = new List <Professor>() ;
            Professor professor ;
            Adiministrador adm = new Adiministrador();
            int op_01,op_02, op_03, op_04;
            do
            {
                
                Console.WriteLine("---------------------------Menu---------------------------");
                Console.WriteLine("Você deseja: \n [1]Acessar area do aluno \n [2]Acessar area do professor \n [3]Acessar area do Adm \n [4]Sair");
                op_01 = int.Parse(Console.ReadLine());
                if (op_01 == 1)
                {
                    Console.WriteLine("---------------------------Verificação---------------------------");
                    Console.WriteLine("Informe o seu numero de matricula:");
                    int matricula = int.Parse(Console.ReadLine());
                    op_02 = Verifica_aluno(alunos, matricula);
                    if (op_02 == 1)
                    {
                        aluno = Pesquisa_matricula(alunos, matricula);
                        do
                        {
                            Console.WriteLine("--------------------------- Menu Aluno ---------------------------");
                            Console.WriteLine("Você deseja: \n [1]Exibir situação do trimestre \n [2]Exibir situação do ano  \n [3]Exibir dados \n [4]Sair");
                            op_03 = int.Parse(Console.ReadLine());
                            if (op_03 == 1)
                            {
                                Console.WriteLine("Você deseja: \n [1] - 1° trimestre \n [2] - 2° trimestre  \n [3] - 3° trimestre ");
                                op_04 = int.Parse(Console.ReadLine());
                                if (op_04 == 1)
                                {
                                    aluno.Situacao_trimestre(aluno.nota_trimestre1);
                                }
                                else if (op_04 == 2)
                                {
                                    aluno.Situacao_trimestre(aluno.nota_trimestre2);
                                }
                                else if (op_04 == 3)
                                {
                                    aluno.Situacao_trimestre(aluno.nota_trimestre3);
                                }
                            }
                            else if (op_03 == 2)
                            {
                                aluno.Situacao_ano();
                            }
                            else if (op_03 == 3)
                            {
                                aluno.Exibe_aluno();
                            }
                        } while (op_03 != 4);

                    }
                    else if (op_02 == 2)
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("Matricula não encontrada !!! Acesso negado !!!");
                    }
                }
                else if (op_01 == 2)
                {

                    Console.WriteLine("---------------------------Verificação---------------------------");
                    Console.WriteLine("Informe o Codigo de professor:");
                    int cod_professor = int.Parse(Console.ReadLine());
                    op_02 = Verifica_professor(professores, cod_professor);

                    if (op_02 == 1)
                    {
                        do
                        {
                            professor = Pesquisa_codProfessor(professores, cod_professor);
                            Console.WriteLine("--------------------------- Menu Professor ---------------------------");
                            Console.WriteLine("Você deseja: \n [1]Adicionar nota \n [2]Exibir situação do aluno  \n [3]Exibir dados \n [4]Sair");
                            op_03 = int.Parse(Console.ReadLine());
                            if (op_03 == 1)
                            {
                                professor.Add_Nota(alunos);
                            }
                            else if (op_03 == 2)
                            {
                                aluno = professor.Pesquisa_alunos(alunos);
                                aluno.Exibe_aluno();
                            }
                            else if (op_03 == 3)
                            {
                                professor.Exibe_professor();
                            }
                        } while (op_03 != 4);
                    }
                    else if (op_02 == 2)
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("Codigo de professor não encontrada !!! Acesso negado !!!");
                    }
                }
                else if (op_01 == 3)
                {
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Digite o codigo de acesso: ");
                    int senha = int.Parse(Console.ReadLine());
                    op_02 = adm.Verifica_senha(senha);
                    if (op_02 == 1)
                    {
                        do
                        {
                            Console.WriteLine("--------------------------- Menu Adiministrador ---------------------------");
                            Console.WriteLine("Você deseja: \n [1]Cadastrar Aluno \n [2]Cadastrar Professor  \n [3]Sair");
                            op_03 = int.Parse(Console.ReadLine());
                            if (op_03 == 1)
                            {
                                Console.WriteLine("------------------------------------------------------------");
                                aluno = adm.Cadastra_aluno();
                                alunos.Add(aluno);
                            }
                            else if (op_03 == 2)
                            {
                                Console.WriteLine("------------------------------------------------------------");
                                professor = adm.Cadastra_professor();
                                professores.Add(professor);

                            }
                        } while(op_03 != 3);
                        
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("!!! Acesso negado !!!");
                    }
                }
                op_01 = 0;
            } while(op_01 != 4);
            

        }
        public static int Verifica_aluno(List <Aluno> alunos, int matricula)
        {
            
            int op = 2;
            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].matricula == matricula)
                {
                    op = 1;
                }
                else
                {
                    op = 2;
                }
            }
            if (op == 1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static int Verifica_professor(List <Professor> professores, int Cod_professor)
        {
            int op = 2;
            for (int i = 0; i < professores.Count; i++)
            {
                if (professores[i].Cod_Professor == Cod_professor)
                {
                    op = 1;
                    break;
                }
                else
                {
                    op = 2;
                }
            }
            if (op == 1)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static Professor Pesquisa_codProfessor(List<Professor> professores, int Cod_professor)
        {
            Professor professor = new Professor();
            for (int i = 0; i < professores.Count; i++)
            {
                if (professores[i].Cod_Professor == Cod_professor)
                {
                    professor = professores[i];
                }
            }
            return professor;
        }
        public static Aluno Pesquisa_matricula(List <Aluno> alunos,int matricula)
        {
            Aluno aluno = new Aluno();
            for (int i = 0; i < alunos.Count; i++)
            {
                if (alunos[i].matricula == matricula)
                {
                    aluno = alunos[i];
                }
            }
            return aluno;
        }
    }
}
