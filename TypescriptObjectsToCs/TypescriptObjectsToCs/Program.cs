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
    }
}