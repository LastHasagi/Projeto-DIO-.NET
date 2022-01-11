// See https://aka.ms/new-console-template for more information
using System;

namespace Revisao_Dio_Dotnet
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            Aluno[] alunos = new Aluno[15];
            var indiceAluno = 0;
            string OpçaoUsuario = ObterOpçaoUsuario();

            while (OpçaoUsuario != "4")
            {

                switch (OpçaoUsuario)
                {

                    case "1":
                    //ToDo: Cadastrar alunos
                
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                    //ToDo: Listar alunos

                        foreach(var a in alunos)
                        { 
                            
                            if(!String.IsNullOrEmpty(a.Nome))
                            {
                                
                                 Console.WriteLine($"ALUNO: {a.Nome} NOTA: {a.Nota}");

                            }
                        
                        }
                        break;

                    case "3":
                    //ToDo: Calcular média geral
                        
                        decimal NotaTotal = 0;
                        var NumAlunos = 0;

                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if(!String.IsNullOrEmpty(alunos[i].Nome))
                            {
                                NotaTotal = NotaTotal + alunos[i].Nota;
                                NumAlunos++;
                            }
                        }

                        var mediageral = NotaTotal / NumAlunos;

                        Console.WriteLine($"MÉDIA GERAL: {mediageral}");
                        Console.WriteLine("");
                        
                        if (mediageral < 3)
                        {
                            Console.WriteLine("CONCEITO GERAL: E");
                        }

                        else if (mediageral < 5)
                        {
                            Console.WriteLine("CONCEITO GERAL: D");
                        }

                        else if (mediageral < 7)
                        {
                            Console.WriteLine("CONCEITO GERAL: C");
                        }

                        else if (mediageral < 8)
                        {
                            Console.WriteLine("CONCEITO GERAL: B");
                        }

                        else if (mediageral < 10)
                        {
                            Console.WriteLine("CONCEITO GERAL: B++");
                        }

                        else if (mediageral == 10)
                        {
                            Console.WriteLine("CONCEITO GERAL: A ! Parabéns, turma ! :)");
                        }

                        

                        break;
                    default:

                        throw new ArgumentOutOfRangeException();

                }

                OpçaoUsuario = ObterOpçaoUsuario();

            }

        }

        private static string ObterOpçaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("4 - Sair");
            Console.WriteLine();

            string OpçaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return OpçaoUsuario;
        }
    }

}
