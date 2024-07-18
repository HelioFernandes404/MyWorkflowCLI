using System;

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
        HandleDockerCommands(args);
        break;
      default:
        Console.WriteLine("Comando não reconhecido. Use '-h' ou '--help' para ver os comandos disponíveis.");
        break;
    }
  }

  static void ShowHelp()
  {
    Console.WriteLine("Uso: myworkflow [comando] [opções]");
    Console.WriteLine();
    Console.WriteLine("Comandos disponíveis:");
    Console.WriteLine("  -h, --help       Mostra a ajuda");
    Console.WriteLine("  docker           Comandos relacionados ao Docker");
    Console.WriteLine();
    Console.WriteLine("Para mais informações sobre um comando, use: myworkflow [comando] --help");
  }

  static void HandleDockerCommands(string[] args)
  {
    if (args.Length < 2 || args[1] == "--help")
    {
      ShowDockerHelp();
      return;
    }

    string dockerCommand = args[1].ToLower();
    switch (dockerCommand)
    {
      case "all":
        ShowAllDockerCommands();
        break;
      // Adicione mais casos aqui para outros comandos Docker
      default:
        Console.WriteLine("Comando Docker não reconhecido. Use 'myworkflow docker --help' para ver os comandos disponíveis.");
        break;
    }
  }

  static void ShowDockerHelp()
  {
    Console.WriteLine("Uso: myworkflow docker [comando]");
    Console.WriteLine();
    Console.WriteLine("Comandos Docker disponíveis:");
    Console.WriteLine("  all              Mostra todos os comandos Docker disponíveis");
    // Adicione mais comandos e descrições aqui
  }

  static void ShowAllDockerCommands()
  {
    Console.WriteLine("Comandos Docker disponíveis:");
    Console.WriteLine("  docker run       Executa um contêiner");
    Console.WriteLine("  docker build     Constrói uma imagem Docker");
    Console.WriteLine("  docker pull      Baixa uma imagem Docker");
    // Adicione mais comandos aqui
  }
}
