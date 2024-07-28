using MyWorkflow.Utils;

namespace MyWorkflow.Commands;

public class DefaultCommand : ICommand
{
  public void Execute(string[] args)
  {
    Console.WriteLine("Comando não reconhecido. Use 'myworkflow --help' para ver os comandos disponíveis.");
  }
}
