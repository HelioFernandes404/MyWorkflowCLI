from typing import List
from utils.command_factory import ICommand


class GitCommand(ICommand):
    def execute(self, args: List[str]) -> None:
        if len(args) > 1 and args[1] in ["use -h to show commands"]:
            self._show_help()
            return
        
        print("🔧 Executando comandos Git...")
        # Your Git logic here
        print("Comandos Git disponíveis:")
        print("  - git status")
        print("  - git add .")
        print("  - git commit -m 'message'")
        print("  - git push")
        
    def _show_help(self):
        print("Git Command Help")
        print("Usage: myworkflow git [options]")
        print("Options:")
        print("  --help, -h    Show this help")
        print("  --status      Show git status")
        print("  --commit      Make a commit")