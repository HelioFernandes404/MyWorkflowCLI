using MyWorkflow.Utils;
using System;

namespace MyWorkflow.Commands
{
    public class PsqlCommand : ICommand
    {

        public void Execute(string[] args)
        {
            if (args.Length < 2 || args[1] == "--help")
            {
                ShowSqlHelp();
                return;
            }

            string sqlCommand = args[1].ToLower();
            switch (sqlCommand)
            {
                case "all":
                    ShowAllSqlCommands();
                    break;
                default:
                    Console.WriteLine("Comando SQL não reconhecido. Use 'myworkflow PSQL --help' para ver os comandos disponíveis.");
                    break;
            }

            static void ShowSqlHelp()
            {
                Console.WriteLine();
                Console.WriteLine("Uso: myworkflow sql [comando]");
                Console.WriteLine();
                Console.WriteLine("Comandos SQL disponíveis:");
                Console.WriteLine("  all              Mostra todos os comandos SQL disponíveis");
                Console.WriteLine();
            }

            static void ShowAllSqlCommands()
            {
                Console.WriteLine();
                Console.WriteLine("Comandos SQL (psql CLI) disponíveis:");
                Console.WriteLine("  \\q                  Sai do psql");
                Console.WriteLine("  \\c database_name    Conecta-se a um banco de dados");
                Console.WriteLine("  \\d [pattern]        Lista tabelas, visões e índices");
                Console.WriteLine("  \\d table_name       Mostra a estrutura da tabela");
                Console.WriteLine("  \\l                  Lista todos os bancos de dados");
                Console.WriteLine("  \\dt                 Lista todas as tabelas");
                Console.WriteLine("  \\df                 Lista todas as funções");
                Console.WriteLine("  \\i filename.sql     Executa um arquivo SQL");
                Console.WriteLine("  \\h [command]        Mostra a sintaxe de um comando SQL");
                Console.WriteLine("  \\x                  Alterna o modo de exibição expandida");
                Console.WriteLine();
            }

        }
    }
}
