from utils.command_factory import ICommand


class DockerCommand(ICommand):
    """Docker command that handles unknown commands"""

    def execute(self, args: list[str]) -> None:
        """Execute the Docker command"""
        if len(args) > 1 and args[1] in ["use -h to show commands"]:
            self._show_help()
            return

        self._show_help()

    def _show_help(self):
        """
        Displays help information for the Docker command, including usage instructions and available options.
        """
        print("docker build <PATH> - Build a Docker image from a Dockerfile")
        print("docker run <IMAGE> - Run a Docker container from an image")
        print("docker ps - List running Docker containers")
        print("docker images - List available Docker images")
        print("docker rmi <IMAGE> - Remove a Docker image")
        print("docker rm <CONTAINER> - Remove a stopped Docker container")
        print("docker logs <CONTAINER> - View logs of a Docker container")
        print(
            "docker exec -it <CONTAINER> <COMMAND> - Execute a command in a running Docker container"
        )
