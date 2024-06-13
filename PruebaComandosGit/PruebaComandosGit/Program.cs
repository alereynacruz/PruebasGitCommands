using System.Diagnostics;

namespace PruebaComandosGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string gitCommand = "git";
            string gitAddArgument = @"add -A";
            string gitCommitArgument = @"commit ""Agregadndo cambios a Git Hub""";
            string gitPushArgument = @"push origin main";

            Process.Start(gitCommand, gitAddArgument);
            Process.Start(gitCommand, gitCommitArgument);
            Process.Start(gitCommand, gitPushArgument);
        }
    }
}
