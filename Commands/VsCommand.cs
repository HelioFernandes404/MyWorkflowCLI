using MyWorkflow.Utils;

public class VsCommand : ICommand
{
    public void Execute(string[] args)
    {
        if (args.Length < 2 || args[1] == "-h")
        {
            VsHelp();
            return;
        }

        var VsCommand = args[1].ToLower();
        switch (VsCommand)
        {
            case "all":
                AllVs();
                break;
            default:
                Console.WriteLine(
                    "Comando Vscode não reconhecido. Use 'myworkflow Vs --help' para ver os comandos disponíveis.");
                AllVs();
                break;
        }
    }


    private static void VsHelp()
    {
        Console.WriteLine();
        Console.WriteLine("Uso: myworkflow Vs [comando]");
        Console.WriteLine();
        Console.WriteLine("Comandos Vscode disponíveis:");
        Console.WriteLine();
        Console.WriteLine("  all              Mostra todos os comandos Vs disponíveis");
    }

    private static void AllVs()
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