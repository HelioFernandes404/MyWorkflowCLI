using System;
using MyWorkflow;

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
    switch (command)
    {
      case "-h":
      case "--help":
        ShowHelp();
        break;
      case "docker":
        Docker.HandleDockerCommands(args);
        break;
      case "linux":
        Linux.HandleLinuxCommands(args);
        break;
      case "psql":
        PSQL.HandleSqlCommands(args);
        break;
      default:
        Console.WriteLine("Comando não reconhecido. Use '-h' ou '--help' para ver os comandos disponíveis.");
        break;
    }
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
    Console.WriteLine();
    Console.WriteLine("Para mais informações sobre um comando, use: myworkflow [modulo] --help");
  }

}
