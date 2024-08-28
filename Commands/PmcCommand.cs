using MyWorkflow.Utils;

namespace MyWorkflow.Commands;

public class PmcCommand : ICommand
{
    public void Execute(string[] args)
    {
        if (args.Length < 2 || args[1] == "--help")
        {
            ShowPmcHelp();
            return;
        }

        var pmcCommand = args[1].ToLower();
        switch (pmcCommand)
        {
            case "all":
                ShowTop10PmcCommands();
                break;
            case "delete":
                ShowDeletePmcCommands();
                break;
            case "efc":
                ShowEfcPmcCommands();
                break;
            default:
                Console.WriteLine(
                    "Comando PMC não reconhecido. Use 'myworkflow pmc --help' para ver os comandos disponíveis.");
                break;
        }


        static void ShowPmcHelp()
        {
            Console.WriteLine();
            Console.WriteLine("Uso: myworkflow pmc [comando]");
            Console.WriteLine();
            Console.WriteLine("Comandos PMC disponíveis:");
            Console.WriteLine("  all              Mostra os 10 comandos PMC mais usados");
            Console.WriteLine("  delete           Mostra todos os comandos PMC de deletar");
            Console.WriteLine("  efc           Mostra todos os comandos PMC de efc(EntityFrameworkCore)");
            Console.WriteLine();
        }

        static void ShowTop10PmcCommands()
        {
            Console.WriteLine();
            Console.WriteLine("Os 10 comandos PMC mais usados:");
            Console.WriteLine("  Update-Package             Atualiza os pacotes NuGet do projeto");
            Console.WriteLine("  Install-Package            Instala um novo pacote NuGet");
            Console.WriteLine("  Uninstall-Package          Remove um pacote NuGet instalado");
            Console.WriteLine("  Get-Package                Lista os pacotes NuGet instalados");
            Console.WriteLine("  Add-TypeDefinition         Adiciona uma definição de tipo ao assembly atual");
            Console.WriteLine("  New-Project                Cria um novo projeto");
            Console.WriteLine("  Remove-Item                Exclui arquivos ou diretórios especificados");
            Console.WriteLine("  New-Solution               Cria um novo solution (.sln)");
            Console.WriteLine(
                "  Restore-NuGetPackages      Restaura os pacotes NuGet listados no arquivo packages.config");
            Console.WriteLine("  Publish-NewProject         Publica um projeto para um feed de nuget");
            Console.WriteLine();
        }

        static void ShowDeletePmcCommands()
        {
            Console.WriteLine();
            Console.WriteLine("Comandos PMC de deletar:");
            Console.WriteLine("  Remove-Project           Remove um projeto existente");
            Console.WriteLine("  Remove-Solution          Remove uma solução (.sln)");
            Console.WriteLine("  Remove-Item              Exclui arquivos ou diretórios especificados");
            Console.WriteLine("  Unpublish-Package        Despublica um pacote do feed de nuget");
            Console.WriteLine("  Unregister-PackageSource Desinscreve um source de pacotes NuGet");
            Console.WriteLine("  Clear-NuGetCache         Limpa o cache do NuGet");
            Console.WriteLine("  Remove-PackageSource     Remove um source de pacotes NuGet");
            Console.WriteLine();
        }

        static void ShowEfcPmcCommands()
        {
            Console.WriteLine();
            Console.WriteLine("Comandos PMC de Entity Framework Core (EFC):");
            Console.WriteLine("  Add-Migration              Cria uma nova mão de migração");
            Console.WriteLine("  Update-Database            Atualiza o contexto do banco de dados");
            Console.WriteLine("  Remove-Migration           Remove a última mão de migração criada");
            Console.WriteLine("  Script-Migration           Gera scripts SQL para a última mão de migração");
            Console.WriteLine("  Database.SetInitializer    Define um inicializador de banco de dados");
            Console.WriteLine("  Database.EnsureCreated     Garante que o banco de dados seja criado");
            Console.WriteLine("  Database.Migrate           Aplica todas as migrações pendentes");
            Console.WriteLine("  Database.ExecuteSqlRaw     Executa comandos SQL brutos contra o banco de dados");
            Console.WriteLine("  Database.ExecuteSqlCommand Executa comandos SQL contra o banco de dados");
            Console.WriteLine();
        }
    }
}