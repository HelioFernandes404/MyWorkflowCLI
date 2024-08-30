using MyWorkflow.Commands;

namespace MyWorkflow.Utils
{
    public static class CommandFactory
    {
        public static ICommand CreateCommand(string command)
        {
            return command switch
            {
                "-h" => new HelpCommand(),
                "--help" => new HelpCommand(),
                "docker" => new DockerCommand(),
                "linux" => new LinuxCommand(),
                "psql" => new PsqlCommand(),
                "pmc" => new PmcCommand(),
                "git" => new GitCommand(),
                "docs" => new DocsCommand(),
                "vs" => new VsCommand(),
                "mongoshell" => new MongoDbShell(),
                _ => new DefaultCommand(),
            };
        }
    }


}


