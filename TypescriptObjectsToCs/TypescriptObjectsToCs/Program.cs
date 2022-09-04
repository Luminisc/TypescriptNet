using TypescriptObjectsToCs;

internal class Program
{
    private static async Task Main(string[] args)
    {
        // args:
        // filename - path to ts file. (or folder where TS files are located)
        var filename = args[0];
        var file = File.ReadAllText(filename);

        await NodeSandbox.Test();

        Console.ReadLine();

        /*
        // Example usage...
        using (var workspace = new NodeWorkspace(options)) // to create node options, how to access node, and other stuff
        {
            // if files not loading, or Node failing, we need to print this
            workspace.WorkspaceFailed += (o, e) => Console.WriteLine(e.Diagnostic.Message);
            var project = workspace.OpenProjectAsync(path); // to get list of files and maybe some metadata
            // at this point we should have parsed AST and be able to work with it
            var doc = project.Documents.First();
        }
        */
    }
}