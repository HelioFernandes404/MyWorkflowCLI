# main.py
import sys

from utils.command_factory import CommandFactory


def show_help():
    print("Available commands:")
    print("-h: Show help")
    print("git: Git related commands")
    print("argocd: Argocd related commands")
    # Add other commands here


def main():
    """Main entry point for the CLI application"""
    if len(sys.argv) <= 2:
        show_help()
        return

    command = sys.argv[2].lower()
    command_handler = CommandFactory.create_command(command)

    if command_handler is None:
        print(f"Command '{command}' not found. Use '-h' for help.")
        return

    try:
        command_handler.execute(sys.argv[1:])
    except KeyboardInterrupt:
        print("\nProcess interrupted by user.")
    except Exception as e:
        print(f"An error occurred: {e}")


if __name__ == "__main__":
    main()
