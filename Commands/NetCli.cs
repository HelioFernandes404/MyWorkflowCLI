namespace MyWorkflow.Commands;

public class NetCli
{
    public static void ShowEfCoreMigrationHelp()
    {
        Console.WriteLine();
        Console.WriteLine("Uso: myworkflow efcore [comando]");
        Console.WriteLine();
        Console.WriteLine("Comandos EF Core Migration disponíveis:");
        Console.WriteLine("  addmigration          Cria uma nova mão de migração");
        Console.WriteLine("  updatedatabase        Atualiza o contexto do banco de dados com as migrações pendentes");
        Console.WriteLine("  removemigration       Remove a última mão de migração criada");
        Console.WriteLine("  scriptmigration       Gera scripts SQL para a última mão de migração");
        Console.WriteLine();
    }
}