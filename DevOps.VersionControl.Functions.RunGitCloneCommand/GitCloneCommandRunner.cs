using static DevOps.VersionControl.Functions.RunGitCommand.GitCommandRunner;

namespace DevOps.VersionControl.Functions.RunGitCloneCommand
{
    public static class GitCloneCommandRunner
    {
        private const string clone = nameof(clone);

        public static void Clone(string directory, string uri)
            => Git(directory,
                command: clone,
                uri);
    }
}
