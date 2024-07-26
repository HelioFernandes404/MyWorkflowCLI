using MyWorkflow.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkflow.Commands
{
    public class HelpCommand : ICommand
    {
        public void Execute(string[] args)
        {
            Console.WriteLine("Uso: myworkflow [modulo] [opções]");
            Console.WriteLine();
            Console.WriteLine("Comandos disponíveis:");
            Console.WriteLine("  -h, --help       Mostra a ajuda");
            Console.WriteLine("  docker           Comandos relacionados ao Docker");
            Console.WriteLine("  linux            Comandos relacionados ao Linux");
            Console.WriteLine("  psql             Comandos relacionados ao Psql");
            Console.WriteLine("  pmc              Comandos relacionados ao (pmc)Package Manager Console");
            Console.WriteLine("  git              Comandos relacionados ao Git");
            Console.WriteLine();
            Console.WriteLine("Para mais informações sobre um comando, use: myworkflow [modulo] --help");
        }
    }
}
