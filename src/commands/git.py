# commands/docker.py
import click

@click.command()
@click.option('--help', '-h', is_flag=True, help='Show help')
def git(help):
    """Comandos relacionados ao Docker"""
    if help:
        click.echo("Docker command help")
        return
    click.echo("Docker functionality")