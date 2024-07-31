# 1. 

[ x ] - Comandos mais usados : Linux
[ x ] - Comandos mais usados : Docker
[ x ] - Comandos mais usados : PSQL Command
[ x ] - When using the Package Manager Console (PMC)
[ x ] - When using the .NET Command Line Interface (.NET CLI)
[ x ] - Git
[ x ] - Docs ?
[ x ] - visual studio

[ ] - IA CLI
[ ] - padrao de commits
[ ] - CommitsPattern


# 2. passar o projeto pra padrões de design / Factory Method ?


```
myworkflow/
├── src/
│   ├── Program.cs
│   ├── Commands/
│   │   ├── DockerCommand.cs
│   │   ├── LinuxCommand.cs
│   │   ├── PsqlCommand.cs
│   │   ├── PmcCommand.cs
│   │   ├── GitCommand.cs
│   │   ├── DocsCommand.cs
│   └── Utils/
│       ├── CommandFactory.cs
│       ├── ICommand.cs
├── bin/
├── obj/
└── README.md
```