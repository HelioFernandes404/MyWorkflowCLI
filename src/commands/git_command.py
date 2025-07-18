from utils.command_factory import ICommand


class GitCommand(ICommand):
    def execute(self, args: list[str]) -> None:
        if len(args) > 1 and args[1] in ["use -h to show commands"]:
            return

        print("Git Command Help")
        print("Usage: wk git [options]")
        print("Options:")
        print("  --help, -h                               Show this help")
        print("  --status                                 Show git status")
        print("  --commit                                 Make a commit")
        print("  --stash push                             Push changes to stash")
        print("  --stash list                             List all stashed changes")
        print("  --stash pop                              Pop changes from stash")
        print(" git config --global --list | grep alias   Show all alias configs")
