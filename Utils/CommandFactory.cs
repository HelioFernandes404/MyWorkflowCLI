using MyWorkflow.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                _ => null,
            };
        }
    }
}
