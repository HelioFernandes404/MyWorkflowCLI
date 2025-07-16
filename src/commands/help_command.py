# commands / help_command.py
from utils.command_factory import ICommand
from typing import List

class HelpCommand(ICommand):
    def execute(self, args: List[str]) -> None:
        print("Use: wf [module] [option]")
        print()
        print("For exemple: wf git -h")
        print("Commands available:")
        print(" -h      Show all commands")