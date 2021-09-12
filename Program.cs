using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];                                
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();                           

            while (opcaoUsuario.ToUpper() != "X")
            {
               switch (opcaoUsuario)
               {
                   case "1":
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
                        foreach (var a in alunos)                                              // inserção
                       {
                               if (!string.IsNullOrEmpty(a.Nome))
                               {
                                   Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                               }
                                
                       }
                        break;
                   case "3":
                        // TODO: Calcula média geral
                        break;
                   default:
                       throw new ArgumentOutOfRangeException();
               }

               opcaoUsuario = ObterOpcaoUsuario();  
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novos alunos");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            String opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }

    }                                                                              
}