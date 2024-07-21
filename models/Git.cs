namespace MyWorkflow
{
  public class Git
  {

    public static void HandleGitCommands(string[] args)
    {
      if (args.Length < 2 || args[1] == "--help")
      {
        ShowGitHelp();
        return;
      }

      string GitCommand = args[1].ToLower();
      switch (GitCommand)
      {
        case "all":
          ShowTop10GitCommands();
          break;
        default:
          Console.WriteLine("Comando Git não reconhecido. Use 'myworkflow Git --help' para ver os comandos disponíveis.");
          break;
      }
    }

    public static void ShowGitHelp()
    {
      Console.WriteLine();
      Console.WriteLine("Uso: myworkflow Git [comando]");
      Console.WriteLine();
      Console.WriteLine("Comandos Git disponíveis:");
      Console.WriteLine("  all              Mostra os 10 comandos Git mais usados");
      Console.WriteLine();
    }

    public static void ShowTop10GitCommands()
    {
      Console.WriteLine();
      Console.WriteLine("Os 10 comandos Git mais usados:");
      Console.WriteLine("  git clone                  Clona um repositório Git");
      Console.WriteLine("  git status                 Mostra o estado do trabalho no índice e na árvore de trabalho");
      Console.WriteLine("  git add                    Adiciona arquivos ao stage");
      Console.WriteLine("  git commit                 Faz commit das alterações adicionadas ao stage");
      Console.WriteLine("  git push                   Envia commits para o servidor remoto");
      Console.WriteLine("  git pull                   Busca e combina alterações de um repositório remoto");
      Console.WriteLine("  git branch                 Lista todas as branches locais");
      Console.WriteLine("  git checkout              Muda para a branch especificada");
      Console.WriteLine("  git merge                  Mescla a branch atual com a branch especificada");
      Console.WriteLine("  git log                   Exibe o histórico de commits");
      Console.WriteLine();
    }

  }
}

