using MyWorkflow.Utils;

namespace MyWorkflow.Commands;

public class DocsCommand : ICommand
{
    public void Execute(string[] args)
    {
        if (args.Length < 2 || args[1] == "--help")
        {
            ShowDocsHelp();
            return;
        }

        var gitCommand = args[1].ToLower();
        switch (gitCommand)
        {
            case "all":
                BasicCommands();
                break;
            default:
                Console.WriteLine(
                    "Comando Git não reconhecido. Use 'myworkflow Git --help' para ver os comandos disponíveis.");
                break;
        }


        static void ShowDocsHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Uso: myworkflow Docs [comando]");
            Console.WriteLine();
            Console.WriteLine("Comandos Docs disponíveis:");
            Console.WriteLine("  all              Mostra todos os comandos Docs disponíveis");
            Console.WriteLine();
            BasicCommands();
        }

        static void BasicCommands()
        {
            // .NET documentation links
            string[] docLinks =
            {
                "https://learn.microsoft.com/en-us/dotnet/",
                "https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0",
                "https://github.com/dotnet/docs",
                "https://cloud.google.com/dotnet/docs",
                "https://jakeydocs.readthedocs.io/"
            };

            Console.WriteLine();
            foreach (var link in docLinks) Console.WriteLine(link);
            Console.WriteLine();
        }
    }
}