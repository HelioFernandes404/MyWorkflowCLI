namespace MyWorkflow;

public class Docs
{
  public static void HandleDocsCommands(string[] args)
  {
    if (args.Length < 2 || args[1] == "--help")
    {
      ShowDocsHelp();
      return;
    }

    string GitCommand = args[1].ToLower();
    switch (GitCommand)
    {
      case "all":
        ShowDocs();
        break;
      default:
        Console.WriteLine("Comando Git não reconhecido. Use 'myworkflow Git --help' para ver os comandos disponíveis.");
        break;
    }
  }

  public static void ShowDocsHelp()
  {
    Console.WriteLine();
    Console.WriteLine("Uso: myworkflow Docs [comando]");
    Console.WriteLine();
    Console.WriteLine("Comandos Docs disponíveis:");
    Console.WriteLine("  all              Mostra todos os comandos Docs disponíveis");
    Console.WriteLine();
    ShowDocs();
  }

  public static void ShowDocs()
  {
    // .NET documentation links
    string[] docLinks = new string[]
    {
        "https://learn.microsoft.com/en-us/dotnet/",
        "https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-8.0",
        "https://github.com/dotnet/docs",
        "https://cloud.google.com/dotnet/docs",
        "https://jakeydocs.readthedocs.io/"
    };

    Console.WriteLine();
    foreach (var link in docLinks)
    {
      Console.WriteLine(link);
    }
    Console.WriteLine();
  }

}