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
                BasicCommands();
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

    private static void BasicCommands()
    {
        Console.WriteLine();
        Console.WriteLine("Uso: myworkflow commitpattern [padrão]");
        Console.WriteLine();
        Console.WriteLine("Padrões de commits disponíveis:");
        Console.WriteLine("  feat:            Nova funcionalidade para o usuário");
        Console.WriteLine("  fix:             Correção de bug para o usuário");
        Console.WriteLine("  docs:            Alterações na documentação");
        Console.WriteLine("  style:           Formatação, ponto e vírgula faltando; não afeta o código");
        Console.WriteLine("  refactor:        Refatoração do código de produção");
        Console.WriteLine("  test:            Adição de testes, refatoração de testes; não afeta o código de produção");
        Console.WriteLine("  chore:           Atualização de tarefas de compilação, configurações de gerenciamento de pacotes");
        Console.WriteLine("  perf:            Mudança de código que melhora o desempenho");
        Console.WriteLine("  ci:              Mudanças em arquivos e scripts de CI (exemplo: Circle, Travis, BrowserStack)");
        Console.WriteLine("  build:           Mudanças que afetam o sistema de compilação ou dependências externas");
        Console.WriteLine();
    }
}