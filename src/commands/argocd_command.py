from typing import List
from utils.command_factory import ICommand


class ArgoCdCommand(ICommand):
    def execute(self, args: List[str]) -> None:
        if len(args) > 1 and args[1] in ["use -h to show commands"]:
            self._show_help()
            return
        
        print("🔧 Executando comandos Argocd...")
        print("Top 10 comandos mais usados no ArgoCD CLI:")
        print("  1. argocd login <SERVER>")
        print("  2. argocd app list")
        print("  3. argocd app get <APPNAME>")
        print("  4. argocd app sync <APPNAME>")
        print("  5. argocd app create <APPNAME> --repo <REPO> --path <PATH> --dest-server <SERVER> --dest-namespace <NAMESPACE>")
        print("  6. argocd app delete <APPNAME>")
        print("  7. argocd app rollback <APPNAME> <REVISION>")
        print("  8. argocd app history <APPNAME>")
        print("  9. argocd app diff <APPNAME>")
        print(" 10. argocd proj list")
        
    def _show_help(self):
        """
        Displays help information for the Argocd command, including usage instructions and available options.
        """
        print("Argocd Command Help")
        print("Usage: wk argocd [options]")
        print("Options:")
        print("  --help, -h    Show this help")