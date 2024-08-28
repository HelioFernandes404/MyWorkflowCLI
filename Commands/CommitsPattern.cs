using MyWorkflow.Utils;

namespace MyWorkflow.Commands;

public class CommitsPattern : ICommand
{
    public void Execute(string[] args)
    {
        if (args.Length < 2 || args[1] == "--help")
        {
            ShowHelp();
            return;
        }

        var VsCommand = args[1].ToLower();
        switch (VsCommand)
        {
            case "all":
                AllCommitsPattern();
                break;
            default:
                Console.WriteLine(
                    "Comando Vscode não reconhecido. Use 'myworkflow Vs --help' para ver os comandos disponíveis.");
                break;
        }
    }

    private static void ShowHelp()
    {
        Console.WriteLine();
        Console.WriteLine("Uso: myworkflow Commits [comando]");
        Console.WriteLine();
        Console.WriteLine("Comandos Commits disponíveis:");
        Console.WriteLine();
        Console.WriteLine("  all              Mostra todos os comandos Commits disponíveis");
        Console.WriteLine();
    }

    private static void AllCommitsPattern()
    {
        Console.WriteLine();
        Console.WriteLine("Comandos Commits disponíveis:");
        Console.WriteLine("");
        Console.WriteLine();
    }
}