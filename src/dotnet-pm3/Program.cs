using System;
using System.CommandLine.Builder;
using System.CommandLine.Parsing;
using System.Threading.Tasks;

namespace Shirhatti.Pm3
{
    internal class Program
    {
        static async Task<int> Main(string[] args) =>
            await new CommandLineBuilder()
                .AddCommand(ManifestCommand.Create())
                .UseDefaults()
                .Build()
                .InvokeAsync(args);
    }
}
