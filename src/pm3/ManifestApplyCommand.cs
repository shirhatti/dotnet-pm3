using System;
using System.CommandLine;
using System.CommandLine.Invocation;
using System.CommandLine.IO;

namespace Shirhatti.Pm3
{
    internal class ManifestApplyCommand
    {
        internal static Command Create()
        {
            var command = new Command(
                name: "apply",
                description: "The apply subcommand generates an PM3 install manifest and applies it to a cluster.")
            {
                Handler = CommandHandler.Create<IConsole>(ApplyManifest)
            };
            return command;
        }

        private static void ApplyManifest(IConsole console)
        {
            console.Out.WriteLine("Applying manifest");
        }
    }
}