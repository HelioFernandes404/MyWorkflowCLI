using System;
using MyWorkflow.Utils;

namespace MyWorkflow
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowHelp();
                return;
            }

            string command = args[0].ToLower();
            ICommand commandHandler = CommandFactory.CreateCommand(command);

            if (commandHandler == null)
            {
                Console.WriteLine("Comando não reconhecido. Use '-h' ou '--help' para ver os comandos disponíveis.");
                return;
            }

            commandHandler.Execute(args);
        }

        static void ShowHelp()
        {
            Console.WriteLine("Uso: myworkflow [modulo] [opções]");
            Console.WriteLine();
            Console.WriteLine("Comandos disponíveis:");
            Console.WriteLine("  -h, --help       Mostra a ajuda");
            Console.WriteLine("  docker           Comandos relacionados ao Docker");
            Console.WriteLine("  linux            Comandos relacionados ao Linux");
            Console.WriteLine("  psql             Comandos relacionados ao Psql");
            Console.WriteLine("  pmc              Comandos relacionados ao (pmc)Package Manager Console");
            Console.WriteLine("  git              Comandos relacionados ao Git");
            Console.WriteLine("  vs               Comandos relacionados ao Visual Studio");
            Console.WriteLine("  mongoshell       Comandos relacionados ao mongoshell");
            Console.WriteLine("  CP               Comandos relacionados ao Commits Pattern");
            Console.WriteLine();
            Console.WriteLine("Para mais informações sobre um comando, use: myworkflow [modulo] --help");
        }
    }
}
