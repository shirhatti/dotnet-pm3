using System;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace Shirhatti.Pm3
{
    internal class ManifestCommand
    {
        internal static Command Create()
        {
            var command = new Command(
                name: "manifest",
                description: "The manifest subcommand generates, applies, diffs or migrates PM3 manifests.");

            command.AddCommand(ManifestApplyCommand.Create());
            return command;
        }
    }
}