using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();                           // Adicionado - inicio

            while (opcaoUsuario.ToUpper() != "X")
            {
               switch (opcaoUsuario)
               {
                   case "1":
                        // TODO: adiciona aluno
                        break;
                   case "2":
                        // TODO: Lista aluno
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

    }                                                                              // Adicionado - fim
}