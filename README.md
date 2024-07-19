# MyWorkflowCLI

MyWorkflowCLI é uma interface de linha de comando (CLI) personalizada criada com .NET. Esta ferramenta permite executar e gerenciar comandos pré-configurados de maneira simples e eficiente diretamente do terminal.

## Instalação

#### Linux

```sh
nano ~/.bashrc
```

```sh
export CAMINHO_MEUPROJETO="/mnt/c/Users/helio/projetos/my_cli/MyWorkflow/bin/Release/net8.0/linux-x64/publish/"
alias myworkflow='$CAMINHO_MEUPROJETO/myworkflow'
```

```sh
source ~/.bashrc
```

Agora, você pode simplesmente digitar myworkflow docker all no terminal para executar os comandos do seu projeto CLI.

### Pré-requisitos

- .NET SDK 6.0 ou superior

### Passos para Instalação

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/MyWorkflowCLI.git
   cd MyWorkflowCLI
   ```

2. Compile o projeto:

   ```bash
   dotnet build
   ```

3. (Opcional) Publique o projeto para uso global:

   ```bash
   dotnet publish -c Release -r win-x64 --self-contained
   ```

   Adicione a pasta `publish` ao seu `PATH` ou mova o executável para um local acessível globalmente.

## Uso

### Comandos Disponíveis

- **Ajuda Geral**:

  ```bash
  myworkflow -h
  ```

- **Comandos Docker**:

  Para ver todos os comandos Docker disponíveis:

  ```bash
  myworkflow docker all
  ```

### Exemplos

- Para ver a ajuda geral:

  ```bash
  myworkflow -h
  ```

- Para listar todos os comandos Docker disponíveis:

  ```bash
  myworkflow docker all
  ```

## Estrutura do Projeto

- **Program.cs**: Contém a lógica principal da CLI.
- **Comandos**: A lógica de cada comando é gerida aqui. Atualmente, inclui comandos para Docker.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests.

1. Fork o projeto
2. Crie uma nova branch (`git checkout -b feature/nova-funcionalidade`)
3. Commit suas alterações (`git commit -m 'Adiciona nova funcionalidade'`)
4. Push para a branch (`git push origin feature/nova-funcionalidade`)
5. Abra um Pull Request

## Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes.

---
