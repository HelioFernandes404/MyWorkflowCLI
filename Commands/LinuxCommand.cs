﻿using MyWorkflow.Utils;

namespace MyWorkflow.Commands;

public class LinuxCommand : ICommand
{
    public void Execute(string[] args)
    {
        Console.WriteLine("Executando comandos Linux...");


        if (args.Length < 2 || args[1] == "--help")
        {
            ShowLinuxHelp();
            return;
        }

        var dockerCommand = args[1].ToLower();
        switch (dockerCommand)
        {
            case "all":
                BasicCommands();
                break;
            default:
                Console.WriteLine(
                    "Comando linux não reconhecido. Use 'myworkflow linux --help' para ver os comandos disponíveis.");
                break;
        }


        static void ShowLinuxHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Uso: myworkflow linux [comando]");
            Console.WriteLine();
            Console.WriteLine("Comandos linux disponíveis:");
            Console.WriteLine("  all              Mostra todos os comandos Linux disponíveis");
            Console.WriteLine();
        }

        static void BasicCommands()
        {
            Console.WriteLine();
            Console.WriteLine("Comandos Linux(Ubuntu) disponíveis:");
            Console.WriteLine("  ls                                            Listar arquivos e diretórios");
            Console.WriteLine("  cd nome_do_diretorio                          Mudar para o diretório especificado");
            Console.WriteLine(
                "  pwd                                           Mostrar o caminho completo do diretório atual");
            Console.WriteLine("  cat nome_do_arquivo                           Visualizar o conteúdo de um arquivo");
            Console.WriteLine("  touch novo_arquivo.txt                        Criar um novo arquivo vazio");
            Console.WriteLine("  mkdir nome_do_diretorio                       Criar um novo diretório");
            Console.WriteLine("  rmdir nome_do_diretorio                       Remover um diretório vazio");
            Console.WriteLine("  rm nome_do_arquivo                            Remover um arquivo");
            Console.WriteLine("  mv nome_antigo nome_novo                      Renomear um arquivo ou diretório");
            Console.WriteLine("  cp source destination                         Copiar arquivos ou diretórios");
            Console.WriteLine();
        }
    }
}