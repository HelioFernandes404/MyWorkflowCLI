from typing import List
from utils.command_factory import ICommand


class ArgoCdCommand(ICommand):
    def execute(self, args: List[str]) -> None:
        if len(args) > 1 and args[1] in ["use -h to show commands"]:
            self._show_help()
            return
        
        self._show_help()

    def workflow_command(self) -> None:        
        pass
        
    def _show_help(self):
        """
        Displays help information for the Argocd command, including usage instructions and available options.
        """
        print("argocd login <SERVER>")
        print("argocd app list")
        print("argocd app get <APPNAME>")
        print("argocd app sync <APPNAME>")
        print("argocd app create <APPNAME> --repo <REPO> --path <PATH> --dest-server <SERVER> --dest-namespace <NAMESPACE>")
        print("argocd app delete <APPNAME>")
        print("argocd app rollback <APPNAME> <REVISION>")
        print("argocd app history <APPNAME>")
        print("argocd app diff <APPNAME>")
        print("argocd proj list")