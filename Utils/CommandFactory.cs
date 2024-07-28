using MyWorkflow.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkflow.Utils
{
    public static class CommandFactory
    {
        public static ICommand CreateCommand(string command)
        {
            return command switch
            {
                "-h" => new HelpCommand(),
                "--help" => new HelpCommand(),
                "docker" => new DockerCommand(),
                "linux" => new LinuxCommand(),
                "psql" => new PsqlCommand(),
                "pmc" => new PmcCommand(),
                "git" => new GitCommand(),
                "docs" => new DocsCommand(),
                "vs" => new VsCommand(),
                _ => new DefaultCommand(),
            };
        }
    }

    public class VsCommand : ICommand
    {
        public void Execute(string[] args)
        {
            if (args.Length < 2 || args[1] == "-h")
            {
                VsHelp();
                return;
            }

            string VsCommand = args[1].ToLower();
            switch (VsCommand)
            {
                case "all":
                    AllVs();
                    break;
                default:
                    Console.WriteLine("Comando Vscode não reconhecido. Use 'myworkflow Vs --help' para ver os comandos disponíveis.");
                    break;
            }
        }


        static void VsHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Uso: myworkflow Vs [comando]");
            Console.WriteLine();
            Console.WriteLine("Comandos Vscode disponíveis:");
            Console.WriteLine();
            Console.WriteLine("  all              Mostra todos os comandos Vs disponíveis");
        }

        static void AllVs()
        {
            Console.WriteLine();
            Console.WriteLine("Comandos úteis da IDE:");
            Console.WriteLine("  Ctrl + Espaço: Auto-completar código");
            Console.WriteLine("  Tab + Tab: Expande o código (sugestões de código)");
            Console.WriteLine("  Tab + Setas: Navega pelas sugestões de código");
            Console.WriteLine("  Ctrl + Clique: Navega para a definição de um símbolo");
            Console.WriteLine("  Ctrl + M + O: Colapsa todos os blocos de código");
            Console.WriteLine("  Ctrl + M + P: Expande todos os blocos de código");
            Console.WriteLine("  Ctrl + G: Vai para uma linha específica");
            Console.WriteLine("  Ctrl + T: Pesquisa por símbolos e arquivos");
            Console.WriteLine("  Ctrl + K + D: Formata o código automaticamente");
            Console.WriteLine("  Alt + Setas: Move linhas de código para cima/baixo");
            Console.WriteLine("  Ctrl + R + R: Renomeia todos os símbolos de uma vez");
            Console.WriteLine("  TODO: Ctrl + .: Adiciona um TODO item");
            Console.WriteLine();
        }

    }


}


