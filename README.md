# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

MyWorkflowCLI is a Python-based CLI tool that provides shortcuts for common development commands. The application uses a command pattern with a factory to dynamically register and execute commands.

## Architecture

- **Entry point**: `src/main.py` - Main CLI entry point that parses arguments and delegates to command handlers
- **Command Factory**: `src/utils/command_factory.py` - Factory pattern implementation with `ICommand` interface
- **Commands**: `src/commands/` - Individual command implementations (git, docker, argocd, help, default)
- **Execution pattern**: `python src/main.py <command> [options]`

The CLI expects at least 2 arguments: the script name and a command. Commands are registered in the `CommandFactory.create_command()` method.

## Development Commands

### Setup
```bash
# Create virtual environment
python -m venv .venv
source .venv/bin/activate  # Linux/Mac
# or
.venv\Scripts\activate  # Windows

# Install dependencies
pip install -r requirements.txt
```

### Code Quality
```bash
# Lint with ruff
ruff check src/

# Format with ruff
ruff format src/

# Run pre-commit hooks
pre-commit run --all-files
```

### Installation
```bash
# Install package locally
pip install -e .

# Run CLI after installation
myworkflow <command>
```

### Versioning
Uses commitizen for conventional commits:
```bash
# Make a conventional commit
cz commit

# Bump version
cz bump
```

## Available Commands

- `git` - Git workflow shortcuts (status, commit, stash operations)
- `docker` - Docker command references and shortcuts
- `argocd` - ArgoCD related commands
- `-h` - Help command

## Configuration

- **Ruff**: Configured in `pyproject.toml` with Python 3.12 target, line length 88
- **Commitizen**: Conventional commits with semantic versioning
- **Pre-commit**: Hooks for code quality (configured but hooks file not visible)

## Adding New Commands

1. Create new command class in `src/commands/` implementing `ICommand`
2. Add import and mapping entry in `CommandFactory.create_command()`
3. Update help text in `src/main.py` if needed