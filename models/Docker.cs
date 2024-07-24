namespace MyWorkflow
{
  public class Docker
  {

    public static void HandleDockerCommands(string[] args)
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
        case "delete":
          ShowDeleteDockerCommands();
          break;
        default:
          Console.WriteLine("Comando Docker não reconhecido. Use 'myworkflow docker --help' para ver os comandos disponíveis.");
          break;
      }
    }

    public static void ShowDockerHelp()
    {
      Console.WriteLine();
      Console.WriteLine("Uso: myworkflow docker [comando]");
      Console.WriteLine();
      Console.WriteLine("Comandos Docker disponíveis:");
      Console.WriteLine("  all              Mostra todos os comandos Docker disponíveis");
      Console.WriteLine("  delete           Mostra todos os comandos Docker de deletar");
      Console.WriteLine();
      ShowAllDockerCommands();
    }

    public static void ShowAllDockerCommands()
    {
      Console.WriteLine();
      Console.WriteLine("Comandos Docker disponíveis:");
      Console.WriteLine("  docker run -d --name meu_conteiner minha_imagem       Iniciar um contêiner em segundo plano e exibir o ID do contêiner");
      Console.WriteLine("  docker ps -a                                          Listar todos os contêineres (em execução ou parados)");
      Console.WriteLine("  docker stop meu_conteiner                             Parar um contêiner em execução");
      Console.WriteLine("  docker rm meu_conteiner                               Remover um contêiner");
      Console.WriteLine("  docker start meu_conteiner                            Iniciar um contêiner que já foi parado");
      Console.WriteLine("  docker exec -it meu_conteiner bash                    Executar um comando dentro de um contêiner em execução");
      Console.WriteLine("  docker build -t minha_nova_imagem .                   Construir uma imagem a partir de um Dockerfile na pasta atual");
      Console.WriteLine("  docker push minha_imagem                              Enviar uma imagem para um registro remoto");
      Console.WriteLine("  docker pull ubuntu                                    Baixar uma imagem de um registro remoto");
      Console.WriteLine("  docker images                                         Listar todas as imagens disponíveis localmente");
      Console.WriteLine();
    }

    public static void ShowDeleteDockerCommands()
    {
      Console.WriteLine();
      Console.WriteLine("Comandos Docker de deletar:");
      Console.WriteLine("  docker rmi minha_imagem                              Remover uma imagem");
      Console.WriteLine("  docker rmi $(docker images -q)                       Remover todas as imagens");
      Console.WriteLine("  docker rm $(docker ps -a -q)                         Remover todos os contêineres");
      Console.WriteLine("  docker volume rm $(docker volume ls -q)              Remover todos os volumes");
      Console.WriteLine("  docker network rm $(docker network ls -q)            Remover todas as redes");
      Console.WriteLine("  docker system prune -a --volumes                     Remover todos os contêineres, imagens, volumes e redes");
      Console.WriteLine("  docker container prune -a                            Remover todos os contêineres");
      Console.WriteLine();
    }
  }
}

