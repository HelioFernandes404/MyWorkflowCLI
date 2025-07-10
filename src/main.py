# main.py
import click
from commands import git

@click.group()
def cli():
    """MyWorkflow - CLI tool for development workflows"""
    pass

# Register commands
cli.add_command(git.git)


if __name__ == '__main__':
    cli()